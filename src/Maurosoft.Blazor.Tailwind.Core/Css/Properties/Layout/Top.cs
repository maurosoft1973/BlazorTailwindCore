using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Maurosoft.Blazor.Tailwind.Core.Css.Properties.Layout;

/// <summary>
/// Utilities for controlling the top placement of positioned elements.
/// For info, see <see href="https://tailwindcss.com/docs/top-right-top-left">top</see>
/// </summary>
public sealed class Top : TailwindCssClassBase
{
    public static readonly Top NotSet = new("notset", 1);
    public static readonly Top Top_0 = new("top-0", 2);
    public static readonly Top Top_0v5 = new("top-0.5", 3);
    public static readonly Top Top_1 = new("top-1", 4);
    public static readonly Top Top_1v5 = new("top-1.5", 5);
    public static readonly Top Top_1d2 = new("top-1/2", 6);
    public static readonly Top Top_1d3 = new("top-1/3", 7);
    public static readonly Top Top_1d4 = new("top-1/4", 8);
    public static readonly Top Top_2 = new("top-2", 9);
    public static readonly Top Top_2v5 = new("top-2.5", 10);
    public static readonly Top Top_2d3 = new("top-2/3", 11);
    public static readonly Top Top_2d4 = new("top-2/4", 12);
    public static readonly Top Top_3 = new("top-3", 13);
    public static readonly Top Top_3v5 = new("top-3.5", 14);
    public static readonly Top Top_3d4 = new("top-3/4", 15);
    public static readonly Top Top_4 = new("top-4", 16);
    public static readonly Top Top_5 = new("top-5", 17);
    public static readonly Top Top_6 = new("top-6", 18);
    public static readonly Top Top_7 = new("top-7", 19);
    public static readonly Top Top_8 = new("top-8", 20);
    public static readonly Top Top_9 = new("top-9", 21);
    public static readonly Top Top_10 = new("top-10", 21);
    public static readonly Top Top_11 = new("top-11", 22);
    public static readonly Top Top_12 = new("top-12", 23);
    public static readonly Top Top_14 = new("top-14", 24);
    public static readonly Top Top_16 = new("top-16", 25);
    public static readonly Top Top_20 = new("top-20", 26);
    public static readonly Top Top_24 = new("top-24", 27);
    public static readonly Top Top_28 = new("top-28", 28);
    public static readonly Top Top_32 = new("top-32", 29);
    public static readonly Top Top_36 = new("top-36", 30);
    public static readonly Top Top_40 = new("top-40", 31);
    public static readonly Top Top_44 = new("top-44", 32);
    public static readonly Top Top_48 = new("top-48", 33);
    public static readonly Top Top_52 = new("top-52", 34);
    public static readonly Top Top_56 = new("top-56", 35);
    public static readonly Top Top_60 = new("top-60", 36);
    public static readonly Top Top_64 = new("top-64", 37);
    public static readonly Top Top_80 = new("top-80", 38);
    public static readonly Top Top_72 = new("top-72", 39);
    public static readonly Top Top_96 = new("top-96", 40);
    public static readonly Top Top_Auto = new("top-auto", 41);
    public static readonly Top Top_Full = new("top-full", 42);
    public static readonly Top Top_Px = new("top-px", 43);
    public static readonly Top MinusTop_0 = new("-top-0", 44);
    public static readonly Top MinusTop_0v5 = new("-top-0.5", 45);
    public static readonly Top MinusTop_1 = new("-top-1", 46);
    public static readonly Top MinusTop_1v5 = new("-top-1.5", 47);
    public static readonly Top MinusTop_1d2 = new("-top-1/2", 48);
    public static readonly Top MinusTop_1d3 = new("-top-1/3", 49);
    public static readonly Top MinusTop_1d4 = new("-top-1/4", 50);
    public static readonly Top MinusTop_2 = new("-top-2", 51);
    public static readonly Top MinusTop_2v5 = new("-top-2.5", 52);
    public static readonly Top MinusTop_2d3 = new("-top-2/3", 53);
    public static readonly Top MinusTop_2d4 = new("-top-2/4", 54);
    public static readonly Top MinusTop_3 = new("-top-3", 55);
    public static readonly Top MinusTop_3v5 = new("-top-3.5", 56);
    public static readonly Top MinusTop_3d4 = new("-top-3/4", 57);
    public static readonly Top MinusTop_4 = new("-top-4", 58);
    public static readonly Top MinusTop_5 = new("-top-5", 59);
    public static readonly Top MinusTop_6 = new("-top-6", 60);
    public static readonly Top MinusTop_7 = new("-top-7", 61);
    public static readonly Top MinusTop_8 = new("-top-8", 62);
    public static readonly Top MinusTop_9 = new("-top-9", 63);
    public static readonly Top MinusTop_10 = new("-top-10", 64);
    public static readonly Top MinusTop_11 = new("-top-11", 65);
    public static readonly Top MinusTop_12 = new("-top-12", 66);
    public static readonly Top MinusTop_14 = new("-top-14", 67);
    public static readonly Top MinusTop_16 = new("-top-16", 68);
    public static readonly Top MinusTop_20 = new("-top-20", 69);
    public static readonly Top MinusTop_24 = new("-top-24", 70);
    public static readonly Top MinusTop_28 = new("-top-28", 71);
    public static readonly Top MinusTop_32 = new("-top-32", 72);
    public static readonly Top MinusTop_36 = new("-top-36", 73);
    public static readonly Top MinusTop_40 = new("-top-40", 74);
    public static readonly Top MinusTop_44 = new("-top-44", 75);
    public static readonly Top MinusTop_48 = new("-top-48", 76);
    public static readonly Top MinusTop_52 = new("-top-52", 77);
    public static readonly Top MinusTop_56 = new("-top-56", 78);
    public static readonly Top MinusTop_60 = new("-top-60", 79);
    public static readonly Top MinusTop_64 = new("-top-64", 80);
    public static readonly Top MinusTop_72 = new("-top-72", 81);
    public static readonly Top MinusTop_80 = new("-top-80", 82);
    public static readonly Top MinusTop_96 = new("-top-96", 83);
    public static readonly Top MinusTop_Full = new("-top-full", 84);
    public static readonly Top MinusTop_Px = new("-top-px", 85);

    private Top(string name, int value) : base(name, value) { }
}
