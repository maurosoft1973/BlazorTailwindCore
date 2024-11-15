using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Maurosoft.Blazor.Tailwind.Core.Css;

/// <summary>
/// Utilities for setting the height of an element.
/// </summary>
public sealed class Height : TailwindCssClassBase
{
    public static readonly Height NotSet = new("notset", 1);
    public static readonly Height H_0 = new("h-0", 2);
    public static readonly Height H_px = new("h-px", 3);
    public static readonly Height H_0v5 = new("h-0v5", 4);
    public static readonly Height H_1 = new("h-1", 5);
    public static readonly Height H_1v5 = new("h-1v5", 6);
    public static readonly Height H_2 = new("h-2", 7);
    public static readonly Height H_2v5 = new("h-2v5", 8);
    public static readonly Height H_3 = new("h-3", 9);
    public static readonly Height H_3v5 = new("h-3v5", 10);
    public static readonly Height H_4 = new("h-4", 11);
    public static readonly Height H_5 = new("h-5", 12);
    public static readonly Height H_6 = new("h-6", 13);
    public static readonly Height H_7 = new("h-7", 14);
    public static readonly Height H_8 = new("h-8", 15);
    public static readonly Height H_9 = new("h-9", 16);
    public static readonly Height H_10 = new("h-10", 17);
    public static readonly Height H_11 = new("h-11", 18);
    public static readonly Height H_12 = new("h-12", 19);
    public static readonly Height H_14 = new("h-14", 20);
    public static readonly Height H_16 = new("h-16", 21);
    public static readonly Height H_20 = new("h-20", 22);
    public static readonly Height H_24 = new("h-24", 23);
    public static readonly Height H_28 = new("h-28", 24);
    public static readonly Height H_32 = new("h-32", 25);
    public static readonly Height H_36 = new("h-36", 26);
    public static readonly Height H_40 = new("h-40", 27);
    public static readonly Height H_44 = new("h-44", 28);
    public static readonly Height H_48 = new("h-48", 29);
    public static readonly Height H_52 = new("h-52", 30);
    public static readonly Height H_56 = new("h-56", 31);
    public static readonly Height H_60 = new("h-60", 32);
    public static readonly Height H_64 = new("h-64", 33);
    public static readonly Height H_72 = new("h-72", 34);
    public static readonly Height H_80 = new("h-80", 35);
    public static readonly Height H_96 = new("h-96", 36);
    public static readonly Height H_auto = new("h-auto", 37);
    public static readonly Height H_1d2 = new("h-1d2", 38);
    public static readonly Height H_1d3 = new("h-1d3", 39);
    public static readonly Height H_2d3 = new("h-2d3", 40);
    public static readonly Height H_1d4 = new("h-1d4", 41);
    public static readonly Height H_2d4 = new("h-2d4", 42);
    public static readonly Height H_3d4 = new("h-3d4", 43);
    public static readonly Height H_1d5 = new("h-1d5", 44);
    public static readonly Height H_2d5 = new("h-2d5", 45);
    public static readonly Height H_3d5 = new("h-3d5", 46);
    public static readonly Height H_4d5 = new("h-4d5", 47);
    public static readonly Height H_1d6 = new("h-1d6", 48);
    public static readonly Height H_2d6 = new("h-2d6", 49);
    public static readonly Height H_3d6 = new("h-3d6", 50);
    public static readonly Height H_4d6 = new("h-4d6", 51);
    public static readonly Height H_5d6 = new("h-5d6", 52);
    public static readonly Height H_1d12 = new("h-1d12", 53);
    public static readonly Height H_2d12 = new("h-2d12", 54);
    public static readonly Height H_3d12 = new("h-3d12", 55);
    public static readonly Height H_4d12 = new("h-4d12", 56);
    public static readonly Height H_5d12 = new("h-5d12", 57);
    public static readonly Height H_6d12 = new("h-6d12", 58);
    public static readonly Height H_7d12 = new("h-7d12", 59);
    public static readonly Height H_8d12 = new("h-8d12", 60);
    public static readonly Height H_9d12 = new("h-9d12", 61);
    public static readonly Height H_10d12 = new("h-10d12", 62);
    public static readonly Height H_11d12 = new("h-11d12", 63);
    public static readonly Height H_Full = new("h-full", 64);
    public static readonly Height H_Screen = new("h-screen", 65);
    public static readonly Height H_Svw = new("h-svw", 66);
    public static readonly Height H_Lvw = new("h-lvw", 67);
    public static readonly Height H_Dvw = new("h-dvw", 68);
    public static readonly Height H_Min = new("h-min", 69);
    public static readonly Height H_Max = new("h-max", 70);
    public static readonly Height H_Fit = new("h-fit", 71);

    private Height(string name, int value) : base(name, value) { }
}