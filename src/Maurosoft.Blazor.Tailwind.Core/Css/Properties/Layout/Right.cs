using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Maurosoft.Blazor.Tailwind.Core.Css.Properties.Layout;

/// <summary>
/// Utilities for controlling the right placement of positioned elements.
/// For info, see <see href="https://tailwindcss.com/docs/top-right-bottom-right">right</see>
/// </summary>
public sealed class Right : TailwindCssClassBase
{
    public static readonly Right NotSet = new("notset", 1);
    public static readonly Right Right_0 = new("right-0", 2);
    public static readonly Right Right_0v5 = new("right-0.5", 3);
    public static readonly Right Right_1 = new("right-1", 4);
    public static readonly Right Right_1v5 = new("right-1.5", 5);
    public static readonly Right Right_1d2 = new("right-1/2", 6);
    public static readonly Right Right_1d3 = new("right-1/3", 7);
    public static readonly Right Right_1d4 = new("right-1/4", 8);
    public static readonly Right Right_2 = new("right-2", 9);
    public static readonly Right Right_2v5 = new("right-2.5", 10);
    public static readonly Right Right_2d3 = new("right-2/3", 11);
    public static readonly Right Right_2d4 = new("right-2/4", 12);
    public static readonly Right Right_3 = new("right-3", 13);
    public static readonly Right Right_3v5 = new("right-3.5", 14);
    public static readonly Right Right_3d4 = new("right-3/4", 15);
    public static readonly Right Right_4 = new("right-4", 16);
    public static readonly Right Right_5 = new("right-5", 17);
    public static readonly Right Right_6 = new("right-6", 18);
    public static readonly Right Right_7 = new("right-7", 19);
    public static readonly Right Right_8 = new("right-8", 20);
    public static readonly Right Right_9 = new("right-9", 21);
    public static readonly Right Right_10 = new("right-10", 21);
    public static readonly Right Right_11 = new("right-11", 22);
    public static readonly Right Right_12 = new("right-12", 23);
    public static readonly Right Right_14 = new("right-14", 24);
    public static readonly Right Right_16 = new("right-16", 25);
    public static readonly Right Right_20 = new("right-20", 26);
    public static readonly Right Right_24 = new("right-24", 27);
    public static readonly Right Right_28 = new("right-28", 28);
    public static readonly Right Right_32 = new("right-32", 29);
    public static readonly Right Right_36 = new("right-36", 30);
    public static readonly Right Right_40 = new("right-40", 31);
    public static readonly Right Right_44 = new("right-44", 32);
    public static readonly Right Right_48 = new("right-48", 33);
    public static readonly Right Right_52 = new("right-52", 34);
    public static readonly Right Right_56 = new("right-56", 35);
    public static readonly Right Right_60 = new("right-60", 36);
    public static readonly Right Right_64 = new("right-64", 37);
    public static readonly Right Right_80 = new("right-80", 38);
    public static readonly Right Right_72 = new("right-72", 39);
    public static readonly Right Right_96 = new("right-96", 40);
    public static readonly Right Right_Auto = new("right-auto", 41);
    public static readonly Right Right_Full = new("right-full", 42);
    public static readonly Right Right_Px = new("right-px", 43);
    public static readonly Right MinusRight_0 = new("-right-0", 44);
    public static readonly Right MinusRight_0v5 = new("-right-0.5", 45);
    public static readonly Right MinusRight_1 = new("-right-1", 46);
    public static readonly Right MinusRight_1v5 = new("-right-1.5", 47);
    public static readonly Right MinusRight_1d2 = new("-right-1/2", 48);
    public static readonly Right MinusRight_1d3 = new("-right-1/3", 49);
    public static readonly Right MinusRight_1d4 = new("-right-1/4", 50);
    public static readonly Right MinusRight_2 = new("-right-2", 51);
    public static readonly Right MinusRight_2v5 = new("-right-2.5", 52);
    public static readonly Right MinusRight_2d3 = new("-right-2/3", 53);
    public static readonly Right MinusRight_2d4 = new("-right-2/4", 54);
    public static readonly Right MinusRight_3 = new("-right-3", 55);
    public static readonly Right MinusRight_3v5 = new("-right-3.5", 56);
    public static readonly Right MinusRight_3d4 = new("-right-3/4", 57);
    public static readonly Right MinusRight_4 = new("-right-4", 58);
    public static readonly Right MinusRight_5 = new("-right-5", 59);
    public static readonly Right MinusRight_6 = new("-right-6", 60);
    public static readonly Right MinusRight_7 = new("-right-7", 61);
    public static readonly Right MinusRight_8 = new("-right-8", 62);
    public static readonly Right MinusRight_9 = new("-right-9", 63);
    public static readonly Right MinusRight_10 = new("-right-10", 64);
    public static readonly Right MinusRight_11 = new("-right-11", 65);
    public static readonly Right MinusRight_12 = new("-right-12", 66);
    public static readonly Right MinusRight_14 = new("-right-14", 67);
    public static readonly Right MinusRight_16 = new("-right-16", 68);
    public static readonly Right MinusRight_20 = new("-right-20", 69);
    public static readonly Right MinusRight_24 = new("-right-24", 70);
    public static readonly Right MinusRight_28 = new("-right-28", 71);
    public static readonly Right MinusRight_32 = new("-right-32", 72);
    public static readonly Right MinusRight_36 = new("-right-36", 73);
    public static readonly Right MinusRight_40 = new("-right-40", 74);
    public static readonly Right MinusRight_44 = new("-right-44", 75);
    public static readonly Right MinusRight_48 = new("-right-48", 76);
    public static readonly Right MinusRight_52 = new("-right-52", 77);
    public static readonly Right MinusRight_56 = new("-right-56", 78);
    public static readonly Right MinusRight_60 = new("-right-60", 79);
    public static readonly Right MinusRight_64 = new("-right-64", 80);
    public static readonly Right MinusRight_72 = new("-right-72", 81);
    public static readonly Right MinusRight_80 = new("-right-80", 82);
    public static readonly Right MinusRight_96 = new("-right-96", 83);
    public static readonly Right MinusRight_Full = new("-right-full", 84);
    public static readonly Right MinusRight_Px = new("-right-px", 85);

    private Right(string name, int value) : base(name, value) { }
}
