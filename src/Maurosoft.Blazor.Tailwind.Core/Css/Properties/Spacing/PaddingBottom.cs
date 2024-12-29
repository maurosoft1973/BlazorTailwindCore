using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Maurosoft.Blazor.Tailwind.Core.Css.Properties.Spacing;

public sealed class PaddingBottom : TailwindCssClassBase
{
    public static readonly PaddingBottom NotSet = new("notset", 1);
    public static readonly PaddingBottom pb_0 = new("pb-0", 2);
    public static readonly PaddingBottom pb_0_5 = new("pb-0-5", 3);
    public static readonly PaddingBottom pb = new("pb-pb", 4);
    public static readonly PaddingBottom pb_1 = new("pb-1", 5);
    public static readonly PaddingBottom pb_1_5 = new("pb-1-5", 6);
    public static readonly PaddingBottom pb_2 = new("pb-2", 7);
    public static readonly PaddingBottom pb_2_5 = new("pb-2-5", 8);
    public static readonly PaddingBottom pb_3 = new("pb-3", 9);
    public static readonly PaddingBottom pb_4 = new("pb-4", 10);
    public static readonly PaddingBottom pb_5 = new("pb-5", 11);
    public static readonly PaddingBottom pb_6 = new("pb-6", 12);
    public static readonly PaddingBottom pb_7 = new("pb-7", 13);
    public static readonly PaddingBottom pb_8 = new("pb-8", 14);
    public static readonly PaddingBottom pb_9 = new("pb-9", 15);
    public static readonly PaddingBottom pb_10 = new("pb-10", 16);
    public static readonly PaddingBottom pb_11 = new("pb-11", 17);
    public static readonly PaddingBottom pb_12 = new("pb-12", 18);
    public static readonly PaddingBottom pb_13 = new("pb-13", 19);
    public static readonly PaddingBottom pb_14 = new("pb-14", 20);
    public static readonly PaddingBottom pb_16 = new("pb-16", 21);
    public static readonly PaddingBottom pb_20 = new("pb-20", 22);
    public static readonly PaddingBottom pb_24 = new("pb-24", 23);
    public static readonly PaddingBottom pb_28 = new("pb-28", 24);
    public static readonly PaddingBottom pb_32 = new("pb-32", 25);
    public static readonly PaddingBottom pb_36 = new("pb-36", 26);
    public static readonly PaddingBottom pb_40 = new("pb-40", 27);
    public static readonly PaddingBottom pb_44 = new("pb-44", 28);
    public static readonly PaddingBottom pb_48 = new("pb-44", 29);
    public static readonly PaddingBottom pb_52 = new("pb-44", 30);
    public static readonly PaddingBottom pb_56 = new("pb-44", 31);
    public static readonly PaddingBottom pb_60 = new("pb-44", 32);
    public static readonly PaddingBottom pb_64 = new("pb-44", 33);
    public static readonly PaddingBottom pb_72 = new("pb-44", 34);
    public static readonly PaddingBottom pb_80 = new("pb-44", 35);
    public static readonly PaddingBottom pb_88 = new("pb-44", 36);
    public static readonly PaddingBottom pb_96 = new("pb-44", 37);

    private PaddingBottom(string name, int value) : base(name, value) { }
}
