using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Maurosoft.Blazor.Tailwind.Core.Css;

/// <summary>
/// Utilities for controlling how elements are sized and placed across grid rows.
/// </summary>
public class GridRowStart : TailwindCssClassBase
{
    public static readonly GridRowStart NotSet = new("notset", 0);
    public static readonly GridRowStart RowStart1 = new("row-start-1", 1);
    public static readonly GridRowStart RowStart2 = new("row-start-2", 2);
    public static readonly GridRowStart RowStart3 = new("row-start-3", 3);
    public static readonly GridRowStart RowStart4 = new("row-start-4", 4);
    public static readonly GridRowStart RowStart5 = new("row-start-5", 5);
    public static readonly GridRowStart RowStart6 = new("row-start-6", 6);
    public static readonly GridRowStart RowStart7 = new("row-start-7", 7);
    public static readonly GridRowStart RowStart8 = new("row-start-8", 8);
    public static readonly GridRowStart RowStart9 = new("row-start-9", 9);
    public static readonly GridRowStart RowStart10 = new("row-start-10", 10);
    public static readonly GridRowStart RowStart11 = new("row-start-11", 11);
    public static readonly GridRowStart RowStart12 = new("row-start-12", 12);
    public static readonly GridRowStart RowStart13 = new("row-start-13", 13);
    public static readonly GridRowStart RowStartAuto = new("row-start-auto", 14);

    private GridRowStart(string name, int value) : base(name, value) { }
}
