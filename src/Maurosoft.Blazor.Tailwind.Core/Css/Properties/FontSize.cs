using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;


namespace Maurosoft.Blazor.Tailwind.Core.Css;

/// <summary>
/// Utilities for controlling the font size of an element.
/// </summary>
public sealed class FontSize : TailwindCssClassBase
{
    public static readonly FontSize NotSet = new("notset", 1);
    public static readonly FontSize Text_XXs = new("text-xxs", 2);
    public static readonly FontSize Text_Xs = new("text-xs", 2);
    public static readonly FontSize Text_Sm = new("text-sm", 3);
    public static readonly FontSize Text_Base = new("text-base", 4);
    public static readonly FontSize Text_Lg = new("text-lg", 5);
    public static readonly FontSize Text_Xl = new("text-xl", 6);
    public static readonly FontSize Text_2Xl = new("text-2xl", 7);
    public static readonly FontSize Text_3Xl = new("text-3xl", 8);
    public static readonly FontSize Text_4Xl = new("text-4xl", 9);
    public static readonly FontSize Text_5Xl = new("text-5xl", 10);
    public static readonly FontSize Text_6Xl = new("text-6xl", 11);
    public static readonly FontSize Text_7Xl = new("text-7xl", 12);
    public static readonly FontSize Text_8Xl = new("text-8xl", 13);
    public static readonly FontSize Text_9Xl = new("text-9xl", 14);

    private FontSize(string name, int value) : base(name, value) { }
}
//public enum FontSize
//{
//    [EnumMember(Value = "")]
//    NotSet,
//    /// <summary>
//    /// font-size: 0.75rem; /* 12px */
//    ///  line-height: 1rem; /* 16px */
//    /// </summary>
//    [EnumMember(Value = "text-xs")]
//    Text_Xs,
//    /// <summary>
//    /// font-size: 0.875rem; /* 14px */
//    /// line-height: 1.25rem; /* 20px */
//    /// </summary>
//    [EnumMember(Value = "text-sm")]
//    Text_Sm,
//    /// <summary>
//    /// font-size: 1rem; /* 16px */
//    /// line-height: 1.5rem; /* 24px */
//    /// </summary>
//    [EnumMember(Value = "text-base")]
//    Text_Base,
//    /// <summary>
//    /// font-size: 1.125rem; /* 18px */
//    /// line-height: 1.75rem; /* 28px */
//    /// </summary>
//    [EnumMember(Value = "text-lg")]
//    Text_Lg,
//    /// <summary>
//    /// font-size: 1.25rem; /* 20px */
//    /// line-height: 1.75rem; /* 28px */
//    /// </summary>
//    [EnumMember(Value = "text-xl")]
//    Text_Xl,
//    /// <summary>
//    /// font-size: 1.5rem; /* 24px */
//    /// line-height: 2rem; /* 32px */
//    /// </summary>
//    [EnumMember(Value = "text-2xl")]
//    Text_2Xl,
//    /// <summary>
//    /// font-size: 1.875rem; /* 30px */
//    /// line-height: 2.25rem; /* 36px */
//    /// </summary>
//    [EnumMember(Value = "text-3xl")]
//    Text_3Xl,
//    /// <summary>
//    /// font-size: 2.25rem; /* 36px */
//    /// line-height: 2.5rem; /* 40px */
//    /// </summary>
//    [EnumMember(Value = "text-4xl")]
//    Text_4Xl,
//    /// <summary>
//    /// font-size: 3rem; /* 48px */
//    /// line-height: 1;
//    /// </summary>
//    [EnumMember(Value = "text-5xl")]
//    Text_5Xl,
//    /// <summary>
//    /// font-size: 3.75rem; /* 60px */
//    /// line-height: 1;
//    /// </summary>
//    Text_6Xl,
//    /// <summary>
//    /// font-size: 4.5rem; /* 72px */
//    /// line-height: 1;
//    /// </summary>
//    [EnumMember(Value = "text-7xl")]
//    Text_7Xl,
//    /// <summary>
//    /// font-size: 6rem; /* 96px */
//    /// line-height: 1;
//    /// </summary>
//    [EnumMember(Value = "text-8xl")]
//    Text_8Xl,
//    /// <summary>
//    /// font-size: 8rem; /* 128px */
//    /// line-height: 1;
//    /// </summary>
//    [EnumMember(Value = "text-9xl")]
//    Text_9Xl,
//}
