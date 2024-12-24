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

    private PaddingBottom(string name, int value) : base(name, value) { }
}
