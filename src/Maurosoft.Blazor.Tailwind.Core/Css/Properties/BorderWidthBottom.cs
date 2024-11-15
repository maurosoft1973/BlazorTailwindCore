using Ardalis.SmartEnum;
using System.Runtime.Serialization;

namespace Maurosoft.Blazor.Tailwind.Core.Css;

/// <summary>
/// Utilities for controlling the width of an element's border bottom.
/// </summary>
public sealed class BorderWidthBottom : TailwindCssClassBase
{
    public static readonly BorderWidthBottom NotSet = new("notset", 1);
    public static readonly BorderWidthBottom Border_b_0 = new("border-b-0", 2);
    public static readonly BorderWidthBottom Border_b = new("border-b", 3);
    public static readonly BorderWidthBottom Border_b_2 = new("border-b-2", 4);
    public static readonly BorderWidthBottom Border_b_4 = new("border-b-4", 5);
    public static readonly BorderWidthBottom Border_b_8 = new("border-b-8", 6);

    private BorderWidthBottom(string name, int value) : base(name, value) { }
}
