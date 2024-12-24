using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ardalis.SmartEnum;

namespace Maurosoft.Blazor.Tailwind.Core.Css.Properties.FlexboxGrid;

/// <summary>
/// Utilities for controlling how elements are sized and placed across grid columns.
/// For info, see <see href="https://tailwindcss.com/docs/grid-column">grid-column</see>
/// </summary>
public class GridColumn : TailwindCssClassBase
{
    public static readonly GridColumn NotSet = new("notset", 0);
    public static readonly GridColumn ColSpan1 = new("col-span-1", 1);
    public static readonly GridColumn ColSpan2 = new("col-span-2", 2);
    public static readonly GridColumn ColSpan3 = new("col-span-3", 3);
    public static readonly GridColumn ColSpan4 = new("col-span-4", 4);
    public static readonly GridColumn ColSpan5 = new("col-span-5", 5);
    public static readonly GridColumn ColSpan6 = new("col-span-6", 6);
    public static readonly GridColumn ColSpan7 = new("col-span-7", 7);
    public static readonly GridColumn ColSpan8 = new("col-span-8", 8);
    public static readonly GridColumn ColSpan9 = new("col-span-9", 9);
    public static readonly GridColumn ColSpan10 = new("col-span-10", 10);
    public static readonly GridColumn ColSpan11 = new("col-span-11", 11);
    public static readonly GridColumn ColSpan12 = new("col-span-12", 12);
    public static readonly GridColumn ColSpanFull = new("col-span-full", 13);
    public static readonly GridColumn ColAuto = new("col-auto", 14);

    private GridColumn(string name, int value) : base(name, value) { }
}
