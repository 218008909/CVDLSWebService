using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using CVDLS.Data;
using CVDLS.Models;

namespace CVDLS.Pages.Location
{
    public class CreateModel : PageModel
    {
        private readonly CVDLS.Data.CVDLSContext _context;

        public CreateModel(CVDLS.Data.CVDLSContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public CVDLS.Models.Location Location { get; set; }

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Location.Add(Location);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
