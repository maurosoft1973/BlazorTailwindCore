using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Maurosoft.Blazor.Tailwind.Core.Css.Properties.FlexboxGrid;

/// <summary>
/// Utilities for controlling how flex items grow.
/// For info, see <see href="https://tailwindcss.com/docs/flex-grow">flex-grow</see>
/// </summary>
public sealed class FlexGrow : TailwindCssClassBase
{
    public static readonly FlexGrow NotSet = new("notset", 1);
    public static readonly FlexGrow Flex_Grow = new("flex-grow", 2);
    public static readonly FlexGrow Flex_Grow_0 = new("flex-grow-0", 3);

    private FlexGrow(string name, int value) : base(name, value) { }
}
