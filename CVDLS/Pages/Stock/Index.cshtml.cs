using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using CVDLS.Data;
using CVDLS.Models;
using Microsoft.Extensions.DependencyInjection;

namespace CVDLS.Pages.Stock
{
    public class IndexModel : PageModel
    {
        private readonly CVDLS.Data.CVDLSContext _context;

        public IndexModel(CVDLS.Data.CVDLSContext context)
        {
            _context = context;
        }

        public IList<CVDLS.Models.Stock> Stock { get;set; }

        public async Task OnGetAsync()
        {
            //Retrieve Current Date
            DateTime current = DateTime.Now;
            //Get List of Stock Marked as Safe
            var exp = _context.Stock.Where(date => date.ExpiryDate < current).AsQueryable();
            //Change Condition of Expired Stock
            while (exp.Where(date => date.ExpiryDate < current).Where(cond => cond.Condition == "Safe").Any())
            {
                exp.Where(date => date.ExpiryDate < current).Where(cond => cond.Condition == "Safe").FirstOrDefault().Condition = "Expired";
                //Commit
                _context.Stock.UpdateRange(exp);
                _context.SaveChanges();
            }
            
            

            Stock = await _context.Stock.ToListAsync();

        }
    }
}
