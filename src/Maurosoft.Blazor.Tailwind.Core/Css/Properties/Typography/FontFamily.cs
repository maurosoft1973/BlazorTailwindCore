using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Maurosoft.Blazor.Tailwind.Core.Css.Properties.Typography;

/// <summary>
/// Utilities for controlling the font family of an element.
/// For info, see <see href="https://tailwindcss.com/docs/font-family">font-family</see>
/// </summary>
public sealed class FontFamily : TailwindCssClassBase
{
    public static readonly FontFamily NotSet = new("notset", 1);
    public static readonly FontFamily FontSans = new("font-sans", 2);
    public static readonly FontFamily FontSerif = new("font-serif", 3);
    public static readonly FontFamily FontMono = new("font-mono", 4);

    private FontFamily(string name, int value) : base(name, value) { }
}
