using System;
using System.Collections.Generic;

namespace MusicProducts.Models
{
    public class Product
    {
        public int ID { get; set; }
        public string name { get; set; }
        public int bandID { get; set; }
        public string description { get; set; }
        public int categoryID { get; set; }
        public DateTime releaseDate { get; set; }
        public decimal? price { get; set; }

        public virtual Category Categories { get; set; }
        public virtual Band Bands { get; set; }
    }
}