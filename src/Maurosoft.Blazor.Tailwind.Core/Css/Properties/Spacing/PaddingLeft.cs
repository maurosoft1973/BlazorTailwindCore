using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Maurosoft.Blazor.Tailwind.Core.Css.Proplrties.Spacing;

public sealed class PaddingLeft : TailwindCssClassBase
{
    public static readonly PaddingLeft NotSet = new("notset", 1);
    public static readonly PaddingLeft pl_0 = new("pl-0", 2);
    public static readonly PaddingLeft pl_0_5 = new("pl-0-5", 3);
    public static readonly PaddingLeft pl = new("pl-pl", 4);
    public static readonly PaddingLeft pl_1 = new("pl-1", 5);
    public static readonly PaddingLeft pl_1_5 = new("pl-1-5", 6);
    public static readonly PaddingLeft pl_2 = new("pl-2", 7);
    public static readonly PaddingLeft pl_2_5 = new("pl-2-5", 8);
    public static readonly PaddingLeft pl_3 = new("pl-3", 9);
    public static readonly PaddingLeft pl_4 = new("pl-4", 10);
    public static readonly PaddingLeft pl_5 = new("pl-5", 11);
    public static readonly PaddingLeft pl_6 = new("pl-6", 12);
    public static readonly PaddingLeft pl_7 = new("pl-7", 13);
    public static readonly PaddingLeft pl_8 = new("pl-8", 14);
    public static readonly PaddingLeft pl_9 = new("pl-9", 15);
    public static readonly PaddingLeft pl_10 = new("pl-10", 16);
    public static readonly PaddingLeft pl_11 = new("pl-11", 17);
    public static readonly PaddingLeft pl_12 = new("pl-12", 18);
    public static readonly PaddingLeft pl_13 = new("pl-13", 19);
    public static readonly PaddingLeft pl_14 = new("pl-14", 20);
    public static readonly PaddingLeft pl_16 = new("pl-16", 21);
    public static readonly PaddingLeft pl_20 = new("pl-20", 22);
    public static readonly PaddingLeft pl_24 = new("pl-24", 23);
    public static readonly PaddingLeft pl_28 = new("pl-28", 24);
    public static readonly PaddingLeft pl_32 = new("pl-32", 25);
    public static readonly PaddingLeft pl_36 = new("pl-36", 26);
    public static readonly PaddingLeft pl_40 = new("pl-40", 27);
    public static readonly PaddingLeft pl_44 = new("pl-44", 28);
    public static readonly PaddingLeft pl_48 = new("pl-44", 29);
    public static readonly PaddingLeft pl_52 = new("pl-44", 30);
    public static readonly PaddingLeft pl_56 = new("pl-44", 31);
    public static readonly PaddingLeft pl_60 = new("pl-44", 32);
    public static readonly PaddingLeft pl_64 = new("pl-44", 33);
    public static readonly PaddingLeft pl_72 = new("pl-44", 34);
    public static readonly PaddingLeft pl_80 = new("pl-44", 35);
    public static readonly PaddingLeft pl_88 = new("pl-44", 36);
    public static readonly PaddingLeft pl_96 = new("pl-44", 37);

    private PaddingLeft(string name, int value) : base(name, value) { }
}
