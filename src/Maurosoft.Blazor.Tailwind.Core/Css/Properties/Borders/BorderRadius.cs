using Ardalis.SmartEnum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Maurosoft.Blazor.Tailwind.Core.Css.Properties.Borders;

/// <summary>
/// Utilities for controlling the border radius of an element.
/// For info, see <see href="https://tailwindcss.com/docs/border-radius">border-radius</see>
/// </summary>
public sealed class BorderRadius : TailwindCssClassBase
{
    public static readonly BorderRadius NotSet = new("notset", 1);
    public static readonly BorderRadius Rounded_None = new("rounded-none", 2);
    public static readonly BorderRadius Rounded = new("rounded", 3);
    public static readonly BorderRadius Rounded_Sm = new("rounded-sm", 4);
    public static readonly BorderRadius Rounded_Md = new("rounded-md", 5);
    public static readonly BorderRadius Rounded_Lg = new("rounded-lg", 6);
    public static readonly BorderRadius Rounded_Xl = new("rounded-xl", 7);
    public static readonly BorderRadius Rounded_2Xl = new("rounded-2xl", 8);
    public static readonly BorderRadius Rounded_3Xl = new("rounded-3xl", 9);
    public static readonly BorderRadius Rounded_Full = new("rounded-full", 10);
    public static readonly BorderRadius Rounded_S_None = new("rounded-s-none", 11);
    public static readonly BorderRadius Rounded_S_Sm = new("rounded-s-sm", 12);
    public static readonly BorderRadius Rounded_S = new("rounded-s", 13);
    public static readonly BorderRadius Rounded_S_Md = new("rounded-s-md", 14);
    public static readonly BorderRadius Rounded_S_Lg = new("rounded-s-lg", 15);
    public static readonly BorderRadius Rounded_S_Xl = new("rounded-s-xl", 16);
    public static readonly BorderRadius Rounded_S_2Xl = new("rounded-s-2xl", 17);
    public static readonly BorderRadius Rounded_S_3Xl = new("rounded-s-3xl", 18);
    public static readonly BorderRadius Rounded_S_Full = new("rounded-s-full", 19);
    public static readonly BorderRadius Rounded_E_None = new("rounded-e-none", 20);
    public static readonly BorderRadius Rounded_E_Sm = new("rounded-e-sm", 21);
    public static readonly BorderRadius Rounded_E = new("rounded-e", 22);
    public static readonly BorderRadius Rounded_E_Md = new("rounded-e-md", 23);
    public static readonly BorderRadius Rounded_E_Lg = new("rounded-e-lg", 24);
    public static readonly BorderRadius Rounded_E_Xl = new("rounded-e-xl", 25);
    public static readonly BorderRadius Rounded_E_2XL = new("rounded-e-2xl", 26);
    public static readonly BorderRadius Rounded_E_3XL = new("rounded-e-3xl", 27);
    public static readonly BorderRadius Rounded_E_Full = new("rounded-e-full", 28);
    public static readonly BorderRadius Rounded_T_None = new("rounded-t-none", 29);
    public static readonly BorderRadius Rounded_T_Sm = new("rounded-t-sm", 30);
    public static readonly BorderRadius Rounded_T = new("rounded-t", 31);
    public static readonly BorderRadius Rounded_T_Md = new("rounded-t-md", 32);
    public static readonly BorderRadius Rounded_T_Lg = new("rounded-t-lg", 33);
    public static readonly BorderRadius Rounded_T_Xl = new("rounded-t-xl", 34);
    public static readonly BorderRadius Rounded_T_2XL = new("rounded-t-2xl", 35);
    public static readonly BorderRadius Rounded_T_3XL = new("rounded-t-3xl", 36);
    public static readonly BorderRadius Rounded_T_Full = new("rounded-t-full", 37);
    public static readonly BorderRadius Rounded_B_None = new("rounded-b-none", 38);
    public static readonly BorderRadius Rounded_B_Sm = new("rounded-b-sm", 39);
    public static readonly BorderRadius Rounded_B = new("rounded-b", 40);
    public static readonly BorderRadius Rounded_B_Md = new("rounded-b-md", 41);
    public static readonly BorderRadius Rounded_B_Lg = new("rounded-b-lg", 42);
    public static readonly BorderRadius Rounded_B_Xl = new("rounded-b-xl", 43);
    public static readonly BorderRadius Rounded_B_2XL = new("rounded-b-2xl", 44);
    public static readonly BorderRadius Rounded_B_3XL = new("rounded-b-3xl", 45);
    public static readonly BorderRadius Rounded_B_Full = new("rounded-b-full", 46);
    public static readonly BorderRadius Rounded_L_None = new("rounded-l-none", 47);
    public static readonly BorderRadius Rounded_L_Sm = new("rounded-l-sm", 48);
    public static readonly BorderRadius Rounded_L = new("rounded-l", 49);
    public static readonly BorderRadius Rounded_L_Md = new("rounded-l-md", 50);
    public static readonly BorderRadius Rounded_L_Lg = new("rounded-l-lg", 51);
    public static readonly BorderRadius Rounded_L_Xl = new("rounded-l-xl", 52);
    public static readonly BorderRadius Rounded_L_2XL = new("rounded-l-2xl", 53);
    public static readonly BorderRadius Rounded_L_3XL = new("rounded-l-3xl", 54);
    public static readonly BorderRadius Rounded_L_Full = new("rounded-l-full", 55);
    public static readonly BorderRadius Rounded_R_None = new("rounded-r-none", 56);
    public static readonly BorderRadius Rounded_R_Sm = new("rounded-r-sm", 57);
    public static readonly BorderRadius Rounded_R = new("rounded-r", 58);
    public static readonly BorderRadius Rounded_R_Md = new("rounded-r-md", 59);
    public static readonly BorderRadius Rounded_R_Lg = new("rounded-r-lg", 60);
    public static readonly BorderRadius Rounded_R_Xl = new("rounded-r-xl", 61);
    public static readonly BorderRadius Rounded_R_2XL = new("rounded-r-2xl", 62);
    public static readonly BorderRadius Rounded_R_3XL = new("rounded-r-3xl", 63);
    public static readonly BorderRadius Rounded_R_Full = new("rounded-r-full", 64);

    private BorderRadius(string name, int value) : base(name, value) { }
}
