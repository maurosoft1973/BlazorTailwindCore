using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Maurosoft.Blazor.Tailwind.Core.Css.Properties.FlexboxGrid;

/// <summary>
/// Utilities for specifying the columns in a grid layout.
/// For info, see <see href="https://tailwindcss.com/docs/grid-template-columns">grid-template-columns</see>
/// </summary>
public sealed class GridTemplateColumns : TailwindCssClassBase
{
    public static readonly GridTemplateColumns NotSet = new("notset", 1);
    public static readonly GridTemplateColumns GridCols_1 = new("grid-cols-1", 2);
    public static readonly GridTemplateColumns GridCols_2 = new("grid-cols-2", 3);
    public static readonly GridTemplateColumns GridCols_3 = new("grid-cols-3", 4);
    public static readonly GridTemplateColumns GridCols_4 = new("grid-cols-4", 5);
    public static readonly GridTemplateColumns GridCols_5 = new("grid-cols-5", 6);
    public static readonly GridTemplateColumns GridCols_6 = new("grid-cols-6", 7);
    public static readonly GridTemplateColumns GridCols_7 = new("grid-cols-7", 8);
    public static readonly GridTemplateColumns GridCols_8 = new("grid-cols-8", 9);
    public static readonly GridTemplateColumns GridCols_9 = new("grid-cols-9", 10);
    public static readonly GridTemplateColumns GridCols_10 = new("grid-cols-10", 11);
    public static readonly GridTemplateColumns GridCols_11 = new("grid-cols-11", 12);
    public static readonly GridTemplateColumns GridCols_12 = new("grid-cols-12", 13);
    public static readonly GridTemplateColumns GridCols_None = new("grid-cols-none", 14);
    public static readonly GridTemplateColumns GridCols_SubGrid = new("grid-cols-subgrid", 15);

    private GridTemplateColumns(string name, int value) : base(name, value) { }
}
