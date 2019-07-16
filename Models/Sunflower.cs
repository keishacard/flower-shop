using System;

namespace flower_shop
{
    public class Sunflower : Flower, IDescribable, IStemLength
    {
        // public string Color { get; set; }
        // public bool HasThorns { get; set; }
        // public DateTime DateBloomed { get; set; }
        // public double Price { get; set; }
        public double StemLength { get; set; }
        public int PetalCount { get; set; }

        public string Describe()
        {
            return $"A beautiful {PetalCount} Sunflower";
        }
    }
}