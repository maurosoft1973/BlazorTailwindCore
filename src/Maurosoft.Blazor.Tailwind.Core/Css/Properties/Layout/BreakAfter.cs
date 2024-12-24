using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Maurosoft.Blazor.Tailwind.Core.Css.Properties.Layout;

/// <summary>
/// Utilities for controlling how a column or page should break after an element.
/// For info, see <see href="https://tailwindcss.com/docs/break-after">break-after</see>
/// </summary>
public sealed class BreakAfter : TailwindCssClassBase
{
    public static readonly BreakAfter NotSet = new("notset", 1);
    public static readonly BreakAfter Auto = new("break-after-auto", 2);
    public static readonly BreakAfter Avoid = new("break-after-avoid", 3);
    public static readonly BreakAfter All = new("break-after-all", 4);
    public static readonly BreakAfter AvoidPage = new("break-after-avoid-page", 5);
    public static readonly BreakAfter Page = new("break-after-page", 6);
    public static readonly BreakAfter Left = new("break-after-left", 7);
    public static readonly BreakAfter Right = new("break-after-right", 8);
    public static readonly BreakAfter Column = new("break-after-column", 9);

    private BreakAfter(string name, int value) : base(name, value) { }
}
