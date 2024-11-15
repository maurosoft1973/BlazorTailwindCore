using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Maurosoft.Blazor.Tailwind.Core.Css;

public sealed class PaddingY : TailwindCssClassBase
{
    public static readonly PaddingY NotSet = new("notset", 1);
    public static readonly PaddingY py_0 = new("py-0", 2);
    public static readonly PaddingY py_0_5 = new("py-0-5", 3);
    public static readonly PaddingY py_py = new("py-py", 4);
    public static readonly PaddingY py_1 = new("py-1", 5);
    public static readonly PaddingY py_1_5 = new("py-1-5", 6);
    public static readonly PaddingY py_2 = new("py-2", 7);
    public static readonly PaddingY py_2_5 = new("py-2-5", 8);
    public static readonly PaddingY py_3 = new("py-3", 9);
    public static readonly PaddingY py_4 = new("py-4", 10);
    public static readonly PaddingY py_5 = new("py-5", 11);
    public static readonly PaddingY py_6 = new("py-6", 12);
    public static readonly PaddingY py_7 = new("py-7", 13);
    public static readonly PaddingY py_8 = new("py-8", 14);
    public static readonly PaddingY py_9 = new("py-9", 15);
    public static readonly PaddingY py_10 = new("py-10", 16);

    private PaddingY(string name, int value) : base(name, value) { }
}
