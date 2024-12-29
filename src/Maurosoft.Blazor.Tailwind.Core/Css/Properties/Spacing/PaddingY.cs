using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Maurosoft.Blazor.Tailwind.Core.Css.Properties.Spacing;

/// <summary>
/// Utilities for controlling an element's padding.
/// For info, see <see href="https://tailwindcss.com/docs/padding">padding</see>
/// </summary>
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
    public static readonly PaddingY py_11 = new("py-11", 17);
    public static readonly PaddingY py_12 = new("py-12", 18);
    public static readonly PaddingY py_13 = new("py-13", 19);
    public static readonly PaddingY py_14 = new("py-14", 20);
    public static readonly PaddingY py_16 = new("py-16", 21);
    public static readonly PaddingY py_20 = new("py-20", 22);
    public static readonly PaddingY py_24 = new("py-24", 23);
    public static readonly PaddingY py_28 = new("py-28", 24);
    public static readonly PaddingY py_32 = new("py-32", 25);
    public static readonly PaddingY py_36 = new("py-36", 26);
    public static readonly PaddingY py_40 = new("py-40", 27);
    public static readonly PaddingY py_44 = new("py-44", 28);
    public static readonly PaddingY py_48 = new("py-44", 29);
    public static readonly PaddingY py_52 = new("py-44", 30);
    public static readonly PaddingY py_56 = new("py-44", 31);
    public static readonly PaddingY py_60 = new("py-44", 32);
    public static readonly PaddingY py_64 = new("py-44", 33);
    public static readonly PaddingY py_72 = new("py-44", 34);
    public static readonly PaddingY py_80 = new("py-44", 35);
    public static readonly PaddingY py_88 = new("py-44", 36);
    public static readonly PaddingY py_96 = new("py-44", 37);

    private PaddingY(string name, int value) : base(name, value) { }
}
