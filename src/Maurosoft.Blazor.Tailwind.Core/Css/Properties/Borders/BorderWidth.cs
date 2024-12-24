using Ardalis.SmartEnum;
using System.Runtime.Serialization;

namespace Maurosoft.Blazor.Tailwind.Core.Css.Properties.Borders;

/// <summary>
/// Utilities for controlling the width of an element's borders.
/// For info, see <see href="https://tailwindcss.com/docs/border-width">border-width</see>
/// </summary>
public sealed class BorderWidth : TailwindCssClassBase
{
    public static readonly BorderWidth NotSet = new("notset", 1);
    public static readonly BorderWidth Border_Bottom_0 = new("border-b-0", 2);
    public static readonly BorderWidth Border_Bottom_1 = new("border-b", 3);
    public static readonly BorderWidth Border_Bottom_2 = new("border-b-2", 4);
    public static readonly BorderWidth Border_Bottom_4 = new("border-b-4", 5);
    public static readonly BorderWidth Border_Bottom_8 = new("border-b-8", 6);
    public static readonly BorderWidth Border_End_0 = new("border-e-0", 7);
    public static readonly BorderWidth Border_End_1 = new("border-e", 8);
    public static readonly BorderWidth Border_End_2 = new("border-e-2", 9);
    public static readonly BorderWidth Border_End_4 = new("border-e-4", 10);
    public static readonly BorderWidth Border_End_8 = new("border-e-8", 11);
    public static readonly BorderWidth Border_Left_0 = new("border-l-0", 12);
    public static readonly BorderWidth Border_Left_1 = new("border-l", 13);
    public static readonly BorderWidth Border_Left_2 = new("border-l-2", 14);
    public static readonly BorderWidth Border_Left_4 = new("border-l-4", 15);
    public static readonly BorderWidth Border_Left_8 = new("border-l-8", 16);
    public static readonly BorderWidth Border_Border_Right_0 = new("border-r-0", 17);
    public static readonly BorderWidth Border_Border_Right_1 = new("border-r", 18);
    public static readonly BorderWidth Border_Border_Right_2 = new("border-r-2", 19);
    public static readonly BorderWidth Border_Border_Right_4 = new("border-r-4", 20);
    public static readonly BorderWidth Border_Border_Right_8 = new("border-r-8", 21);
    public static readonly BorderWidth Border_Start_0 = new("border-s-0", 22);
    public static readonly BorderWidth Border_Start_1 = new("border-s", 23);
    public static readonly BorderWidth Border_Start_2 = new("border-s-2", 24);
    public static readonly BorderWidth Border_Start_4 = new("border-s-4", 25);
    public static readonly BorderWidth Border_Start_8 = new("border-s-8", 26);
    public static readonly BorderWidth Border_Top_0 = new("border-t-0", 27);
    public static readonly BorderWidth Border_Top_1 = new("border-t", 28);
    public static readonly BorderWidth Border_Top_2 = new("border-t-2", 29);
    public static readonly BorderWidth Border_Top_4 = new("border-t-4", 30);
    public static readonly BorderWidth Border_Top_8 = new("border-t-8", 31);

    private BorderWidth(string name, int value) : base(name, value) { }
}
