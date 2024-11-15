using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Maurosoft.Blazor.Tailwind.Core.Css;

/// <summary>
/// Utilities for controlling how elements are sized and placed across grid columns.
/// </summary>
public class GridColumnEnd : TailwindCssClassBase
{
    public static readonly GridColumnEnd NotSet = new("notset", 0);
    public static readonly GridColumnEnd ColEnd1 = new("col-end-1", 1);
    public static readonly GridColumnEnd ColEnd2 = new("col-end-2", 2);
    public static readonly GridColumnEnd ColEnd3 = new("col-end-3", 3);
    public static readonly GridColumnEnd ColEnd4 = new("col-end-4", 4);
    public static readonly GridColumnEnd ColEnd5 = new("col-end-5", 5);
    public static readonly GridColumnEnd ColEnd6 = new("col-end-6", 6);
    public static readonly GridColumnEnd ColEnd7 = new("col-end-7", 7);
    public static readonly GridColumnEnd ColEnd8 = new("col-end-8", 8);
    public static readonly GridColumnEnd ColEnd9 = new("col-end-9", 9);
    public static readonly GridColumnEnd ColEnd10 = new("col-end-10", 10);
    public static readonly GridColumnEnd ColEnd11 = new("col-end-11", 11);
    public static readonly GridColumnEnd ColEnd12 = new("col-end-12", 12);
    public static readonly GridColumnEnd ColEnd13 = new("col-end-13", 13);
    public static readonly GridColumnEnd ColEndAuto = new("col-end-auto", 14);

    private GridColumnEnd(string name, int value) : base(name, value) { }
}
