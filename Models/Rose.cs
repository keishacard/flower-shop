using System;

namespace flower_shop
{
    public class Rose : Flower, IDescribable, IColor, IStemLength
    {
        public string Color { get; set; }
        public bool HasThorns { get; set; }
        // public DateTime DateBloomed { get; set; }
        // public double Price { get; set; }
        public double StemLength { get; set; }
        public int PetalCount { get; set; }

        public string Describe()
        {
            return $"A beautiful {Color} Rose";
        }
    }
    // tulip, sunflower, lily
    // public class Tulip
    // {
    //     public string Color { get; set; }
    //     public bool HasThorns { get; set; }
    //     public DateTime DateBloomed { get; set; }
    //     public double Price { get; set; }
    //     public double StemLength { get; set; }
    //     public int PetalCount { get; set; }

    //     public string Describe()
    //     {
    //         return $"A beautiful {Color} Tulip";
    //     }

    // }
    // public class Sunflower
    // {
    //     public string Color { get; set; }
    //     public bool HasThorns { get; set; }
    //     public DateTime DateBloomed { get; set; }
    //     public double Price { get; set; }
    //     public double StemLength { get; set; }
    //     public int PetalCount { get; set; }

    //     public string Describe()
    //     {
    //         return $"A beautiful {Color} Sunflower";
    //     }

    // }
    // public class Lily
    // {
    //     public string Color { get; set; }
    //     public bool HasThorns { get; set; }
    //     public DateTime DateBloomed { get; set; }
    //     public double Price { get; set; }
    //     public double StemLength { get; set; }
    //     public int PetalCount { get; set; }

    //     public string Describe()
    //     {
    //         return $"A beautiful {Color} Lily";
    //     }
    // }
}
