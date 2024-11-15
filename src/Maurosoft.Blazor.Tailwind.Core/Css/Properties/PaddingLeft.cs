using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Maurosoft.Blazor.Tailwind.Core.Css;

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

    private PaddingLeft(string name, int value) : base(name, value) { }
}
