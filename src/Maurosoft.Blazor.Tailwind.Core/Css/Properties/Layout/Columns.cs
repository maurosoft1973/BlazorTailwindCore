using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Maurosoft.Blazor.Tailwind.Core.Css.Properties.Layout;

/// <summary>
/// Utilities for controlling the number of columns within an element.
/// For info, see <see href="https://tailwindcss.com/docs/columns">columns</see>
/// </summary>
public sealed class Columns : TailwindCssClassBase
{
    public static readonly Columns NotSet = new("notset", 1);
    public static readonly Columns Columns_1 = new("columns-1", 2);
    public static readonly Columns Columns_2 = new("columns-2", 3);
    public static readonly Columns Columns_3 = new("columns-3", 4);
    public static readonly Columns Columns_4 = new("columns-4", 5);
    public static readonly Columns Columns_5 = new("columns-5", 6);
    public static readonly Columns Columns_6 = new("columns-6", 7);
    public static readonly Columns Columns_7 = new("columns-7", 8);
    public static readonly Columns Columns_8 = new("columns-8", 9);
    public static readonly Columns Columns_9 = new("columns-9", 10);
    public static readonly Columns Columns_10 = new("columns-10", 11);
    public static readonly Columns Columns_11 = new("columns-11", 12);
    public static readonly Columns Columns_12 = new("columns-12", 13);
    public static readonly Columns Columns_Auto = new("columns-auto", 14);
    public static readonly Columns Columns_3xs = new("columns-3xs", 15);
    public static readonly Columns Columns_2xs = new("columns-2xs", 16);
    public static readonly Columns Columns_Xs = new("columns-xs", 17);
    public static readonly Columns Columns_Sm = new("columns-sm", 18);
    public static readonly Columns Columns_Md = new("columns-md", 19);
    public static readonly Columns Columns_Lg = new("columns-lg", 20);
    public static readonly Columns Columns_2xl = new("columns-2xl", 21);
    public static readonly Columns Columns_3xl = new("columns-3xl", 22);
    public static readonly Columns Columns_4xl = new("columns-4xl", 23);
    public static readonly Columns Columns_5xl = new("columns-5xl", 24);
    public static readonly Columns Columns_6xl = new("columns-6xl", 25);
    public static readonly Columns Columns_7xl = new("columns-7xl", 26);

    private Columns(string name, int value) : base(name, value) { }
}
