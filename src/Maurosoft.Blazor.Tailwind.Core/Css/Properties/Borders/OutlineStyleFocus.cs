using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Maurosoft.Blazor.Tailwind.Core.Css.Properties.Borders;

/// <summary>
/// Utilities for controlling the focus style of an element's outline.
/// For info, see <see href="https://tailwindcss.com/docs/outline-style">outline-style</see>
/// </summary>
public sealed class OutlineStyleFocus : TailwindCssClassBase
{
    public static readonly OutlineStyleFocus NotSet = new("notset", 1);
    public static readonly OutlineStyleFocus Outline_None = new("focus:outline-none", 2);
    public static readonly OutlineStyleFocus Outline_Offset = new("focus:outline-offset", 3);
    public static readonly OutlineStyleFocus Outline_Outline = new("focus:outline", 4);
    public static readonly OutlineStyleFocus Outline_Dashed = new("focus:outline-dashed", 5);
    public static readonly OutlineStyleFocus Outline_Dotted = new("focus:outline-dotted", 6);
    public static readonly OutlineStyleFocus Outline_Double = new("focus:outline-double", 7);

    private OutlineStyleFocus(string name, int value) : base(name, value) { }
}
