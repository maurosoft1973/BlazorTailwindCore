using BlazorComponentUtilities;
using Maurosoft.Blazor.Tailwind.Core.Css;
using Maurosoft.Blazor.Tailwind.Core.Enums;
using Maurosoft.Blazor.Tailwind.Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Maurosoft.Blazor.Tailwind.Core.ExtensionMethods;

public static class EnumExtension
{
    /// <summary>
    /// 
    /// </summary>
    /// <typeparam name="T"></typeparam>
    /// <param name="cssProperties"></param>
    /// <returns></returns>
    public static string RenderCssProperty<T>(this IEnumerable<T> cssProperties) where T : ITailwindCssProperty
    {
        var cssPropertiesBuilder = new CssBuilder();

        foreach (var cssProperty in cssProperties)
            cssPropertiesBuilder.AddClass(cssProperty.Value.ToValue());

        return cssPropertiesBuilder.Build();
    }

    /// <summary>
    /// 
    /// </summary>
    /// <param name="value"></param>
    /// <returns></returns>
    public static string ToValue(this TailwindCssClassBase value)
    {
        if (value.Name == "notset")
            return "";
        else
            return value.Name;
    }

    /// <summary>
    /// 
    /// </summary>
    /// <param name="value"></param>
    /// <returns></returns>
    /// <exception cref="NotSupportedException"></exception>
    public static string? ToEnumMemberAttributeValue(this Enum value)
    {
        var enumType = value.GetType();
        var enumMemeberAttribute = enumType
            .GetTypeInfo()
            .DeclaredMembers
            .Single(x => x.Name == value.ToString())
            .GetCustomAttribute<EnumMemberAttribute>(false) ?? throw new NotSupportedException($"Enum: '{enumType.FullName}', value: {value} does not have attribute: '{nameof(EnumMemberAttribute)}'.");

        return enumMemeberAttribute.Value;
    }

    /// <summary>
    /// 
    /// </summary>
    /// <param name="value"></param>
    /// <param name="colorRgbPart"></param>
    /// <returns></returns>
    /// <exception cref="NotSupportedException"></exception>
    public static int RgbColor(this ColorRgb value, ColorRgbPart colorRgbPart)
    {
        var enumType = value.GetType();

        var enumMemeberAttribute = enumType
            .GetTypeInfo()
            .DeclaredMembers
            .Single(x => x.Name == value.ToString())
            .GetCustomAttribute<EnumMemberAttribute>(false) ?? throw new NotSupportedException($"Enum: '{enumType.FullName}', value: {value} does not have attribute: '{nameof(EnumMemberAttribute)}'.");

        var colorHex = enumMemeberAttribute.Value;

        var colorRgbPartValue = colorRgbPart switch
        {
            ColorRgbPart.R => 1,
            ColorRgbPart.G => 3,
            ColorRgbPart.B => 5,
            _ => 0
        };

        var t = colorHex?.Substring(colorRgbPartValue, 2);

        return Convert.ToInt32(t, 16);
    }
}
