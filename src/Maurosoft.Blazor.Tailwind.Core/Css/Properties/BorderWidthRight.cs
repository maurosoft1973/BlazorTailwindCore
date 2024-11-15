using Ardalis.SmartEnum;
using System.Runtime.Serialization;

namespace Maurosoft.Blazor.Tailwind.Core.Css;

/// <summary>
/// Utilities for controlling the width of an element's border right.
/// </summary>
public sealed class BorderWidthRight : TailwindCssClassBase
{
    public static readonly BorderWidthRight NotSet = new("notset", 1);
    public static readonly BorderWidthRight Border_r_0 = new("border-r-0", 2);
    public static readonly BorderWidthRight Border_r = new("border-r", 3);
    public static readonly BorderWidthRight Border_r_2 = new("border-r-2", 4);
    public static readonly BorderWidthRight Border_r_4 = new("border-r-4", 5);
    public static readonly BorderWidthRight Border_r_8 = new("border-r-8", 6);

    private BorderWidthRight(string name, int value) : base(name, value) { }
}
