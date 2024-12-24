using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Maurosoft.Blazor.Tailwind.Core.Css.Properties.Spacing;

/// <summary>
/// Utilities for controlling the space between child elements.
/// For info, see <see href="https://tailwindcss.com/docs/space">space</see>
/// </summary>
public sealed class SpaceBetween : TailwindCssClassBase
{
    public static readonly SpaceBetween NotSet = new("notset", 1);
    public static readonly SpaceBetween X_0 = new("space-x-0", 2);
    public static readonly SpaceBetween Y_0 = new("space-y-0", 3);
    public static readonly SpaceBetween X_0d5 = new("space-x-0.5", 4);
    public static readonly SpaceBetween Y_0d5 = new("space-y-0.5", 5);
    public static readonly SpaceBetween X_1 = new("space-x-1", 6);
    public static readonly SpaceBetween Y_1 = new("space-y-1", 7);
    public static readonly SpaceBetween X_1d5 = new("space-x-1.5", 8);
    public static readonly SpaceBetween Y_1d5 = new("space-y-1.5", 9);
    public static readonly SpaceBetween X_2 = new("space-x-2", 10);
    public static readonly SpaceBetween Y_2 = new("space-y-2", 11);
    public static readonly SpaceBetween X_2d5 = new("space-x-2.5", 12);
    public static readonly SpaceBetween Y_2d5 = new("space-y-2.5", 13);
    public static readonly SpaceBetween X_3 = new("space-x-3", 14);
    public static readonly SpaceBetween Y_3 = new("space-y-3", 15);
    public static readonly SpaceBetween X_3d5 = new("space-x-3.5", 16);
    public static readonly SpaceBetween Y_3d5 = new("space-y-3.5", 17);
    public static readonly SpaceBetween X_4 = new("space-x-4", 18);
    public static readonly SpaceBetween Y_4 = new("space-y-4", 19);
    public static readonly SpaceBetween X_5 = new("space-x-5", 20);
    public static readonly SpaceBetween Y_5 = new("space-y-5", 21);
    public static readonly SpaceBetween X_6 = new("space-x-6", 22);
    public static readonly SpaceBetween Y_6 = new("space-y-6", 23);
    public static readonly SpaceBetween X_7 = new("space-x-7", 24);
    public static readonly SpaceBetween Y_7 = new("space-y-7", 25);
    public static readonly SpaceBetween X_8 = new("space-x-8", 26);
    public static readonly SpaceBetween Y_8 = new("space-y-8", 27);
    public static readonly SpaceBetween X_9 = new("space-x-9", 28);
    public static readonly SpaceBetween Y_9 = new("space-y-9", 29);
    public static readonly SpaceBetween X_10 = new("space-x-10", 30);
    public static readonly SpaceBetween Y_10 = new("space-y-10", 31);
    public static readonly SpaceBetween X_11 = new("space-x-11", 32);
    public static readonly SpaceBetween Y_11 = new("space-y-11", 33);
    public static readonly SpaceBetween X_12 = new("space-x-12", 34);
    public static readonly SpaceBetween Y_12 = new("space-y-12", 35);
    public static readonly SpaceBetween X_14 = new("space-x-14", 36);
    public static readonly SpaceBetween Y_14 = new("space-y-14", 37);
    public static readonly SpaceBetween X_16 = new("space-x-16", 38);
    public static readonly SpaceBetween Y_16 = new("space-y-16", 39);
    public static readonly SpaceBetween X_20 = new("space-x-20", 40);
    public static readonly SpaceBetween Y_20 = new("space-y-20", 41);
    public static readonly SpaceBetween X_24 = new("space-x-24", 42);
    public static readonly SpaceBetween Y_24 = new("space-y-24", 43);
    public static readonly SpaceBetween X_28 = new("space-x-28", 44);
    public static readonly SpaceBetween Y_28 = new("space-y-28", 45);
    public static readonly SpaceBetween X_32 = new("space-x-32", 46);
    public static readonly SpaceBetween Y_32 = new("space-y-32", 47);
    public static readonly SpaceBetween X_36 = new("space-x-36", 48);
    public static readonly SpaceBetween Y_36 = new("space-y-36", 49);
    public static readonly SpaceBetween X_40 = new("space-x-40", 50);
    public static readonly SpaceBetween Y_40 = new("space-y-40", 51);
    public static readonly SpaceBetween X_44 = new("space-x-44", 52);
    public static readonly SpaceBetween Y_44 = new("space-y-44", 53);
    public static readonly SpaceBetween X_48 = new("space-x-48", 54);
    public static readonly SpaceBetween Y_48 = new("space-y-48", 55);
    public static readonly SpaceBetween X_52 = new("space-x-52", 56);
    public static readonly SpaceBetween Y_52 = new("space-y-52", 57);
    public static readonly SpaceBetween X_56 = new("space-x-56", 58);
    public static readonly SpaceBetween Y_56 = new("space-y-56", 59);
    public static readonly SpaceBetween X_60 = new("space-x-60", 60);
    public static readonly SpaceBetween Y_60 = new("space-y-60", 61);
    public static readonly SpaceBetween X_64 = new("space-x-64", 62);
    public static readonly SpaceBetween Y_64 = new("space-y-64", 63);
    public static readonly SpaceBetween X_72 = new("space-x-72", 64);
    public static readonly SpaceBetween Y_72 = new("space-y-72", 65);
    public static readonly SpaceBetween X_80 = new("space-x-80", 66);
    public static readonly SpaceBetween Y_80 = new("space-y-80", 67);
    public static readonly SpaceBetween X_88 = new("space-x-88", 68);
    public static readonly SpaceBetween Y_88 = new("space-y-88", 69);
    public static readonly SpaceBetween X_96 = new("space-x-96", 70);
    public static readonly SpaceBetween Y_96 = new("space-y-96", 71);
    public static readonly SpaceBetween X = new("space-x-px", 72);
    public static readonly SpaceBetween Y = new("space-y-px", 73);
    public static readonly SpaceBetween X_Reverse = new("space-x-reverse", 74);
    public static readonly SpaceBetween Y_Reverse = new("space-y-reverse", 75);

    private SpaceBetween(string name, int value) : base(name, value) { }
}
