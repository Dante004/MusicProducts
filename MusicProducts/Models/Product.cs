using System;
using System.Collections.Generic;

namespace MusicProducts.Models
{
    public class Product
    {
        public int ID { get; set; }
        public string name { get; set; }
        public string description { get; set; }
        public int categoryID { get; set; }
        public DateTime releaseDate { get; set; }

        public virtual ICollection<Category> Categories { get; set; }
    }
}