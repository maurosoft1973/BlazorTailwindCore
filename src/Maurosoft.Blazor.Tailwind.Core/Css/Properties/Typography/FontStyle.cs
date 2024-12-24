using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Maurosoft.Blazor.Tailwind.Core.Css.Properties.Typography;

/// <summary>
/// Utilities for controlling the style of text.
/// For info, see <see href="https://tailwindcss.com/docs/font-style">font-style</see>
/// </summary>
public sealed class FontStyle : TailwindCssClassBase
{
    public static readonly FontStyle NotSet = new("notset", 1);
    public static readonly FontStyle Italic = new("italic", 2);
    public static readonly FontStyle NotItalic = new("not-italic", 3);

    private FontStyle(string name, int value) : base(name, value) { }
}
