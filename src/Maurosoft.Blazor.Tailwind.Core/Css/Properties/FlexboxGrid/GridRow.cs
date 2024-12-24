using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Maurosoft.Blazor.Tailwind.Core.Css.Properties.FlexboxGrid;

/// <summary>
/// Utilities for controlling how elements are sized and placed across grid rows.
/// For info, see <see href="https://tailwindcss.com/docs/grid-row">row</see>
/// </summary>
public class GridRow : TailwindCssClassBase
{
    public static readonly GridRow NotSet = new("notset", 0);
    public static readonly GridRow RowAuto = new("row-auto", 1);
    public static readonly GridRow RowSpan1 = new("row-span-1", 2);
    public static readonly GridRow RowSpan2 = new("row-span-2", 3);
    public static readonly GridRow RowSpan3 = new("row-span-3", 4);
    public static readonly GridRow RowSpan4 = new("row-span-4", 5);
    public static readonly GridRow RowSpan5 = new("row-span-5", 6);
    public static readonly GridRow RowSpan6 = new("row-span-6", 7);
    public static readonly GridRow RowSpan7 = new("row-span-7", 8);
    public static readonly GridRow RowSpan8 = new("row-span-8", 9);
    public static readonly GridRow RowSpan9 = new("row-span-8", 10);
    public static readonly GridRow RowSpan10 = new("row-span-8", 11);
    public static readonly GridRow RowSpan11 = new("row-span-8", 12);
    public static readonly GridRow RowSpan12 = new("row-span-8", 13);
    public static readonly GridRow RowSpanFull = new("row-span-full", 14);

    private GridRow(string name, int value) : base(name, value) { }
}
