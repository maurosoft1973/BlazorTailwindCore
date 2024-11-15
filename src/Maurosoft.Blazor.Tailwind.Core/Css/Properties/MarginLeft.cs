using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Maurosoft.Blazor.Tailwind.Core.Css;

public sealed class MarginLeft : TailwindCssClassBase
{
    public static readonly MarginLeft NotSet = new("notset", 1);
    public static readonly MarginLeft ml_0 = new("ml-0", 2);
    public static readonly MarginLeft ml_0v5 = new("ml-0.5", 3);
    public static readonly MarginLeft ml_px = new("ml-px", 4);
    public static readonly MarginLeft ml_1 = new("ml-1", 5);
    public static readonly MarginLeft ml_1v5 = new("ml-1.5", 6);
    public static readonly MarginLeft ml_2 = new("ml-2", 7);
    public static readonly MarginLeft ml_2v5 = new("ml-2.5", 8);
    public static readonly MarginLeft ml_3 = new("ml-3", 9);
    public static readonly MarginLeft ml_3v5 = new("ml-2.5", 10);
    public static readonly MarginLeft ml_4 = new("ml-4", 11);
    public static readonly MarginLeft ml_5 = new("ml-5", 12);
    public static readonly MarginLeft ml_6 = new("ml-6", 13);
    public static readonly MarginLeft ml_7 = new("ml-7", 14);
    public static readonly MarginLeft ml_8 = new("ml-8", 15);
    public static readonly MarginLeft ml_9 = new("ml-9", 16);
    public static readonly MarginLeft ml_10 = new("ml-10", 17);
    public static readonly MarginLeft ml_Minus0v5 = new("-ml-0.5", 18);
    public static readonly MarginLeft ml_Minuspx = new("-ml-px", 19);
    public static readonly MarginLeft ml_Minus1 = new("-ml-1", 20);
    public static readonly MarginLeft ml_Minus1v5 = new("-ml-1.5", 21);
    public static readonly MarginLeft ml_Minus2 = new("-ml-2", 22);
    public static readonly MarginLeft ml_Minus2v5 = new("-ml-2.5", 23);
    public static readonly MarginLeft ml_Minus3 = new("-ml-3", 24);
    public static readonly MarginLeft ml_Minus3v5 = new("-ml-3.5", 25);
    public static readonly MarginLeft ml_Minus4 = new("-ml-4", 26);
    public static readonly MarginLeft ml_Minus5 = new("-ml-5", 27);
    public static readonly MarginLeft ml_Minus6 = new("-ml-6", 28);
    public static readonly MarginLeft ml_Minus7 = new("-ml-7", 29);
    public static readonly MarginLeft ml_Minus8 = new("-ml-8", 30);
    public static readonly MarginLeft ml_Minus9 = new("-ml-9", 31);
    public static readonly MarginLeft ml_Minus10 = new("-ml-10", 32);

    private MarginLeft(string name, int value) : base(name, value) { }
}
