using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Maurosoft.Blazor.Tailwind.Core.Css;

public sealed class MarginBottom : TailwindCssClassBase
{
    public static readonly MarginBottom NotSet = new("notset", 1);
    public static readonly MarginBottom mb_0 = new("mb-0", 2);
    public static readonly MarginBottom mb_0v5 = new("mb-0.5", 3);
    public static readonly MarginBottom mb_px = new("mb-px", 4);
    public static readonly MarginBottom mb_1 = new("mb-1", 5);
    public static readonly MarginBottom mb_1v5 = new("mb-1.5", 6);
    public static readonly MarginBottom mb_2 = new("mb-2", 7);
    public static readonly MarginBottom mb_2v5 = new("mb-2", 8);
    public static readonly MarginBottom mb_3 = new("mb-3", 9);
    public static readonly MarginBottom mb_3v5 = new("mb-3.5", 10);
    public static readonly MarginBottom mb_4 = new("mb-4", 11);
    public static readonly MarginBottom mb_5 = new("mb-5", 12);
    public static readonly MarginBottom mb_6 = new("mb-6", 13);
    public static readonly MarginBottom mb_7 = new("mb-7", 14);
    public static readonly MarginBottom mb_8 = new("mb-8", 15);
    public static readonly MarginBottom mb_9 = new("mb-9", 16);
    public static readonly MarginBottom mb_10 = new("mb-10", 17);
    public static readonly MarginBottom mb_Minus0v5 = new("-mb-0.5", 18);
    public static readonly MarginBottom mb_Minuspx = new("-mb-px", 19);
    public static readonly MarginBottom mb_Minus1 = new("-mb-1", 20);
    public static readonly MarginBottom mb_Minus1v5 = new("-mb-1.5", 21);
    public static readonly MarginBottom mb_Minus2 = new("-mb-2", 22);
    public static readonly MarginBottom mb_Minus2v5 = new("-mb-2.5", 23);
    public static readonly MarginBottom mb_Minus3 = new("-mb-3", 24);
    public static readonly MarginBottom mb_Minus3v5 = new("-mb-3.5", 25);
    public static readonly MarginBottom mb_Minus4 = new("-mb-4", 26);
    public static readonly MarginBottom mb_Minus5 = new("-mb-5", 27);
    public static readonly MarginBottom mb_Minus6 = new("-mb-6", 28);
    public static readonly MarginBottom mb_Minus7 = new("-mb-7", 29);
    public static readonly MarginBottom mb_Minus8 = new("-mb-8", 30);
    public static readonly MarginBottom mb_Minus9 = new("-mb-9", 31);
    public static readonly MarginBottom mb_Minus10 = new("-mb-10", 32);

    private MarginBottom(string name, int value) : base(name, value) { }
}
