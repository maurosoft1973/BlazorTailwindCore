using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Maurosoft.Blazor.Tailwind.Core.Css.Properties.Spacing;

public sealed class PaddingTop : TailwindCssClassBase
{
    public static readonly PaddingTop NotSet = new("notset", 1);
    public static readonly PaddingTop pt_0 = new("pt-0", 2);
    public static readonly PaddingTop pt_0_5 = new("pt-0-5", 3);
    public static readonly PaddingTop pt_pt = new("pt-pt", 4);
    public static readonly PaddingTop pt_1 = new("pt-1", 5);
    public static readonly PaddingTop pt_1_5 = new("pt-1-5", 6);
    public static readonly PaddingTop pt_2 = new("pt-2", 7);
    public static readonly PaddingTop pt_2_5 = new("pt-2-5", 8);
    public static readonly PaddingTop pt_3 = new("pt-3", 9);
    public static readonly PaddingTop pt_4 = new("pt-4", 10);
    public static readonly PaddingTop pt_5 = new("pt-5", 11);
    public static readonly PaddingTop pt_6 = new("pt-6", 12);
    public static readonly PaddingTop pt_7 = new("pt-7", 13);
    public static readonly PaddingTop pt_8 = new("pt-8", 14);
    public static readonly PaddingTop pt_9 = new("pt-9", 15);
    public static readonly PaddingTop pt_10 = new("pt-10", 16);
    public static readonly PaddingTop pt_11 = new("pt-11", 17);
    public static readonly PaddingTop pt_12 = new("pt-12", 18);
    public static readonly PaddingTop pt_13 = new("pt-13", 19);
    public static readonly PaddingTop pt_14 = new("pt-14", 20);
    public static readonly PaddingTop pt_16 = new("pt-16", 21);
    public static readonly PaddingTop pt_20 = new("pt-20", 22);
    public static readonly PaddingTop pt_24 = new("pt-24", 23);
    public static readonly PaddingTop pt_28 = new("pt-28", 24);
    public static readonly PaddingTop pt_32 = new("pt-32", 25);
    public static readonly PaddingTop pt_36 = new("pt-36", 26);
    public static readonly PaddingTop pt_40 = new("pt-40", 27);
    public static readonly PaddingTop pt_44 = new("pt-44", 28);
    public static readonly PaddingTop pt_48 = new("pt-44", 29);
    public static readonly PaddingTop pt_52 = new("pt-44", 30);
    public static readonly PaddingTop pt_56 = new("pt-44", 31);
    public static readonly PaddingTop pt_60 = new("pt-44", 32);
    public static readonly PaddingTop pt_64 = new("pt-44", 33);
    public static readonly PaddingTop pt_72 = new("pt-44", 34);
    public static readonly PaddingTop pt_80 = new("pt-44", 35);
    public static readonly PaddingTop pt_88 = new("pt-44", 36);
    public static readonly PaddingTop pt_96 = new("pt-44", 37);

    private PaddingTop(string name, int value) : base(name, value) { }
}
