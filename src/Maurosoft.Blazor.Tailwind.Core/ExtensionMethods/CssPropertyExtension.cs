using Maurosoft.Blazor.Tailwind.Core.Css;
using Maurosoft.Blazor.Tailwind.Core.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Maurosoft.Blazor.Tailwind.Core.ExtensionMethods;

public static class CssPropertyExtension
{
    /// <summary>
    /// Adds a CSS property if it does not exist
    /// </summary>
    /// <typeparam name="T"></typeparam>
    /// <typeparam name="P"></typeparam>
    /// <param name="cssProperties"></param>
    /// <param name="scope"></param>
    /// <param name="value"></param>
    public static void AddIfNotExist<P>(this IList<ITailwindCssPropertyBase> cssProperties, TailwindCssPropertyScopeBase scope, TailwindCssClassBase value) where P : TailwindCssClassBase
    {
        var found = cssProperties.SingleOrDefault(c => c.Scope == scope && c.Name == typeof(P).Name);

        if (found == null)
            cssProperties.Add(new BaseComponentCssProperty<P>(scope, value));
    }

    /// <summary>
    /// Reads the value of a CSS property
    /// </summary>
    /// <typeparam name="P"></typeparam>
    /// <param name="cssProperties"></param>
    /// <param name="scope"></param>
    /// <returns></returns>
    public static P? ReadValue<P>(this IEnumerable<ITailwindCssPropertyBase> cssProperties, TailwindCssPropertyScopeBase scope = TailwindCssPropertyScopeBase.All) where P : TailwindCssClassBase
    {
        var found = cssProperties.SingleOrDefault(c => (c.Scope == scope || scope == TailwindCssPropertyScopeBase.All) && c.Name == typeof(P).Name);

        if (found != null)
            return (P)found.Value;
        else
            return default;
    }

    /// <summary>
    /// Updates the value of a CSS property
    /// </summary>
    /// <typeparam name="T"></typeparam>
    /// <param name="cssProperties"></param>
    /// <returns>True if <typeparamref name="P"/> exist, false otherwise</returns>
    public static bool UpdateValue<P>(this IEnumerable<ITailwindCssPropertyBase> cssProperties, TailwindCssClassBase value) where P : TailwindCssClassBase
    {
        var found = cssProperties.SingleOrDefault(c => c.Name == typeof(P).Name);

        if (found != null)
        {
            found.Value = value;
            return true;
        }
        else
            return false;
    }

    /// <summary>
    /// 
    /// </summary>
    /// <typeparam name="P"></typeparam>
    /// <param name="cssProperties"></param>
    /// <param name="scope"></param>
    /// <param name="value"></param>
    public static void UpdateOrAddValueIfNotExist<P>(this IList<ITailwindCssPropertyBase> cssProperties, TailwindCssPropertyScopeBase scope, TailwindCssClassBase value) where P : TailwindCssClassBase
    {
        var found = cssProperties.SingleOrDefault(c => c.Name == typeof(P).Name);

        if (found != null)
        {
            found.Value = value;
        }
        else
            cssProperties.Add(new BaseComponentCssProperty<P>(scope, value));
    }

