using Ardalis.SmartEnum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Maurosoft.Blazor.Tailwind.Core.Css.Properties.Effects;

/// <summary>
/// Utilities for controlling the box shadow of an element.
/// For info, see <see href="https://tailwindcss.com/docs/box-shadow">box-shadow</see>
/// </summary>
public sealed class BoxShadow : TailwindCssClassBase
{
    public static readonly BoxShadow NotSet = new("notset", 1);
    public static readonly BoxShadow Shadow_Sm = new("shadow-sm", 2);
    public static readonly BoxShadow Shadow_Normal = new("shadow-normal", 3);
    public static readonly BoxShadow Shadow_Md = new("shadow-md", 4);
    public static readonly BoxShadow Shadow_Lg = new("shadow-lg", 5);
    public static readonly BoxShadow Shadow_Xl = new("shadow-xl", 6);
    public static readonly BoxShadow Shadow_2Xl = new("shadow-2xl", 7);
    public static readonly BoxShadow Shadow_Inner = new("shadow-inner", 8);
    public static readonly BoxShadow Shadow_None = new("shadow-none", 9);

    private BoxShadow(string name, int value) : base(name, value) { }
}
