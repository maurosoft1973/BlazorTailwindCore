using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Maurosoft.Blazor.Tailwind.Core.Css;

/// <summary>
/// Utilities for controlling the bottom placement of positioned elements.
/// </summary>
public sealed class PlacementBottom : TailwindCssClassBase
{
    public static readonly PlacementBottom NotSet = new("notset", 1);
    ///.bottom-0
    public static readonly PlacementBottom Bottom_0 = new("bottom-0", 1);
    ///.bottom-0.5
    public static readonly PlacementBottom Bottom_0v5 = new("bottom-0.5", 1);
    ///.bottom-1
    public static readonly PlacementBottom Bottom_1 = new("bottom-1", 1);
    ///.bottom-1.5
    public static readonly PlacementBottom Bottom_1v5 = new("bottom-1.5", 1);
    ///.bottom-1/2
    public static readonly PlacementBottom Bottom_1d2 = new("bottom-1/2", 1);
    ///.bottom-1/3
    public static readonly PlacementBottom Bottom_1d3 = new("bottom-1/3", 1);
    ///.bottom-1/4
    public static readonly PlacementBottom Bottom_1d4 = new("bottom-1/4", 1);
    ///.bottom-10
    public static readonly PlacementBottom Bottom_10 = new("bottom-10", 1);
    ///.bottom-11
    public static readonly PlacementBottom Bottom_11 = new("bottom-11", 1);
    ///.bottom-12
    public static readonly PlacementBottom Bottom_12 = new("bottom-12", 1);
    ///.bottom-14
    public static readonly PlacementBottom Bottom_14 = new("bottom-14", 1);
    ///.bottom-16
    public static readonly PlacementBottom Bottom_16 = new("bottom-16", 1);
    ///.bottom-2
    public static readonly PlacementBottom Bottom_2 = new("bottom-2", 1);
    ///.bottom-2.5
    public static readonly PlacementBottom Bottom_2v5 = new("bottom-2.5", 1);
    ///.bottom-2/3
    public static readonly PlacementBottom Bottom_2d3 = new("bottom-2/3", 1);
    ///.bottom-2/4
    public static readonly PlacementBottom Bottom_2d4 = new("bottom-2/4", 1);
    ///.bottom-20
    public static readonly PlacementBottom Bottom_20 = new("bottom-20", 1);
    ///.bottom-24
    public static readonly PlacementBottom Bottom_24 = new("bottom-24", 1);
    ///.bottom-28
    public static readonly PlacementBottom Bottom_28 = new("bottom-28", 1);
    ///.bottom-3
    public static readonly PlacementBottom Bottom_3 = new("bottom-3", 1);
    ///.bottom-3.5
    public static readonly PlacementBottom Bottom_3v5 = new("bottom-3.5", 1);
    ///.bottom-3/4
    public static readonly PlacementBottom Bottom_3d4 = new("bottom-3/4", 1);
    ///.bottom-32
    public static readonly PlacementBottom Bottom_32 = new("bottom-32", 1);
    ///.bottom-36
    public static readonly PlacementBottom Bottom_36 = new("bottom-36", 1);
    ///.bottom-4
    public static readonly PlacementBottom Bottom_4 = new("bottom-4", 1);
    ///.bottom-40
    public static readonly PlacementBottom Bottom_40 = new("bottom-40", 1);
    ///.bottom-44
    public static readonly PlacementBottom Bottom_44 = new("bottom-44", 1);
    ///.bottom-48
    public static readonly PlacementBottom Bottom_48 = new("bottom-48", 1);
    ///.bottom-5
    public static readonly PlacementBottom Bottom_5 = new("bottom-5", 1);
    ///.bottom-52
    public static readonly PlacementBottom Bottom_52 = new("bottom-52", 1);
    ///.bottom-56
    public static readonly PlacementBottom Bottom_56 = new("bottom-56", 1);
    ///.bottom-6
    public static readonly PlacementBottom Bottom_6 = new("bottom-6", 1);
    ///.bottom-60
    public static readonly PlacementBottom Bottom_60 = new("bottom-60", 1);
    ///.bottom-64
    public static readonly PlacementBottom Bottom_64 = new("bottom-64", 1);
    ///.bottom-7
    public static readonly PlacementBottom Bottom_7 = new("bottom-7", 1);
    ///.bottom-72
    public static readonly PlacementBottom Bottom_72 = new("bottom-72", 1);
    ///.bottom-8
    public static readonly PlacementBottom Bottom_8 = new("bottom-8", 1);
    ///.bottom-80
    public static readonly PlacementBottom Bottom_80 = new("bottom-80", 1);
    ///.bottom-9
    public static readonly PlacementBottom Bottom_9 = new("bottom-9", 1);
    ///.bottom-96
    public static readonly PlacementBottom Bottom_96 = new("bottom-96", 1);
    ///.bottom-auto
    public static readonly PlacementBottom Bottom_auto = new("bottom-auto", 1);
    ///.bottom-full
    public static readonly PlacementBottom Bottom_full = new("bottom-full", 1);
    ///.bottom-px
    public static readonly PlacementBottom Bottom_px = new("bottom-px", 1);
    ///.-bottom-0
    public static readonly PlacementBottom MinusBottom_0 = new("-bottom-0", 1);
    ///.-bottom-0.5
    public static readonly PlacementBottom MinusBottom_0v5 = new("-bottom-0.5", 1);
    ///.-bottom-1
    public static readonly PlacementBottom MinusBottom_1 = new("-bottom-1", 1);
    ///.-bottom-1.5
    public static readonly PlacementBottom MinusBottom_1v5 = new("-bottom-1.5", 1);
    ///.-bottom-1/2
    public static readonly PlacementBottom MinusBottom_1d2 = new("-bottom-1/2", 1);
    ///.-bottom-1/3
    public static readonly PlacementBottom MinusBottom_1d3 = new("-bottom-1/3", 1);
    ///.-bottom-1/4
    public static readonly PlacementBottom MinusBottom_1d4 = new("-bottom-1/4", 1);
    ///.-bottom-10
    public static readonly PlacementBottom MinusBottom_10 = new("-bottom-10", 1);
    ///.-bottom-11
    public static readonly PlacementBottom MinusBottom_11 = new("-bottom-11", 1);
    ///.-bottom-12
    public static readonly PlacementBottom MinusBottom_12 = new("-bottom-12", 1);
    ///.-bottom-14
    public static readonly PlacementBottom MinusBottom_14 = new("-bottom-14", 1);
    ///.-bottom-16
    public static readonly PlacementBottom MinusBottom_16 = new("-bottom-16", 1);
    ///.-bottom-2
    public static readonly PlacementBottom MinusBottom_2 = new("-bottom-2", 1);
    ///.-bottom-2.5
    public static readonly PlacementBottom MinusBottom_2v5 = new("-bottom-2.5", 1);
    ///.-bottom-2/3
    public static readonly PlacementBottom MinusBottom_2d3 = new("-bottom-2/3", 1);
    ///.-bottom-2/4
    public static readonly PlacementBottom MinusBottom_2d4 = new("-bottom-2/4", 1);
    ///.-bottom-20
    public static readonly PlacementBottom MinusBottom_20 = new("-bottom-20", 1);
    ///.-bottom-24
    public static readonly PlacementBottom MinusBottom_24 = new("-bottom-24", 1);
    ///.-bottom-28
    public static readonly PlacementBottom MinusBottom_28 = new("-bottom-28", 1);
    ///.-bottom-3
    public static readonly PlacementBottom MinusBottom_3 = new("-bottom-3", 1);
    ///.-bottom-3.5
    public static readonly PlacementBottom MinusBottom_3v5 = new("-bottom-3.5", 1);
    ///.-bottom-3/4
    public static readonly PlacementBottom MinusBottom_3d4 = new("-bottom-3/4", 1);
    ///.-bottom-32
    public static readonly PlacementBottom MinusBottom_32 = new("-bottom-32", 1);
    ///.-bottom-36
    public static readonly PlacementBottom MinusBottom_36 = new("-bottom-36", 1);
    ///.-bottom-4
    public static readonly PlacementBottom MinusBottom_4 = new("-bottom-4", 1);
    ///.-bottom-40
    public static readonly PlacementBottom MinusBottom_40 = new("-bottom-40", 1);
    ///.-bottom-44
    public static readonly PlacementBottom MinusBottom_44 = new("-bottom-44", 1);
    ///.-bottom-48
    public static readonly PlacementBottom MinusBottom_48 = new("-bottom-48", 1);
    ///.-bottom-5
    public static readonly PlacementBottom MinusBottom_5 = new("-bottom-5", 1);
    ///.-bottom-52
    public static readonly PlacementBottom MinusBottom_52 = new("-bottom-52", 1);
    ///.-bottom-56
    public static readonly PlacementBottom MinusBottom_56 = new("-bottom-56", 1);
    ///.-bottom-6
    public static readonly PlacementBottom MinusBottom_6 = new("-bottom-6", 1);
    ///.-bottom-60
    public static readonly PlacementBottom MinusBottom_60 = new("-bottom-60", 1);
    ///.-bottom-64
    public static readonly PlacementBottom MinusBottom_64 = new("-bottom-64", 1);
    ///.-bottom-7
    public static readonly PlacementBottom MinusBottom_7 = new("-bottom-7", 1);
    ///.-bottom-72
    public static readonly PlacementBottom MinusBottom_72 = new("-bottom-72", 1);
    ///.-bottom-8
    public static readonly PlacementBottom MinusBottom_8 = new("-bottom-8", 1);
    ///.-bottom-80
    public static readonly PlacementBottom MinusBottom_80 = new("-bottom-80", 1);
    ///.-bottom-9
    public static readonly PlacementBottom MinusBottom_9 = new("-bottom-9", 1);
    ///.-bottom-96
    public static readonly PlacementBottom MinusBottom_96 = new("-bottom-96", 1);
    ///.-bottom-full
    public static readonly PlacementBottom MinusBottom_full = new("-bottom-full", 1);
    ///.-bottom-px
    public static readonly PlacementBottom MinusBottom_px = new("-bottom-px", 1);

    private PlacementBottom(string name, int value) : base(name, value) { }
}
