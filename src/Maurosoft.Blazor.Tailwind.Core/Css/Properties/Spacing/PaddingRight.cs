using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Maurosoft.Blazor.Tailwind.Core.Css.Properties.Spacing;

public sealed class PaddingRight : TailwindCssClassBase
{
    public static readonly PaddingRight NotSet = new("notset", 1);
    public static readonly PaddingRight pr_0 = new("pr-0", 2);
    public static readonly PaddingRight pr_0_5 = new("pr-0-5", 3);
    public static readonly PaddingRight pr = new("pr-pr", 4);
    public static readonly PaddingRight pr_1 = new("pr-1", 5);
    public static readonly PaddingRight pr_1_5 = new("pr-1-5", 6);
    public static readonly PaddingRight pr_2 = new("pr-2", 7);
    public static readonly PaddingRight pr_2_5 = new("pr-2-5", 8);
    public static readonly PaddingRight pr_3 = new("pr-3", 9);
    public static readonly PaddingRight pr_4 = new("pr-4", 10);
    public static readonly PaddingRight pr_5 = new("pr-5", 11);
    public static readonly PaddingRight pr_6 = new("pr-6", 12);
    public static readonly PaddingRight pr_7 = new("pr-7", 13);
    public static readonly PaddingRight pr_8 = new("pr-8", 14);
    public static readonly PaddingRight pr_9 = new("pr-9", 15);
    public static readonly PaddingRight pr_10 = new("pr-10", 16);
    public static readonly PaddingRight pr_11 = new("pr-11", 17);
    public static readonly PaddingRight pr_12 = new("pr-12", 18);
    public static readonly PaddingRight pr_13 = new("pr-13", 19);
    public static readonly PaddingRight pr_14 = new("pr-14", 20);
    public static readonly PaddingRight pr_16 = new("pr-16", 21);
    public static readonly PaddingRight pr_20 = new("pr-20", 22);
    public static readonly PaddingRight pr_24 = new("pr-24", 23);
    public static readonly PaddingRight pr_28 = new("pr-28", 24);
    public static readonly PaddingRight pr_32 = new("pr-32", 25);
    public static readonly PaddingRight pr_36 = new("pr-36", 26);
    public static readonly PaddingRight pr_40 = new("pr-40", 27);
    public static readonly PaddingRight pr_44 = new("pr-44", 28);
    public static readonly PaddingRight pr_48 = new("pr-44", 29);
    public static readonly PaddingRight pr_52 = new("pr-44", 30);
    public static readonly PaddingRight pr_56 = new("pr-44", 31);
    public static readonly PaddingRight pr_60 = new("pr-44", 32);
    public static readonly PaddingRight pr_64 = new("pr-44", 33);
    public static readonly PaddingRight pr_72 = new("pr-44", 34);
    public static readonly PaddingRight pr_80 = new("pr-44", 35);
    public static readonly PaddingRight pr_88 = new("pr-44", 36);
    public static readonly PaddingRight pr_96 = new("pr-44", 37);

    private PaddingRight(string name, int value) : base(name, value) { }
}
