using Ardalis.SmartEnum;
using System.Runtime.Serialization;

namespace Maurosoft.Blazor.Tailwind.Core.Css;

/// <summary>
/// Utilities for controlling the width of an element's borders.
/// </summary>
public sealed class BorderWidth : TailwindCssClassBase
{
    public static readonly BorderWidth NotSet = new("notset", 1);
    public static readonly BorderWidth Border_0 = new("border-0", 2);
    public static readonly BorderWidth Border = new("border", 3);
    public static readonly BorderWidth Border_2 = new("border-2", 4);
    public static readonly BorderWidth Border_4 = new("border-4", 5);
    public static readonly BorderWidth Border_8 = new("border-8", 6);
    public static readonly BorderWidth Border_x_0 = new("border-x-0", 7);
    public static readonly BorderWidth Border_x = new("border-x", 8);
    public static readonly BorderWidth Border_x_2 = new("border-x-2", 9);
    public static readonly BorderWidth Border_x_4 = new("border-x-4", 10);
    public static readonly BorderWidth Border_x_8 = new("border-x-8", 11);
    public static readonly BorderWidth Border_y_0 = new("border-y-0", 12);
    public static readonly BorderWidth Border_y = new("border-y", 13);
    public static readonly BorderWidth Border_y_2 = new("border-y-2", 14);
    public static readonly BorderWidth Border_y_4 = new("border-y-4", 15);
    public static readonly BorderWidth Border_y_8 = new("border-y-8", 16);
    public static readonly BorderWidth Border_e_0 = new("border-e-0", 17);
    public static readonly BorderWidth Border_e = new("border-e", 18);
    public static readonly BorderWidth Border_e_2 = new("border-e-2", 19);
    public static readonly BorderWidth Border_e_4 = new("border-e-4", 20);
    public static readonly BorderWidth Border_e_8 = new("border-e-8", 21);
    public static readonly BorderWidth Border_s_0 = new("border-s-0", 22);
    public static readonly BorderWidth Border_s = new("border-s", 23);
    public static readonly BorderWidth Border_s_2 = new("border-s-2", 24);
    public static readonly BorderWidth Border_s_4 = new("border-s-4", 25);
    public static readonly BorderWidth Border_s_8 = new("border-s-8", 26);
    public static readonly BorderWidth Border_t_0 = new("border-t-0", 27);
    public static readonly BorderWidth Border_t = new("border-t", 28);
    public static readonly BorderWidth Border_t_2 = new("border-t-2", 29);
    public static readonly BorderWidth Border_t_4 = new("border-t-4", 30);
    public static readonly BorderWidth Border_t_8 = new("border-t-8", 31);
    public static readonly BorderWidth Border_b_0 = new("border-b-0", 32);
    public static readonly BorderWidth Border_b = new("border-b", 33);
    public static readonly BorderWidth Border_b_2 = new("border-b-2", 34);
    public static readonly BorderWidth Border_b_4 = new("border-b-4", 35);
    public static readonly BorderWidth Border_b_8 = new("border-b-8", 36);
    public static readonly BorderWidth Border_l_0 = new("border-l-0", 37);
    public static readonly BorderWidth Border_l = new("border-l", 38);
    public static readonly BorderWidth Border_l_2 = new("border-l-2", 39);
    public static readonly BorderWidth Border_l_4 = new("border-l-4", 40);
    public static readonly BorderWidth Border_l_8 = new("border-l-8", 41);
    public static readonly BorderWidth Border_r_0 = new("border-r-0", 42);
    public static readonly BorderWidth Border_r = new("border-r", 43);
    public static readonly BorderWidth Border_r_2 = new("border-r-2", 44);
    public static readonly BorderWidth Border_r_4 = new("border-r-4", 45);
    public static readonly BorderWidth Border_r_8 = new("border-r-8", 46);

    private BorderWidth(string name, int value) : base(name, value) { }
}
