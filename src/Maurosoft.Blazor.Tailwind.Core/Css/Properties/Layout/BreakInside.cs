using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Maurosoft.Blazor.Tailwind.Core.Css.Properties.Layout;

/// <summary>
/// Utilities for controlling how a column or page should break within an element.
/// For info, see <see href="https://tailwindcss.com/docs/break-inside">break-inside</see>
/// </summary>
public sealed class BreakInside : TailwindCssClassBase
{
    public static readonly BreakInside NotSet = new("notset", 1);
    public static readonly BreakInside Auto = new("break-inside-auto", 2);
    public static readonly BreakInside Avoid = new("break-inside-avoid", 3);
    public static readonly BreakInside AvoidPage = new("break-inside-avoid-page", 4);
    public static readonly BreakInside AvoidColumn = new("break-inside-avoid-column", 5);

    private BreakInside(string name, int value) : base(name, value) { }
}
