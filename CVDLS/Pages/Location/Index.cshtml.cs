using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using CVDLS.Data;
using CVDLS.Models;

namespace CVDLS.Pages.Location
{
    public class IndexModel : PageModel
    {
        private readonly CVDLS.Data.CVDLSContext _context;

        public IndexModel(CVDLS.Data.CVDLSContext context)
        {
            _context = context;
        }

        public IList<CVDLS.Models.Location> Location { get;set; }

        public async Task OnGetAsync()
        {
            Location = await _context.Location.ToListAsync();
        }
    }
}
