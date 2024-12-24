using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Maurosoft.Blazor.Tailwind.Core.Css.Properties.Typography;

/// <summary>
/// Utilities for controlling the font size of an element.
/// For info, see <see href="https://tailwindcss.com/docs/font-size">font-size</see>
/// </summary>
public sealed class FontSize : TailwindCssClassBase
{
    public static readonly FontSize NotSet = new("notset", 1);
    [Description("Custom")]
    public static readonly FontSize Text_Xxs = new("text-xxs", 2);
    public static readonly FontSize Text_Xs = new("text-xs", 2);
    public static readonly FontSize Text_Sm = new("text-sm", 3);
    public static readonly FontSize Text_Base = new("text-base", 4);
    public static readonly FontSize Text_Lg = new("text-lg", 5);
    public static readonly FontSize Text_Xl = new("text-xl", 6);
    public static readonly FontSize Text_2Xl = new("text-2xl", 7);
    public static readonly FontSize Text_3Xl = new("text-3xl", 8);
    public static readonly FontSize Text_4Xl = new("text-4xl", 9);
    public static readonly FontSize Text_5Xl = new("text-5xl", 10);
    public static readonly FontSize Text_6Xl = new("text-6xl", 11);
    public static readonly FontSize Text_7Xl = new("text-7xl", 12);
    public static readonly FontSize Text_8Xl = new("text-8xl", 13);
    public static readonly FontSize Text_9Xl = new("text-9xl", 14);

    private FontSize(string name, int value) : base(name, value) { }
}
