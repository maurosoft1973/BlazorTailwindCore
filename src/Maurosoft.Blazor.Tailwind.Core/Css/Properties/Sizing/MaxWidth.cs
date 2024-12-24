using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Maurosoft.Blazor.Tailwind.Core.Css.Properties.Sizing;

/// <summary>
/// Utilities for setting the maximum width of an element.
/// For info, see <see href="https://tailwindcss.com/docs/max-width">max-width</see>
/// </summary>
public sealed class MaxWidth : TailwindCssClassBase
{
    public static readonly MaxWidth NotSet = new("notset", 1);
    public static readonly MaxWidth Max_W_0 = new("max-w-0", 2);
    public static readonly MaxWidth Max_W_px = new("max-w-px", 3);
    public static readonly MaxWidth Max_W_0v5 = new("max-w-0.5", 4);
    public static readonly MaxWidth Max_W_1 = new("max-w-1", 5);
    public static readonly MaxWidth Max_W_1v5 = new("max-w-1.5", 6);
    public static readonly MaxWidth Max_W_2 = new("max-w-2", 7);
    public static readonly MaxWidth Max_W_2v5 = new("max-w-2.5", 8);
    public static readonly MaxWidth Max_W_3 = new("max-w-3", 9);
    public static readonly MaxWidth Max_W_3v5 = new("max-w-3.5", 10);
    public static readonly MaxWidth Max_W_4 = new("max-w-4", 11);
    public static readonly MaxWidth Max_W_5 = new("max-w-5", 12);
    public static readonly MaxWidth Max_W_6 = new("max-w-6", 13);
    public static readonly MaxWidth Max_W_7 = new("max-w-7", 14);
    public static readonly MaxWidth Max_W_8 = new("max-w-8", 15);
    public static readonly MaxWidth Max_W_9 = new("max-w-9", 16);
    public static readonly MaxWidth Max_W_10 = new("max-w-10", 17);
    public static readonly MaxWidth Max_W_11 = new("max-w-11", 18);
    public static readonly MaxWidth Max_W_12 = new("max-w-12", 19);
    public static readonly MaxWidth Max_W_13 = new("max-w-13", 20);
    public static readonly MaxWidth Max_W_14 = new("max-w-14", 21);
    public static readonly MaxWidth Max_W_16 = new("max-w-16", 22);
    public static readonly MaxWidth Max_W_20 = new("max-w-20", 23);
    public static readonly MaxWidth Max_W_24 = new("max-w-24", 24);
    public static readonly MaxWidth Max_W_28 = new("max-w-28", 25);
    public static readonly MaxWidth Max_W_32 = new("max-w-32", 26);
    public static readonly MaxWidth Max_W_36 = new("max-w-36", 27);
    public static readonly MaxWidth Max_W_40 = new("max-w-40", 28);
    public static readonly MaxWidth Max_W_44 = new("max-w-44", 29);
    public static readonly MaxWidth Max_W_48 = new("max-w-48", 30);
    public static readonly MaxWidth Max_W_52 = new("max-w-52", 31);
    public static readonly MaxWidth Max_W_56 = new("max-w-56", 32);
    public static readonly MaxWidth Max_W_60 = new("max-w-60", 33);
    public static readonly MaxWidth Max_W_64 = new("max-w-64", 34);
    public static readonly MaxWidth Max_W_72 = new("max-w-72", 35);
    public static readonly MaxWidth Max_W_80 = new("max-w-80", 36);
    public static readonly MaxWidth Max_W_96 = new("max-w-96", 37);
    public static readonly MaxWidth Max_W_None = new("max-w-none", 38);
    public static readonly MaxWidth Max_W_Sm = new("max-w-sm", 39);
    public static readonly MaxWidth Max_W_Md = new("max-w-md", 40);
    public static readonly MaxWidth Max_W_Lg = new("max-w-lg", 41);
    public static readonly MaxWidth Max_W_Xl = new("max-w-xl", 42);
    public static readonly MaxWidth Max_W_2Xl = new("max-w-2xl", 43);
    public static readonly MaxWidth Max_W_3Xl = new("max-w-3xl", 44);
    public static readonly MaxWidth Max_W_4Xl = new("max-w-4xl", 45);
    public static readonly MaxWidth Max_W_5Xl = new("max-w-5xl", 46);
    public static readonly MaxWidth Max_W_6Xl = new("max-w-6xl", 47);
    public static readonly MaxWidth Max_W_7Xl = new("max-w-7xl", 48);
    public static readonly MaxWidth Max_W_Full = new("max-w-full", 49);
    public static readonly MaxWidth Max_W_Screen = new("max-w-screen", 50);
    public static readonly MaxWidth Max_W_Min = new("max-w-min", 51);
    public static readonly MaxWidth Max_W_Max = new("max-w-max", 52);
    public static readonly MaxWidth Max_W_Fit = new("max-w-fit", 53);
    public static readonly MaxWidth Max_W_Prose = new("max-w-prose", 54);
    public static readonly MaxWidth Max_W_Screen_Sm = new("max-w-screen-sm", 55);
    public static readonly MaxWidth Max_W_Screen_Md = new("max-w-screen-md", 56);
    public static readonly MaxWidth Max_W_Screen_Lg = new("max-w-screen-lg", 57);
    public static readonly MaxWidth Max_W_Screen_Xl = new("max-w-screen-xl", 58);
    public static readonly MaxWidth Max_W_Screen_2Xl = new("max-w-screen-2xl", 58);

    private MaxWidth(string name, int value) : base(name, value) { }
}

