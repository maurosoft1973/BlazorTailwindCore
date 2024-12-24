using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Maurosoft.Blazor.Tailwind.Core.Css.Properties.Layout;

/// <summary>
/// Utilities for controlling the visibility of an element.
/// For info, see <see href="https://tailwindcss.com/docs/visibility">visibility</see>
/// </summary>
public class Visibility : TailwindCssClassBase
{
    public static readonly Visibility NotSet = new("notset", 1);
    public static readonly Visibility Visible = new("visible", 2);
    public static readonly Visibility Invisible = new("invisible", 3);
    public static readonly Visibility Collapse = new("collapse", 4);

    private Visibility(string name, int value) : base(name, value) { }
}
