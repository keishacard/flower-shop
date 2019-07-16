using System;
using System.Collections.Generic;

namespace flower_shop
{

    public class FlowerShop
    {
        public List<Rose> Roses { get; set; }
        public List<Lily> Lilies { get; set; }
        public List<Tulip> Tulips { get; set; }
        public List<Sunflower> Sunflowers { get; set; }

        // any flower that goes in mothers arr must have stemlength prop
        public List<IStemLength> MothersDayArrangement { get; set; } = new List<IStemLength>
        {
            new Rose() { PetalCount = 27, Price = 3.00},
            new Sunflower() { PetalCount = 50, Price = 5.00 }
        };

        // any flower in bd arr must have color prop
        public List<IColor> BirthdayArrangement { get; set; } = new List<IColor>
        {
            new Rose() { Color = "red", Price = 3.00 },
            new Lily() { Color = "yellow", Price = 4.00 }
        };

    }
}