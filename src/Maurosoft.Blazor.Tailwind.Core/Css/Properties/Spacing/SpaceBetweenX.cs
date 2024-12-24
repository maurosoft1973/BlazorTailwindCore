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
public sealed class SpaceBetweenX : TailwindCssClassBase
{
    public static readonly SpaceBetweenX NotSet = new("notset", 0);
    public static readonly SpaceBetweenX X_0 = new("space-x-0", 1);
    public static readonly SpaceBetweenX X_0d5 = new("space-x-0.5", 2);
    public static readonly SpaceBetweenX X_1 = new("space-x-1", 3);
    public static readonly SpaceBetweenX X_1d5 = new("space-x-1.5", 4);
    public static readonly SpaceBetweenX X_2 = new("space-x-2", 5);
    public static readonly SpaceBetweenX X_2d5 = new("space-x-2.5", 6);
    public static readonly SpaceBetweenX X_3 = new("space-x-3", 7);
    public static readonly SpaceBetweenX X_3d5 = new("space-x-3.5", 8);
    public static readonly SpaceBetweenX X_4 = new("space-x-4", 9);
    public static readonly SpaceBetweenX X_5 = new("space-x-5", 10);
    public static readonly SpaceBetweenX X_6 = new("space-x-6", 11);
    public static readonly SpaceBetweenX X_7 = new("space-x-7", 12);
    public static readonly SpaceBetweenX X_8 = new("space-x-8", 13);
    public static readonly SpaceBetweenX X_9 = new("space-x-9", 14);
    public static readonly SpaceBetweenX X_10 = new("space-x-10", 15);
    public static readonly SpaceBetweenX X_11 = new("space-x-11", 16);
    public static readonly SpaceBetweenX X_12 = new("space-x-12", 17);
    public static readonly SpaceBetweenX X_14 = new("space-x-14", 18);
    public static readonly SpaceBetweenX X_16 = new("space-x-16", 19);
    public static readonly SpaceBetweenX X_20 = new("space-x-20", 20);
    public static readonly SpaceBetweenX X_24 = new("space-x-24", 21);
    public static readonly SpaceBetweenX X_28 = new("space-x-28", 22);
    public static readonly SpaceBetweenX X_32 = new("space-x-32", 23);
    public static readonly SpaceBetweenX X_36 = new("space-x-36", 24);
    public static readonly SpaceBetweenX X_40 = new("space-x-40", 25);
    public static readonly SpaceBetweenX X_44 = new("space-x-44", 26);
    public static readonly SpaceBetweenX X_48 = new("space-x-48", 27);
    public static readonly SpaceBetweenX X_52 = new("space-x-52", 28);
    public static readonly SpaceBetweenX X_56 = new("space-x-56", 29);
    public static readonly SpaceBetweenX X_60 = new("space-x-60", 30);
    public static readonly SpaceBetweenX X_64 = new("space-x-64", 31);
    public static readonly SpaceBetweenX X_72 = new("space-x-72", 32);
    public static readonly SpaceBetweenX X_80 = new("space-x-80", 33);
    public static readonly SpaceBetweenX X_88 = new("space-x-88", 34);
    public static readonly SpaceBetweenX X_96 = new("space-x-96", 35);
    public static readonly SpaceBetweenX X = new("space-x-px", 36);
    public static readonly SpaceBetweenX X_Reverse = new("space-x-reverse", 37);

    private SpaceBetweenX(string name, int value) : base(name, value) { }
}
