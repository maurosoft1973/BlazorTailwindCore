using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Maurosoft.Blazor.Tailwind.Core.Css;

/// <summary>
/// Utilities for controlling the placement of positioned elements.
/// </summary>
public sealed class Placement : TailwindCssClassBase
{
    public static readonly Placement NotSet = new("notset", 1);
    ///.inset-0
    public static readonly Placement Inset_0 = new("inset-0", 1);
    ///.inset-0.5
    public static readonly Placement Inset_0v5 = new("inset-0.5", 1);
    ///.inset-1
    public static readonly Placement Inset_1 = new("inset-1", 1);
    ///.inset-1.5
    public static readonly Placement Inset_1v5 = new("inset-1.5", 1);
    ///.inset-1/2
    public static readonly Placement Inset_1d2 = new("inset-1/2", 1);
    ///.inset-1/3
    public static readonly Placement Inset_1d3 = new("inset-1/3", 1);
    ///.inset-1/4
    public static readonly Placement Inset_1d4 = new("inset-1/4", 1);
    ///.inset-10
    public static readonly Placement Inset_10 = new("inset-10", 1);
    ///.inset-11
    public static readonly Placement Inset_11 = new("inset-11", 1);
    ///.inset-12
    public static readonly Placement Inset_12 = new("inset-12", 1);
    ///.inset-14
    public static readonly Placement Inset_14 = new("inset-14", 1);
    ///.inset-16
    public static readonly Placement Inset_16 = new("inset-16", 1);
    ///.inset-2
    public static readonly Placement Inset_2 = new("inset-2", 1);
    ///.inset-2.5
    public static readonly Placement Inset_2v5 = new("inset-2.5", 1);
    ///.inset-2/3
    public static readonly Placement Inset_2d3 = new("inset-2/3", 1);
    ///.inset-2/4
    public static readonly Placement Inset_2d4 = new("inset-2/4", 1);
    ///.inset-20
    public static readonly Placement Inset_20 = new("inset-20", 1);
    ///.inset-24
    public static readonly Placement Inset_24 = new("inset-24", 1);
    ///.inset-28
    public static readonly Placement Inset_28 = new("inset-28", 1);
    ///.inset-3
    public static readonly Placement Inset_3 = new("inset-3", 1);
    ///.inset-3.5
    public static readonly Placement Inset_3v5 = new("inset-3.5", 1);
    ///.inset-3/4
    public static readonly Placement Inset_3d4 = new("inset-3/4", 1);
    ///.inset-32
    public static readonly Placement Inset_32 = new("inset-32", 1);
    ///.inset-36
    public static readonly Placement Inset_36 = new("inset-36", 1);
    ///.inset-4
    public static readonly Placement Inset_4 = new("inset-4", 1);
    ///.inset-40
    public static readonly Placement Inset_40 = new("inset-40", 1);
    ///.inset-44
    public static readonly Placement Inset_44 = new("inset-44", 1);
    ///.inset-48
    public static readonly Placement Inset_48 = new("inset-48", 1);
    ///.inset-5
    public static readonly Placement Inset_5 = new("inset-5", 1);
    ///.inset-52
    public static readonly Placement Inset_52 = new("inset-52", 1);
    ///.inset-56
    public static readonly Placement Inset_56 = new("inset-56", 1);
    ///.inset-6
    public static readonly Placement Inset_6 = new("inset-6", 1);
    ///.inset-60
    public static readonly Placement Inset_60 = new("inset-60", 1);
    ///.inset-64
    public static readonly Placement Inset_64 = new("inset-64", 1);
    ///.inset-7
    public static readonly Placement Inset_7 = new("inset-7", 1);
    ///.inset-72
    public static readonly Placement Inset_72 = new("inset-72", 1);
    ///.inset-8
    public static readonly Placement Inset_8 = new("inset-8", 1);
    ///.inset-80
    public static readonly Placement Inset_80 = new("inset-80", 1);
    ///.inset-9
    public static readonly Placement Inset_9 = new("inset-9", 1);
    ///.inset-96
    public static readonly Placement Inset_96 = new("inset-96", 1);
    ///.inset-auto
    public static readonly Placement Inset_auto = new("inset-auto", 1);
    ///.inset-full
    public static readonly Placement Inset_full = new("inset-full", 1);
    ///.inset-px
    public static readonly Placement Inset_px = new("inset-px", 1);
    ///.inset-x-0
    public static readonly Placement Inset_x_0 = new("inset-x-0", 1);
    ///.inset-x-0.5
    public static readonly Placement Inset_x_0v5 = new("inset-x-0.5", 1);
    ///.inset-x-1
    public static readonly Placement Inset_x_1 = new("inset-x-1", 1);
    ///.inset-x-1.5
    public static readonly Placement Inset_x_1v5 = new("inset-x-1.5", 1);
    ///.inset-x-1/2
    public static readonly Placement Inset_x_1d2 = new("inset-x-1/2", 1);
    ///.inset-x-1/3
    public static readonly Placement Inset_x_1d3 = new("inset-x-1/3", 1);
    ///.inset-x-1/4
    public static readonly Placement Inset_x_1d4 = new("inset-x-1/4", 1);
    ///.inset-x-10
    public static readonly Placement Inset_x_10 = new("inset-x-10", 1);
    ///.inset-x-11
    public static readonly Placement Inset_x_11 = new("inset-x-11", 1);
    ///.inset-x-12
    public static readonly Placement Inset_x_12 = new("inset-x-12", 1);
    ///.inset-x-14
    public static readonly Placement Inset_x_14 = new("inset-x-14", 1);
    ///.inset-x-16
    public static readonly Placement Inset_x_16 = new("inset-x-16", 1);
    ///.inset-x-2
    public static readonly Placement Inset_x_2 = new("inset-x-2", 1);
    ///.inset-x-2.5
    public static readonly Placement Inset_x_2v5 = new("inset-x-2.5", 1);
    ///.inset-x-2/3
    public static readonly Placement Inset_x_2d3 = new("inset-x-2/3", 1);
    ///.inset-x-2/4
    public static readonly Placement Inset_x_2d4 = new("inset-x-2/4", 1);
    ///.inset-x-20
    public static readonly Placement Inset_x_20 = new("inset-x-20", 1);
    ///.inset-x-24
    public static readonly Placement Inset_x_24 = new("inset-x-24", 1);
    ///.inset-x-28
    public static readonly Placement Inset_x_28 = new("inset-x-28", 1);
    ///.inset-x-3
    public static readonly Placement Inset_x_3 = new("inset-x-3", 1);
    ///.inset-x-3.5
    public static readonly Placement Inset_x_3v5 = new("inset-x-3.5", 1);
    ///.inset-x-3/4
    public static readonly Placement Inset_x_3d4 = new("inset-x-3/4", 1);
    ///.inset-x-32
    public static readonly Placement Inset_x_32 = new("inset-x-32", 1);
    ///.inset-x-36
    public static readonly Placement Inset_x_36 = new("inset-x-36", 1);
    ///.inset-x-4
    public static readonly Placement Inset_x_4 = new("inset-x-4", 1);
    ///.inset-x-40
    public static readonly Placement Inset_x_40 = new("inset-x-40", 1);
    ///.inset-x-44
    public static readonly Placement Inset_x_44 = new("inset-x-44", 1);
    ///.inset-x-48
    public static readonly Placement Inset_x_48 = new("inset-x-48", 1);
    ///.inset-x-5
    public static readonly Placement Inset_x_5 = new("inset-x-5", 1);
    ///.inset-x-52
    public static readonly Placement Inset_x_52 = new("inset-x-52", 1);
    ///.inset-x-56
    public static readonly Placement Inset_x_56 = new("inset-x-56", 1);
    ///.inset-x-6
    public static readonly Placement Inset_x_6 = new("inset-x-6", 1);
    ///.inset-x-60
    public static readonly Placement Inset_x_60 = new("inset-x-60", 1);
    ///.inset-x-64
    public static readonly Placement Inset_x_64 = new("inset-x-64", 1);
    ///.inset-x-7
    public static readonly Placement Inset_x_7 = new("inset-x-7", 1);
    ///.inset-x-72
    public static readonly Placement Inset_x_72 = new("inset-x-72", 1);
    ///.inset-x-8
    public static readonly Placement Inset_x_8 = new("inset-x-8", 1);
    ///.inset-x-80
    public static readonly Placement Inset_x_80 = new("inset-x-80", 1);
    ///.inset-x-9
    public static readonly Placement Inset_x_9 = new("inset-x-9", 1);
    ///.inset-x-96
    public static readonly Placement Inset_x_96 = new("inset-x-96", 1);
    ///.inset-x-auto
    public static readonly Placement Inset_x_auto = new("inset-x-auto", 1);
    ///.inset-x-full
    public static readonly Placement Inset_x_full = new("inset-x-full", 1);
    ///.inset-x-px
    public static readonly Placement Inset_x_px = new("inset-x-px", 1);
    ///.inset-y-0
    public static readonly Placement Inset_y_0 = new("inset-y-0", 1);
    ///.inset-y-0.5
    public static readonly Placement Inset_y_0v5 = new("inset-y-0.5", 1);
    ///.inset-y-1
    public static readonly Placement Inset_y_1 = new("inset-y-1", 1);
    ///.inset-y-1.5
    public static readonly Placement Inset_y_1v5 = new("inset-y-1.5", 1);
    ///.inset-y-1/2
    public static readonly Placement Inset_y_1d2 = new("inset-y-1/2", 1);
    ///.inset-y-1/3
    public static readonly Placement Inset_y_1d3 = new("inset-y-1/3", 1);
    ///.inset-y-1/4
    public static readonly Placement Inset_y_1d4 = new("inset-y-1/4", 1);
    ///.inset-y-10
    public static readonly Placement Inset_y_10 = new("inset-y-10", 1);
    ///.inset-y-11
    public static readonly Placement Inset_y_11 = new("inset-y-11", 1);
    ///.inset-y-12
    public static readonly Placement Inset_y_12 = new("inset-y-12", 1);
    ///.inset-y-14
    public static readonly Placement Inset_y_14 = new("inset-y-14", 1);
    ///.inset-y-16
    public static readonly Placement Inset_y_16 = new("inset-y-16", 1);
    ///.inset-y-2
    public static readonly Placement Inset_y_2 = new("inset-y-2", 1);
    ///.inset-y-2.5
    public static readonly Placement Inset_y_2v5 = new("inset-y-2.5", 1);
    ///.inset-y-2/3
    public static readonly Placement Inset_y_2d3 = new("inset-y-2/3", 1);
    ///.inset-y-2/4
    public static readonly Placement Inset_y_2d4 = new("inset-y-2/4", 1);
    ///.inset-y-20
    public static readonly Placement Inset_y_20 = new("inset-y-20", 1);
    ///.inset-y-24
    public static readonly Placement Inset_y_24 = new("inset-y-24", 1);
    ///.inset-y-28
    public static readonly Placement Inset_y_28 = new("inset-y-28", 1);
    ///.inset-y-3
    public static readonly Placement Inset_y_3 = new("inset-y-3", 1);
    ///.inset-y-3.5
    public static readonly Placement Inset_y_3v5 = new("inset-y-3.5", 1);
    ///.inset-y-3/4
    public static readonly Placement Inset_y_3d4 = new("inset-y-3/4", 1);
    ///.inset-y-32
    public static readonly Placement Inset_y_32 = new("inset-y-32", 1);
    ///.inset-y-36
    public static readonly Placement Inset_y_36 = new("inset-y-36", 1);
    ///.inset-y-4
    public static readonly Placement Inset_y_4 = new("inset-y-4", 1);
    ///.inset-y-40
    public static readonly Placement Inset_y_40 = new("inset-y-40", 1);
    ///.inset-y-44
    public static readonly Placement Inset_y_44 = new("inset-y-44", 1);
    ///.inset-y-48
    public static readonly Placement Inset_y_48 = new("inset-y-48", 1);
    ///.inset-y-5
    public static readonly Placement Inset_y_5 = new("inset-y-5", 1);
    ///.inset-y-52
    public static readonly Placement Inset_y_52 = new("inset-y-52", 1);
    ///.inset-y-56
    public static readonly Placement Inset_y_56 = new("inset-y-56", 1);
    ///.inset-y-6
    public static readonly Placement Inset_y_6 = new("inset-y-6", 1);
    ///.inset-y-60
    public static readonly Placement Inset_y_60 = new("inset-y-60", 1);
    ///.inset-y-64
    public static readonly Placement Inset_y_64 = new("inset-y-64", 1);
    ///.inset-y-7
    public static readonly Placement Inset_y_7 = new("inset-y-7", 1);
    ///.inset-y-72
    public static readonly Placement Inset_y_72 = new("inset-y-72", 1);
    ///.inset-y-8
    public static readonly Placement Inset_y_8 = new("inset-y-8", 1);
    ///.inset-y-80
    public static readonly Placement Inset_y_80 = new("inset-y-80", 1);
    ///.inset-y-9
    public static readonly Placement Inset_y_9 = new("inset-y-9", 1);
    ///.inset-y-96
    public static readonly Placement Inset_y_96 = new("inset-y-96", 1);
    ///.inset-y-auto
    public static readonly Placement Inset_y_auto = new("inset-y-auto", 1);
    ///.inset-y-full
    public static readonly Placement Inset_y_full = new("inset-y-full", 1);
    ///.inset-y-px
    public static readonly Placement Inset_y_px = new("inset-y-px", 1);
    ///.-inset-0
    public static readonly Placement MinusInset_0 = new("-inset-0", 1);
    ///.-inset-0.5
    public static readonly Placement MinusInset_0v5 = new("-inset-0.5", 1);
    ///.-inset-1
    public static readonly Placement MinusInset_1 = new("-inset-1", 1);
    ///.-inset-1.5
    public static readonly Placement MinusInset_1v5 = new("-inset-1.5", 1);
    ///.-inset-1/2
    public static readonly Placement MinusInset_1d2 = new("-inset-1/2", 1);
    ///.-inset-1/3
    public static readonly Placement MinusInset_1d3 = new("-inset-1/3", 1);
    ///.-inset-1/4
    public static readonly Placement MinusInset_1d4 = new("-inset-1/4", 1);
    ///.-inset-10
    public static readonly Placement MinusInset_10 = new("-inset-10", 1);
    ///.-inset-11
    public static readonly Placement MinusInset_11 = new("-inset-11", 1);
    ///.-inset-12
    public static readonly Placement MinusInset_12 = new("-inset-12", 1);
    ///.-inset-14
    public static readonly Placement MinusInset_14 = new("-inset-14", 1);
    ///.-inset-16
    public static readonly Placement MinusInset_16 = new("-inset-16", 1);
    ///.-inset-2
    public static readonly Placement MinusInset_2 = new("-inset-2", 1);
    ///.-inset-2.5
    public static readonly Placement MinusInset_2v5 = new("-inset-2.5", 1);
    ///.-inset-2/3
    public static readonly Placement MinusInset_2d3 = new("-inset-2/3", 1);
    ///.-inset-2/4
    public static readonly Placement MinusInset_2d4 = new("-inset-2/4", 1);
    ///.-inset-20
    public static readonly Placement MinusInset_20 = new("-inset-20", 1);
    ///.-inset-24
    public static readonly Placement MinusInset_24 = new("-inset-24", 1);
    ///.-inset-28
    public static readonly Placement MinusInset_28 = new("-inset-28", 1);
    ///.-inset-3
    public static readonly Placement MinusInset_3 = new("-inset-3", 1);
    ///.-inset-3.5
    public static readonly Placement MinusInset_3v5 = new("-inset-3.5", 1);
    ///.-inset-3/4
    public static readonly Placement MinusInset_3d4 = new("-inset-3/4", 1);
    ///.-inset-32
    public static readonly Placement MinusInset_32 = new("-inset-32", 1);
    ///.-inset-36
    public static readonly Placement MinusInset_36 = new("-inset-36", 1);
    ///.-inset-4
    public static readonly Placement MinusInset_4 = new("-inset-4", 1);
    ///.-inset-40
    public static readonly Placement MinusInset_40 = new("-inset-40", 1);
    ///.-inset-44
    public static readonly Placement MinusInset_44 = new("-inset-44", 1);
    ///.-inset-48
    public static readonly Placement MinusInset_48 = new("-inset-48", 1);
    ///.-inset-5
    public static readonly Placement MinusInset_5 = new("-inset-5", 1);
    ///.-inset-52
    public static readonly Placement MinusInset_52 = new("-inset-52", 1);
    ///.-inset-56
    public static readonly Placement MinusInset_56 = new("-inset-56", 1);
    ///.-inset-6
    public static readonly Placement MinusInset_6 = new("-inset-6", 1);
    ///.-inset-60
    public static readonly Placement MinusInset_60 = new("-inset-60", 1);
    ///.-inset-64
    public static readonly Placement MinusInset_64 = new("-inset-64", 1);
    ///.-inset-7
    public static readonly Placement MinusInset_7 = new("-inset-7", 1);
    ///.-inset-72
    public static readonly Placement MinusInset_72 = new("-inset-72", 1);
    ///.-inset-8
    public static readonly Placement MinusInset_8 = new("-inset-8", 1);
    ///.-inset-80
    public static readonly Placement MinusInset_80 = new("-inset-80", 1);
    ///.-inset-9
    public static readonly Placement MinusInset_9 = new("-inset-9", 1);
    ///.-inset-96
    public static readonly Placement MinusInset_96 = new("-inset-96", 1);
    ///.-inset-full
    public static readonly Placement MinusInset_full = new("-inset-full", 1);
    ///.-inset-px
    public static readonly Placement MinusInset_px = new("-inset-px", 1);
    ///.-inset-x-0
    public static readonly Placement MinusInset_x_0 = new("-inset-x-0", 1);
    ///.-inset-x-0.5
    public static readonly Placement MinusInset_x_0v5 = new("-inset-x-0.5", 1);
    ///.-inset-x-1
    public static readonly Placement MinusInset_x_1 = new("-inset-x-1", 1);
    ///.-inset-x-1.5
    public static readonly Placement MinusInset_x_1v5 = new("-inset-x-1.5", 1);
    ///.-inset-x-1/2
    public static readonly Placement MinusInset_x_1d2 = new("-inset-x-1/2", 1);
    ///.-inset-x-1/3
    public static readonly Placement MinusInset_x_1d3 = new("-inset-x-1/3", 1);
    ///.-inset-x-1/4
    public static readonly Placement MinusInset_x_1d4 = new("-inset-x-1/4", 1);
    ///.-inset-x-10
    public static readonly Placement MinusInset_x_10 = new("-inset-x-10", 1);
    ///.-inset-x-11
    public static readonly Placement MinusInset_x_11 = new("-inset-x-11", 1);
    ///.-inset-x-12
    public static readonly Placement MinusInset_x_12 = new("-inset-x-12", 1);
    ///.-inset-x-14
    public static readonly Placement MinusInset_x_14 = new("-inset-x-14", 1);
    ///.-inset-x-16
    public static readonly Placement MinusInset_x_16 = new("-inset-x-16", 1);
    ///.-inset-x-2
    public static readonly Placement MinusInset_x_2 = new("-inset-x-2", 1);
    ///.-inset-x-2.5
    public static readonly Placement MinusInset_x_2v5 = new("-inset-x-2.5", 1);
    ///.-inset-x-2/3
    public static readonly Placement MinusInset_x_2d3 = new("-inset-x-2/3", 1);
    ///.-inset-x-2/4
    public static readonly Placement MinusInset_x_2d4 = new("-inset-x-2/4", 1);
    ///.-inset-x-20
    public static readonly Placement MinusInset_x_20 = new("-inset-x-20", 1);
    ///.-inset-x-24
    public static readonly Placement MinusInset_x_24 = new("-inset-x-24", 1);
    ///.-inset-x-28
    public static readonly Placement MinusInset_x_28 = new("-inset-x-28", 1);
    ///.-inset-x-3
    public static readonly Placement MinusInset_x_3 = new("-inset-x-3", 1);
    ///.-inset-x-3.5
    public static readonly Placement MinusInset_x_3v5 = new("-inset-x-3.5", 1);
    ///.-inset-x-3/4
    public static readonly Placement MinusInset_x_3d4 = new("-inset-x-3/4", 1);
    ///.-inset-x-32
    public static readonly Placement MinusInset_x_32 = new("-inset-x-32", 1);
    ///.-inset-x-36
    public static readonly Placement MinusInset_x_36 = new("-inset-x-36", 1);
    ///.-inset-x-4
    public static readonly Placement MinusInset_x_4 = new("-inset-x-4", 1);
    ///.-inset-x-40
    public static readonly Placement MinusInset_x_40 = new("-inset-x-40", 1);
    ///.-inset-x-44
    public static readonly Placement MinusInset_x_44 = new("-inset-x-44", 1);
    ///.-inset-x-48
    public static readonly Placement MinusInset_x_48 = new("-inset-x-48", 1);
    ///.-inset-x-5
    public static readonly Placement MinusInset_x_5 = new("-inset-x-5", 1);
    ///.-inset-x-52
    public static readonly Placement MinusInset_x_52 = new("-inset-x-52", 1);
    ///.-inset-x-56
    public static readonly Placement MinusInset_x_56 = new("-inset-x-56", 1);
    ///.-inset-x-6
    public static readonly Placement MinusInset_x_6 = new("-inset-x-6", 1);
    ///.-inset-x-60
    public static readonly Placement MinusInset_x_60 = new("-inset-x-60", 1);
    ///.-inset-x-64
    public static readonly Placement MinusInset_x_64 = new("-inset-x-64", 1);
    ///.-inset-x-7
    public static readonly Placement MinusInset_x_7 = new("-inset-x-7", 1);
    ///.-inset-x-72
    public static readonly Placement MinusInset_x_72 = new("-inset-x-72", 1);
    ///.-inset-x-8
    public static readonly Placement MinusInset_x_8 = new("-inset-x-8", 1);
    ///.-inset-x-80
    public static readonly Placement MinusInset_x_80 = new("-inset-x-80", 1);
    ///.-inset-x-9
    public static readonly Placement MinusInset_x_9 = new("-inset-x-9", 1);
    ///.-inset-x-96
    public static readonly Placement MinusInset_x_96 = new("-inset-x-96", 1);
    ///.-inset-x-full
    public static readonly Placement MinusInset_x_full = new("-inset-x-full", 1);
    ///.-inset-x-px
    public static readonly Placement MinusInset_x_px = new("-inset-x-px", 1);
    ///.-inset-y-0
    public static readonly Placement MinusInset_y_0 = new("-inset-y-0", 1);
    ///.-inset-y-0.5
    public static readonly Placement MinusInset_y_0v5 = new("-inset-y-0.5", 1);
    ///.-inset-y-1
    public static readonly Placement MinusInset_y_1 = new("-inset-y-1", 1);
    ///.-inset-y-1.5
    public static readonly Placement MinusInset_y_1v5 = new("-inset-y-1.5", 1);
    ///.-inset-y-1/2
    public static readonly Placement MinusInset_y_1d2 = new("-inset-y-1/2", 1);
    ///.-inset-y-1/3
    public static readonly Placement MinusInset_y_1d3 = new("-inset-y-1/3", 1);
    ///.-inset-y-1/4
    public static readonly Placement MinusInset_y_1d4 = new("-inset-y-1/4", 1);
    ///.-inset-y-10
    public static readonly Placement MinusInset_y_10 = new("-inset-y-10", 1);
    ///.-inset-y-11
    public static readonly Placement MinusInset_y_11 = new("-inset-y-11", 1);
    ///.-inset-y-12
    public static readonly Placement MinusInset_y_12 = new("-inset-y-12", 1);
    ///.-inset-y-14
    public static readonly Placement MinusInset_y_14 = new("-inset-y-14", 1);
    ///.-inset-y-16
    public static readonly Placement MinusInset_y_16 = new("-inset-y-16", 1);
    ///.-inset-y-2
    public static readonly Placement MinusInset_y_2 = new("-inset-y-2", 1);
    ///.-inset-y-2.5
    public static readonly Placement MinusInset_y_2v5 = new("-inset-y-2.5", 1);
    ///.-inset-y-2/3
    public static readonly Placement MinusInset_y_2d3 = new("-inset-y-2/3", 1);
    ///.-inset-y-2/4
    public static readonly Placement MinusInset_y_2d4 = new("-inset-y-2/4", 1);
    ///.-inset-y-20
    public static readonly Placement MinusInset_y_20 = new("-inset-y-20", 1);
    ///.-inset-y-24
    public static readonly Placement MinusInset_y_24 = new("-inset-y-24", 1);
    ///.-inset-y-28
    public static readonly Placement MinusInset_y_28 = new("-inset-y-28", 1);
    ///.-inset-y-3
    public static readonly Placement MinusInset_y_3 = new("-inset-y-3", 1);
    ///.-inset-y-3.5
    public static readonly Placement MinusInset_y_3v5 = new("-inset-y-3.5", 1);
    ///.-inset-y-3/4
    public static readonly Placement MinusInset_y_3d4 = new("-inset-y-3/4", 1);
    ///.-inset-y-32
    public static readonly Placement MinusInset_y_32 = new("-inset-y-32", 1);
    ///.-inset-y-36
    public static readonly Placement MinusInset_y_36 = new("-inset-y-36", 1);
    ///.-inset-y-4
    public static readonly Placement MinusInset_y_4 = new("-inset-y-4", 1);
    ///.-inset-y-40
    public static readonly Placement MinusInset_y_40 = new("-inset-y-40", 1);
    ///.-inset-y-44
    public static readonly Placement MinusInset_y_44 = new("-inset-y-44", 1);
    ///.-inset-y-48
    public static readonly Placement MinusInset_y_48 = new("-inset-y-48", 1);
    ///.-inset-y-5
    public static readonly Placement MinusInset_y_5 = new("-inset-y-5", 1);
    ///.-inset-y-52
    public static readonly Placement MinusInset_y_52 = new("-inset-y-52", 1);
    ///.-inset-y-56
    public static readonly Placement MinusInset_y_56 = new("-inset-y-56", 1);
    ///.-inset-y-6
    public static readonly Placement MinusInset_y_6 = new("-inset-y-6", 1);
    ///.-inset-y-60
    public static readonly Placement MinusInset_y_60 = new("-inset-y-60", 1);
    ///.-inset-y-64
    public static readonly Placement MinusInset_y_64 = new("-inset-y-64", 1);
    ///.-inset-y-7
    public static readonly Placement MinusInset_y_7 = new("-inset-y-7", 1);
    ///.-inset-y-72
    public static readonly Placement MinusInset_y_72 = new("-inset-y-72", 1);
    ///.-inset-y-8
    public static readonly Placement MinusInset_y_8 = new("-inset-y-8", 1);
    ///.-inset-y-80
    public static readonly Placement MinusInset_y_80 = new("-inset-y-80", 1);
    ///.-inset-y-9
    public static readonly Placement MinusInset_y_9 = new("-inset-y-9", 1);
    ///.-inset-y-96
    public static readonly Placement MinusInset_y_96 = new("-inset-y-96", 1);
    ///.-inset-y-full
    public static readonly Placement MinusInset_y_full = new("-inset-y-full", 1);
    ///.-inset-y-px
    public static readonly Placement MinusInset_y_px = new("-inset-y-px", 1);

    private Placement(string name, int value) : base(name, value) { }

}
