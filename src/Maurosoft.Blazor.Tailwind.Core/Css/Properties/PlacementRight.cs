using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Maurosoft.Blazor.Tailwind.Core.Css;

/// <summary>
/// Utilities for controlling the right placement of positioned elements.
/// </summary>
public sealed class PlacementRight : TailwindCssClassBase
{
    public static readonly PlacementRight NotSet = new("notset", 1);
    ///.right-0
    public static readonly PlacementRight Right_0 = new("right-0", 1);
    ///.right-0.5
    public static readonly PlacementRight Right_0v5 = new("right-0.5", 1);
    ///.right-1
    public static readonly PlacementRight Right_1 = new("right-1", 1);
    ///.right-1.5
    public static readonly PlacementRight Right_1v5 = new("right-1.5", 1);
    ///.right-1/2
    public static readonly PlacementRight Right_1d2 = new("right-1/2", 1);
    ///.right-1/3
    public static readonly PlacementRight Right_1d3 = new("right-1/3", 1);
    ///.right-1/4
    public static readonly PlacementRight Right_1d4 = new("right-1/4", 1);
    ///.right-10
    public static readonly PlacementRight Right_10 = new("right-10", 1);
    ///.right-11
    public static readonly PlacementRight Right_11 = new("right-11", 1);
    ///.right-12
    public static readonly PlacementRight Right_12 = new("right-12", 1);
    ///.right-14
    public static readonly PlacementRight Right_14 = new("right-14", 1);
    ///.right-16
    public static readonly PlacementRight Right_16 = new("right-16", 1);
    ///.right-2
    public static readonly PlacementRight Right_2 = new("right-2", 1);
    ///.right-2.5
    public static readonly PlacementRight Right_2v5 = new("right-2.5", 1);
    ///.right-2/3
    public static readonly PlacementRight Right_2d3 = new("right-2/3", 1);
    ///.right-2/4
    public static readonly PlacementRight Right_2d4 = new("right-2/4", 1);
    ///.right-20
    public static readonly PlacementRight Right_20 = new("right-20", 1);
    ///.right-24
    public static readonly PlacementRight Right_24 = new("right-24", 1);
    ///.right-28
    public static readonly PlacementRight Right_28 = new("right-28", 1);
    ///.right-3
    public static readonly PlacementRight Right_3 = new("right-3", 1);
    ///.right-3.5
    public static readonly PlacementRight Right_3v5 = new("right-3.5", 1);
    ///.right-3/4
    public static readonly PlacementRight Right_3d4 = new("right-3/4", 1);
    ///.right-32
    public static readonly PlacementRight Right_32 = new("right-32", 1);
    ///.right-36
    public static readonly PlacementRight Right_36 = new("right-36", 1);
    ///.right-4
    public static readonly PlacementRight Right_4 = new("right-4", 1);
    ///.right-40
    public static readonly PlacementRight Right_40 = new("right-40", 1);
    ///.right-44
    public static readonly PlacementRight Right_44 = new("right-44", 1);
    ///.right-48
    public static readonly PlacementRight Right_48 = new("right-48", 1);
    ///.right-5
    public static readonly PlacementRight Right_5 = new("right-5", 1);
    ///.right-52
    public static readonly PlacementRight Right_52 = new("right-52", 1);
    ///.right-56
    public static readonly PlacementRight Right_56 = new("right-56", 1);
    ///.right-6
    public static readonly PlacementRight Right_6 = new("right-6", 1);
    ///.right-60
    public static readonly PlacementRight Right_60 = new("right-60", 1);
    ///.right-64
    public static readonly PlacementRight Right_64 = new("right-64", 1);
    ///.right-7
    public static readonly PlacementRight Right_7 = new("right-7", 1);
    ///.right-72
    public static readonly PlacementRight Right_72 = new("right-72", 1);
    ///.right-8
    public static readonly PlacementRight Right_8 = new("right-8", 1);
    ///.right-80
    public static readonly PlacementRight Right_80 = new("right-80", 1);
    ///.right-9
    public static readonly PlacementRight Right_9 = new("right-9", 1);
    ///.right-96
    public static readonly PlacementRight Right_96 = new("right-96", 1);
    ///.right-auto
    public static readonly PlacementRight Right_auto = new("right-auto", 1);
    ///.right-full
    public static readonly PlacementRight Right_full = new("right-full", 1);
    ///.right-px
    public static readonly PlacementRight Right_px = new("right-px", 1);
    ///.-right-0
    public static readonly PlacementRight MinusRight_0 = new("-right-0", 1);
    ///.-right-0.5
    public static readonly PlacementRight MinusRight_0v5 = new("-right-0.5", 1);
    ///.-right-1
    public static readonly PlacementRight MinusRight_1 = new("-right-1", 1);
    ///.-right-1.5
    public static readonly PlacementRight MinusRight_1v5 = new("-right-1.5", 1);
    ///.-right-1/2
    public static readonly PlacementRight MinusRight_1d2 = new("-right-1/2", 1);
    ///.-right-1/3
    public static readonly PlacementRight MinusRight_1d3 = new("-right-1/3", 1);
    ///.-right-1/4
    public static readonly PlacementRight MinusRight_1d4 = new("-right-1/4", 1);
    ///.-right-10
    public static readonly PlacementRight MinusRight_10 = new("-right-10", 1);
    ///.-right-11
    public static readonly PlacementRight MinusRight_11 = new("-right-11", 1);
    ///.-right-12
    public static readonly PlacementRight MinusRight_12 = new("-right-12", 1);
    ///.-right-14
    public static readonly PlacementRight MinusRight_14 = new("-right-14", 1);
    ///.-right-16
    public static readonly PlacementRight MinusRight_16 = new("-right-16", 1);
    ///.-right-2
    public static readonly PlacementRight MinusRight_2 = new("-right-2", 1);
    ///.-right-2.5
    public static readonly PlacementRight MinusRight_2v5 = new("-right-2.5", 1);
    ///.-right-2/3
    public static readonly PlacementRight MinusRight_2d3 = new("-right-2/3", 1);
    ///.-right-2/4
    public static readonly PlacementRight MinusRight_2d4 = new("-right-2/4", 1);
    ///.-right-20
    public static readonly PlacementRight MinusRight_20 = new("-right-20", 1);
    ///.-right-24
    public static readonly PlacementRight MinusRight_24 = new("-right-24", 1);
    ///.-right-28
    public static readonly PlacementRight MinusRight_28 = new("-right-28", 1);
    ///.-right-3
    public static readonly PlacementRight MinusRight_3 = new("-right-3", 1);
    ///.-right-3.5
    public static readonly PlacementRight MinusRight_3v5 = new("-right-3.5", 1);
    ///.-right-3/4
    public static readonly PlacementRight MinusRight_3d4 = new("-right-3/4", 1);
    ///.-right-32
    public static readonly PlacementRight MinusRight_32 = new("-right-32", 1);
    ///.-right-36
    public static readonly PlacementRight MinusRight_36 = new("-right-36", 1);
    ///.-right-4
    public static readonly PlacementRight MinusRight_4 = new("-right-4", 1);
    ///.-right-40
    public static readonly PlacementRight MinusRight_40 = new("-right-40", 1);
    ///.-right-44
    public static readonly PlacementRight MinusRight_44 = new("-right-44", 1);
    ///.-right-48
    public static readonly PlacementRight MinusRight_48 = new("-right-48", 1);
    ///.-right-5
    public static readonly PlacementRight MinusRight_5 = new("-right-5", 1);
    ///.-right-52
    public static readonly PlacementRight MinusRight_52 = new("-right-52", 1);
    ///.-right-56
    public static readonly PlacementRight MinusRight_56 = new("-right-56", 1);
    ///.-right-6
    public static readonly PlacementRight MinusRight_6 = new("-right-6", 1);
    ///.-right-60
    public static readonly PlacementRight MinusRight_60 = new("-right-60", 1);
    ///.-right-64
    public static readonly PlacementRight MinusRight_64 = new("-right-64", 1);
    ///.-right-7
    public static readonly PlacementRight MinusRight_7 = new("-right-7", 1);
    ///.-right-72
    public static readonly PlacementRight MinusRight_72 = new("-right-72", 1);
    ///.-right-8
    public static readonly PlacementRight MinusRight_8 = new("-right-8", 1);
    ///.-right-80
    public static readonly PlacementRight MinusRight_80 = new("-right-80", 1);
    ///.-right-9
    public static readonly PlacementRight MinusRight_9 = new("-right-9", 1);
    ///.-right-96
    public static readonly PlacementRight MinusRight_96 = new("-right-96", 1);
    ///.-right-full
    public static readonly PlacementRight MinusRight_full = new("-right-full", 1);
    ///.-right-px
    public static readonly PlacementRight MinusRight_px = new("-right-px", 1);

    private PlacementRight(string name, int value) : base(name, value) { }
}
