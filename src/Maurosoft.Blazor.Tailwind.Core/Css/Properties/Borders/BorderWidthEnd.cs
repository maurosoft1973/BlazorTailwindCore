using Ardalis.SmartEnum;
using System.Runtime.Serialization;

namespace Maurosoft.Blazor.Tailwind.Core.Css.Properties.Borders;

/// <summary>
/// Utilities for controlling the width of an element's border end.
/// For info, see <see href="https://tailwindcss.com/docs/border-width">border-width</see>
/// </summary>
public sealed class BorderWidthEnd : TailwindCssClassBase
{
    public static readonly BorderWidthEnd NotSet = new("notset", 1);
    public static readonly BorderWidthEnd Border_End_0 = new("border-e-0", 2);
    public static readonly BorderWidthEnd Border_End_1 = new("border-e", 3);
    public static readonly BorderWidthEnd Border_End_2 = new("border-e-2", 4);
    public static readonly BorderWidthEnd Border_End_4 = new("border-e-4", 5);
    public static readonly BorderWidthEnd Border_End_8 = new("border-e-8", 6);

    private BorderWidthEnd(string name, int value) : base(name, value) { }
}
