using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Maurosoft.Blazor.Tailwind.Core.Css;

/// <summary>
/// Utilities for controlling the top placement of positioned elements.
/// </summary>
public sealed class PlacementTop : TailwindCssClassBase
{
    public static readonly PlacementTop NotSet = new("notset", 1);
    ///.top-0
    public static readonly PlacementTop Top_0 = new("top-0", 1);
    ///.top-0.5
    public static readonly PlacementTop Top_0v5 = new("top-0.5", 1);
    ///.top-1
    public static readonly PlacementTop Top_1 = new("top-1", 1);
    ///.top-1.5
    public static readonly PlacementTop Top_1v5 = new("top-1.5", 1);
    ///.top-1/2
    public static readonly PlacementTop Top_1d2 = new("top-1/2", 1);
    ///.top-1/3
    public static readonly PlacementTop Top_1d3 = new("top-1/3", 1);
    ///.top-1/4
    public static readonly PlacementTop Top_1d4 = new("top-1/4", 1);
    ///.top-10
    public static readonly PlacementTop Top_10 = new("top-10", 1);
    ///.top-11
    public static readonly PlacementTop Top_11 = new("top-11", 1);
    ///.top-12
    public static readonly PlacementTop Top_12 = new("top-12", 1);
    ///.top-14
    public static readonly PlacementTop Top_14 = new("top-14", 1);
    ///.top-16
    public static readonly PlacementTop Top_16 = new("top-16", 1);
    ///.top-2
    public static readonly PlacementTop Top_2 = new("top-2", 1);
    ///.top-2.5
    public static readonly PlacementTop Top_2v5 = new("top-2.5", 1);
    ///.top-2/3
    public static readonly PlacementTop Top_2d3 = new("top-2/3", 1);
    ///.top-2/4
    public static readonly PlacementTop Top_2d4 = new("top-2/4", 1);
    ///.top-20
    public static readonly PlacementTop Top_20 = new("top-20", 1);
    ///.top-24
    public static readonly PlacementTop Top_24 = new("top-24", 1);
    ///.top-28
    public static readonly PlacementTop Top_28 = new("top-28", 1);
    ///.top-3
    public static readonly PlacementTop Top_3 = new("top-3", 1);
    ///.top-3.5
    public static readonly PlacementTop Top_3v5 = new("top-3.5", 1);
    ///.top-3/4
    public static readonly PlacementTop Top_3d4 = new("top-3/4", 1);
    ///.top-32
    public static readonly PlacementTop Top_32 = new("top-32", 1);
    ///.top-36
    public static readonly PlacementTop Top_36 = new("top-36", 1);
    ///.top-4
    public static readonly PlacementTop Top_4 = new("top-4", 1);
    ///.top-40
    public static readonly PlacementTop Top_40 = new("top-40", 1);
    ///.top-44
    public static readonly PlacementTop Top_44 = new("top-44", 1);
    ///.top-48
    public static readonly PlacementTop Top_48 = new("top-48", 1);
    ///.top-5
    public static readonly PlacementTop Top_5 = new("top-5", 1);
    ///.top-52
    public static readonly PlacementTop Top_52 = new("top-52", 1);
    ///.top-56
    public static readonly PlacementTop Top_56 = new("top-56", 1);
    ///.top-6
    public static readonly PlacementTop Top_6 = new("top-6", 1);
    ///.top-60
    public static readonly PlacementTop Top_60 = new("top-60", 1);
    ///.top-64
    public static readonly PlacementTop Top_64 = new("top-64", 1);
    ///.top-7
    public static readonly PlacementTop Top_7 = new("top-7", 1);
    ///.top-72
    public static readonly PlacementTop Top_72 = new("top-72", 1);
    ///.top-8
    public static readonly PlacementTop Top_8 = new("top-8", 1);
    ///.top-80
    public static readonly PlacementTop Top_80 = new("top-80", 1);
    ///.top-9
    public static readonly PlacementTop Top_9 = new("top-9", 1);
    ///.top-96
    public static readonly PlacementTop Top_96 = new("top-96", 1);
    ///.top-auto
    public static readonly PlacementTop Top_auto = new("top-auto", 1);
    ///.top-full
    public static readonly PlacementTop Top_full = new("top-full", 1);
    ///.top-px
    public static readonly PlacementTop Top_px = new("top-px", 1);
    ///.-top-0
    public static readonly PlacementTop MinusTop_0 = new("-top-0", 1);
    ///.-top-0.5
    public static readonly PlacementTop MinusTop_0v5 = new("-top-0.5", 1);
    ///.-top-1
    public static readonly PlacementTop MinusTop_1 = new("-top-1", 1);
    ///.-top-1.5
    public static readonly PlacementTop MinusTop_1v5 = new("-top-1.5", 1);
    ///.-top-1/2
    public static readonly PlacementTop MinusTop_1d2 = new("-top-1/2", 1);
    ///.-top-1/3
    public static readonly PlacementTop MinusTop_1d3 = new("-top-1/3", 1);
    ///.-top-1/4
    public static readonly PlacementTop MinusTop_1d4 = new("-top-1/4", 1);
    ///.-top-10
    public static readonly PlacementTop MinusTop_10 = new("-top-10", 1);
    ///.-top-11
    public static readonly PlacementTop MinusTop_11 = new("-top-11", 1);
    ///.-top-12
    public static readonly PlacementTop MinusTop_12 = new("-top-12", 1);
    ///.-top-14
    public static readonly PlacementTop MinusTop_14 = new("-top-14", 1);
    ///.-top-16
    public static readonly PlacementTop MinusTop_16 = new("-top-16", 1);
    ///.-top-2
    public static readonly PlacementTop MinusTop_2 = new("-top-2", 1);
    ///.-top-2.5
    public static readonly PlacementTop MinusTop_2v5 = new("-top-2.5", 1);
    ///.-top-2/3
    public static readonly PlacementTop MinusTop_2d3 = new("-top-2/3", 1);
    ///.-top-2/4
    public static readonly PlacementTop MinusTop_2d4 = new("-top-2/4", 1);
    ///.-top-20
    public static readonly PlacementTop MinusTop_20 = new("-top-20", 1);
    ///.-top-24
    public static readonly PlacementTop MinusTop_24 = new("-top-24", 1);
    ///.-top-28
    public static readonly PlacementTop MinusTop_28 = new("-top-28", 1);
    ///.-top-3
    public static readonly PlacementTop MinusTop_3 = new("-top-3", 1);
    ///.-top-3.5
    public static readonly PlacementTop MinusTop_3v5 = new("-top-3.5", 1);
    ///.-top-3/4
    public static readonly PlacementTop MinusTop_3d4 = new("-top-3/4", 1);
    ///.-top-32
    public static readonly PlacementTop MinusTop_32 = new("-top-32", 1);
    ///.-top-36
    public static readonly PlacementTop MinusTop_36 = new("-top-36", 1);
    ///.-top-4
    public static readonly PlacementTop MinusTop_4 = new("-top-4", 1);
    ///.-top-40
    public static readonly PlacementTop MinusTop_40 = new("-top-40", 1);
    ///.-top-44
    public static readonly PlacementTop MinusTop_44 = new("-top-44", 1);
    ///.-top-48
    public static readonly PlacementTop MinusTop_48 = new("-top-48", 1);
    ///.-top-5
    public static readonly PlacementTop MinusTop_5 = new("-top-5", 1);
    ///.-top-52
    public static readonly PlacementTop MinusTop_52 = new("-top-52", 1);
    ///.-top-56
    public static readonly PlacementTop MinusTop_56 = new("-top-56", 1);
    ///.-top-6
    public static readonly PlacementTop MinusTop_6 = new("-top-6", 1);
    ///.-top-60
    public static readonly PlacementTop MinusTop_60 = new("-top-60", 1);
    ///.-top-64
    public static readonly PlacementTop MinusTop_64 = new("-top-64", 1);
    ///.-top-7
    public static readonly PlacementTop MinusTop_7 = new("-top-7", 1);
    ///.-top-72
    public static readonly PlacementTop MinusTop_72 = new("-top-72", 1);
    ///.-top-8
    public static readonly PlacementTop MinusTop_8 = new("-top-8", 1);
    ///.-top-80
    public static readonly PlacementTop MinusTop_80 = new("-top-80", 1);
    ///.-top-9
    public static readonly PlacementTop MinusTop_9 = new("-top-9", 1);
    ///.-top-96
    public static readonly PlacementTop MinusTop_96 = new("-top-96", 1);
    ///.-top-full
    public static readonly PlacementTop MinusTop_full = new("-top-full", 1);
    ///.-top-px
    public static readonly PlacementTop MinusTop_px = new("-top-px", 1);

    private PlacementTop(string name, int value) : base(name, value)
    {
    }
}
