﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Maurosoft.Blazor.Tailwind.Core.Css.Properties.Layout;

/// <summary>
/// Utilities for controlling the end placement of positioned elements.
/// For info, see <see href="https://tailwindcss.com/docs/top-right-bottom-left">end</see>
/// </summary>
public class PlacementEnd : TailwindCssClassBase
{
    public static readonly PlacementEnd NotSet = new("notset", 1);
    public static readonly PlacementEnd End_0 = new("end-0", 2);
    public static readonly PlacementEnd End_0v5 = new("end-0.5", 3);
    public static readonly PlacementEnd End_1 = new("end-1", 4);
    public static readonly PlacementEnd End_1v5 = new("end-1.5", 5);
    public static readonly PlacementEnd End_2 = new("end-2", 6);
    public static readonly PlacementEnd End_2v5 = new("end-2.5", 7);
    public static readonly PlacementEnd End_3 = new("end-3", 8);
    public static readonly PlacementEnd End_3v5 = new("end-3.5", 9);
    public static readonly PlacementEnd End_4 = new("end-4", 10);
    public static readonly PlacementEnd End_5 = new("end-5", 11);
    public static readonly PlacementEnd End_6 = new("end-6", 12);
    public static readonly PlacementEnd End_7 = new("end-7", 13);
    public static readonly PlacementEnd End_8 = new("end-8", 14);
    public static readonly PlacementEnd End_9 = new("end-9", 15);
    public static readonly PlacementEnd End_10 = new("end-10", 16);

    private PlacementEnd(string name, int value) : base(name, value) { }
}
