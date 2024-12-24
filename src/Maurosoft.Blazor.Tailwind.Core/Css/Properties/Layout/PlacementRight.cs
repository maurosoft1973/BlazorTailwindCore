using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Maurosoft.Blazor.Tailwind.Core.Css.Properties.Layout;

/// <summary>
/// Utilities for controlling the right placement of positioned elements.
/// For info, see <see href="https://tailwindcss.com/docs/top-right-bottom-left">right</see>
/// </summary>
public sealed class PlacementRight : TailwindCssClassBase
{
    public static readonly PlacementRight NotSet = new("notset", 1);
    public static readonly PlacementRight Right_0 = new("right-0", 2);
    public static readonly PlacementRight Right_0v5 = new("right-0.5", 3);
    public static readonly PlacementRight Right_1 = new("right-1", 4);
    public static readonly PlacementRight Right_1v5 = new("right-1.5", 5);
    public static readonly PlacementRight Right_1d2 = new("right-1/2", 6);
    public static readonly PlacementRight Right_1d3 = new("right-1/3", 7);
    public static readonly PlacementRight Right_1d4 = new("right-1/4", 8);
    public static readonly PlacementRight Right_10 = new("right-10", 9);
    public static readonly PlacementRight Right_11 = new("right-11", 10);
    public static readonly PlacementRight Right_12 = new("right-12", 11);
    public static readonly PlacementRight Right_14 = new("right-14", 12);
    public static readonly PlacementRight Right_16 = new("right-16", 13);
    public static readonly PlacementRight Right_2 = new("right-2", 14);
    public static readonly PlacementRight Right_2v5 = new("right-2.5", 15);
    public static readonly PlacementRight Right_2d3 = new("right-2/3", 16);
    public static readonly PlacementRight Right_2d4 = new("right-2/4", 17);
    public static readonly PlacementRight Right_20 = new("right-20", 18);
    public static readonly PlacementRight Right_24 = new("right-24", 19);
    public static readonly PlacementRight Right_28 = new("right-28", 20);
    public static readonly PlacementRight Right_3 = new("right-3", 21);
    public static readonly PlacementRight Right_3v5 = new("right-3.5", 22);
    public static readonly PlacementRight Right_3d4 = new("right-3/4", 23);
    public static readonly PlacementRight Right_32 = new("right-32", 24);
    public static readonly PlacementRight Right_36 = new("right-36", 25);
    public static readonly PlacementRight Right_4 = new("right-4", 26);
    public static readonly PlacementRight Right_40 = new("right-40", 27);
    public static readonly PlacementRight Right_44 = new("right-44", 28);
    public static readonly PlacementRight Right_48 = new("right-48", 29);
    public static readonly PlacementRight Right_5 = new("right-5", 30);
    public static readonly PlacementRight Right_52 = new("right-52", 31);
    public static readonly PlacementRight Right_56 = new("right-56", 32);
    public static readonly PlacementRight Right_6 = new("right-6", 33);
    public static readonly PlacementRight Right_60 = new("right-60", 34);
    public static readonly PlacementRight Right_64 = new("right-64", 35);
    public static readonly PlacementRight Right_7 = new("right-7", 36);
    public static readonly PlacementRight Right_72 = new("right-72", 37);
    public static readonly PlacementRight Right_8 = new("right-8", 38);
    public static readonly PlacementRight Right_80 = new("right-80", 39);
    public static readonly PlacementRight Right_9 = new("right-9", 40);
    public static readonly PlacementRight Right_96 = new("right-96", 41);
    public static readonly PlacementRight Right_Auto = new("right-auto", 42);
    public static readonly PlacementRight Right_Full = new("right-full", 43);
    public static readonly PlacementRight Right_Px = new("right-px", 44);
    public static readonly PlacementRight MinusRight_0 = new("-right-0", 45);
    public static readonly PlacementRight MinusRight_0v5 = new("-right-0.5", 46);
    public static readonly PlacementRight MinusRight_1 = new("-right-1", 47);
    public static readonly PlacementRight MinusRight_1v5 = new("-right-1.5", 48);
    public static readonly PlacementRight MinusRight_1d2 = new("-right-1/2", 49);
    public static readonly PlacementRight MinusRight_1d3 = new("-right-1/3", 50);
    public static readonly PlacementRight MinusRight_1d4 = new("-right-1/4", 51);
    public static readonly PlacementRight MinusRight_10 = new("-right-10", 52);
    public static readonly PlacementRight MinusRight_11 = new("-right-11", 53);
    public static readonly PlacementRight MinusRight_12 = new("-right-12", 54);
    public static readonly PlacementRight MinusRight_14 = new("-right-14", 55);
    public static readonly PlacementRight MinusRight_16 = new("-right-16", 56);
    public static readonly PlacementRight MinusRight_2 = new("-right-2", 57);
    public static readonly PlacementRight MinusRight_2v5 = new("-right-2.5", 58);
    public static readonly PlacementRight MinusRight_2d3 = new("-right-2/3", 59);
    public static readonly PlacementRight MinusRight_2d4 = new("-right-2/4", 60);
    public static readonly PlacementRight MinusRight_20 = new("-right-20", 61);
    public static readonly PlacementRight MinusRight_24 = new("-right-24", 62);
    public static readonly PlacementRight MinusRight_28 = new("-right-28", 63);
    public static readonly PlacementRight MinusRight_3 = new("-right-3", 64);
    public static readonly PlacementRight MinusRight_3v5 = new("-right-3.5", 65);
    public static readonly PlacementRight MinusRight_3d4 = new("-right-3/4", 66);
    public static readonly PlacementRight MinusRight_32 = new("-right-32", 67);
    public static readonly PlacementRight MinusRight_36 = new("-right-36", 68);
    public static readonly PlacementRight MinusRight_4 = new("-right-4", 69);
    public static readonly PlacementRight MinusRight_40 = new("-right-40", 70);
    public static readonly PlacementRight MinusRight_44 = new("-right-44", 71);
    public static readonly PlacementRight MinusRight_48 = new("-right-48", 72);
    public static readonly PlacementRight MinusRight_5 = new("-right-5", 73);
    public static readonly PlacementRight MinusRight_52 = new("-right-52", 74);
    public static readonly PlacementRight MinusRight_56 = new("-right-56", 75);
    public static readonly PlacementRight MinusRight_6 = new("-right-6", 76);
    public static readonly PlacementRight MinusRight_60 = new("-right-60", 77);
    public static readonly PlacementRight MinusRight_64 = new("-right-64", 78);
    public static readonly PlacementRight MinusRight_7 = new("-right-7", 79);
    public static readonly PlacementRight MinusRight_72 = new("-right-72", 80);
    public static readonly PlacementRight MinusRight_8 = new("-right-8", 81);
    public static readonly PlacementRight MinusRight_80 = new("-right-80", 82);
    public static readonly PlacementRight MinusRight_9 = new("-right-9", 83);
    public static readonly PlacementRight MinusRight_96 = new("-right-96", 84);
    public static readonly PlacementRight MinusRight_Full = new("-right-full", 85);
    public static readonly PlacementRight MinusRight_Px = new("-right-px", 86);

    private PlacementRight(string name, int value) : base(name, value) { }
}
