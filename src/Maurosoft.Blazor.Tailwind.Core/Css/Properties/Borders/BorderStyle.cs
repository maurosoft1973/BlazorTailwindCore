using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Maurosoft.Blazor.Tailwind.Core.Css.Properties.Borders;

/// <summary>
/// Utilities for controlling the style of an element's borders.
/// For info, see <see href="https://tailwindcss.com/docs/border-style">border-style</see>
/// </summary>
public class BorderStyle : TailwindCssClassBase
{
    public static readonly BorderStyle NotSet = new("notset", 1);
    public static readonly BorderStyle Solid = new("border-solid", 2);
    public static readonly BorderStyle Dashed = new("border-dashed", 3);
    public static readonly BorderStyle Dotted = new("border-dotted", 4);
    public static readonly BorderStyle Double = new("border-double", 5);
    public static readonly BorderStyle Hidden = new("border-hidden", 6);
    public static readonly BorderStyle None = new("border-none", 7);

    private BorderStyle(string name, int value) : base(name, value) { }
}
