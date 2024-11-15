using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Maurosoft.Blazor.Tailwind.Core.Css;

public sealed class Outline : TailwindCssClassBase
{
    public static readonly Outline NotSet = new("notset", 1);
    public static readonly Outline Outline_None = new("outline-none", 2);
    public static readonly Outline Outline_Offset = new("outline-offset", 3);
    public static readonly Outline Outline_Outline = new("outline", 4);
    public static readonly Outline Outline_Dashed = new("outline-dashed", 5);
    public static readonly Outline Outline_Dotted = new("outline-dotted", 6);
    public static readonly Outline Outline_Double = new("outline-double", 7);

    private Outline(string name, int value) : base(name, value) { }
}
