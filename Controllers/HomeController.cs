using Microsoft.AspNetCore.Mvc;
using SSBlogs.Models;
using System.Diagnostics;

namespace SSBlogs.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IRepository<Blog> _repository;

        public HomeController(ILogger<HomeController> logger, IRepository<Blog> repository)
        {
            _logger = logger;
            _repository = repository;
        }


        public IActionResult Index()
        {
            return View();
        }


        public async Task<IActionResult> View(int id)
        {

            var blog = await _repository.GetByIdAsync(id);
            if (blog == null)
            {
                return NotFound();
            }
            var editViewModel = new Blog
            {
                Id = blog.Id,
                Title = blog.Title,
                Content = blog.Content,
                AuthorName = blog.AuthorName,
                Description = blog.Description,
                PublishedOn = blog.PublishedOn
            };

            return View(editViewModel);
        }


        public IActionResult Add()
        {
            return View();
        }

        public async Task<IActionResult> Edit(int id)
        {

            var blog = await _repository.GetByIdAsync(id);
            if (blog == null)
            {
                return NotFound();
            }
            var editViewModel = new Blog
            {
                Id = blog.Id,
                Title = blog.Title,
                Content = blog.Content,
                AuthorName = blog.AuthorName,
                Description = blog.Description,
                PublishedOn = blog.PublishedOn
            };

             return View(editViewModel);
        }


        public IActionResult Privacy()
        {
            return View();
        }



        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
