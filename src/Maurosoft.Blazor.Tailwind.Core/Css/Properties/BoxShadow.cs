using Ardalis.SmartEnum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Maurosoft.Blazor.Tailwind.Core.Css;

/// <summary>
/// Utilities for controlling the box shadow of an element.
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

//public enum BoxShadow
//{
//    [EnumMember(Value = "")]
//    NotSet,
//    /// <summary>
//    /// box-shadow: 0 1px 2px 0 rgb(0 0 0 / 0.05);
//    /// </summary>
//    [EnumMember(Value = "shadow-sm")]
//    Shadow_Sm,
//    /// <summary>
//    /// box-shadow: 0 1px 3px 0 rgb(0 0 0 / 0.1), 0 1px 2px -1px rgb(0 0 0 / 0.1);
//    /// </summary>
//    [EnumMember(Value = "shadow")]
//    Shadow_Normal,
//    /// <summary>
//    /// box-shadow: 0 4px 6px -1px rgb(0 0 0 / 0.1), 0 2px 4px -2px rgb(0 0 0 / 0.1);
//    /// </summary>
//    [EnumMember(Value = "shadow-md")]
//    Shadow_Md,
//    /// <summary>
//    /// box-shadow: 0 10px 15px -3px rgb(0 0 0 / 0.1), 0 4px 6px -4px rgb(0 0 0 / 0.1);
//    /// </summary>
//    [EnumMember(Value = "shadow-lg")]
//    Shadow_Lg,
//    /// <summary>
//    /// box-shadow: 0 20px 25px -5px rgb(0 0 0 / 0.1), 0 8px 10px -6px rgb(0 0 0 / 0.1);
//    /// </summary>
//    [EnumMember(Value = "shadow-xl")]
//    Shadow_Xl,
//    /// <summary>
//    /// box-shadow: 0 25px 50px -12px rgb(0 0 0 / 0.25);
//    /// </summary>
//    [EnumMember(Value = "shadow-2xl")]
//    Shadow_2Xl,
//    /// <summary>
//    /// box-shadow: inset 0 2px 4px 0 rgb(0 0 0 / 0.05);
//    /// </summary>
//    [EnumMember(Value = "shadow-inner")]
//    Shadow_Inner,
//    /// <summary>
//    /// box-shadow: 0 0 #0000;
//    /// </summary>
//    [EnumMember(Value = "shadow-none")]
//    Shadow_None
//}
