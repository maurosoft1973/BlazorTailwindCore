using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Maurosoft.Blazor.Tailwind.Core.Css.Properties.Sizing;

/// <summary>
/// Utilities for setting the maximum height of an element.
/// For info, see <see href="https://tailwindcss.com/docs/max-height">min-height</see>
/// </summary>
public sealed class MaxHeight : TailwindCssClassBase
{
    public static readonly MaxHeight NotSet = new("notset", 1);
    public static readonly MaxHeight Max_H_0 = new("max-h-0", 2);
    public static readonly MaxHeight Max_H_px = new("max-h-px", 3);
    public static readonly MaxHeight Max_H_0v5 = new("max-h-0.5", 4);
    public static readonly MaxHeight Max_H_1 = new("max-h-1", 5);
    public static readonly MaxHeight Max_H_1v5 = new("max-h-1.5", 6);
    public static readonly MaxHeight Max_H_2 = new("max-h-2", 7);
    public static readonly MaxHeight Max_H_2v5 = new("max-h-2.5", 8);
    public static readonly MaxHeight Max_H_3 = new("max-h-3", 9);
    public static readonly MaxHeight Max_H_3v5 = new("max-h-3.5", 10);
    public static readonly MaxHeight Max_H_4 = new("max-h-4", 11);
    public static readonly MaxHeight Max_H_5 = new("max-h-5", 12);
    public static readonly MaxHeight Max_H_6 = new("max-h-6", 13);
    public static readonly MaxHeight Max_H_7 = new("max-h-7", 14);
    public static readonly MaxHeight Max_H_8 = new("max-h-8", 15);
    public static readonly MaxHeight Max_H_9 = new("max-h-9", 16);
    public static readonly MaxHeight Max_H_10 = new("max-h-10", 17);
    public static readonly MaxHeight Max_H_11 = new("max-h-11", 18);
    public static readonly MaxHeight Max_H_12 = new("max-h-12", 19);
    public static readonly MaxHeight Max_H_13 = new("max-h-13", 20);
    public static readonly MaxHeight Max_H_14 = new("max-h-14", 21);
    public static readonly MaxHeight Max_H_16 = new("max-h-16", 22);
    public static readonly MaxHeight Max_H_20 = new("max-h-20", 23);
    public static readonly MaxHeight Max_H_24 = new("max-h-24", 24);
    public static readonly MaxHeight Max_H_28 = new("max-h-28", 25);
    public static readonly MaxHeight Max_H_32 = new("max-h-32", 26);
    public static readonly MaxHeight Max_H_36 = new("max-h-36", 27);
    public static readonly MaxHeight Max_H_40 = new("max-h-40", 28);
    public static readonly MaxHeight Max_H_44 = new("max-h-44", 29);
    public static readonly MaxHeight Max_H_48 = new("max-h-48", 30);
    public static readonly MaxHeight Max_H_52 = new("max-h-52", 31);
    public static readonly MaxHeight Max_H_56 = new("max-h-56", 32);
    public static readonly MaxHeight Max_H_60 = new("max-h-60", 33);
    public static readonly MaxHeight Max_H_64 = new("max-h-64", 34);
    public static readonly MaxHeight Max_H_72 = new("max-h-72", 35);
    public static readonly MaxHeight Max_H_80 = new("max-h-80", 36);
    public static readonly MaxHeight Max_H_96 = new("max-h-96", 37);
    public static readonly MaxHeight Max_H_Full = new("max-h-full", 38);
    public static readonly MaxHeight Max_H_Screen = new("max-h-screen", 39);
    public static readonly MaxHeight Max_H_Lvh = new("max-h-lvh", 40);
    public static readonly MaxHeight Max_H_Dvh = new("max-h-dvh", 41);
    public static readonly MaxHeight Max_H_Min = new("max-h-min", 42);
    public static readonly MaxHeight Max_H_Max = new("max-h-max", 43);
    public static readonly MaxHeight Max_H_Fit = new("max-h-fit", 44);

    private MaxHeight(string name, int value) : base(name, value) { }
}
