using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Maurosoft.Blazor.Tailwind.Core.Css.Properties.Layout;

/// <summary>
/// Utilities for controlling the stack order of an element.
/// For info, see <see href="https://tailwindcss.com/docs/z-index">z-index</see>
/// </summary>
public sealed class ZIndex : TailwindCssClassBase
{
    public static readonly ZIndex NotSet = new("notset", 1);
    public static readonly ZIndex z_0 = new("z-0", 2);
    public static readonly ZIndex z_1 = new("z-1", 3);
    public static readonly ZIndex z_2 = new("z-2", 4);
    public static readonly ZIndex z_3 = new("z-3", 5);
    public static readonly ZIndex z_4 = new("z-4", 6);
    public static readonly ZIndex z_5 = new("z-5", 7);
    public static readonly ZIndex z_6 = new("z-6", 8);
    public static readonly ZIndex z_7 = new("z-7", 9);
    public static readonly ZIndex z_8 = new("z-8", 10);
    public static readonly ZIndex z_9 = new("z-9", 11);
    public static readonly ZIndex z_10 = new("z-10", 12);
    public static readonly ZIndex z_20 = new("z-20", 13);
    public static readonly ZIndex z_30 = new("z-30", 14);
    public static readonly ZIndex z_40 = new("z-40", 15);
    public static readonly ZIndex z_50 = new("z-50", 16);
    public static readonly ZIndex z_60 = new("z-60", 17);
    public static readonly ZIndex z_70 = new("z-70", 18);
    public static readonly ZIndex z_80 = new("z-80", 19);
    public static readonly ZIndex z_90 = new("z-90", 20);
    public static readonly ZIndex z_100 = new("z-100", 21);
    public static readonly ZIndex z_Auto = new("z-auto", 999);

    private ZIndex(string name, int value) : base(name, value) { }
}
