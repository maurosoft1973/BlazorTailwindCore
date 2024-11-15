using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;


namespace Maurosoft.Blazor.Tailwind.Core.Css;

/// <summary>
/// Utilities for controlling the font weight of an element.
/// </summary>
public sealed class FontWeight : TailwindCssClassBase
{
    public static readonly FontWeight NotSet = new("notset", 1);
    public static readonly FontWeight Font_Thin = new("font-thin", 2);
    public static readonly FontWeight Font_ExtraLight = new("font-extralight", 3);
    public static readonly FontWeight Font_Light = new("font-light", 4);
    public static readonly FontWeight Font_Normal = new("font-normal", 5);
    public static readonly FontWeight Font_Medium = new("font-medium", 6);
    public static readonly FontWeight Font_SemiBold = new("font-semibold", 7);
    public static readonly FontWeight Font_Bold = new("font-bold", 8);
    public static readonly FontWeight Font_ExtraBold = new("font-extrabold", 9);
    public static readonly FontWeight Font_Black = new("font-black", 10);

    private FontWeight(string name, int value) : base(name, value) { }
}
