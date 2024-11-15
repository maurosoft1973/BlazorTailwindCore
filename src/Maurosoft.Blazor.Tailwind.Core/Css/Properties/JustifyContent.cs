using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Maurosoft.Blazor.Tailwind.Core.Css;

/// <summary>
/// Utilities for controlling how flex and grid items are positioned along a container's main axis.
/// </summary>
public sealed class JustifyContent : TailwindCssClassBase
{
    public static readonly JustifyContent NotSet = new("notset", 1);
    public static readonly JustifyContent Justify_Normal = new("justify-normal", 2);
    public static readonly JustifyContent Justify_Start = new("justify-start", 3);
    public static readonly JustifyContent Justify_End = new("justify-end", 4);
    public static readonly JustifyContent Justify_Center = new("justify-center", 5);
    public static readonly JustifyContent Justify_Between = new("justify-between", 6);
    public static readonly JustifyContent Justify_Around = new("justify-around", 7);
    public static readonly JustifyContent Justify_Evenly = new("justify-evenly", 8);
    public static readonly JustifyContent Justify_Stretch = new("justify-stretch", 9);

    private JustifyContent(string name, int value) : base(name, value) { }
}
