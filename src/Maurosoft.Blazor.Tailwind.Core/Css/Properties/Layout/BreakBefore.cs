using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Maurosoft.Blazor.Tailwind.Core.Css.Properties.Layout;

/// <summary>
/// Utilities for controlling how a column or page should break before an element.
/// For info, see <see href="https://tailwindcss.com/docs/break-before">break-before</see>
/// </summary>
public sealed class BreakBefore : TailwindCssClassBase
{
    public static readonly BreakBefore NotSet = new("notset", 1);
    public static readonly BreakBefore Auto = new("break-before-auto", 2);
    public static readonly BreakBefore Avoid = new("break-before-avoid", 3);
    public static readonly BreakBefore All = new("break-before-all", 4);
    public static readonly BreakBefore AvoidPage = new("break-before-avoid-page", 5);
    public static readonly BreakBefore Page = new("break-before-page", 6);
    public static readonly BreakBefore Left = new("break-before-left", 7);
    public static readonly BreakBefore Right = new("break-before-right", 8);
    public static readonly BreakBefore Column = new("break-before-column", 9);

    private BreakBefore(string name, int value) : base(name, value) { }
}
