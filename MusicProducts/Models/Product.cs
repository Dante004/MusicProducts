using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace MusicProducts.Models
{
    public class Product
    {
        public int ID { get; set; }

        [Required]
        [Display(Name = "Name")]
        [StringLength(50, ErrorMessage = "The name of the album can't be longer than 50 characters.")]
        public string name { get; set; }

        [Required]
        [Display(Name = "Band")]
        public int bandID { get; set; }

        [Required]
        [Display(Name = "Description")]
        [StringLength(450, ErrorMessage = "Description cannot be longer than 450 characters")]
        public string description { get; set; }

        [Required]
        [Display(Name = "Category")]
        public int categoryID { get; set; }

        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        [Display(Name = "Release Date")]
        public DateTime releaseDate { get; set; }

        [Display(Name = "Price")]
        public decimal? price { get; set; }

        public virtual Category Categories { get; set; }
        public virtual Band Bands { get; set; }
    }
}