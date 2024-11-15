using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Maurosoft.Blazor.Tailwind.Core.Css;

/// <summary>
/// Utilities for controlling how an element is positioned in the DOM.
/// For info, see <see href="https://Maurosoft.Blazor.Tailwind.Core.Css.Basecss.com/docs/position#absolutely-positioning-elements">absolutely-positioning-elements</see>
/// </summary>
public sealed class Position : TailwindCssClassBase
{
    public static readonly Position NotSet = new("notset", 0);
    public static readonly Position Static = new("static", 1);
    public static readonly Position Fixed = new("fixed", 2);
    public static readonly Position Absolute = new("absolute", 3);
    public static readonly Position Relative = new("relative", 4);
    public static readonly Position Sticky = new("sticky", 5);

    private Position(string name, int value) : base(name, value) { }
}
