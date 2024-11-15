using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Maurosoft.Blazor.Tailwind.Core.Css;

/// <summary>
/// Utilities for controlling the left placement of positioned elements.
/// </summary>
public sealed class PlacementLeft : TailwindCssClassBase
{
    public static readonly PlacementLeft NotSet = new("notset", 1);
    ///.left-0
    public static readonly PlacementLeft Left_0 = new("left-0", 1);
    ///.left-0.5
    public static readonly PlacementLeft Left_0v5 = new("left-0.5", 1);
    ///.left-1
    public static readonly PlacementLeft Left_1 = new("left-1", 1);
    ///.left-1.5
    public static readonly PlacementLeft Left_1v5 = new("left-1.5", 1);
    ///.left-1/2
    public static readonly PlacementLeft Left_1d2 = new("left-1/2", 1);
    ///.left-1/3
    public static readonly PlacementLeft Left_1d3 = new("left-1/3", 1);
    ///.left-1/4
    public static readonly PlacementLeft Left_1d4 = new("left-1/4", 1);
    ///.left-10
    public static readonly PlacementLeft Left_10 = new("left-10", 1);
    ///.left-11
    public static readonly PlacementLeft Left_11 = new("left-11", 1);
    ///.left-12
    public static readonly PlacementLeft Left_12 = new("left-12", 1);
    ///.left-14
    public static readonly PlacementLeft Left_14 = new("left-14", 1);
    ///.left-16
    public static readonly PlacementLeft Left_16 = new("left-16", 1);
    ///.left-2
    public static readonly PlacementLeft Left_2 = new("left-2", 1);
    ///.left-2.5
    public static readonly PlacementLeft Left_2v5 = new("left-2.5", 1);
    ///.left-2/3
    public static readonly PlacementLeft Left_2d3 = new("left-2/3", 1);
    ///.left-2/4
    public static readonly PlacementLeft Left_2d4 = new("left-2/4", 1);
    ///.left-20
    public static readonly PlacementLeft Left_20 = new("left-20", 1);
    ///.left-24
    public static readonly PlacementLeft Left_24 = new("left-24", 1);
    ///.left-28
    public static readonly PlacementLeft Left_28 = new("left-28", 1);
    ///.left-3
    public static readonly PlacementLeft Left_3 = new("left-3", 1);
    ///.left-3.5
    public static readonly PlacementLeft Left_3v5 = new("left-3.5", 1);
    ///.left-3/4
    public static readonly PlacementLeft Left_3d4 = new("left-3/4", 1);
    ///.left-32
    public static readonly PlacementLeft Left_32 = new("left-32", 1);
    ///.left-36
    public static readonly PlacementLeft Left_36 = new("left-36", 1);
    ///.left-4
    public static readonly PlacementLeft Left_4 = new("left-4", 1);
    ///.left-40
    public static readonly PlacementLeft Left_40 = new("left-40", 1);
    ///.left-44
    public static readonly PlacementLeft Left_44 = new("left-44", 1);
    ///.left-48
    public static readonly PlacementLeft Left_48 = new("left-48", 1);
    ///.left-5
    public static readonly PlacementLeft Left_5 = new("left-5", 1);
    ///.left-52
    public static readonly PlacementLeft Left_52 = new("left-52", 1);
    ///.left-56
    public static readonly PlacementLeft Left_56 = new("left-56", 1);
    ///.left-6
    public static readonly PlacementLeft Left_6 = new("left-6", 1);
    ///.left-60
    public static readonly PlacementLeft Left_60 = new("left-60", 1);
    ///.left-64
    public static readonly PlacementLeft Left_64 = new("left-64", 1);
    ///.left-7
    public static readonly PlacementLeft Left_7 = new("left-7", 1);
    ///.left-72
    public static readonly PlacementLeft Left_72 = new("left-72", 1);
    ///.left-8
    public static readonly PlacementLeft Left_8 = new("left-8", 1);
    ///.left-80
    public static readonly PlacementLeft Left_80 = new("left-80", 1);
    ///.left-9
    public static readonly PlacementLeft Left_9 = new("left-9", 1);
    ///.left-96
    public static readonly PlacementLeft Left_96 = new("left-96", 1);
    ///.left-auto
    public static readonly PlacementLeft Left_auto = new("left-auto", 1);
    ///.left-full
    public static readonly PlacementLeft Left_full = new("left-full", 1);
    ///.left-px
    public static readonly PlacementLeft Left_px = new("left-px", 1);
    ///.-left-0
    public static readonly PlacementLeft MinusLeft_0 = new("-left-0", 1);
    ///.-left-0.5
    public static readonly PlacementLeft MinusLeft_0v5 = new("-left-0.5", 1);
    ///.-left-1
    public static readonly PlacementLeft MinusLeft_1 = new("-left-1", 1);
    ///.-left-1.5
    public static readonly PlacementLeft MinusLeft_1v5 = new("-left-1.5", 1);
    ///.-left-1/2
    public static readonly PlacementLeft MinusLeft_1d2 = new("-left-1/2", 1);
    ///.-left-1/3
    public static readonly PlacementLeft MinusLeft_1d3 = new("-left-1/3", 1);
    ///.-left-1/4
    public static readonly PlacementLeft MinusLeft_1d4 = new("-left-1/4", 1);
    ///.-left-10
    public static readonly PlacementLeft MinusLeft_10 = new("-left-10", 1);
    ///.-left-11
    public static readonly PlacementLeft MinusLeft_11 = new("-left-11", 1);
    ///.-left-12
    public static readonly PlacementLeft MinusLeft_12 = new("-left-12", 1);
    ///.-left-14
    public static readonly PlacementLeft MinusLeft_14 = new("-left-14", 1);
    ///.-left-16
    public static readonly PlacementLeft MinusLeft_16 = new("-left-16", 1);
    ///.-left-2
    public static readonly PlacementLeft MinusLeft_2 = new("-left-2", 1);
    ///.-left-2.5
    public static readonly PlacementLeft MinusLeft_2v5 = new("-left-2.5", 1);
    ///.-left-2/3
    public static readonly PlacementLeft MinusLeft_2d3 = new("-left-2/3", 1);
    ///.-left-2/4
    public static readonly PlacementLeft MinusLeft_2d4 = new("-left-2/4", 1);
    ///.-left-20
    public static readonly PlacementLeft MinusLeft_20 = new("-left-20", 1);
    ///.-left-24
    public static readonly PlacementLeft MinusLeft_24 = new("-left-24", 1);
    ///.-left-28
    public static readonly PlacementLeft MinusLeft_28 = new("-left-28", 1);
    ///.-left-3
    public static readonly PlacementLeft MinusLeft_3 = new("-left-3", 1);
    ///.-left-3.5
    public static readonly PlacementLeft MinusLeft_3v5 = new("-left-3.5", 1);
    ///.-left-3/4
    public static readonly PlacementLeft MinusLeft_3d4 = new("-left-3/4", 1);
    ///.-left-32
    public static readonly PlacementLeft MinusLeft_32 = new("-left-32", 1);
    ///.-left-36
    public static readonly PlacementLeft MinusLeft_36 = new("-left-36", 1);
    ///.-left-4
    public static readonly PlacementLeft MinusLeft_4 = new("-left-4", 1);
    ///.-left-40
    public static readonly PlacementLeft MinusLeft_40 = new("-left-40", 1);
    ///.-left-44
    public static readonly PlacementLeft MinusLeft_44 = new("-left-44", 1);
    ///.-left-48
    public static readonly PlacementLeft MinusLeft_48 = new("-left-48", 1);
    ///.-left-5
    public static readonly PlacementLeft MinusLeft_5 = new("-left-5", 1);
    ///.-left-52
    public static readonly PlacementLeft MinusLeft_52 = new("-left-52", 1);
    ///.-left-56
    public static readonly PlacementLeft MinusLeft_56 = new("-left-56", 1);
    ///.-left-6
    public static readonly PlacementLeft MinusLeft_6 = new("-left-6", 1);
    ///.-left-60
    public static readonly PlacementLeft MinusLeft_60 = new("-left-60", 1);
    ///.-left-64
    public static readonly PlacementLeft MinusLeft_64 = new("-left-64", 1);
    ///.-left-7
    public static readonly PlacementLeft MinusLeft_7 = new("-left-7", 1);
    ///.-left-72
    public static readonly PlacementLeft MinusLeft_72 = new("-left-72", 1);
    ///.-left-8
    public static readonly PlacementLeft MinusLeft_8 = new("-left-8", 1);
    ///.-left-80
    public static readonly PlacementLeft MinusLeft_80 = new("-left-80", 1);
    ///.-left-9
    public static readonly PlacementLeft MinusLeft_9 = new("-left-9", 1);
    ///.-left-96
    public static readonly PlacementLeft MinusLeft_96 = new("-left-96", 1);
    ///.-left-full
    public static readonly PlacementLeft MinusLeft_full = new("-left-full", 1);
    ///.-left-px
    public static readonly PlacementLeft MinusLeft_px = new("-left-px", 1);

    private PlacementLeft(string name, int value) : base(name, value) { }
}
