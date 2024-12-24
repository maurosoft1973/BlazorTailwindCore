using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Maurosoft.Blazor.Tailwind.Core.Css.Properties.Borders;

/// <summary>
/// Utilities for controlling the style of an element's outline.
/// For info, see <see href="https://tailwindcss.com/docs/outline-style">outline-style</see>
/// </summary>
public sealed class OutlineStyle : TailwindCssClassBase
{
    public static readonly OutlineStyle NotSet = new("notset", 1);
    public static readonly OutlineStyle Outline_None = new("outline-none", 2);
    public static readonly OutlineStyle Outline_Offset = new("outline-offset", 3);
    public static readonly OutlineStyle Outline_Outline = new("outline", 4);
    public static readonly OutlineStyle Outline_Dashed = new("outline-dashed", 5);
    public static readonly OutlineStyle Outline_Dotted = new("outline-dotted", 6);
    public static readonly OutlineStyle Outline_Double = new("outline-double", 7);

    private OutlineStyle(string name, int value) : base(name, value) { }
}
