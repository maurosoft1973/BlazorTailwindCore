using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Maurosoft.Blazor.Tailwind.Core.Css.Properties.Layout;

/// <summary>
/// Utilities for controlling how element fragments should be rendered across multiple lines, columns, or pages.
/// For info, see <see href="https://tailwindcss.com/docs/box-decoration-break">box-decoration-break</see>
/// </summary>
public sealed class BoxDecorationBreak : TailwindCssClassBase
{
    public static readonly BoxDecorationBreak NotSet = new("notset", 1);
    public static readonly BoxDecorationBreak BoxDecoration_Clone = new("box-decoration-clone", 2);
    public static readonly BoxDecorationBreak BoxDecoration_Slice = new("box-decoration-slice", 3);

    private BoxDecorationBreak(string name, int value) : base(name, value) { }
}
