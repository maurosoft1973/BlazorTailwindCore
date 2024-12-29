using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Maurosoft.Blazor.Tailwind.Core.Css.Properties.FlexboxGrid;

/// <summary>
/// Utilities for specifying the rows in a grid layout.
/// For info, see <see href="https://tailwindcss.com/docs/grid-template-rows">grid-template-rows</see>
/// </summary>
public sealed class GridTemplateRows : TailwindCssClassBase
{
    public static readonly GridTemplateRows NotSet = new("notset", 1);
    public static readonly GridTemplateRows GridRows_1 = new("grid-rows-1", 2);
    public static readonly GridTemplateRows GridRows_2 = new("grid-rows-2", 3);
    public static readonly GridTemplateRows GridRows_3 = new("grid-rows-3", 4);
    public static readonly GridTemplateRows GridRows_4 = new("grid-rows-4", 5);
    public static readonly GridTemplateRows GridRows_5 = new("grid-rows-5", 6);
    public static readonly GridTemplateRows GridRows_6 = new("grid-rows-6", 7);
    public static readonly GridTemplateRows GridRows_7 = new("grid-rows-7", 8);
    public static readonly GridTemplateRows GridRows_8 = new("grid-rows-8", 9);
    public static readonly GridTemplateRows GridRows_9 = new("grid-rows-9", 10);
    public static readonly GridTemplateRows GridRows_10 = new("grid-rows-10", 11);
    public static readonly GridTemplateRows GridRows_11 = new("grid-rows-11", 12);
    public static readonly GridTemplateRows GridRows_12 = new("grid-rows-12", 13);
    public static readonly GridTemplateRows GridRows_None = new("grid-rows-none", 14);
    public static readonly GridTemplateRows GridRows_SubGrid = new("grid-rows-subgrid", 15);

    private GridTemplateRows(string name, int value) : base(name, value) { }
}
