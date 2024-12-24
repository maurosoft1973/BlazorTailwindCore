using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Maurosoft.Blazor.Tailwind.Core.Css.Properties.Effects;

/// <summary>
/// Utilities for controlling the opacity of an element.
/// For info, see <see href="https://tailwindcss.com/docs/opacity">opacity</see>
/// </summary>
public sealed class Opacity : TailwindCssClassBase
{
    public static readonly Opacity NotSet = new("notset", 1);
    public static readonly Opacity Opacity_0 = new("opacity-0", 2);
    public static readonly Opacity Opacity_5 = new("opacity-5", 3);
    public static readonly Opacity Opacity_10 = new("opacity-10", 4);
    public static readonly Opacity Opacity_15 = new("opacity-15", 5);
    public static readonly Opacity Opacity_20 = new("opacity-20", 6);
    public static readonly Opacity Opacity_25 = new("opacity-25", 7);
    public static readonly Opacity Opacity_30 = new("opacity-30", 8);
    public static readonly Opacity Opacity_35 = new("opacity-35", 9);
    public static readonly Opacity Opacity_40 = new("opacity-40", 10);
    public static readonly Opacity Opacity_45 = new("opacity-45", 11);
    public static readonly Opacity Opacity_50 = new("opacity-50", 12);
    public static readonly Opacity Opacity_55 = new("opacity-55", 13);
    public static readonly Opacity Opacity_60 = new("opacity-60", 14);
    public static readonly Opacity Opacity_65 = new("opacity-65", 15);
    public static readonly Opacity Opacity_70 = new("opacity-70", 16);
    public static readonly Opacity Opacity_75 = new("opacity-75", 17);
    public static readonly Opacity Opacity_80 = new("opacity-80", 18);
    public static readonly Opacity Opacity_85 = new("opacity-85", 19);
    public static readonly Opacity Opacity_90 = new("opacity-90", 20);
    public static readonly Opacity Opacity_95 = new("opacity-95", 21);
    public static readonly Opacity Opacity_100 = new("opacity-100", 22);

    private Opacity(string name, int value) : base(name, value) { }
}
