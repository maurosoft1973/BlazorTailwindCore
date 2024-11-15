using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Maurosoft.Blazor.Tailwind.Core.Css;

public sealed class MaxHeight : TailwindCssClassBase
{
    public static readonly MaxHeight NotSet = new("notset", 1);
    public static readonly MaxHeight max_h_0 = new("max-h-0", 2);
    public static readonly MaxHeight max_h_pax = new("max-h-px", 3);
    public static readonly MaxHeight max_h_0v5 = new("max-h-0.5", 4);
    public static readonly MaxHeight max_h_1 = new("max-h-1", 5);
    public static readonly MaxHeight max_h_1v5 = new("max-h-1.5", 6);
    public static readonly MaxHeight max_h_2 = new("max-h-2", 7);
    public static readonly MaxHeight max_h_2v5 = new("max-h-2.5", 8);
    public static readonly MaxHeight max_h_3 = new("max-h-3", 9);
    public static readonly MaxHeight max_h_3v5 = new("max-h-3.5", 10);
    public static readonly MaxHeight max_h_4 = new("max-h-4", 11);
    public static readonly MaxHeight max_h_5 = new("max-h-5", 12);
    public static readonly MaxHeight max_h_6 = new("max-h-6", 13);
    public static readonly MaxHeight max_h_7 = new("max-h-7", 14);
    public static readonly MaxHeight max_h_8 = new("max-h-8", 15);
    public static readonly MaxHeight max_h_9 = new("max-h-9", 16);
    public static readonly MaxHeight max_h_10 = new("max-h-10", 17);
    public static readonly MaxHeight max_h_11 = new("max-h-11", 18);
    public static readonly MaxHeight max_h_12 = new("max-h-12", 19);
    public static readonly MaxHeight max_h_13 = new("max-h-13", 20);
    public static readonly MaxHeight max_h_14 = new("max-h-14", 21);
    public static readonly MaxHeight max_h_16 = new("max-h-16", 22);
    public static readonly MaxHeight max_h_20 = new("max-h-20", 23);
    public static readonly MaxHeight max_h_24 = new("max-h-24", 24);
    public static readonly MaxHeight max_h_28 = new("max-h-28", 25);
    public static readonly MaxHeight max_h_32 = new("max-h-32", 26);
    public static readonly MaxHeight max_h_36 = new("max-h-36", 27);
    public static readonly MaxHeight max_h_40 = new("max-h-40", 28);
    public static readonly MaxHeight max_h_44 = new("max-h-44", 29);
    public static readonly MaxHeight max_h_48 = new("max-h-48", 30);
    public static readonly MaxHeight max_h_52 = new("max-h-52", 31);
    public static readonly MaxHeight max_h_56 = new("max-h-56", 32);
    public static readonly MaxHeight max_h_60 = new("max-h-60", 33);
    public static readonly MaxHeight max_h_64 = new("max-h-64", 34);
    public static readonly MaxHeight max_h_72 = new("max-h-72", 35);
    public static readonly MaxHeight max_h_80 = new("max-h-80", 36);
    public static readonly MaxHeight max_h_96 = new("max-h-96", 37);
    public static readonly MaxHeight max_h_full = new("max-h-full", 38);
    public static readonly MaxHeight max_h_screen = new("max-h-screen", 39);
    public static readonly MaxHeight max_h_lvh = new("max-h-lvh", 40);
    public static readonly MaxHeight max_h_dvh = new("max-h-dvh", 41);
    public static readonly MaxHeight max_h_min = new("max-h-min", 42);
    public static readonly MaxHeight max_h_max = new("max-h-max", 43);
    public static readonly MaxHeight max_h_fit = new("max-h-fit", 44);

    private MaxHeight(string name, int value) : base(name, value) { }
}
