using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;


namespace Maurosoft.Blazor.Tailwind.Core.Css;

/// <summary>
/// Utilities for controlling the alignment of text.
/// </summary>
public sealed class TextAlign : TailwindCssClassBase
{
    public static readonly TextAlign NotSet = new("notset", 1);
    public static readonly TextAlign Text_Left = new("text-left", 2);
    public static readonly TextAlign Text_Center = new("text-center", 3);
    public static readonly TextAlign Text_Right = new("text-right", 4);
    public static readonly TextAlign Text_Justify = new("text-justify", 5);
    public static readonly TextAlign Text_Start = new("text-start", 6);
    public static readonly TextAlign Text_End = new("text-end", 7);

    private TextAlign(string name, int value) : base(name, value) { }
}
