using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MusicProducts.Models
{
    public class Band
    {
        public int bandID { get; set; }
        public string bandName;

        public virtual Product product { get; set; }
    }
}