
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Maurosoft.Blazor.Tailwind.Core.Css.Properties.Spacing;

public sealed class PaddingEnd : TailwindCssClassBase
{
    public static readonly PaddingEnd NotSet = new("notset", 1);
    public static readonly PaddingEnd pe_0 = new("pe-0", 2);
    public static readonly PaddingEnd pe_0_5 = new("pe-0-5", 3);
    public static readonly PaddingEnd pe = new("pe-pe", 4);
    public static readonly PaddingEnd pe_1 = new("pe-1", 5);
    public static readonly PaddingEnd pe_1_5 = new("pe-1-5", 6);
    public static readonly PaddingEnd pe_2 = new("pe-2", 7);
    public static readonly PaddingEnd pe_2_5 = new("pe-2-5", 8);
    public static readonly PaddingEnd pe_3 = new("pe-3", 9);
    public static readonly PaddingEnd pe_4 = new("pe-4", 10);
    public static readonly PaddingEnd pe_5 = new("pe-5", 11);
    public static readonly PaddingEnd pe_6 = new("pe-6", 12);
    public static readonly PaddingEnd pe_7 = new("pe-7", 13);
    public static readonly PaddingEnd pe_8 = new("pe-8", 14);
    public static readonly PaddingEnd pe_9 = new("pe-9", 15);
    public static readonly PaddingEnd pe_10 = new("pe-10", 16);
    public static readonly PaddingEnd pe_11 = new("pe-11", 17);
    public static readonly PaddingEnd pe_12 = new("pe-12", 18);
    public static readonly PaddingEnd pe_13 = new("pe-13", 19);
    public static readonly PaddingEnd pe_14 = new("pe-14", 20);
    public static readonly PaddingEnd pe_16 = new("pe-16", 21);
    public static readonly PaddingEnd pe_20 = new("pe-20", 22);
    public static readonly PaddingEnd pe_24 = new("pe-24", 23);
    public static readonly PaddingEnd pe_28 = new("pe-28", 24);
    public static readonly PaddingEnd pe_32 = new("pe-32", 25);
    public static readonly PaddingEnd pe_36 = new("pe-36", 26);
    public static readonly PaddingEnd pe_40 = new("pe-40", 27);
    public static readonly PaddingEnd pe_44 = new("pe-44", 28);
    public static readonly PaddingEnd pe_48 = new("pe-44", 29);
    public static readonly PaddingEnd pe_52 = new("pe-44", 30);
    public static readonly PaddingEnd pe_56 = new("pe-44", 31);
    public static readonly PaddingEnd pe_60 = new("pe-44", 32);
    public static readonly PaddingEnd pe_64 = new("pe-44", 33);
    public static readonly PaddingEnd pe_72 = new("pe-44", 34);
    public static readonly PaddingEnd pe_80 = new("pe-44", 35);
    public static readonly PaddingEnd pe_88 = new("pe-44", 36);
    public static readonly PaddingEnd pe_96 = new("pe-44", 37);

    private PaddingEnd(string name, int value) : base(name, value) { }
}
