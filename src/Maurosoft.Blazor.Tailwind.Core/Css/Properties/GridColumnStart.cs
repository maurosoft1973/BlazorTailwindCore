using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Maurosoft.Blazor.Tailwind.Core.Css;

/// <summary>
/// Utilities for controlling how elements are sized and placed across grid columns.
/// </summary>
public class GridColumnStart : TailwindCssClassBase
{
    public static readonly GridColumnStart NotSet = new("notset", 0);
    public static readonly GridColumnStart ColStart1 = new("col-start-1", 1);
    public static readonly GridColumnStart ColStart2 = new("col-start-2", 2);
    public static readonly GridColumnStart ColStart3 = new("col-start-3", 3);
    public static readonly GridColumnStart ColStart4 = new("col-start-4", 4);
    public static readonly GridColumnStart ColStart5 = new("col-start-5", 5);
    public static readonly GridColumnStart ColStart6 = new("col-start-6", 6);
    public static readonly GridColumnStart ColStart7 = new("col-start-7", 7);
    public static readonly GridColumnStart ColStart8 = new("col-start-8", 8);
    public static readonly GridColumnStart ColStart9 = new("col-start-9", 9);
    public static readonly GridColumnStart ColStart10 = new("col-start-10", 10);
    public static readonly GridColumnStart ColStart11 = new("col-start-11", 11);
    public static readonly GridColumnStart ColStart12 = new("col-start-12", 12);
    public static readonly GridColumnStart ColStart13 = new("col-start-13", 13);
    public static readonly GridColumnStart ColStartAuto = new("col-start-auto", 14);

    private GridColumnStart(string name, int value) : base(name, value) { }
}
