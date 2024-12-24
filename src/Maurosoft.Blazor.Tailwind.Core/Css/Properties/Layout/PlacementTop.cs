using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Maurosoft.Blazor.Tailwind.Core.Css.Properties.Layout;

/// <summary>
/// Utilities for controlling the top placement of positioned elements.
/// For info, see <see href="https://tailwindcss.com/docs/top-right-bottom-left">top</see>
/// </summary>
public sealed class PlacementTop : TailwindCssClassBase
{
    public static readonly PlacementTop NotSet = new("notset", 1);
    public static readonly PlacementTop Top_0 = new("top-0", 2);
    public static readonly PlacementTop Top_0v5 = new("top-0.5", 3);
    public static readonly PlacementTop Top_1 = new("top-1", 4);
    public static readonly PlacementTop Top_1v5 = new("top-1.5", 5);
    public static readonly PlacementTop Top_1d2 = new("top-1/2", 6);
    public static readonly PlacementTop Top_1d3 = new("top-1/3", 7);
    public static readonly PlacementTop Top_1d4 = new("top-1/4", 8);
    public static readonly PlacementTop Top_10 = new("top-10", 9);
    public static readonly PlacementTop Top_11 = new("top-11", 10);
    public static readonly PlacementTop Top_12 = new("top-12", 11);
    public static readonly PlacementTop Top_14 = new("top-14", 12);
    public static readonly PlacementTop Top_16 = new("top-16", 13);
    public static readonly PlacementTop Top_2 = new("top-2", 14);
    public static readonly PlacementTop Top_2v5 = new("top-2.5", 15);
    public static readonly PlacementTop Top_2d3 = new("top-2/3", 16);
    public static readonly PlacementTop Top_2d4 = new("top-2/4", 17);
    public static readonly PlacementTop Top_20 = new("top-20", 18);
    public static readonly PlacementTop Top_24 = new("top-24", 19);
    public static readonly PlacementTop Top_28 = new("top-28", 20);
    public static readonly PlacementTop Top_3 = new("top-3", 21);
    public static readonly PlacementTop Top_3v5 = new("top-3.5", 22);
    public static readonly PlacementTop Top_3d4 = new("top-3/4", 23);
    public static readonly PlacementTop Top_32 = new("top-32", 24);
    public static readonly PlacementTop Top_36 = new("top-36", 25);
    public static readonly PlacementTop Top_4 = new("top-4", 26);
    public static readonly PlacementTop Top_40 = new("top-40", 27);
    public static readonly PlacementTop Top_44 = new("top-44", 28);
    public static readonly PlacementTop Top_48 = new("top-48", 29);
    public static readonly PlacementTop Top_5 = new("top-5", 30);
    public static readonly PlacementTop Top_52 = new("top-52", 31);
    public static readonly PlacementTop Top_56 = new("top-56", 32);
    public static readonly PlacementTop Top_6 = new("top-6", 33);
    public static readonly PlacementTop Top_60 = new("top-60", 34);
    public static readonly PlacementTop Top_64 = new("top-64", 35);
    public static readonly PlacementTop Top_7 = new("top-7", 36);
    public static readonly PlacementTop Top_72 = new("top-72", 37);
    public static readonly PlacementTop Top_8 = new("top-8", 38);
    public static readonly PlacementTop Top_80 = new("top-80", 39);
    public static readonly PlacementTop Top_9 = new("top-9", 40);
    public static readonly PlacementTop Top_96 = new("top-96", 41);
    public static readonly PlacementTop Top_Auto = new("top-auto", 42);
    public static readonly PlacementTop Top_Full = new("top-full", 43);
    public static readonly PlacementTop Top_Px = new("top-px", 44);
    public static readonly PlacementTop MinusTop_0 = new("-top-0", 45);
    public static readonly PlacementTop MinusTop_0v5 = new("-top-0.5", 46);
    public static readonly PlacementTop MinusTop_1 = new("-top-1", 47);
    public static readonly PlacementTop MinusTop_1v5 = new("-top-1.5", 48);
    public static readonly PlacementTop MinusTop_1d2 = new("-top-1/2", 49);
    public static readonly PlacementTop MinusTop_1d3 = new("-top-1/3", 50);
    public static readonly PlacementTop MinusTop_1d4 = new("-top-1/4", 51);
    public static readonly PlacementTop MinusTop_10 = new("-top-10", 52);
    public static readonly PlacementTop MinusTop_11 = new("-top-11", 53);
    public static readonly PlacementTop MinusTop_12 = new("-top-12", 54);
    public static readonly PlacementTop MinusTop_14 = new("-top-14", 55);
    public static readonly PlacementTop MinusTop_16 = new("-top-16", 56);
    public static readonly PlacementTop MinusTop_2 = new("-top-2", 57);
    public static readonly PlacementTop MinusTop_2v5 = new("-top-2.5", 58);
    public static readonly PlacementTop MinusTop_2d3 = new("-top-2/3", 59);
    public static readonly PlacementTop MinusTop_2d4 = new("-top-2/4", 60);
    public static readonly PlacementTop MinusTop_20 = new("-top-20", 61);
    public static readonly PlacementTop MinusTop_24 = new("-top-24", 62);
    public static readonly PlacementTop MinusTop_28 = new("-top-28", 63);
    public static readonly PlacementTop MinusTop_3 = new("-top-3", 64);
    public static readonly PlacementTop MinusTop_3v5 = new("-top-3.5", 65);
    public static readonly PlacementTop MinusTop_3d4 = new("-top-3/4", 66);
    public static readonly PlacementTop MinusTop_32 = new("-top-32", 67);
    public static readonly PlacementTop MinusTop_36 = new("-top-36", 68);
    public static readonly PlacementTop MinusTop_4 = new("-top-4", 69);
    public static readonly PlacementTop MinusTop_40 = new("-top-40", 70);
    public static readonly PlacementTop MinusTop_44 = new("-top-44", 71);
    public static readonly PlacementTop MinusTop_48 = new("-top-48", 72);
    public static readonly PlacementTop MinusTop_5 = new("-top-5", 73);
    public static readonly PlacementTop MinusTop_52 = new("-top-52", 74);
    public static readonly PlacementTop MinusTop_56 = new("-top-56", 75);
    public static readonly PlacementTop MinusTop_6 = new("-top-6", 76);
    public static readonly PlacementTop MinusTop_60 = new("-top-60", 77);
    public static readonly PlacementTop MinusTop_64 = new("-top-64", 78);
    public static readonly PlacementTop MinusTop_7 = new("-top-7", 79);
    public static readonly PlacementTop MinusTop_72 = new("-top-72", 80);
    public static readonly PlacementTop MinusTop_8 = new("-top-8", 81);
    public static readonly PlacementTop MinusTop_80 = new("-top-80", 82);
    public static readonly PlacementTop MinusTop_9 = new("-top-9", 83);
    public static readonly PlacementTop MinusTop_96 = new("-top-96", 84);
    public static readonly PlacementTop MinusTop_Full = new("-top-full", 85);
    public static readonly PlacementTop MinusTop_Px = new("-top-px", 86);

    private PlacementTop(string name, int value) : base(name, value) { }
}
