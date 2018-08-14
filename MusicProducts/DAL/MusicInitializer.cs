using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using MusicProducts.Models;

namespace MusicProducts.DAL
{
    public class MusicInitializer : DropCreateDatabaseIfModelChanges<ProductContext>
    {
        protected override void Seed(ProductContext context)
        {
            var categories = new List<Category>
            {
                new Category{ categoryName="Heavy Metal" },
                new Category{ categoryName="Thrash Metal"},
                new Category{ categoryName="Power Metal" },
                new Category{ categoryName="Hard Rock"},
            };

            categories.ForEach(s => context.categories.Add(s));

            var bands = new List<Band>
            {
                new Band{bandName="Metallica" },
                new Band{bandName="Megadeth" },
                new Band{bandName="Iron Maiden" },
                new Band{bandName="Judas Priest" },
                new Band{bandName="Sabaton" },
                new Band{bandName="AC/DC" },
            };

            bands.ForEach(s => context.bands.Add(s));

            var products = new List<Product>
            {
                new Product{ name="Master of Puppets",bandID=1,description="Master of Puppets is the third studio album by American heavy metal band Metallica. It was released on March 3, 1986 by Elektra Records.[1] Recorded at the Sweet Silence Studios with producer Flemming Rasmussen, it was the first Metallica album released on a major record label.",categoryID=2,releaseDate=new DateTime(1986,3,3)},
                new Product{ name="Painkiller",bandID=4,description="Painkiller is the 12th studio album by British heavy metal band Judas Priest, released in September 1990. It is the last Judas Priest album to feature lead singer Rob Halford until his return for the 2005 album Angel of Retribution and the first to feature drummer Scott Travis.",categoryID=1,releaseDate=new DateTime(1990,9,3)},
                new Product{ name="The Number of The Beast",bandID=3,description="The Number of the Beast is the third studio album by the English heavy metal band Iron Maiden, released in March 1982. It was their first release to feature vocalist Bruce Dickinson and their last with drummer Clive Burr.",categoryID=1,releaseDate=new DateTime(1982,3,22)},
                new Product{ name="Rust in Peace",bandID=2,description="Rust in Peace is the fourth studio album by the American thrash metal band Megadeth, released on September 24, 1990 by Capitol Records. Following the departure of band members Jeff Young and Chuck Behler in 1989, Rust in Peace was the first album to feature guitarist Marty Friedman and drummer Nick Menza.",categoryID=2,releaseDate=new DateTime(1989,9,24)},
                new Product{ name="Kill'em All",bandID=1,description="Kill 'Em All is the debut studio album by the American heavy metal band Metallica, released on July 25, 1983, by the independent record label Megaforce Records.",categoryID=2,releaseDate=new DateTime(1983,7,25)},
            };

            products.ForEach(s => context.products.Add(s));
            context.SaveChanges();
        }
    }
}