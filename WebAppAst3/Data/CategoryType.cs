using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebAppAst3.Data
{
    public class CategoryType
    {

        
        [Key]
        public String Type { get; set; }

        public String Name {get; set;}

        public ICollection<Category> Categories { get; set; }

    }
}
