using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Maurosoft.Blazor.Tailwind.Core.Css.Properties.Typography;

/// <summary>
/// Utilities for controlling the leading (line height) of an element.
/// For info, see <see href="https://tailwindcss.com/docs/line-height">line-height</see>
/// </summary>
public class LineHeight : TailwindCssClassBase
{
    public static readonly LineHeight NotSet = new("notset", 1);
    public static readonly LineHeight Leading_3 = new("leading-3", 2);
    public static readonly LineHeight Leading_4 = new("leading-4", 3);
    public static readonly LineHeight Leading_5 = new("leading-5", 4);
    public static readonly LineHeight Leading_6 = new("leading-6", 5);
    public static readonly LineHeight Leading_7 = new("leading-7", 6);
    public static readonly LineHeight Leading_8 = new("leading-8", 7);
    public static readonly LineHeight Leading_9 = new("leading-9", 8);
    public static readonly LineHeight Leading_10 = new("leading-10", 9);
    [Description("Custom")]
    public static readonly LineHeight Leading_11 = new("leading-11", 10);
    [Description("Custom")]
    public static readonly LineHeight Leading_12 = new("leading-12", 11);
    public static readonly LineHeight Leading_None = new("leading-none", 12);
    public static readonly LineHeight Leading_Snug = new("leading-snug", 13);
    public static readonly LineHeight Leading_Normal = new("leading-normal", 14);
    public static readonly LineHeight Leading_Relaxed = new("leading-relaxed", 15);
    public static readonly LineHeight Leading_Loose = new("leading-loose", 16);

    private LineHeight(string name, int value) : base(name, value) { }
}
