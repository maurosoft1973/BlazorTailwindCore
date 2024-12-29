using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Maurosoft.Blazor.Tailwind.Core.Css.Properties.Spacing;

public sealed class PaddingStart : TailwindCssClassBase
{
    public static readonly PaddingStart NotSet = new("notset", 1);
    public static readonly PaddingStart ps_0 = new("ps-0", 2);
    public static readonly PaddingStart ps_0_5 = new("ps-0-5", 3);
    public static readonly PaddingStart ps_ps = new("ps-ps", 4);
    public static readonly PaddingStart ps_1 = new("ps-1", 5);
    public static readonly PaddingStart ps_1_5 = new("ps-1-5", 6);
    public static readonly PaddingStart ps_2 = new("ps-2", 7);
    public static readonly PaddingStart ps_2_5 = new("ps-2-5", 8);
    public static readonly PaddingStart ps_3 = new("ps-3", 9);
    public static readonly PaddingStart ps_4 = new("ps-4", 10);
    public static readonly PaddingStart ps_5 = new("ps-5", 11);
    public static readonly PaddingStart ps_6 = new("ps-6", 12);
    public static readonly PaddingStart ps_7 = new("ps-7", 13);
    public static readonly PaddingStart ps_8 = new("ps-8", 14);
    public static readonly PaddingStart ps_9 = new("ps-9", 15);
    public static readonly PaddingStart ps_10 = new("ps-10", 16);
    public static readonly PaddingStart ps_11 = new("ps-11", 17);
    public static readonly PaddingStart ps_12 = new("ps-12", 18);
    public static readonly PaddingStart ps_13 = new("ps-13", 19);
    public static readonly PaddingStart ps_14 = new("ps-14", 20);
    public static readonly PaddingStart ps_16 = new("ps-16", 21);
    public static readonly PaddingStart ps_20 = new("ps-20", 22);
    public static readonly PaddingStart ps_24 = new("ps-24", 23);
    public static readonly PaddingStart ps_28 = new("ps-28", 24);
    public static readonly PaddingStart ps_32 = new("ps-32", 25);
    public static readonly PaddingStart ps_36 = new("ps-36", 26);
    public static readonly PaddingStart ps_40 = new("ps-40", 27);
    public static readonly PaddingStart ps_44 = new("ps-44", 28);
    public static readonly PaddingStart ps_48 = new("ps-44", 29);
    public static readonly PaddingStart ps_52 = new("ps-44", 30);
    public static readonly PaddingStart ps_56 = new("ps-44", 31);
    public static readonly PaddingStart ps_60 = new("ps-44", 32);
    public static readonly PaddingStart ps_64 = new("ps-44", 33);
    public static readonly PaddingStart ps_72 = new("ps-44", 34);
    public static readonly PaddingStart ps_80 = new("ps-44", 35);
    public static readonly PaddingStart ps_88 = new("ps-44", 36);
    public static readonly PaddingStart ps_96 = new("ps-44", 37);

    private PaddingStart(string name, int value) : base(name, value) { }
}
