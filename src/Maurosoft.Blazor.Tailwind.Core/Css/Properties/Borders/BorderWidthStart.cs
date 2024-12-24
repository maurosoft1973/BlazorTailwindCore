using Ardalis.SmartEnum;
using System.Runtime.Serialization;

namespace Maurosoft.Blazor.Tailwind.Core.Css.Properties.Borders;

/// <summary>
/// Utilities for controlling the width of an element's border start.
/// For info, see <see href="https://tailwindcss.com/docs/border-width">border-width</see>
/// </summary>
public sealed class BorderWidthStart : TailwindCssClassBase
{
    public static readonly BorderWidthStart NotSet = new("notset", 1);
    public static readonly BorderWidthStart Border_Start_0 = new("border-s-0", 2);
    public static readonly BorderWidthStart Border_Start_1 = new("border-s", 3);
    public static readonly BorderWidthStart Border_Start_2 = new("border-s-2", 4);
    public static readonly BorderWidthStart Border_Start_4 = new("border-s-4", 5);
    public static readonly BorderWidthStart Border_Start_8 = new("border-s-8", 6);

    private BorderWidthStart(string name, int value) : base(name, value) { }
}
