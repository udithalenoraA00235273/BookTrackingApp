using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using WebAppAst3.Data;
using WebAppAst3.Data.Context;

namespace WebAppAst3.Pages.Book_b
{
    public class IndexModel : PageModel
    {
        private readonly WebAppAst3.Data.Context.BookContext _context;

        public IndexModel(WebAppAst3.Data.Context.BookContext context)
        {
            _context = context;
        }

        public IList<Book> Book { get;set; }

        public async Task OnGetAsync()
        {
            Book = await _context.Book.ToListAsync();
        }
    }
}
