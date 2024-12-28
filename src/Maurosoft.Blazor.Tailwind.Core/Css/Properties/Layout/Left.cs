using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Maurosoft.Blazor.Tailwind.Core.Css.Properties.Layout;

/// <summary>
/// Utilities for controlling the left placement of positioned elements.
/// For info, see <see href="https://tailwindcss.com/docs/left-right-bottom-left">left</see>
/// </summary>
public sealed class Left : TailwindCssClassBase
{
    public static readonly Left NotSet = new("notset", 1);
    public static readonly Left Left_0 = new("left-0", 2);
    public static readonly Left Left_0v5 = new("left-0.5", 3);
    public static readonly Left Left_1 = new("left-1", 4);
    public static readonly Left Left_1v5 = new("left-1.5", 5);
    public static readonly Left Left_1d2 = new("left-1/2", 6);
    public static readonly Left Left_1d3 = new("left-1/3", 7);
    public static readonly Left Left_1d4 = new("left-1/4", 8);
    public static readonly Left Left_2 = new("left-2", 9);
    public static readonly Left Left_2v5 = new("left-2.5", 10);
    public static readonly Left Left_2d3 = new("left-2/3", 11);
    public static readonly Left Left_2d4 = new("left-2/4", 12);
    public static readonly Left Left_3 = new("left-3", 13);
    public static readonly Left Left_3v5 = new("left-3.5", 14);
    public static readonly Left Left_3d4 = new("left-3/4", 15);
    public static readonly Left Left_4 = new("left-4", 16);
    public static readonly Left Left_5 = new("left-5", 17);
    public static readonly Left Left_6 = new("left-6", 18);
    public static readonly Left Left_7 = new("left-7", 19);
    public static readonly Left Left_8 = new("left-8", 20);
    public static readonly Left Left_9 = new("left-9", 21);
    public static readonly Left Left_10 = new("left-10", 21);
    public static readonly Left Left_11 = new("left-11", 22);
    public static readonly Left Left_12 = new("left-12", 23);
    public static readonly Left Left_14 = new("left-14", 24);
    public static readonly Left Left_16 = new("left-16", 25);
    public static readonly Left Left_20 = new("left-20", 26);
    public static readonly Left Left_24 = new("left-24", 27);
    public static readonly Left Left_28 = new("left-28", 28);
    public static readonly Left Left_32 = new("left-32", 29);
    public static readonly Left Left_36 = new("left-36", 30);
    public static readonly Left Left_40 = new("left-40", 31);
    public static readonly Left Left_44 = new("left-44", 32);
    public static readonly Left Left_48 = new("left-48", 33);
    public static readonly Left Left_52 = new("left-52", 34);
    public static readonly Left Left_56 = new("left-56", 35);
    public static readonly Left Left_60 = new("left-60", 36);
    public static readonly Left Left_64 = new("left-64", 37);
    public static readonly Left Left_80 = new("left-80", 38);
    public static readonly Left Left_72 = new("left-72", 39);
    public static readonly Left Left_96 = new("left-96", 40);
    public static readonly Left Left_Auto = new("left-auto", 41);
    public static readonly Left Left_Full = new("left-full", 42);
    public static readonly Left Left_Px = new("left-px", 43);
    public static readonly Left MinusLeft_0 = new("-left-0", 44);
    public static readonly Left MinusLeft_0v5 = new("-left-0.5", 45);
    public static readonly Left MinusLeft_1 = new("-left-1", 46);
    public static readonly Left MinusLeft_1v5 = new("-left-1.5", 47);
    public static readonly Left MinusLeft_1d2 = new("-left-1/2", 48);
    public static readonly Left MinusLeft_1d3 = new("-left-1/3", 49);
    public static readonly Left MinusLeft_1d4 = new("-left-1/4", 50);
    public static readonly Left MinusLeft_2 = new("-left-2", 51);
    public static readonly Left MinusLeft_2v5 = new("-left-2.5", 52);
    public static readonly Left MinusLeft_2d3 = new("-left-2/3", 53);
    public static readonly Left MinusLeft_2d4 = new("-left-2/4", 54);
    public static readonly Left MinusLeft_3 = new("-left-3", 55);
    public static readonly Left MinusLeft_3v5 = new("-left-3.5", 56);
    public static readonly Left MinusLeft_3d4 = new("-left-3/4", 57);
    public static readonly Left MinusLeft_4 = new("-left-4", 58);
    public static readonly Left MinusLeft_5 = new("-left-5", 59);
    public static readonly Left MinusLeft_6 = new("-left-6", 60);
    public static readonly Left MinusLeft_7 = new("-left-7", 61);
    public static readonly Left MinusLeft_8 = new("-left-8", 62);
    public static readonly Left MinusLeft_9 = new("-left-9", 63);
    public static readonly Left MinusLeft_10 = new("-left-10", 64);
    public static readonly Left MinusLeft_11 = new("-left-11", 65);
    public static readonly Left MinusLeft_12 = new("-left-12", 66);
    public static readonly Left MinusLeft_14 = new("-left-14", 67);
    public static readonly Left MinusLeft_16 = new("-left-16", 68);
    public static readonly Left MinusLeft_20 = new("-left-20", 69);
    public static readonly Left MinusLeft_24 = new("-left-24", 70);
    public static readonly Left MinusLeft_28 = new("-left-28", 71);
    public static readonly Left MinusLeft_32 = new("-left-32", 72);
    public static readonly Left MinusLeft_36 = new("-left-36", 73);
    public static readonly Left MinusLeft_40 = new("-left-40", 74);
    public static readonly Left MinusLeft_44 = new("-left-44", 75);
    public static readonly Left MinusLeft_48 = new("-left-48", 76);
    public static readonly Left MinusLeft_52 = new("-left-52", 77);
    public static readonly Left MinusLeft_56 = new("-left-56", 78);
    public static readonly Left MinusLeft_60 = new("-left-60", 79);
    public static readonly Left MinusLeft_64 = new("-left-64", 80);
    public static readonly Left MinusLeft_72 = new("-left-72", 81);
    public static readonly Left MinusLeft_80 = new("-left-80", 82);
    public static readonly Left MinusLeft_96 = new("-left-96", 83);
    public static readonly Left MinusLeft_Full = new("-left-full", 84);
    public static readonly Left MinusLeft_Px = new("-left-px", 85);

    private Left(string name, int value) : base(name, value) { }
}
