using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebAppAst3.Data;

namespace WebAppAst3.Data.Context
{
    public class BookContext
        :DbContext
    {
        public BookContext(DbContextOptions<BookContext> options)
            :base (options)
        {
        }
        public DbSet<Book> Book { get; set; }
        public DbSet<Category> Category { get; set; }
        public DbSet<CategoryType> CategoryType { get; set; }


    }
}
