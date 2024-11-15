using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Maurosoft.Blazor.Tailwind.Core.Css;

/// <summary>
/// Utilities for controlling the visibility of an element.
/// </summary>
public class Visibility : TailwindCssClassBase
{
    public static readonly Visibility NotSet = new("notset", 0);
    public static readonly Visibility Visible = new("visible", 1);
    public static readonly Visibility Invisible = new("invisible", 2);
    public static readonly Visibility Collapse = new("collapse", 3);

    private Visibility(string name, int value) : base(name, value) { }
}
