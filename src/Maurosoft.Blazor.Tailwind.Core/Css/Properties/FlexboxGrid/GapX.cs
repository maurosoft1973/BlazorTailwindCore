using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Maurosoft.Blazor.Tailwind.Core.Css.Properties.FlexboxGrid;

/// <summary>
/// Utilities for controlling gutters between columns for grid and flexbox items.
/// For info, see <see href="https://tailwindcss.com/docs/gap">flex</see>
/// </summary>
public sealed class GapX : TailwindCssClassBase
{
    public static readonly GapX NotSet = new("notset", 1);
    public static readonly GapX Gap_X0 = new("gap-x-0", 2);
    public static readonly GapX Gap_X_Px = new("gap-x-px", 3);
    public static readonly GapX Gap_X0_5 = new("gap-x-0.5", 4);
    public static readonly GapX Gap_X1 = new("gap-x-1", 5);
    public static readonly GapX Gap_X2 = new("gap-x-2", 6);
    public static readonly GapX Gap_X3 = new("gap-x-3", 7);
    public static readonly GapX Gap_X4 = new("gap-x-4", 8);
    public static readonly GapX Gap_X5 = new("gap-x-5", 9);
    public static readonly GapX Gap_X6 = new("gap-x-6", 10);
    public static readonly GapX Gap_X7 = new("gap-x-7", 11);
    public static readonly GapX Gap_X8 = new("gap-x-8", 12);
    public static readonly GapX Gap_X9 = new("gap-x-9", 13);
    public static readonly GapX Gap_X10 = new("gap-x-10", 14);

    private GapX(string name, int value) : base(name, value) { }
}
