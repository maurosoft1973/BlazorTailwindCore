using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Maurosoft.Blazor.Tailwind.Core.Css;

public sealed class MarginRight : TailwindCssClassBase
{
    public static readonly MarginRight NotSet = new("notset", 1);
    public static readonly MarginRight mr_0 = new("mr-0", 2);
    public static readonly MarginRight mr_0v5 = new("mr-0.5", 3);
    public static readonly MarginRight mr_px = new("mr-px", 4);
    public static readonly MarginRight mr_1 = new("mr-1", 5);
    public static readonly MarginRight mr_1v5 = new("mr-1.5", 6);
    public static readonly MarginRight mr_2 = new("mr-2", 7);
    public static readonly MarginRight mr_2v5 = new("mr-2.5", 8);
    public static readonly MarginRight mr_3 = new("mr-3", 9);
    public static readonly MarginRight mr_3v5 = new("mr-2.5", 10);
    public static readonly MarginRight mr_4 = new("mr-4", 11);
    public static readonly MarginRight mr_5 = new("mr-5", 12);
    public static readonly MarginRight mr_6 = new("mr-6", 13);
    public static readonly MarginRight mr_7 = new("mr-7", 14);
    public static readonly MarginRight mr_8 = new("mr-8", 15);
    public static readonly MarginRight mr_9 = new("mr-9", 16);
    public static readonly MarginRight mr_10 = new("mr-10", 17);
    public static readonly MarginRight mr_Minus0v5 = new("-mr-0.5", 18);
    public static readonly MarginRight mr_Minuspx = new("-mr-px", 19);
    public static readonly MarginRight mr_Minus1 = new("-mr-1", 20);
    public static readonly MarginRight mr_Minus1v5 = new("-mr-1.5", 21);
    public static readonly MarginRight mr_Minus2 = new("-mr-2", 22);
    public static readonly MarginRight mr_Minus2v5 = new("-mr-2.5", 23);
    public static readonly MarginRight mr_Minus3 = new("-mr-3", 24);
    public static readonly MarginRight mr_Minus3v5 = new("-mr-3.5", 25);
    public static readonly MarginRight mr_Minus4 = new("-mr-4", 26);
    public static readonly MarginRight mr_Minus5 = new("-mr-5", 27);
    public static readonly MarginRight mr_Minus6 = new("-mr-6", 28);
    public static readonly MarginRight mr_Minus7 = new("-mr-7", 29);
    public static readonly MarginRight mr_Minus8 = new("-mr-8", 30);
    public static readonly MarginRight mr_Minus9 = new("-mr-9", 31);
    public static readonly MarginRight mr_Minus10 = new("-mr-10", 32);

    private MarginRight(string name, int value) : base(name, value) { }
}