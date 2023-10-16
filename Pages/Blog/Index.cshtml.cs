#nullable disable
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using razorweb1.models;

namespace razorweb1.Pages_Blog
{
    public class IndexModel : PageModel
    {
        private readonly razorweb1.models.MyBlogContext _context;

        public IndexModel(razorweb1.models.MyBlogContext context)
        {
            _context = context;
        }

        public IList<Article> Article { get;set; }

        public async Task OnGetAsync()
        {
            Article = await _context.articles.ToListAsync();
        }
    }
}
