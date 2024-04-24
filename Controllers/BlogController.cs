using Microsoft.AspNetCore.Mvc;
using SSBlogs.Models;
using System.Linq.Dynamic.Core;

namespace SSBlogs.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class BlogController : ControllerBase
    {
        private readonly IRepository<Blog> _repository;


        public BlogController(IRepository<Blog> repository)
        {
            _repository = repository;
        }


        [HttpPost("create")]
        public async Task<IActionResult> Create([FromForm] Blog blog)
        {
            blog.PublishedOn = DateTime.Now;
            await _repository.CreateAsync(blog);
            return Ok(blog.Id);
        }


        [HttpPost("getBlogs")]
        public async Task<IActionResult> GetBlogs(DataTableParams dataTableParams)
        {
            // Retrieve parameters from the client-side
            int draw = dataTableParams.Draw;
            int start = dataTableParams.Start;
            int length = dataTableParams.Length;
            string searchValue = dataTableParams.Search?.Value;
            string sortColumnName = dataTableParams.Columns[dataTableParams.Order[0].Column].Data;
            bool sortAscending = dataTableParams.Order[0].Dir == "asc";

            var query = await _repository.GetFilteredBlogs(searchValue); // Implement GetFilteredBlogs method in your repository

            int recordsTotal = query.Count();

            // Apply pagination
            var blogs = query.Skip(start).Take(length)
                             .Select(b => new BlogView
                             {
                                 Id = b.Id,
                                 Title = b.Title,
                                 AuthorName = b.AuthorName,
                                 Description = b.Description,
                                 PublishedOn = b.PublishedOn
                             })
                             .ToList();

            // Return the result in the format expected by DataTables
            return Ok(new
            {
                draw = draw,
                recordsTotal = recordsTotal,
                recordsFiltered = recordsTotal, // For now, we'll set recordsFiltered to recordsTotal since we're not filtering
                data = blogs
            });
        }


        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            var blog = await _repository.GetByIdAsync(id);
            if (blog == null)
            {
                return NotFound();
            }
            return Ok(blog);
        }



        [HttpPost("update")]
        public async Task<IActionResult> Update([FromForm] Blog blog)
        {
            await _repository.UpdateAsync(blog);
            return NoContent();
        }


        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            var blog = await _repository.GetByIdAsync(id);
            if (blog == null)
            {
                return NotFound();
            }
            await _repository.DeleteAsync(blog);
            return NoContent();
        }

    }
}
