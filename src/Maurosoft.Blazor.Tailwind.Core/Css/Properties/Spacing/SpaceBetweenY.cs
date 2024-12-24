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
public sealed class SpaceBetweenY : TailwindCssClassBase
{
    public static readonly SpaceBetweenY NotSet = new("notset", 0);
    public static readonly SpaceBetweenY Y_0 = new("space-y-0", 1);
    public static readonly SpaceBetweenY Y_0d5 = new("space-y-0.5", 2);
    public static readonly SpaceBetweenY Y_1 = new("space-y-1", 3);
    public static readonly SpaceBetweenY Y_1d5 = new("space-y-1.5", 4);
    public static readonly SpaceBetweenY Y_2 = new("space-y-2", 5);
    public static readonly SpaceBetweenY Y_2d5 = new("space-y-2.5", 6);
    public static readonly SpaceBetweenY Y_3 = new("space-y-3", 7);
    public static readonly SpaceBetweenY Y_3d5 = new("space-y-3.5", 8);
    public static readonly SpaceBetweenY Y_4 = new("space-y-4", 9);
    public static readonly SpaceBetweenY Y_5 = new("space-y-5", 10);
    public static readonly SpaceBetweenY Y_6 = new("space-y-6", 11);
    public static readonly SpaceBetweenY Y_7 = new("space-y-7", 12);
    public static readonly SpaceBetweenY Y_8 = new("space-y-8", 13);
    public static readonly SpaceBetweenY Y_9 = new("space-y-9", 14);
    public static readonly SpaceBetweenY Y_10 = new("space-y-10", 15);
    public static readonly SpaceBetweenY Y_11 = new("space-y-11", 16);
    public static readonly SpaceBetweenY Y_12 = new("space-y-12", 17);
    public static readonly SpaceBetweenY Y_14 = new("space-y-14", 18);
    public static readonly SpaceBetweenY Y_16 = new("space-y-16", 19);
    public static readonly SpaceBetweenY Y_20 = new("space-y-20", 20);
    public static readonly SpaceBetweenY Y_24 = new("space-y-24", 21);
    public static readonly SpaceBetweenY Y_28 = new("space-y-28", 22);
    public static readonly SpaceBetweenY Y_32 = new("space-y-32", 23);
    public static readonly SpaceBetweenY Y_36 = new("space-y-36", 24);
    public static readonly SpaceBetweenY Y_40 = new("space-y-40", 25);
    public static readonly SpaceBetweenY Y_44 = new("space-y-44", 26);
    public static readonly SpaceBetweenY Y_48 = new("space-y-48", 27);
    public static readonly SpaceBetweenY Y_52 = new("space-y-52", 28);
    public static readonly SpaceBetweenY Y_56 = new("space-y-56", 29);
    public static readonly SpaceBetweenY Y_60 = new("space-y-60", 30);
    public static readonly SpaceBetweenY Y_64 = new("space-y-64", 31);
    public static readonly SpaceBetweenY Y_72 = new("space-y-72", 32);
    public static readonly SpaceBetweenY Y_80 = new("space-y-80", 33);
    public static readonly SpaceBetweenY Y_88 = new("space-y-88", 34);
    public static readonly SpaceBetweenY Y_96 = new("space-y-96", 35);
    public static readonly SpaceBetweenY Y = new("space-y-px", 36);
    public static readonly SpaceBetweenY Y_Reverse = new("space-y-reverse", 37);

    private SpaceBetweenY(string name, int value) : base(name, value) { }
}
