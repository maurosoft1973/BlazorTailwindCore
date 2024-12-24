using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Maurosoft.Blazor.Tailwind.Core.Css.Properties.FlexboxGrid;

/// <summary>
/// Utilities for controlling gutters between row for grid and flexbox items.
/// For info, see <see href="https://tailwindcss.com/docs/gap">flex</see>
/// </summary>
public sealed class GapY : TailwindCssClassBase
{
    public static readonly GapY NotSet = new("notset", 1);
    public static readonly GapY Gap_Y0 = new("gap-y-0", 2);
    public static readonly GapY Gap_Y_Px = new("gap-y-px", 3);
    public static readonly GapY Gap_Y0_5 = new("gap-y-0.5", 4);
    public static readonly GapY Gap_Y1 = new("gap-y-1", 5);
    public static readonly GapY Gap_Y2 = new("gap-y-2", 6);
    public static readonly GapY Gap_Y3 = new("gap-y-3", 7);
    public static readonly GapY Gap_Y4 = new("gap-y-4", 8);
    public static readonly GapY Gap_Y5 = new("gap-y-5", 9);
    public static readonly GapY Gap_Y6 = new("gap-y-6", 10);
    public static readonly GapY Gap_Y7 = new("gap-y-7", 11);
    public static readonly GapY Gap_Y8 = new("gap-y-8", 12);
    public static readonly GapY Gap_Y9 = new("gap-y-9", 13);
    public static readonly GapY Gap_Y10 = new("gap-y-10", 14);

    private GapY(string name, int value) : base(name, value) { }
}
