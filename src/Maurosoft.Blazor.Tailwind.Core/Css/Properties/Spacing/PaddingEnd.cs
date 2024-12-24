
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

    private PaddingEnd(string name, int value) : base(name, value) { }
}
