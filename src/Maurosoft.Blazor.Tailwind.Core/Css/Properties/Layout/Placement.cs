﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Maurosoft.Blazor.Tailwind.Core.Css.Properties.Layout;

/// <summary>
/// Utilities for controlling the placement of positioned elements.
/// For info, see <see href="https://tailwindcss.com/docs/top-right-bottom-left">top-right-bottom-left</see>
/// </summary>
public sealed class Placement : TailwindCssClassBase
{
    public static readonly Placement NotSet = new("notset", 1);
    public static readonly Placement Inset_0 = new("inset-0", 1);
    public static readonly Placement Inset_0v5 = new("inset-0.5", 1);
    public static readonly Placement Inset_1 = new("inset-1", 1);
    public static readonly Placement Inset_1v5 = new("inset-1.5", 1);
    public static readonly Placement Inset_1d2 = new("inset-1/2", 1);
    public static readonly Placement Inset_1d3 = new("inset-1/3", 1);
    public static readonly Placement Inset_1d4 = new("inset-1/4", 1);
    public static readonly Placement Inset_10 = new("inset-10", 1);
    public static readonly Placement Inset_11 = new("inset-11", 1);
    public static readonly Placement Inset_12 = new("inset-12", 1);
    public static readonly Placement Inset_14 = new("inset-14", 1);
    public static readonly Placement Inset_16 = new("inset-16", 1);
    public static readonly Placement Inset_2 = new("inset-2", 1);
    public static readonly Placement Inset_2v5 = new("inset-2.5", 1);
    public static readonly Placement Inset_2d3 = new("inset-2/3", 1);
    public static readonly Placement Inset_2d4 = new("inset-2/4", 1);
    public static readonly Placement Inset_20 = new("inset-20", 1);
    public static readonly Placement Inset_24 = new("inset-24", 1);
    public static readonly Placement Inset_28 = new("inset-28", 1);
    public static readonly Placement Inset_3 = new("inset-3", 1);
    public static readonly Placement Inset_3v5 = new("inset-3.5", 1);
    public static readonly Placement Inset_3d4 = new("inset-3/4", 1);
    public static readonly Placement Inset_32 = new("inset-32", 1);
    public static readonly Placement Inset_36 = new("inset-36", 1);
    public static readonly Placement Inset_4 = new("inset-4", 1);
    public static readonly Placement Inset_40 = new("inset-40", 1);
    public static readonly Placement Inset_44 = new("inset-44", 1);
    public static readonly Placement Inset_48 = new("inset-48", 1);
    public static readonly Placement Inset_5 = new("inset-5", 1);
    public static readonly Placement Inset_52 = new("inset-52", 1);
    public static readonly Placement Inset_56 = new("inset-56", 1);
    public static readonly Placement Inset_6 = new("inset-6", 1);
    public static readonly Placement Inset_60 = new("inset-60", 1);
    public static readonly Placement Inset_64 = new("inset-64", 1);
    public static readonly Placement Inset_7 = new("inset-7", 1);
    public static readonly Placement Inset_72 = new("inset-72", 1);
    public static readonly Placement Inset_8 = new("inset-8", 1);
    public static readonly Placement Inset_80 = new("inset-80", 1);
    public static readonly Placement Inset_9 = new("inset-9", 1);
    public static readonly Placement Inset_96 = new("inset-96", 1);
    public static readonly Placement Inset_Auto = new("inset-auto", 1);
    public static readonly Placement Inset_Full = new("inset-full", 1);
    public static readonly Placement Inset_Px = new("inset-px", 1);
    public static readonly Placement Inset_X_0 = new("inset-x-0", 1);
    public static readonly Placement Inset_X_0v5 = new("inset-x-0.5", 1);
    public static readonly Placement Inset_X_1 = new("inset-x-1", 1);
    public static readonly Placement Inset_X_1v5 = new("inset-x-1.5", 1);
    public static readonly Placement Inset_X_1d2 = new("inset-x-1/2", 1);
    public static readonly Placement Inset_X_1d3 = new("inset-x-1/3", 1);
    public static readonly Placement Inset_X_1d4 = new("inset-x-1/4", 1);
    public static readonly Placement Inset_X_10 = new("inset-x-10", 1);
    public static readonly Placement Inset_X_11 = new("inset-x-11", 1);
    public static readonly Placement Inset_X_12 = new("inset-x-12", 1);
    public static readonly Placement Inset_X_14 = new("inset-x-14", 1);
    public static readonly Placement Inset_X_16 = new("inset-x-16", 1);
    public static readonly Placement Inset_X_2 = new("inset-x-2", 1);
    public static readonly Placement Inset_X_2v5 = new("inset-x-2.5", 1);
    public static readonly Placement Inset_X_2d3 = new("inset-x-2/3", 1);
    public static readonly Placement Inset_X_2d4 = new("inset-x-2/4", 1);
    public static readonly Placement Inset_X_20 = new("inset-x-20", 1);
    public static readonly Placement Inset_X_24 = new("inset-x-24", 1);
    public static readonly Placement Inset_X_28 = new("inset-x-28", 1);
    public static readonly Placement Inset_X_3 = new("inset-x-3", 1);
    public static readonly Placement Inset_X_3v5 = new("inset-x-3.5", 1);
    public static readonly Placement Inset_X_3d4 = new("inset-x-3/4", 1);
    public static readonly Placement Inset_X_32 = new("inset-x-32", 1);
    public static readonly Placement Inset_X_36 = new("inset-x-36", 1);
    public static readonly Placement Inset_X_4 = new("inset-x-4", 1);
    public static readonly Placement Inset_X_40 = new("inset-x-40", 1);
    public static readonly Placement Inset_X_44 = new("inset-x-44", 1);
    public static readonly Placement Inset_X_48 = new("inset-x-48", 1);
    public static readonly Placement Inset_X_5 = new("inset-x-5", 1);
    public static readonly Placement Inset_X_52 = new("inset-x-52", 1);
    public static readonly Placement Inset_X_56 = new("inset-x-56", 1);
    public static readonly Placement Inset_X_6 = new("inset-x-6", 1);
    public static readonly Placement Inset_X_60 = new("inset-x-60", 1);
    public static readonly Placement Inset_X_64 = new("inset-x-64", 1);
    public static readonly Placement Inset_X_7 = new("inset-x-7", 1);
    public static readonly Placement Inset_X_72 = new("inset-x-72", 1);
    public static readonly Placement Inset_X_8 = new("inset-x-8", 1);
    public static readonly Placement Inset_X_80 = new("inset-x-80", 1);
    public static readonly Placement Inset_X_9 = new("inset-x-9", 1);
    public static readonly Placement Inset_X_96 = new("inset-x-96", 1);
    public static readonly Placement Inset_X_Auto = new("inset-x-auto", 1);
    public static readonly Placement Inset_X_Full = new("inset-x-full", 1);
    public static readonly Placement Inset_X_Px = new("inset-x-px", 1);
    public static readonly Placement Inset_Y_0 = new("inset-y-0", 1);
    public static readonly Placement Inset_Y_0v5 = new("inset-y-0.5", 1);
    public static readonly Placement Inset_Y_1 = new("inset-y-1", 1);
    public static readonly Placement Inset_Y_1v5 = new("inset-y-1.5", 1);
    public static readonly Placement Inset_Y_1d2 = new("inset-y-1/2", 1);
    public static readonly Placement Inset_Y_1d3 = new("inset-y-1/3", 1);
    public static readonly Placement Inset_Y_1d4 = new("inset-y-1/4", 1);
    public static readonly Placement Inset_Y_10 = new("inset-y-10", 1);
    public static readonly Placement Inset_Y_11 = new("inset-y-11", 1);
    public static readonly Placement Inset_Y_12 = new("inset-y-12", 1);
    public static readonly Placement Inset_Y_14 = new("inset-y-14", 1);
    public static readonly Placement Inset_Y_16 = new("inset-y-16", 1);
    public static readonly Placement Inset_Y_2 = new("inset-y-2", 1);
    public static readonly Placement Inset_Y_2v5 = new("inset-y-2.5", 1);
    public static readonly Placement Inset_Y_2d3 = new("inset-y-2/3", 1);
    public static readonly Placement Inset_Y_2d4 = new("inset-y-2/4", 1);
    public static readonly Placement Inset_Y_20 = new("inset-y-20", 1);
    public static readonly Placement Inset_Y_24 = new("inset-y-24", 1);
    public static readonly Placement Inset_Y_28 = new("inset-y-28", 1);
    public static readonly Placement Inset_Y_3 = new("inset-y-3", 1);
    public static readonly Placement Inset_Y_3v5 = new("inset-y-3.5", 1);
    public static readonly Placement Inset_Y_3d4 = new("inset-y-3/4", 1);
    public static readonly Placement Inset_Y_32 = new("inset-y-32", 1);
    public static readonly Placement Inset_Y_36 = new("inset-y-36", 1);
    public static readonly Placement Inset_Y_4 = new("inset-y-4", 1);
    public static readonly Placement Inset_Y_40 = new("inset-y-40", 1);
    public static readonly Placement Inset_Y_44 = new("inset-y-44", 1);
    public static readonly Placement Inset_Y_48 = new("inset-y-48", 1);
    public static readonly Placement Inset_Y_5 = new("inset-y-5", 1);
    public static readonly Placement Inset_Y_52 = new("inset-y-52", 1);
    public static readonly Placement Inset_Y_56 = new("inset-y-56", 1);
    public static readonly Placement Inset_Y_6 = new("inset-y-6", 1);
    public static readonly Placement Inset_Y_60 = new("inset-y-60", 1);
    public static readonly Placement Inset_Y_64 = new("inset-y-64", 1);
    public static readonly Placement Inset_Y_7 = new("inset-y-7", 1);
    public static readonly Placement Inset_Y_72 = new("inset-y-72", 1);
    public static readonly Placement Inset_Y_8 = new("inset-y-8", 1);
    public static readonly Placement Inset_Y_80 = new("inset-y-80", 1);
    public static readonly Placement Inset_Y_9 = new("inset-y-9", 1);
    public static readonly Placement Inset_Y_96 = new("inset-y-96", 1);
    public static readonly Placement Inset_Y_Auto = new("inset-y-auto", 1);
    public static readonly Placement Inset_Y_Full = new("inset-y-full", 1);
    public static readonly Placement Inset_Y_Px = new("inset-y-px", 1);
    public static readonly Placement MinusInset_0 = new("-inset-0", 1);
    public static readonly Placement MinusInset_0v5 = new("-inset-0.5", 1);
    public static readonly Placement MinusInset_1 = new("-inset-1", 1);
    public static readonly Placement MinusInset_1v5 = new("-inset-1.5", 1);
    public static readonly Placement MinusInset_1d2 = new("-inset-1/2", 1);
    public static readonly Placement MinusInset_1d3 = new("-inset-1/3", 1);
    public static readonly Placement MinusInset_1d4 = new("-inset-1/4", 1);
    public static readonly Placement MinusInset_10 = new("-inset-10", 1);
    public static readonly Placement MinusInset_11 = new("-inset-11", 1);
    public static readonly Placement MinusInset_12 = new("-inset-12", 1);
    public static readonly Placement MinusInset_14 = new("-inset-14", 1);
    public static readonly Placement MinusInset_16 = new("-inset-16", 1);
    public static readonly Placement MinusInset_2 = new("-inset-2", 1);
    public static readonly Placement MinusInset_2v5 = new("-inset-2.5", 1);
    public static readonly Placement MinusInset_2d3 = new("-inset-2/3", 1);
    public static readonly Placement MinusInset_2d4 = new("-inset-2/4", 1);
    public static readonly Placement MinusInset_20 = new("-inset-20", 1);
    public static readonly Placement MinusInset_24 = new("-inset-24", 1);
    public static readonly Placement MinusInset_28 = new("-inset-28", 1);
    public static readonly Placement MinusInset_3 = new("-inset-3", 1);
    public static readonly Placement MinusInset_3v5 = new("-inset-3.5", 1);
    public static readonly Placement MinusInset_3d4 = new("-inset-3/4", 1);
    public static readonly Placement MinusInset_32 = new("-inset-32", 1);
    public static readonly Placement MinusInset_36 = new("-inset-36", 1);
    public static readonly Placement MinusInset_4 = new("-inset-4", 1);
    public static readonly Placement MinusInset_40 = new("-inset-40", 1);
    public static readonly Placement MinusInset_44 = new("-inset-44", 1);
    public static readonly Placement MinusInset_48 = new("-inset-48", 1);
    public static readonly Placement MinusInset_5 = new("-inset-5", 1);
    public static readonly Placement MinusInset_52 = new("-inset-52", 1);
    public static readonly Placement MinusInset_56 = new("-inset-56", 1);
    public static readonly Placement MinusInset_6 = new("-inset-6", 1);
    public static readonly Placement MinusInset_60 = new("-inset-60", 1);
    public static readonly Placement MinusInset_64 = new("-inset-64", 1);
    public static readonly Placement MinusInset_7 = new("-inset-7", 1);
    public static readonly Placement MinusInset_72 = new("-inset-72", 1);
    public static readonly Placement MinusInset_8 = new("-inset-8", 1);
    public static readonly Placement MinusInset_80 = new("-inset-80", 1);
    public static readonly Placement MinusInset_9 = new("-inset-9", 1);
    public static readonly Placement MinusInset_96 = new("-inset-96", 1);
    public static readonly Placement MinusInset_Full = new("-inset-full", 1);
    public static readonly Placement MinusInset_Px = new("-inset-px", 1);
    public static readonly Placement MinusInset_X_0 = new("-inset-x-0", 1);
    public static readonly Placement MinusInset_X_0v5 = new("-inset-x-0.5", 1);
    public static readonly Placement MinusInset_X_1 = new("-inset-x-1", 1);
    public static readonly Placement MinusInset_X_1v5 = new("-inset-x-1.5", 1);
    public static readonly Placement MinusInset_X_1d2 = new("-inset-x-1/2", 1);
    public static readonly Placement MinusInset_X_1d3 = new("-inset-x-1/3", 1);
    public static readonly Placement MinusInset_X_1d4 = new("-inset-x-1/4", 1);
    public static readonly Placement MinusInset_X_10 = new("-inset-x-10", 1);
    public static readonly Placement MinusInset_X_11 = new("-inset-x-11", 1);
    public static readonly Placement MinusInset_X_12 = new("-inset-x-12", 1);
    public static readonly Placement MinusInset_X_14 = new("-inset-x-14", 1);
    public static readonly Placement MinusInset_X_16 = new("-inset-x-16", 1);
    public static readonly Placement MinusInset_X_2 = new("-inset-x-2", 1);
    public static readonly Placement MinusInset_X_2v5 = new("-inset-x-2.5", 1);
    public static readonly Placement MinusInset_X_2d3 = new("-inset-x-2/3", 1);
    public static readonly Placement MinusInset_X_2d4 = new("-inset-x-2/4", 1);
    public static readonly Placement MinusInset_X_20 = new("-inset-x-20", 1);
    public static readonly Placement MinusInset_X_24 = new("-inset-x-24", 1);
    public static readonly Placement MinusInset_X_28 = new("-inset-x-28", 1);
    public static readonly Placement MinusInset_X_3 = new("-inset-x-3", 1);
    public static readonly Placement MinusInset_X_3v5 = new("-inset-x-3.5", 1);
    public static readonly Placement MinusInset_X_3d4 = new("-inset-x-3/4", 1);
    public static readonly Placement MinusInset_X_32 = new("-inset-x-32", 1);
    public static readonly Placement MinusInset_X_36 = new("-inset-x-36", 1);
    public static readonly Placement MinusInset_X_4 = new("-inset-x-4", 1);
    public static readonly Placement MinusInset_X_40 = new("-inset-x-40", 1);
    public static readonly Placement MinusInset_X_44 = new("-inset-x-44", 1);
    public static readonly Placement MinusInset_X_48 = new("-inset-x-48", 1);
    public static readonly Placement MinusInset_X_5 = new("-inset-x-5", 1);
    public static readonly Placement MinusInset_X_52 = new("-inset-x-52", 1);
    public static readonly Placement MinusInset_X_56 = new("-inset-x-56", 1);
    public static readonly Placement MinusInset_X_6 = new("-inset-x-6", 1);
    public static readonly Placement MinusInset_X_60 = new("-inset-x-60", 1);
    public static readonly Placement MinusInset_X_64 = new("-inset-x-64", 1);
    public static readonly Placement MinusInset_X_7 = new("-inset-x-7", 1);
    public static readonly Placement MinusInset_X_72 = new("-inset-x-72", 1);
    public static readonly Placement MinusInset_X_8 = new("-inset-x-8", 1);
    public static readonly Placement MinusInset_X_80 = new("-inset-x-80", 1);
    public static readonly Placement MinusInset_X_9 = new("-inset-x-9", 1);
    public static readonly Placement MinusInset_X_96 = new("-inset-x-96", 1);
    public static readonly Placement MinusInset_X_Full = new("-inset-x-full", 1);
    public static readonly Placement MinusInset_X_Px = new("-inset-x-px", 1);
    public static readonly Placement MinusInset_Y_0 = new("-inset-y-0", 1);
    public static readonly Placement MinusInset_Y_0v5 = new("-inset-y-0.5", 1);
    public static readonly Placement MinusInset_Y_1 = new("-inset-y-1", 1);
    public static readonly Placement MinusInset_Y_1v5 = new("-inset-y-1.5", 1);
    public static readonly Placement MinusInset_Y_1d2 = new("-inset-y-1/2", 1);
    public static readonly Placement MinusInset_Y_1d3 = new("-inset-y-1/3", 1);
    public static readonly Placement MinusInset_Y_1d4 = new("-inset-y-1/4", 1);
    public static readonly Placement MinusInset_Y_10 = new("-inset-y-10", 1);
    public static readonly Placement MinusInset_Y_11 = new("-inset-y-11", 1);
    public static readonly Placement MinusInset_Y_12 = new("-inset-y-12", 1);
    public static readonly Placement MinusInset_Y_14 = new("-inset-y-14", 1);
    public static readonly Placement MinusInset_Y_16 = new("-inset-y-16", 1);
    public static readonly Placement MinusInset_Y_2 = new("-inset-y-2", 1);
    public static readonly Placement MinusInset_Y_2v5 = new("-inset-y-2.5", 1);
    public static readonly Placement MinusInset_Y_2d3 = new("-inset-y-2/3", 1);
    public static readonly Placement MinusInset_Y_2d4 = new("-inset-y-2/4", 1);
    public static readonly Placement MinusInset_Y_20 = new("-inset-y-20", 1);
    public static readonly Placement MinusInset_Y_24 = new("-inset-y-24", 1);
    public static readonly Placement MinusInset_Y_28 = new("-inset-y-28", 1);
    public static readonly Placement MinusInset_Y_3 = new("-inset-y-3", 1);
    public static readonly Placement MinusInset_Y_3v5 = new("-inset-y-3.5", 1);
    public static readonly Placement MinusInset_Y_3d4 = new("-inset-y-3/4", 1);
    public static readonly Placement MinusInset_Y_32 = new("-inset-y-32", 1);
    public static readonly Placement MinusInset_Y_36 = new("-inset-y-36", 1);
    public static readonly Placement MinusInset_Y_4 = new("-inset-y-4", 1);
    public static readonly Placement MinusInset_Y_40 = new("-inset-y-40", 1);
    public static readonly Placement MinusInset_Y_44 = new("-inset-y-44", 1);
    public static readonly Placement MinusInset_Y_48 = new("-inset-y-48", 1);
    public static readonly Placement MinusInset_Y_5 = new("-inset-y-5", 1);
    public static readonly Placement MinusInset_Y_52 = new("-inset-y-52", 1);
    public static readonly Placement MinusInset_Y_56 = new("-inset-y-56", 1);
    public static readonly Placement MinusInset_Y_6 = new("-inset-y-6", 1);
    public static readonly Placement MinusInset_Y_60 = new("-inset-y-60", 1);
    public static readonly Placement MinusInset_Y_64 = new("-inset-y-64", 1);
    public static readonly Placement MinusInset_Y_7 = new("-inset-y-7", 1);
    public static readonly Placement MinusInset_Y_72 = new("-inset-y-72", 1);
    public static readonly Placement MinusInset_Y_8 = new("-inset-y-8", 1);
    public static readonly Placement MinusInset_Y_80 = new("-inset-y-80", 1);
    public static readonly Placement MinusInset_Y_9 = new("-inset-y-9", 1);
    public static readonly Placement MinusInset_Y_96 = new("-inset-y-96", 1);
    public static readonly Placement MinusInset_Y_Full = new("-inset-y-full", 1);
    public static readonly Placement MinusInset_Y_Px = new("-inset-y-px", 1);

    private Placement(string name, int value) : base(name, value) { }

}