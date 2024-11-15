using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Maurosoft.Blazor.Tailwind.Core.Css;

public sealed class FocusOutline : TailwindCssClassBase
{
    public static readonly FocusOutline NotSet = new("notset", 1);
    public static readonly FocusOutline Outline_None = new("focus:outline-none", 2);
    public static readonly FocusOutline Outline_Offset = new("focus:outline-offset", 3);
    public static readonly FocusOutline Outline_Outline = new("focus:outline", 4);
    public static readonly FocusOutline Outline_Dashed = new("focus:outline-dashed", 5);
    public static readonly FocusOutline Outline_Dotted = new("focus:outline-dotted", 6);
    public static readonly FocusOutline Outline_Double = new("focus:outline-double", 7);

    private FocusOutline(string name, int value) : base(name, value) { }
}
