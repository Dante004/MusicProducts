using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MusicProducts.Models
{
    public class Category
    {
        public int categoryID { get; set; }
        public string categoryName;

        public virtual ICollection<Product> product { get; set; }
    }
}