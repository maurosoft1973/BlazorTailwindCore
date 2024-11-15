using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;


namespace Maurosoft.Blazor.Tailwind.Core.Css;

/// <summary>
/// Utilities for controlling gutters between grid and flexbox items.
/// </summary>
public sealed class Gap : TailwindCssClassBase
{
    public static readonly Gap NotSet = new("notset", 1);
    public static readonly Gap Gap_0 = new("gap-0", 2);
    public static readonly Gap Gap_X0 = new("gap-x-0", 3);
    public static readonly Gap Gap_Y0 = new("gap-y-0", 4);
    public static readonly Gap Gap_Px = new("gap-px", 5);
    public static readonly Gap Gap_X_Px = new("gap-x-px", 6);
    public static readonly Gap Gap_Y_Px = new("gap-y-px", 7);
    public static readonly Gap Gap_0_5 = new("gap-0.5", 8);
    public static readonly Gap Gap_X0_5 = new("gap-x-0.5", 9);
    public static readonly Gap Gap_Y0_5 = new("gap-y-0.5", 10);
    public static readonly Gap Gap_1 = new("gap-1", 11);
    public static readonly Gap Gap_X1 = new("gap-x-1", 12);
    public static readonly Gap Gap_Y1 = new("gap-y-1", 13);
    public static readonly Gap Gap_2 = new("gap-2", 14);
    public static readonly Gap Gap_X2 = new("gap-x-2", 15);
    public static readonly Gap Gap_Y2 = new("gap-y-2", 16);
    public static readonly Gap Gap_3 = new("gap-3", 17);
    public static readonly Gap Gap_X3 = new("gap-x-3", 18);
    public static readonly Gap Gap_Y3 = new("gap-y-3", 19);
    public static readonly Gap Gap_4 = new("gap-4", 20);
    public static readonly Gap Gap_X4 = new("gap-x-4", 21);
    public static readonly Gap Gap_Y4 = new("gap-y-4", 22);
    public static readonly Gap Gap_5 = new("gap-5", 23);
    public static readonly Gap Gap_X5 = new("gap-x-5", 24);
    public static readonly Gap Gap_Y5 = new("gap-y-5", 25);
    public static readonly Gap Gap_6 = new("gap-6", 26);
    public static readonly Gap Gap_X6 = new("gap-x-6", 27);
    public static readonly Gap Gap_Y6 = new("gap-y-6", 28);
    public static readonly Gap Gap_7 = new("gap-7", 29);
    public static readonly Gap Gap_X7 = new("gap-x-7", 30);
    public static readonly Gap Gap_Y7 = new("gap-y-7", 31);
    public static readonly Gap Gap_8 = new("gap-8", 32);
    public static readonly Gap Gap_X8 = new("gap-x-8", 33);
    public static readonly Gap Gap_Y8 = new("gap-y-8", 34);
    public static readonly Gap Gap_9 = new("gap-9", 32);
    public static readonly Gap Gap_X9 = new("gap-x-9", 33);
    public static readonly Gap Gap_Y9 = new("gap-y-9", 34);
    public static readonly Gap Gap_10 = new("gap-10", 35);
    public static readonly Gap Gap_X10 = new("gap-x-10", 36);
    public static readonly Gap Gap_Y10 = new("gap-y-10", 37);

    private Gap(string name, int value) : base(name, value) { }
}
