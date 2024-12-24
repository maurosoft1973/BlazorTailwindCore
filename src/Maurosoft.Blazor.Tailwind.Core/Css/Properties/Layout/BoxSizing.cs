using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Maurosoft.Blazor.Tailwind.Core.Css.Properties.Layout;

/// <summary>
/// Utilities for controlling how the browser should calculate an element's total size.
/// For info, see <see href="https://tailwindcss.com/docs/box-sizing">box-sizing</see>
/// </summary>
public sealed class BoxSizing : TailwindCssClassBase
{
    public static readonly BoxSizing NotSet = new("notset", 1);
    public static readonly BoxSizing Border = new("box-border", 2);
    public static readonly BoxSizing Content = new("box-content", 3);

    private BoxSizing(string name, int value) : base(name, value) { }
}
