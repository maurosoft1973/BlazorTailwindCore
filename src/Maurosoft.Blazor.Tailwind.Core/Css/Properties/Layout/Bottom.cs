using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Maurosoft.Blazor.Tailwind.Core.Css.Properties.Layout;

/// <summary>
/// Utilities for controlling the bottom placement of positioned elements.
/// For info, see <see href="https://tailwindcss.com/docs/top-right-bottom-left">bottom</see>
/// </summary>
public sealed class Bottom : TailwindCssClassBase
{
    public static readonly Bottom NotSet = new("notset", 1);
    public static readonly Bottom Bottom_0 = new("bottom-0", 2);
    public static readonly Bottom Bottom_0v5 = new("bottom-0.5", 3);
    public static readonly Bottom Bottom_1 = new("bottom-1", 4);
    public static readonly Bottom Bottom_1v5 = new("bottom-1.5", 5);
    public static readonly Bottom Bottom_1d2 = new("bottom-1/2", 6);
    public static readonly Bottom Bottom_1d3 = new("bottom-1/3", 7);
    public static readonly Bottom Bottom_1d4 = new("bottom-1/4", 8);
    public static readonly Bottom Bottom_2 = new("bottom-2", 9);
    public static readonly Bottom Bottom_2v5 = new("bottom-2.5", 10);
    public static readonly Bottom Bottom_2d3 = new("bottom-2/3", 11);
    public static readonly Bottom Bottom_2d4 = new("bottom-2/4", 12);
    public static readonly Bottom Bottom_3 = new("bottom-3", 13);
    public static readonly Bottom Bottom_3v5 = new("bottom-3.5", 14);
    public static readonly Bottom Bottom_3d4 = new("bottom-3/4", 15);
    public static readonly Bottom Bottom_4 = new("bottom-4", 16);
    public static readonly Bottom Bottom_5 = new("bottom-5", 17);
    public static readonly Bottom Bottom_6 = new("bottom-6", 18);
    public static readonly Bottom Bottom_7 = new("bottom-7", 19);
    public static readonly Bottom Bottom_8 = new("bottom-8", 20);
    public static readonly Bottom Bottom_9 = new("bottom-9", 21);
    public static readonly Bottom Bottom_10 = new("bottom-10", 21);
    public static readonly Bottom Bottom_11 = new("bottom-11", 22);
    public static readonly Bottom Bottom_12 = new("bottom-12", 23);
    public static readonly Bottom Bottom_14 = new("bottom-14", 24);
    public static readonly Bottom Bottom_16 = new("bottom-16", 25);
    public static readonly Bottom Bottom_20 = new("bottom-20", 26);
    public static readonly Bottom Bottom_24 = new("bottom-24", 27);
    public static readonly Bottom Bottom_28 = new("bottom-28", 28);
    public static readonly Bottom Bottom_32 = new("bottom-32", 29);
    public static readonly Bottom Bottom_36 = new("bottom-36", 30);
    public static readonly Bottom Bottom_40 = new("bottom-40", 31);
    public static readonly Bottom Bottom_44 = new("bottom-44", 32);
    public static readonly Bottom Bottom_48 = new("bottom-48", 33);
    public static readonly Bottom Bottom_52 = new("bottom-52", 34);
    public static readonly Bottom Bottom_56 = new("bottom-56", 35);
    public static readonly Bottom Bottom_60 = new("bottom-60", 36);
    public static readonly Bottom Bottom_64 = new("bottom-64", 37);
    public static readonly Bottom Bottom_80 = new("bottom-80", 38);
    public static readonly Bottom Bottom_72 = new("bottom-72", 39);
    public static readonly Bottom Bottom_96 = new("bottom-96", 40);
    public static readonly Bottom Bottom_Auto = new("bottom-auto", 41);
    public static readonly Bottom Bottom_Full = new("bottom-full", 42);
    public static readonly Bottom Bottom_Px = new("bottom-px", 43);
    public static readonly Bottom MinusBottom_0 = new("-bottom-0", 44);
    public static readonly Bottom MinusBottom_0v5 = new("-bottom-0.5", 45);
    public static readonly Bottom MinusBottom_1 = new("-bottom-1", 46);
    public static readonly Bottom MinusBottom_1v5 = new("-bottom-1.5", 47);
    public static readonly Bottom MinusBottom_1d2 = new("-bottom-1/2", 48);
    public static readonly Bottom MinusBottom_1d3 = new("-bottom-1/3", 49);
    public static readonly Bottom MinusBottom_1d4 = new("-bottom-1/4", 50);
    public static readonly Bottom MinusBottom_2 = new("-bottom-2", 51);
    public static readonly Bottom MinusBottom_2v5 = new("-bottom-2.5", 52);
    public static readonly Bottom MinusBottom_2d3 = new("-bottom-2/3", 53);
    public static readonly Bottom MinusBottom_2d4 = new("-bottom-2/4", 54);
    public static readonly Bottom MinusBottom_3 = new("-bottom-3", 55);
    public static readonly Bottom MinusBottom_3v5 = new("-bottom-3.5", 56);
    public static readonly Bottom MinusBottom_3d4 = new("-bottom-3/4", 57);
    public static readonly Bottom MinusBottom_4 = new("-bottom-4", 58);
    public static readonly Bottom MinusBottom_5 = new("-bottom-5", 59);
    public static readonly Bottom MinusBottom_6 = new("-bottom-6", 60);
    public static readonly Bottom MinusBottom_7 = new("-bottom-7", 61);
    public static readonly Bottom MinusBottom_8 = new("-bottom-8", 62);
    public static readonly Bottom MinusBottom_9 = new("-bottom-9", 63);
    public static readonly Bottom MinusBottom_10 = new("-bottom-10", 64);
    public static readonly Bottom MinusBottom_11 = new("-bottom-11", 65);
    public static readonly Bottom MinusBottom_12 = new("-bottom-12", 66);
    public static readonly Bottom MinusBottom_14 = new("-bottom-14", 67);
    public static readonly Bottom MinusBottom_16 = new("-bottom-16", 68);
    public static readonly Bottom MinusBottom_20 = new("-bottom-20", 69);
    public static readonly Bottom MinusBottom_24 = new("-bottom-24", 70);
    public static readonly Bottom MinusBottom_28 = new("-bottom-28", 71);
    public static readonly Bottom MinusBottom_32 = new("-bottom-32", 72);
    public static readonly Bottom MinusBottom_36 = new("-bottom-36", 73);
    public static readonly Bottom MinusBottom_40 = new("-bottom-40", 74);
    public static readonly Bottom MinusBottom_44 = new("-bottom-44", 75);
    public static readonly Bottom MinusBottom_48 = new("-bottom-48", 76);
    public static readonly Bottom MinusBottom_52 = new("-bottom-52", 77);
    public static readonly Bottom MinusBottom_56 = new("-bottom-56", 78);
    public static readonly Bottom MinusBottom_60 = new("-bottom-60", 79);
    public static readonly Bottom MinusBottom_64 = new("-bottom-64", 80);
    public static readonly Bottom MinusBottom_72 = new("-bottom-72", 81);
    public static readonly Bottom MinusBottom_80 = new("-bottom-80", 82);
    public static readonly Bottom MinusBottom_96 = new("-bottom-96", 83);
    public static readonly Bottom MinusBottom_Full = new("-bottom-full", 84);
    public static readonly Bottom MinusBottom_Px = new("-bottom-px", 85);

    private Bottom(string name, int value) : base(name, value) { }
}
