using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Maurosoft.Blazor.Tailwind.Core.Css.Properties.FlexboxGrid;

/// <summary>
/// Utilities for controlling the direction of flex items.
/// For info, see <see href="https://tailwindcss.com/docs/flex-direction">flex-direction</see>
/// </summary>
public sealed class FlexDirection : TailwindCssClassBase
{
    public static readonly FlexDirection NotSet = new("notset", 1);
    public static readonly FlexDirection Flex_Row = new("flex-row", 2);
    public static readonly FlexDirection Flex_RowReverse = new("flex-row-reverse", 3);
    public static readonly FlexDirection Flex_Col = new("flex-col", 4);
    public static readonly FlexDirection Flex_ColReverse = new("flex-col-reverse", 5);

    private FlexDirection(string name, int value) : base(name, value) { }
}
