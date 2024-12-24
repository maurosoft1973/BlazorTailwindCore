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

    private PaddingTop(string name, int value) : base(name, value) { }
}
