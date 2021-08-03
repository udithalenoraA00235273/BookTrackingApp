using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using WebAppAst3.Data;
using WebAppAst3.Data.Context;

namespace WebAppAst3.Pages.CategoryType_t
{
    public class DetailsModel : PageModel
    {
        private readonly WebAppAst3.Data.Context.BookContext _context;

        public DetailsModel(WebAppAst3.Data.Context.BookContext context)
        {
            _context = context;
        }

        public CategoryType CategoryType { get; set; }

        public async Task<IActionResult> OnGetAsync(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            CategoryType = await _context.CategoryType.FirstOrDefaultAsync(m => m.Type == id);

            if (CategoryType == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
