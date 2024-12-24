using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Maurosoft.Blazor.Tailwind.Core.Css.Properties.Sizing;

/// <summary>
/// Utilities for setting the width of an element.
/// For info, see <see href="https://tailwindcss.com/docs/width">width</see>
/// </summary>
public sealed class Width : TailwindCssClassBase
{
    public static readonly Width NotSet = new("notset", 1);
    public static readonly Width W_0 = new("w-0", 2);
    public static readonly Width W_px = new("w-px", 3);
    public static readonly Width W_0v5 = new("w-0v5", 4);
    public static readonly Width W_1 = new("w-1", 5);
    public static readonly Width W_1v5 = new("w-1v5", 6);
    public static readonly Width W_2 = new("w-2", 7);
    public static readonly Width W_2v5 = new("w-2v5", 8);
    public static readonly Width W_3 = new("w-3", 9);
    public static readonly Width W_3v5 = new("w-3v5", 10);
    public static readonly Width W_4 = new("w-4", 11);
    public static readonly Width W_5 = new("w-5", 12);
    public static readonly Width W_6 = new("w-6", 13);
    public static readonly Width W_7 = new("w-7", 14);
    public static readonly Width W_8 = new("w-8", 15);
    public static readonly Width W_9 = new("w-9", 16);
    public static readonly Width W_10 = new("w-10", 17);
    public static readonly Width W_11 = new("w-11", 18);
    public static readonly Width W_12 = new("w-12", 19);
    public static readonly Width W_14 = new("w-14", 20);
    public static readonly Width W_16 = new("w-16", 21);
    public static readonly Width W_20 = new("w-20", 22);
    public static readonly Width W_24 = new("w-24", 23);
    public static readonly Width W_28 = new("w-28", 24);
    public static readonly Width W_32 = new("w-32", 25);
    public static readonly Width W_36 = new("w-36", 26);
    public static readonly Width W_40 = new("w-40", 27);
    public static readonly Width W_44 = new("w-44", 28);
    public static readonly Width W_48 = new("w-48", 29);
    public static readonly Width W_52 = new("w-52", 30);
    public static readonly Width W_56 = new("w-56", 31);
    public static readonly Width W_60 = new("w-60", 32);
    public static readonly Width W_64 = new("w-64", 33);
    public static readonly Width W_72 = new("w-72", 34);
    public static readonly Width W_80 = new("w-80", 35);
    public static readonly Width W_96 = new("w-96", 36);
    public static readonly Width W_auto = new("w-auto", 37);
    public static readonly Width W_1d2 = new("w-1d2", 38);
    public static readonly Width W_1d3 = new("w-1d3", 39);
    public static readonly Width W_2d3 = new("w-2d3", 40);
    public static readonly Width W_1d4 = new("w-1d4", 41);
    public static readonly Width W_2d4 = new("w-2d4", 42);
    public static readonly Width W_3d4 = new("w-3d4", 43);
    public static readonly Width W_1d5 = new("w-1d5", 44);
    public static readonly Width W_2d5 = new("w-2d5", 45);
    public static readonly Width W_3d5 = new("w-3d5", 46);
    public static readonly Width W_4d5 = new("w-4d5", 47);
    public static readonly Width W_1d6 = new("w-1d6", 48);
    public static readonly Width W_2d6 = new("w-2d6", 49);
    public static readonly Width W_3d6 = new("w-3d6", 50);
    public static readonly Width W_4d6 = new("w-4d6", 51);
    public static readonly Width W_5d6 = new("w-5d6", 52);
    public static readonly Width W_1d12 = new("w-1d12", 53);
    public static readonly Width W_2d12 = new("w-2d12", 54);
    public static readonly Width W_3d12 = new("w-3d12", 55);
    public static readonly Width W_4d12 = new("w-4d12", 56);
    public static readonly Width W_5d12 = new("w-5d12", 57);
    public static readonly Width W_6d12 = new("w-6d12", 58);
    public static readonly Width W_7d12 = new("w-7d12", 59);
    public static readonly Width W_8d12 = new("w-8d12", 60);
    public static readonly Width W_9d12 = new("w-9d12", 61);
    public static readonly Width W_10d12 = new("w-10d12", 62);
    public static readonly Width W_11d12 = new("w-11d12", 63);
    public static readonly Width W_Full = new("w-full", 64);
    public static readonly Width W_Screen = new("w-screen", 65);
    public static readonly Width W_Svw = new("w-svw", 66);
    public static readonly Width W_Lvw = new("w-lvw", 67);
    public static readonly Width W_Dvw = new("w-dvw", 68);
    public static readonly Width W_Min = new("w-min", 69);
    public static readonly Width W_Max = new("w-max", 70);
    public static readonly Width W_Fit = new("w-fit", 71);

    private Width(string name, int value) : base(name, value) { }
}
