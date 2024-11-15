using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Maurosoft.Blazor.Tailwind.Core.Css;

public sealed class MarginStart : TailwindCssClassBase
{
    public static readonly MarginStart NotSet = new("notset", 1);
    public static readonly MarginStart ms_0 = new("ms-0", 2);
    public static readonly MarginStart ms_px = new("ms-px", 3);
    public static readonly MarginStart ms_1 = new("ms-1", 4);
    public static readonly MarginStart ms_2 = new("ms-2", 5);
    public static readonly MarginStart ms_3 = new("ms-3", 6);
    public static readonly MarginStart ms_4 = new("ms-4", 7);
    public static readonly MarginStart ms_5 = new("ms-5", 8);
    public static readonly MarginStart ms_6 = new("ms-6", 9);
    public static readonly MarginStart ms_7 = new("ms-7", 10);
    public static readonly MarginStart ms_8 = new("ms-8", 11);
    public static readonly MarginStart ms_9 = new("ms-9", 12);
    public static readonly MarginStart ms_10 = new("ms-10", 13);
    public static readonly MarginStart ms_Minus0v5 = new("-ms-0.5", 18);
    public static readonly MarginStart ms_Minuspx = new("-ms-px", 19);
    public static readonly MarginStart ms_Minus1 = new("-ms-1", 20);
    public static readonly MarginStart ms_Minus1v5 = new("-ms-1.5", 21);
    public static readonly MarginStart ms_Minus2 = new("-ms-2", 22);
    public static readonly MarginStart ms_Minus2v5 = new("-ms-2.5", 23);
    public static readonly MarginStart ms_Minus3 = new("-ms-3", 24);
    public static readonly MarginStart ms_Minus3v5 = new("-ms-3.5", 25);
    public static readonly MarginStart ms_Minus4 = new("-ms-4", 26);
    public static readonly MarginStart ms_Minus5 = new("-ms-5", 27);
    public static readonly MarginStart ms_Minus6 = new("-ms-6", 28);
    public static readonly MarginStart ms_Minus7 = new("-ms-7", 29);
    public static readonly MarginStart ms_Minus8 = new("-ms-8", 30);
    public static readonly MarginStart ms_Minus9 = new("-ms-9", 31);
    public static readonly MarginStart ms_Minus10 = new("-ms-10", 32);

    private MarginStart(string name, int value) : base(name, value) { }
}
