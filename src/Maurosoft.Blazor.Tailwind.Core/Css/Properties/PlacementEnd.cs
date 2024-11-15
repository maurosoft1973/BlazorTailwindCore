using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Maurosoft.Blazor.Tailwind.Core.Css;

/// <summary>
/// Utilities for controlling the end placement of positioned elements.
/// </summary>
public class PlacementEnd : TailwindCssClassBase
{
    public static readonly PlacementEnd NotSet = new("notset", 0);
    public static readonly PlacementEnd End_0 = new("end-0", 0);
    public static readonly PlacementEnd End_0v5 = new("end-0.5", 1);
    public static readonly PlacementEnd End_1 = new("end-1", 2);
    public static readonly PlacementEnd End_1v5 = new("end-1.5", 3);
    public static readonly PlacementEnd End_2 = new("end-2", 4);
    public static readonly PlacementEnd End_2v5 = new("end-2.5", 5);
    public static readonly PlacementEnd End_3 = new("end-3", 6);
    public static readonly PlacementEnd End_3v5 = new("end-3.5", 7);
    public static readonly PlacementEnd End_4 = new("end-4", 8);
    public static readonly PlacementEnd End_5 = new("end-5", 9);
    public static readonly PlacementEnd End_6 = new("end-6", 10);
    public static readonly PlacementEnd End_7 = new("end-7", 11);
    public static readonly PlacementEnd End_8 = new("end-8", 12);
    public static readonly PlacementEnd End_9 = new("end-9", 13);
    public static readonly PlacementEnd End_10 = new("end-10", 14);

    private PlacementEnd(string name, int value) : base(name, value)
    {
    }
}
