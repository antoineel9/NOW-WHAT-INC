using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using NWI2.Data;

namespace NWI2
{
    [Authorize(Roles ="admin")]
    public class IndexModel : PageModel
    {
        private readonly NWI2.Data.ApplicationDbContext _context;

        public IndexModel(NWI2.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        public IList<GED> GED { get;set; }

        public async Task OnGetAsync()
        {
            GED = await _context.GED.ToListAsync();
        }
    }
}
