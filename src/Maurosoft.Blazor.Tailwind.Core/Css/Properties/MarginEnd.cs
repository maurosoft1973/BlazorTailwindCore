using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Maurosoft.Blazor.Tailwind.Core.Css;

public sealed class MarginEnd : TailwindCssClassBase
{
    public static readonly MarginEnd NotSet = new("notset", 1);
    public static readonly MarginEnd me_0 = new("me-0", 2);
    public static readonly MarginEnd me_px = new("me-px", 3);
    public static readonly MarginEnd me_1 = new("me-1", 4);
    public static readonly MarginEnd me_2 = new("me-2", 5);
    public static readonly MarginEnd me_3 = new("me-3", 6);
    public static readonly MarginEnd me_4 = new("me-4", 7);
    public static readonly MarginEnd me_5 = new("me-5", 8);
    public static readonly MarginEnd me_6 = new("me-6", 9);
    public static readonly MarginEnd me_7 = new("me-7", 10);
    public static readonly MarginEnd me_8 = new("me-8", 11);
    public static readonly MarginEnd me_9 = new("me-9", 12);
    public static readonly MarginEnd me_10 = new("me-10", 13);
    public static readonly MarginEnd me_Minus0v5 = new("-me-0.5", 18);
    public static readonly MarginEnd me_Minuspx = new("-me-px", 19);
    public static readonly MarginEnd me_Minus1 = new("-me-1", 20);
    public static readonly MarginEnd me_Minus1v5 = new("-me-1.5", 21);
    public static readonly MarginEnd me_Minus2 = new("-me-2", 22);
    public static readonly MarginEnd me_Minus2v5 = new("-me-2.5", 23);
    public static readonly MarginEnd me_Minus3 = new("-me-3", 24);
    public static readonly MarginEnd me_Minus3v5 = new("-me-3.5", 25);
    public static readonly MarginEnd me_Minus4 = new("-me-4", 26);
    public static readonly MarginEnd me_Minus5 = new("-me-5", 27);
    public static readonly MarginEnd me_Minus6 = new("-me-6", 28);
    public static readonly MarginEnd me_Minus7 = new("-me-7", 29);
    public static readonly MarginEnd me_Minus8 = new("-me-8", 30);
    public static readonly MarginEnd me_Minus9 = new("-me-9", 31);
    public static readonly MarginEnd me_Minus10 = new("-me-10", 32);

    private MarginEnd(string name, int value) : base(name, value) { }
}