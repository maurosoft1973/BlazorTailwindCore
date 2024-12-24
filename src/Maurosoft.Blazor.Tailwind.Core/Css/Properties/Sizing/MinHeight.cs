using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Maurosoft.Blazor.Tailwind.Core.Css.Properties.Sizing;

/// <summary>
/// Utilities for setting the minimum height of an element.
/// For info, see <see href="https://tailwindcss.com/docs/min-height">min-height</see>
/// </summary>
public sealed class MinHeight : TailwindCssClassBase
{
    public static readonly MinHeight NotSet = new("notset", 1);
    public static readonly MinHeight Min_H_0 = new("min-h-0", 2);
    public static readonly MinHeight Min_H_px = new("min-h-px", 3);
    public static readonly MinHeight Min_H_0v5 = new("min-h-0.5", 4);
    public static readonly MinHeight Min_H_1 = new("min-h-1", 5);
    public static readonly MinHeight Min_H_1v5 = new("min-h-1.5", 6);
    public static readonly MinHeight Min_H_2 = new("min-h-2", 7);
    public static readonly MinHeight Min_H_2v5 = new("min-h-2.5", 8);
    public static readonly MinHeight Min_H_3 = new("min-h-3", 9);
    public static readonly MinHeight Min_H_3v5 = new("min-h-3.5", 10);
    public static readonly MinHeight Min_H_4 = new("min-h-4", 11);
    public static readonly MinHeight Min_H_5 = new("min-h-5", 12);
    public static readonly MinHeight Min_H_6 = new("min-h-6", 13);
    public static readonly MinHeight Min_H_7 = new("min-h-7", 14);
    public static readonly MinHeight Min_H_8 = new("min-h-8", 15);
    public static readonly MinHeight Min_H_9 = new("min-h-9", 16);
    public static readonly MinHeight Min_H_10 = new("min-h-10", 17);
    public static readonly MinHeight Min_H_11 = new("min-h-11", 18);
    public static readonly MinHeight Min_H_12 = new("min-h-12", 19);
    public static readonly MinHeight Min_H_13 = new("min-h-13", 20);
    public static readonly MinHeight Min_H_14 = new("min-h-14", 21);
    public static readonly MinHeight Min_H_16 = new("min-h-16", 22);
    public static readonly MinHeight Min_H_20 = new("min-h-20", 23);
    public static readonly MinHeight Min_H_24 = new("min-h-24", 24);
    public static readonly MinHeight Min_H_28 = new("min-h-28", 25);
    public static readonly MinHeight Min_H_32 = new("min-h-32", 26);
    public static readonly MinHeight Min_H_36 = new("min-h-36", 27);
    public static readonly MinHeight Min_H_40 = new("min-h-40", 28);
    public static readonly MinHeight Min_H_44 = new("min-h-44", 29);
    public static readonly MinHeight Min_H_48 = new("min-h-48", 30);
    public static readonly MinHeight Min_H_52 = new("min-h-52", 31);
    public static readonly MinHeight Min_H_56 = new("min-h-56", 32);
    public static readonly MinHeight Min_H_60 = new("min-h-60", 33);
    public static readonly MinHeight Min_H_64 = new("min-h-64", 34);
    public static readonly MinHeight Min_H_72 = new("min-h-72", 35);
    public static readonly MinHeight Min_H_80 = new("min-h-80", 36);
    public static readonly MinHeight Min_H_96 = new("min-h-96", 37);
    public static readonly MinHeight Min_H_Full = new("min-h-full", 38);
    public static readonly MinHeight Min_H_Screen = new("min-h-screen", 39);
    public static readonly MinHeight Min_H_Lvh = new("min-h-lvh", 40);
    public static readonly MinHeight Min_H_Dvh = new("min-h-dvh", 41);
    public static readonly MinHeight Min_H_Min = new("min-h-min", 42);
    public static readonly MinHeight Min_H_Max = new("min-h-max", 43);
    public static readonly MinHeight Min_H_Fit = new("min-h-fit", 44);

    private MinHeight(string name, int value) : base(name, value) { }
}
