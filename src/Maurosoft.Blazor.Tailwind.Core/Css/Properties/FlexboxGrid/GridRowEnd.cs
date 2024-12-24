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
public class GridRowEnd : TailwindCssClassBase
{
    public static readonly GridRowEnd NotSet = new("notset", 0);
    public static readonly GridRowEnd RowEnd1 = new("row-end-1", 1);
    public static readonly GridRowEnd RowEnd2 = new("row-end-2", 2);
    public static readonly GridRowEnd RowEnd3 = new("row-end-3", 3);
    public static readonly GridRowEnd RowEnd4 = new("row-end-4", 4);
    public static readonly GridRowEnd RowEnd5 = new("row-end-5", 5);
    public static readonly GridRowEnd RowEnd6 = new("row-end-6", 6);
    public static readonly GridRowEnd RowEnd7 = new("row-end-7", 7);
    public static readonly GridRowEnd RowEnd8 = new("row-end-8", 8);
    public static readonly GridRowEnd RowEnd9 = new("row-end-9", 9);
    public static readonly GridRowEnd RowEnd10 = new("row-end-10", 10);
    public static readonly GridRowEnd RowEnd11 = new("row-end-11", 11);
    public static readonly GridRowEnd RowEnd12 = new("row-end-12", 12);
    public static readonly GridRowEnd RowEnd13 = new("row-end-13", 13);
    public static readonly GridRowEnd RowEndAuto = new("row-end-auto", 14);

    private GridRowEnd(string name, int value) : base(name, value) { }
}
