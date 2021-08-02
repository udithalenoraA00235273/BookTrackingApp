using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebAppAst3.Data
{
    public class Category
    {
     
        [Key]
        public String NameToken { get; set; }

        public String Type { get; set; }
        public CategoryType CategoryType { get; set; }

        public String Description { get; set; }

        public ICollection<Book> Books { get; set; }
    }
}
