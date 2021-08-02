using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebAppAst3.Data
{
    public class Book
    {
        [Key]
        public String ISBN { get; set; }

        public String Title { get; set; }

        public String NameToken { get; set; }
        public Category Category { get; set; }

        public String Author { get; set; }
    }
}
