using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Maurosoft.Blazor.Tailwind.Core.Css.Properties.Spacing;

public sealed class MarginTop : TailwindCssClassBase
{
    public static readonly MarginTop NotSet = new("notset", 1);
    public static readonly MarginTop mt_0 = new("mt-0", 2);
    public static readonly MarginTop mt_0v5 = new("mt-0.5", 3);
    public static readonly MarginTop mt_px = new("mt-px", 4);
    public static readonly MarginTop mt_1 = new("mt-1", 5);
    public static readonly MarginTop mt_1v5 = new("mt-1.5", 6);
    public static readonly MarginTop mt_2 = new("mt-2", 7);
    public static readonly MarginTop mt_2v5 = new("mt-2.5", 8);
    public static readonly MarginTop mt_3 = new("mt-3", 9);
    public static readonly MarginTop mt_3v5 = new("mt-3.5", 10);
    public static readonly MarginTop mt_4 = new("mt-4", 11);
    public static readonly MarginTop mt_5 = new("mt-5", 12);
    public static readonly MarginTop mt_6 = new("mt-6", 13);
    public static readonly MarginTop mt_7 = new("mt-7", 14);
    public static readonly MarginTop mt_8 = new("mt-8", 15);
    public static readonly MarginTop mt_9 = new("mt-9", 16);
    public static readonly MarginTop mt_10 = new("mt-10", 17);
    public static readonly MarginTop mt_Minus0v5 = new("-mt-0.5", 18);
    public static readonly MarginTop mt_Minuspx = new("-mt-px", 19);
    public static readonly MarginTop mt_Minus1 = new("-mt-1", 20);
    public static readonly MarginTop mt_Minus1v5 = new("-mt-1.5", 21);
    public static readonly MarginTop mt_Minus2 = new("-mt-2", 22);
    public static readonly MarginTop mt_Minus2v5 = new("-mt-2.5", 23);
    public static readonly MarginTop mt_Minus3 = new("-mt-3", 24);
    public static readonly MarginTop mt_Minus3v5 = new("-mt-3.5", 25);
    public static readonly MarginTop mt_Minus4 = new("-mt-4", 26);
    public static readonly MarginTop mt_Minus5 = new("-mt-5", 27);
    public static readonly MarginTop mt_Minus6 = new("-mt-6", 28);
    public static readonly MarginTop mt_Minus7 = new("-mt-7", 29);
    public static readonly MarginTop mt_Minus8 = new("-mt-8", 30);
    public static readonly MarginTop mt_Minus9 = new("-mt-9", 31);
    public static readonly MarginTop mt_Minus10 = new("-mt-10", 32);

    private MarginTop(string name, int value) : base(name, value) { }
}
