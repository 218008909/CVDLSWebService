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
    public class DetailsModel : PageModel
    {
        private readonly CVDLS.Data.CVDLSContext _context;

        public DetailsModel(CVDLS.Data.CVDLSContext context)
        {
            _context = context;
        }

        public CVDLS.Models.Location Location { get; set; }

        public async Task<IActionResult> OnGetAsync(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Location = await _context.Location.FirstOrDefaultAsync(m => m.LocationID == id);

            if (Location == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
