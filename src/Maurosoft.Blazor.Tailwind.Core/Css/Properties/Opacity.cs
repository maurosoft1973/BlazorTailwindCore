using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Maurosoft.Blazor.Tailwind.Core.Css;

public sealed class Opacity : TailwindCssClassBase
{
    public static readonly Opacity NotSet = new("notset", 1);
    public static readonly Opacity Opacity_0 = new("opacity-0", 2);
    public static readonly Opacity Opacity_5 = new("opacity-5", 3);
    public static readonly Opacity Opacity_10 = new("opacity-10", 4);
    public static readonly Opacity Opacity_15 = new("opacity-15", 5);
    public static readonly Opacity Opacity_20 = new("opacity-20", 6);
    public static readonly Opacity Opacity_25 = new("opacity-25", 7);
    public static readonly Opacity Opacity_30 = new("opacity-30", 8);
    public static readonly Opacity Opacity_35 = new("opacity-35", 9);
    public static readonly Opacity Opacity_40 = new("opacity-40", 10);
    public static readonly Opacity Opacity_45 = new("opacity-45", 11);
    public static readonly Opacity Opacity_50 = new("opacity-50", 12);
    public static readonly Opacity Opacity_55 = new("opacity-55", 13);
    public static readonly Opacity Opacity_60 = new("opacity-60", 14);
    public static readonly Opacity Opacity_65 = new("opacity-65", 15);
    public static readonly Opacity Opacity_70 = new("opacity-70", 16);
    public static readonly Opacity Opacity_75 = new("opacity-75", 17);
    public static readonly Opacity Opacity_80 = new("opacity-80", 18);
    public static readonly Opacity Opacity_85 = new("opacity-85", 19);
    public static readonly Opacity Opacity_90 = new("opacity-90", 20);
    public static readonly Opacity Opacity_95 = new("opacity-95", 21);
    public static readonly Opacity Opacity_100 = new("opacity-100", 22);

    private Opacity(string name, int value) : base(name, value) { }
}
//public enum Opacity
//{
//    [EnumMember(Value = "")]
//    NotSet,
//    [EnumMember(Value = "opacity-0")]
//    Opacity_0,
//    [EnumMember(Value = "opacity-5")]
//    Opacity_5,
//    [EnumMember(Value = "opacity-10")]
//    Opacity_10,
//    [EnumMember(Value = "opacity-15")]
//    Opacity_15,
//    [EnumMember(Value = "opacity-20")]
//    Opacity_20,
//    [EnumMember(Value = "opacity-25")]
//    Opacity_25,
//    [EnumMember(Value = "opacity-30")]
//    Opacity_30,
//    [EnumMember(Value = "opacity-35")]
//    Opacity_35,
//    [EnumMember(Value = "opacity-40")]
//    Opacity_40,
//    [EnumMember(Value = "opacity-45")]
//    Opacity_45,
//    [EnumMember(Value = "opacity-50")]
//    Opacity_50,
//    [EnumMember(Value = "opacity-55")]
//    Opacity_55,
//    [EnumMember(Value = "opacity-60")]
//    Opacity_60,
//    [EnumMember(Value = "opacity-65")]
//    Opacity_65,
//    [EnumMember(Value = "opacity-70")]
//    Opacity_70,
//    [EnumMember(Value = "opacity-75")]
//    Opacity_75,
//    [EnumMember(Value = "opacity-80")]
//    Opacity_80,
//    [EnumMember(Value = "opacity-85")]
//    Opacity_85,
//    [EnumMember(Value = "opacity-90")]
//    Opacity_90,
//    [EnumMember(Value = "opacity-95")]
//    Opacity_95,
//    [EnumMember(Value = "opacity-100")]
//    Opacity_100
//}
