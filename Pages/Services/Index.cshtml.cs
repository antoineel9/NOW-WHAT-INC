using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.RazorPages;
using new3.Data;

namespace new3.Pages.Services
{
    public class IndexModel : PageModel
    {
        private readonly new3.Data.ApplicationDbContext _context;

        public IndexModel(new3.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        public IList<GED> GED { get; set; }

        public async Task OnGetAsync()
        {
            GED = await _context.GED.ToListAsync();
        }
    }
}
