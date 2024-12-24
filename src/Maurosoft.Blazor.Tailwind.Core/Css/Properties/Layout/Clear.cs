using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Maurosoft.Blazor.Tailwind.Core.Css.Properties.Layout;

/// <summary>
/// Utilities for controlling the wrapping of content around an element.
/// For info, see <see href="https://tailwindcss.com/docs/clear">clear</see>
/// </summary>
public sealed class Clear : TailwindCssClassBase
{
    public static readonly Clear NotSet = new("notset", 1);
    public static readonly Clear Start = new("clear-start", 2);
    public static readonly Clear End = new("clear-end", 3);
    public static readonly Clear Left = new("clear-left", 4);
    public static readonly Clear Right = new("clear-right", 5);
    public static readonly Clear Both = new("clear-both", 6);
    public static readonly Clear None = new("clear-none", 7);

    private Clear(string name, int value) : base(name, value) { }
}
