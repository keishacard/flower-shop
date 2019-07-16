using System;

namespace flower_shop
{

    public interface IColor
    {
        // don't need to write public, bc public is always implied in interface
        string Color { get; set; }
    }
}