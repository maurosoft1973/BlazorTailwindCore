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

    private PaddingStart(string name, int value) : base(name, value) { }
}
