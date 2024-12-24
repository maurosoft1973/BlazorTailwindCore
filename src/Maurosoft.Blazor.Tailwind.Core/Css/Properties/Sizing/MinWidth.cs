using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Maurosoft.Blazor.Tailwind.Core.Css.Properties.Sizing;

/// <summary>
/// Utilities for setting the minimum width of an element.
/// For info, see <see href="https://tailwindcss.com/docs/min-width">min-width</see>
/// </summary>
public sealed class MinWidth : TailwindCssClassBase
{
    public static readonly MinWidth NotSet = new("notset", 1);
    public static readonly MinWidth Min_W_0 = new("min-w-0", 2);
    public static readonly MinWidth Min_W_px = new("min-w-px", 3);
    public static readonly MinWidth Min_W_0v5 = new("min-w-0.5", 4);
    public static readonly MinWidth Min_W_1 = new("min-w-1", 5);
    public static readonly MinWidth Min_W_1v5 = new("min-w-1.5", 6);
    public static readonly MinWidth Min_W_2 = new("min-w-2", 7);
    public static readonly MinWidth Min_W_2v5 = new("min-w-2.5", 8);
    public static readonly MinWidth Min_W_3 = new("min-w-3", 9);
    public static readonly MinWidth Min_W_3v5 = new("min-w-3.5", 10);
    public static readonly MinWidth Min_W_4 = new("min-w-4", 11);
    public static readonly MinWidth Min_W_5 = new("min-w-5", 12);
    public static readonly MinWidth Min_W_6 = new("min-w-6", 13);
    public static readonly MinWidth Min_W_7 = new("min-w-7", 14);
    public static readonly MinWidth Min_W_8 = new("min-w-8", 15);
    public static readonly MinWidth Min_W_9 = new("min-w-9", 16);
    public static readonly MinWidth Min_W_10 = new("min-w-10", 17);
    public static readonly MinWidth Min_W_11 = new("min-w-11", 18);
    public static readonly MinWidth Min_W_12 = new("min-w-12", 19);
    public static readonly MinWidth Min_W_13 = new("min-w-13", 20);
    public static readonly MinWidth Min_W_14 = new("min-w-14", 21);
    public static readonly MinWidth Min_W_16 = new("min-w-16", 22);
    public static readonly MinWidth Min_W_20 = new("min-w-20", 23);
    public static readonly MinWidth Min_W_24 = new("min-w-24", 24);
    public static readonly MinWidth Min_W_28 = new("min-w-28", 25);
    public static readonly MinWidth Min_W_32 = new("min-w-32", 26);
    public static readonly MinWidth Min_W_36 = new("min-w-36", 27);
    public static readonly MinWidth Min_W_40 = new("min-w-40", 28);
    public static readonly MinWidth Min_W_44 = new("min-w-44", 29);
    public static readonly MinWidth Min_W_48 = new("min-w-48", 30);
    public static readonly MinWidth Min_W_52 = new("min-w-52", 31);
    public static readonly MinWidth Min_W_56 = new("min-w-56", 32);
    public static readonly MinWidth Min_W_60 = new("min-w-60", 33);
    public static readonly MinWidth Min_W_64 = new("min-w-64", 34);
    public static readonly MinWidth Min_W_72 = new("min-w-72", 35);
    public static readonly MinWidth Min_W_80 = new("min-w-80", 36);
    public static readonly MinWidth Min_W_96 = new("min-w-96", 37);
    public static readonly MinWidth Min_W_Full = new("min-w-full", 38);
    public static readonly MinWidth Min_W_Screen = new("min-w-screen", 39);
    public static readonly MinWidth Min_W_Lvh = new("min-w-lvh", 40);
    public static readonly MinWidth Min_W_Dvh = new("min-w-dvh", 41);
    public static readonly MinWidth Min_W_Min = new("min-w-min", 42);
    public static readonly MinWidth Min_W_Max = new("min-w-max", 43);
    public static readonly MinWidth Min_W_Fit = new("min-w-fit", 44);

    private MinWidth(string name, int value) : base(name, value) { }
}
