using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Maurosoft.Blazor.Tailwind.Core.Css;

/// <summary>
/// Utilities for controlling the vertical alignment of an inline or table-cell box.
/// </summary>
public sealed class VerticalAlign : TailwindCssClassBase
{
    public static readonly VerticalAlign NotSet = new("notset", 1);
    public static readonly VerticalAlign Align_Baseline = new("align-baseline", 2);
    public static readonly VerticalAlign Align_Top = new("align-top", 3);
    public static readonly VerticalAlign Align_Middle = new("align-middle", 4);
    public static readonly VerticalAlign Align_Bottom = new("align-bottom", 5);
    public static readonly VerticalAlign Align_Text_Top = new("align-text-top", 6);
    public static readonly VerticalAlign Align_Text_Bottom = new("align-text-bottom", 7);
    public static readonly VerticalAlign Align_Sub = new("align-sub", 8);
    public static readonly VerticalAlign Align_Super = new("align-super", 9);

    private VerticalAlign(string name, int value) : base(name, value) { }
}
