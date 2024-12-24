using Ardalis.SmartEnum;
using System.Runtime.Serialization;

namespace Maurosoft.Blazor.Tailwind.Core.Css.Properties.Borders;

/// <summary>
/// Utilities for controlling the width of an element's border top.
/// For info, see <see href="https://tailwindcss.com/docs/border-width">border-width</see>
/// </summary>
public sealed class BorderWidthTop : TailwindCssClassBase
{
    public static readonly BorderWidthTop NotSet = new("notset", 1);
    public static readonly BorderWidthTop Border_Top_0 = new("border-t-0", 2);
    public static readonly BorderWidthTop Border_Top_1 = new("border-t", 3);
    public static readonly BorderWidthTop Border_Top_2 = new("border-t-2", 4);
    public static readonly BorderWidthTop Border_Top_4 = new("border-t-4", 5);
    public static readonly BorderWidthTop Border_Top_8 = new("border-t-8", 6);

    private BorderWidthTop(string name, int value) : base(name, value) { }
}
