using Microsoft.EntityFrameworkCore;
using SSBlogs.Models;

namespace SSBlogs
{
    public class BlogRepository(AppDbContext context) : IRepository<Blog>
    {
        private readonly AppDbContext _context = context;

        public async Task CreateAsync(Blog blog)
        {
            _context.Blogs.Add(blog);
            await _context.SaveChangesAsync();
        }

        public async Task<IEnumerable<Blog>> GetFilteredBlogs(string searchValue)
        {
            var query = _context.Set<Blog>().AsQueryable();

            if (!string.IsNullOrEmpty(searchValue))
            {
                query = query.Where(b => b.Title.Contains(searchValue) || b.AuthorName.Contains(searchValue) || b.Description.Contains(searchValue) || b.Content.Contains(searchValue));
            }

            return await query.ToListAsync();
        }

        public async Task<Blog> GetByIdAsync(int id)
        {
            return await _context.Blogs.FindAsync(id);
        }

        public async Task UpdateAsync(Blog blog)
        {
            _context.Entry(blog).State = EntityState.Modified;
            await _context.SaveChangesAsync();
        }

        public async Task DeleteAsync(Blog blog)
        {
            _context.Blogs.Remove(blog);
            await _context.SaveChangesAsync();
        }
    }
}