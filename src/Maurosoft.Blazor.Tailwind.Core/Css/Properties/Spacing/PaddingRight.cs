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

    private PaddingRight(string name, int value) : base(name, value) { }
}
