using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Maurosoft.Blazor.Tailwind.Core.Css;

/// <summary>
/// Utilities for setting the width and height of an element at the same time.
/// </summary>
public class Size : TailwindCssClassBase
{
    public static readonly Size NotSet = new Size("notset", 0);
    public static readonly Size Size_0 = new Size("size-0", 1);
    public static readonly Size Size_1 = new Size("size-1", 2);
    public static readonly Size Size_2 = new Size("size-2", 3);
    public static readonly Size Size_3 = new Size("size-3", 4);
    public static readonly Size Size_4 = new Size("size-4", 5);
    public static readonly Size Size_5 = new Size("size-5", 6);
    public static readonly Size Size_6 = new Size("size-6", 7);
    public static readonly Size Size_7 = new Size("size-7", 8);
    public static readonly Size Size_8 = new Size("size-8", 9);
    public static readonly Size Size_9 = new Size("size-9", 10);
    public static readonly Size Size_10 = new Size("size-10", 11);
    public static readonly Size Size_11 = new Size("size-11", 12);
    public static readonly Size Size_12 = new Size("size-12", 13);
    public static readonly Size Size_14 = new Size("size-14", 14);
    public static readonly Size Size_16 = new Size("size-16", 15);
    public static readonly Size Size_20 = new Size("size-20", 16);
    public static readonly Size Size_24 = new Size("size-24", 17);
    public static readonly Size Size_28 = new Size("size-28", 18);
    public static readonly Size Size_32 = new Size("size-32", 19);
    public static readonly Size Size_36 = new Size("size-36", 20);
    public static readonly Size Size_40 = new Size("size-40", 21);
    public static readonly Size Size_44 = new Size("size-44", 22);
    public static readonly Size Size_48 = new Size("size-48", 23);
    public static readonly Size Size_52 = new Size("size-52", 24);
    public static readonly Size Size_56 = new Size("size-56", 25);
    public static readonly Size Size_60 = new Size("size-60", 26);
    public static readonly Size Size_64 = new Size("size-64", 27);
    public static readonly Size Size_72 = new Size("size-72", 28);
    public static readonly Size Size_80 = new Size("size-80", 29);
    public static readonly Size Size_96 = new Size("size-96", 30);
    public static readonly Size Size_Auto = new Size("size-auto", 31);
    public static readonly Size Size_Px = new Size("size-px", 32);
    public static readonly Size Size_1_2 = new Size("size-1/2", 33);
    public static readonly Size Size_1_3 = new Size("size-1/3", 34);
    public static readonly Size Size_2_3 = new Size("size-2/3", 35);
    public static readonly Size Size_1_4 = new Size("size-1/4", 36);
    public static readonly Size Size_2_4 = new Size("size-2/4", 37);
    public static readonly Size Size_3_4 = new Size("size-3/4", 38);
    public static readonly Size Size_1_5 = new Size("size-1/5", 39);
    public static readonly Size Size_2_5 = new Size("size-2/5", 40);
    public static readonly Size Size_3_5 = new Size("size-3/5", 41);
    public static readonly Size Size_4_5 = new Size("size-4/5", 42);
    public static readonly Size Size_1_6 = new Size("size-1/6", 43);
    public static readonly Size Size_2_6 = new Size("size-2/6", 44);
    public static readonly Size Size_3_6 = new Size("size-3/6", 45);
    public static readonly Size Size_4_6 = new Size("size-4/6", 46);
    public static readonly Size Size_5_6 = new Size("size-5/6", 47);
    public static readonly Size Size_1_12 = new Size("size-1/12", 48);
    public static readonly Size Size_2_12 = new Size("size-2/12", 49);
    public static readonly Size Size_3_12 = new Size("size-3/12", 50);
    public static readonly Size Size_4_12 = new Size("size-4/12", 51);
    public static readonly Size Size_5_12 = new Size("size-5/12", 52);
    public static readonly Size Size_6_12 = new Size("size-6/12", 53);
    public static readonly Size Size_7_12 = new Size("size-7/12", 54);
    public static readonly Size Size_8_12 = new Size("size-8/12", 55);
    public static readonly Size Size_9_12 = new Size("size-9/12", 56);
    public static readonly Size Size_10_12 = new Size("size-10/12", 57);
    public static readonly Size Size_11_12 = new Size("size-11/12", 58);
    public static readonly Size Size_Full = new Size("size-full", 59);
    public static readonly Size Size_Fit = new Size("size-fit", 60);
    public static readonly Size Size_Min = new Size("size-min", 61);
    public static readonly Size Size_Max = new Size("size-max", 62);
    public static readonly Size Size_0v5 = new Size("size-0.5", 63);
    public static readonly Size Size_1v5 = new Size("size-1.5", 64);
    public static readonly Size Size_2v5 = new Size("size-2.5", 65);
    public static readonly Size Size_3v5 = new Size("size-3.5", 66);

    protected Size(string name, int value) : base(name, value) { }
}
