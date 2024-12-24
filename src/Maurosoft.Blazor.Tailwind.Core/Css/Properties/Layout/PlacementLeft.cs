using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Maurosoft.Blazor.Tailwind.Core.Css.Properties.Layout;

/// <summary>
/// Utilities for controlling the left placement of positioned elements.
/// For info, see <see href="https://tailwindcss.com/docs/top-right-bottom-left">left</see>
/// </summary>
public sealed class PlacementLeft : TailwindCssClassBase
{
    public static readonly PlacementLeft NotSet = new("notset", 1);
    public static readonly PlacementLeft Left_0 = new("left-0", 2);
    public static readonly PlacementLeft Left_0v5 = new("left-0.5", 3);
    public static readonly PlacementLeft Left_1 = new("left-1", 4);
    public static readonly PlacementLeft Left_1v5 = new("left-1.5", 5);
    public static readonly PlacementLeft Left_1d2 = new("left-1/2", 6);
    public static readonly PlacementLeft Left_1d3 = new("left-1/3", 7);
    public static readonly PlacementLeft Left_1d4 = new("left-1/4", 8);
    public static readonly PlacementLeft Left_10 = new("left-10", 9);
    public static readonly PlacementLeft Left_11 = new("left-11", 10);
    public static readonly PlacementLeft Left_12 = new("left-12", 11);
    public static readonly PlacementLeft Left_14 = new("left-14", 12);
    public static readonly PlacementLeft Left_16 = new("left-16", 13);
    public static readonly PlacementLeft Left_2 = new("left-2", 14);
    public static readonly PlacementLeft Left_2v5 = new("left-2.5", 15);
    public static readonly PlacementLeft Left_2d3 = new("left-2/3", 16);
    public static readonly PlacementLeft Left_2d4 = new("left-2/4", 17);
    public static readonly PlacementLeft Left_20 = new("left-20", 18);
    public static readonly PlacementLeft Left_24 = new("left-24", 19);
    public static readonly PlacementLeft Left_28 = new("left-28", 20);
    public static readonly PlacementLeft Left_3 = new("left-3", 21);
    public static readonly PlacementLeft Left_3v5 = new("left-3.5", 22);
    public static readonly PlacementLeft Left_3d4 = new("left-3/4", 23);
    public static readonly PlacementLeft Left_32 = new("left-32", 24);
    public static readonly PlacementLeft Left_36 = new("left-36", 25);
    public static readonly PlacementLeft Left_4 = new("left-4", 26);
    public static readonly PlacementLeft Left_40 = new("left-40", 27);
    public static readonly PlacementLeft Left_44 = new("left-44", 28);
    public static readonly PlacementLeft Left_48 = new("left-48", 29);
    public static readonly PlacementLeft Left_5 = new("left-5", 30);
    public static readonly PlacementLeft Left_52 = new("left-52", 31);
    public static readonly PlacementLeft Left_56 = new("left-56", 32);
    public static readonly PlacementLeft Left_6 = new("left-6", 33);
    public static readonly PlacementLeft Left_60 = new("left-60", 34);
    public static readonly PlacementLeft Left_64 = new("left-64", 35);
    public static readonly PlacementLeft Left_7 = new("left-7", 36);
    public static readonly PlacementLeft Left_72 = new("left-72", 37);
    public static readonly PlacementLeft Left_8 = new("left-8", 38);
    public static readonly PlacementLeft Left_80 = new("left-80", 39);
    public static readonly PlacementLeft Left_9 = new("left-9", 40);
    public static readonly PlacementLeft Left_96 = new("left-96", 41);
    public static readonly PlacementLeft Left_Auto = new("left-auto", 42);
    public static readonly PlacementLeft Left_Full = new("left-full", 43);
    public static readonly PlacementLeft Left_Px = new("left-px", 44);
    public static readonly PlacementLeft MinusLeft_0 = new("-left-0", 45);
    public static readonly PlacementLeft MinusLeft_0v5 = new("-left-0.5", 46);
    public static readonly PlacementLeft MinusLeft_1 = new("-left-1", 47);
    public static readonly PlacementLeft MinusLeft_1v5 = new("-left-1.5", 48);
    public static readonly PlacementLeft MinusLeft_1d2 = new("-left-1/2", 49);
    public static readonly PlacementLeft MinusLeft_1d3 = new("-left-1/3", 50);
    public static readonly PlacementLeft MinusLeft_1d4 = new("-left-1/4", 51);
    public static readonly PlacementLeft MinusLeft_10 = new("-left-10", 52);
    public static readonly PlacementLeft MinusLeft_11 = new("-left-11", 53);
    public static readonly PlacementLeft MinusLeft_12 = new("-left-12", 54);
    public static readonly PlacementLeft MinusLeft_14 = new("-left-14", 55);
    public static readonly PlacementLeft MinusLeft_16 = new("-left-16", 56);
    public static readonly PlacementLeft MinusLeft_2 = new("-left-2", 57);
    public static readonly PlacementLeft MinusLeft_2v5 = new("-left-2.5", 58);
    public static readonly PlacementLeft MinusLeft_2d3 = new("-left-2/3", 59);
    public static readonly PlacementLeft MinusLeft_2d4 = new("-left-2/4", 60);
    public static readonly PlacementLeft MinusLeft_20 = new("-left-20", 61);
    public static readonly PlacementLeft MinusLeft_24 = new("-left-24", 62);
    public static readonly PlacementLeft MinusLeft_28 = new("-left-28", 63);
    public static readonly PlacementLeft MinusLeft_3 = new("-left-3", 64);
    public static readonly PlacementLeft MinusLeft_3v5 = new("-left-3.5", 65);
    public static readonly PlacementLeft MinusLeft_3d4 = new("-left-3/4", 66);
    public static readonly PlacementLeft MinusLeft_32 = new("-left-32", 67);
    public static readonly PlacementLeft MinusLeft_36 = new("-left-36", 68);
    public static readonly PlacementLeft MinusLeft_4 = new("-left-4", 69);
    public static readonly PlacementLeft MinusLeft_40 = new("-left-40", 70);
    public static readonly PlacementLeft MinusLeft_44 = new("-left-44", 71);
    public static readonly PlacementLeft MinusLeft_48 = new("-left-48", 72);
    public static readonly PlacementLeft MinusLeft_5 = new("-left-5", 73);
    public static readonly PlacementLeft MinusLeft_52 = new("-left-52", 74);
    public static readonly PlacementLeft MinusLeft_56 = new("-left-56", 75);
    public static readonly PlacementLeft MinusLeft_6 = new("-left-6", 76);
    public static readonly PlacementLeft MinusLeft_60 = new("-left-60", 77);
    public static readonly PlacementLeft MinusLeft_64 = new("-left-64", 78);
    public static readonly PlacementLeft MinusLeft_7 = new("-left-7", 79);
    public static readonly PlacementLeft MinusLeft_72 = new("-left-72", 80);
    public static readonly PlacementLeft MinusLeft_8 = new("-left-8", 81);
    public static readonly PlacementLeft MinusLeft_80 = new("-left-80", 82);
    public static readonly PlacementLeft MinusLeft_9 = new("-left-9", 83);
    public static readonly PlacementLeft MinusLeft_96 = new("-left-96", 84);
    public static readonly PlacementLeft MinusLeft_Full = new("-left-full", 85);
    public static readonly PlacementLeft MinusLeft_Px = new("-left-px", 86);

    private PlacementLeft(string name, int value) : base(name, value) { }
}
