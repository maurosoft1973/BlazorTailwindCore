using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Maurosoft.Blazor.Tailwind.Core.Css.Properties.FlexboxGrid;

/// <summary>
/// Utilities for controlling how flex items shrink.
/// For info, see <see href="https://tailwindcss.com/docs/flex-shrink">flex-shrink</see>
/// </summary>
public sealed class FlexShrink : TailwindCssClassBase
{
    public static readonly FlexShrink NotSet = new("notset", 1);
    public static readonly FlexShrink Flex_Shrink = new("flex-shrink", 2);
    public static readonly FlexShrink Flex_Shrink_0 = new("flex-shrink-0", 3);

    private FlexShrink(string name, int value) : base(name, value) { }
}
