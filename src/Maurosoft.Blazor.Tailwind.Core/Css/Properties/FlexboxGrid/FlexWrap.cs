using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Maurosoft.Blazor.Tailwind.Core.Css.Properties.FlexboxGrid;

/// <summary>
/// Utilities for controlling how flex items wrap.
/// For info, see <see href="https://tailwindcss.com/docs/flex-wrap">flex-wrap</see>
/// </summary>
public sealed class FlexWrap : TailwindCssClassBase
{
    public static readonly FlexWrap NotSet = new("notset", 1);
    public static readonly FlexWrap Flex_Wrap = new("flex-wrap", 2);
    public static readonly FlexWrap Flex_WrapReverse = new("flex-wrap-reverse", 3);
    public static readonly FlexWrap Flex_NoWrap = new("flex-nowrap", 4);

    private FlexWrap(string name, int value) : base(name, value) { }
}
