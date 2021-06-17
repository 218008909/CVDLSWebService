using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using CVDLS.Data;
using CVDLS.Models;

namespace CVDLS.Pages.Stock
{
    public class DetailsModel : PageModel
    {
        private readonly CVDLS.Data.CVDLSContext _context;

        public DetailsModel(CVDLS.Data.CVDLSContext context)
        {
            _context = context;
        }

        public CVDLS.Models.Stock Stock { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Stock = await _context.Stock.FirstOrDefaultAsync(m => m.StockID == id);

            if (Stock == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
