using Ardalis.SmartEnum;
using System.Runtime.Serialization;

namespace Maurosoft.Blazor.Tailwind.Core.Css.Properties.Borders;

/// <summary>
/// Utilities for controlling the width of an element's border right.
/// For info, see <see href="https://tailwindcss.com/docs/border-width">border-width</see>
/// </summary>
public sealed class BorderWidthRight : TailwindCssClassBase
{
    public static readonly BorderWidthRight NotSet = new("notset", 1);
    public static readonly BorderWidthRight Border_Border_Right_0 = new("border-r-0", 2);
    public static readonly BorderWidthRight Border_Border_Right_1 = new("border-r", 3);
    public static readonly BorderWidthRight Border_Border_Right_2 = new("border-r-2", 4);
    public static readonly BorderWidthRight Border_Border_Right_4 = new("border-r-4", 5);
    public static readonly BorderWidthRight Border_Border_Right_8 = new("border-r-8", 6);

    private BorderWidthRight(string name, int value) : base(name, value) { }
}
