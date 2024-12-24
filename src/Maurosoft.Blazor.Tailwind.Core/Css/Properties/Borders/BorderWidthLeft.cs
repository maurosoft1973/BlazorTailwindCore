using Ardalis.SmartEnum;
using System.Runtime.Serialization;

namespace Maurosoft.Blazor.Tailwind.Core.Css.Properties.Borders;

/// <summary>
/// Utilities for controlling the width of an element's border left.
/// For info, see <see href="https://tailwindcss.com/docs/border-width">border-width</see>
/// </summary>
public sealed class BorderWidthLeft : TailwindCssClassBase
{
    public static readonly BorderWidthLeft NotSet = new("notset", 1);
    public static readonly BorderWidthLeft Border_Left_0 = new("border-l-0", 2);
    public static readonly BorderWidthLeft Border_Left_1 = new("border-l", 3);
    public static readonly BorderWidthLeft Border_Left_2 = new("border-l-2", 4);
    public static readonly BorderWidthLeft Border_Left_4 = new("border-l-4", 5);
    public static readonly BorderWidthLeft Border_Left_8 = new("border-l-8", 6);

    private BorderWidthLeft(string name, int value) : base(name, value) { }
}