    /// <summary>
    /// 
    /// </summary>
    /// <typeparam name="P"></typeparam>
    /// <param name="cssProperties"></param>
    /// <param name="scope"></param>
    /// <param name="value"></param>
    public static void UpdateOrAddValueIfNotExist(this IList<ITailwindCssPropertyBase> cssProperties, ITailwindCssPropertyBase cssPropertyBase)
    {
        var found = cssProperties.SingleOrDefault(c => c.Name == cssPropertyBase.Name && c.Scope == cssPropertyBase.Scope);

        if (found != null)
        {
            found.Value = cssPropertyBase.Value;
        }
        else
        {
            switch (cssPropertyBase.Type)
            {
                case Type t when t == typeof(AlignItem):
                    cssProperties.Add(new BaseComponentCssProperty<AlignItem>(cssPropertyBase.Scope, cssPropertyBase.Value));
                    break;

                case Type t when t == typeof(BackgroundColor):
                    cssProperties.Add(new BaseComponentCssProperty<BackgroundColor>(cssPropertyBase.Scope, cssPropertyBase.Value));
                    break;

                case Type t when t == typeof(BorderCollapsed):
                    cssProperties.Add(new BaseComponentCssProperty<BorderCollapsed>(cssPropertyBase.Scope, cssPropertyBase.Value));
                    break;

                case Type t when t == typeof(BorderColor):
                    cssProperties.Add(new BaseComponentCssProperty<BorderColor>(cssPropertyBase.Scope, cssPropertyBase.Value));
                    break;

                case Type t when t == typeof(BorderRadius):
                    cssProperties.Add(new BaseComponentCssProperty<BorderRadius>(cssPropertyBase.Scope, cssPropertyBase.Value));
                    break;

                case Type t when t == typeof(BorderWidth):
                    cssProperties.Add(new BaseComponentCssProperty<BorderWidth>(cssPropertyBase.Scope, cssPropertyBase.Value));
                    break;

                case Type t when t == typeof(BorderWidthBottom):
                    cssProperties.Add(new BaseComponentCssProperty<BorderWidthBottom>(cssPropertyBase.Scope, cssPropertyBase.Value));
                    break;

                case Type t when t == typeof(BorderWidthLeft):
                    cssProperties.Add(new BaseComponentCssProperty<BorderWidthLeft>(cssPropertyBase.Scope, cssPropertyBase.Value));
                    break;

                case Type t when t == typeof(BorderWidthRight):
                    cssProperties.Add(new BaseComponentCssProperty<BorderWidthRight>(cssPropertyBase.Scope, cssPropertyBase.Value));
                    break;

                case Type t when t == typeof(BorderWidthTop):
                    cssProperties.Add(new BaseComponentCssProperty<BorderWidthTop>(cssPropertyBase.Scope, cssPropertyBase.Value));
                    break;

                case Type t when t == typeof(BoxShadow):
                    cssProperties.Add(new BaseComponentCssProperty<BoxShadow>(cssPropertyBase.Scope, cssPropertyBase.Value));
                    break;

                case Type t when t == typeof(Color):
                    cssProperties.Add(new BaseComponentCssProperty<Color>(cssPropertyBase.Scope, cssPropertyBase.Value));
                    break;

                case Type t when t == typeof(ColorOpacity):
                    cssProperties.Add(new BaseComponentCssProperty<ColorOpacity>(cssPropertyBase.Scope, cssPropertyBase.Value));
                    break;

                case Type t when t == typeof(Cursor):
                    cssProperties.Add(new BaseComponentCssProperty<Cursor>(cssPropertyBase.Scope, cssPropertyBase.Value));
                    break;

                case Type t when t == typeof(Display):
                    cssProperties.Add(new BaseComponentCssProperty<Display>(cssPropertyBase.Scope, cssPropertyBase.Value));
                    break;

                case Type t when t == typeof(Flex):
                    cssProperties.Add(new BaseComponentCssProperty<Flex>(cssPropertyBase.Scope, cssPropertyBase.Value));
                    break;

                case Type t when t == typeof(FontSize):
                    cssProperties.Add(new BaseComponentCssProperty<FontSize>(cssPropertyBase.Scope, cssPropertyBase.Value));
                    break;

                case Type t when t == typeof(FontWeight):
                    cssProperties.Add(new BaseComponentCssProperty<FontWeight>(cssPropertyBase.Scope, cssPropertyBase.Value));
                    break;

                case Type t when t == typeof(Gap):
                    cssProperties.Add(new BaseComponentCssProperty<Gap>(cssPropertyBase.Scope, cssPropertyBase.Value));
                    break;

                case Type t when t == typeof(GridColumn):
                    cssProperties.Add(new BaseComponentCssProperty<GridColumn>(cssPropertyBase.Scope, cssPropertyBase.Value));
                    break;

                case Type t when t == typeof(GridColumnEnd):
                    cssProperties.Add(new BaseComponentCssProperty<GridColumnEnd>(cssPropertyBase.Scope, cssPropertyBase.Value));
                    break;

                case Type t when t == typeof(GridColumnStart):
                    cssProperties.Add(new BaseComponentCssProperty<GridColumnStart>(cssPropertyBase.Scope, cssPropertyBase.Value));
                    break;

                case Type t when t == typeof(Height):
                    cssProperties.Add(new BaseComponentCssProperty<Height>(cssPropertyBase.Scope, cssPropertyBase.Value));
                    break;

                case Type t when t == typeof(MarginLeft):
                    cssProperties.Add(new BaseComponentCssProperty<MarginLeft>(cssPropertyBase.Scope, cssPropertyBase.Value));
                    break;

                case Type t when t == typeof(MarginTop):
                    cssProperties.Add(new BaseComponentCssProperty<MarginTop>(cssPropertyBase.Scope, cssPropertyBase.Value));
                    break;

                case Type t when t == typeof(Padding):
                    cssProperties.Add(new BaseComponentCssProperty<Padding>(cssPropertyBase.Scope, cssPropertyBase.Value));
                    break;

                case Type t when t == typeof(Position):
                    cssProperties.Add(new BaseComponentCssProperty<Position>(cssPropertyBase.Scope, cssPropertyBase.Value));
                    break;

                case Type t when t == typeof(Size):
                    cssProperties.Add(new BaseComponentCssProperty<Size>(cssPropertyBase.Scope, cssPropertyBase.Value));
                    break;

                case Type t when t == typeof(TextAlign):
                    cssProperties.Add(new BaseComponentCssProperty<TextAlign>(cssPropertyBase.Scope, cssPropertyBase.Value));
                    break;

                case Type t when t == typeof(TextColor):
                    cssProperties.Add(new BaseComponentCssProperty<TextColor>(cssPropertyBase.Scope, cssPropertyBase.Value));
                    break;

                case Type t when t == typeof(VerticalAlign):
                    cssProperties.Add(new BaseComponentCssProperty<VerticalAlign>(cssPropertyBase.Scope, cssPropertyBase.Value));
                    break;

                case Type t when t == typeof(Visibility):
                    cssProperties.Add(new BaseComponentCssProperty<Visibility>(cssPropertyBase.Scope, cssPropertyBase.Value));
                    break;

                case Type t when t == typeof(Width):
                    cssProperties.Add(new BaseComponentCssProperty<Width>(cssPropertyBase.Scope, cssPropertyBase.Value));
                    break;

                case Type t when t == typeof(ZIndex):
                    cssProperties.Add(new BaseComponentCssProperty<ZIndex>(cssPropertyBase.Scope, cssPropertyBase.Value));
                    break;
            }
        }
    }
}
