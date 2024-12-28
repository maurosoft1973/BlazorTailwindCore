using Maurosoft.Blazor.Tailwind.Core.Css;
using Maurosoft.Blazor.Tailwind.Core.Css.Properties.Backgrounds;
using Maurosoft.Blazor.Tailwind.Core.Css.Properties.Borders;
using Maurosoft.Blazor.Tailwind.Core.Css.Properties.Custom;
using Maurosoft.Blazor.Tailwind.Core.Css.Properties.Effects;
using Maurosoft.Blazor.Tailwind.Core.Css.Properties.FlexboxGrid;
using Maurosoft.Blazor.Tailwind.Core.Css.Properties.Interactivity;
using Maurosoft.Blazor.Tailwind.Core.Css.Properties.Layout;
using Maurosoft.Blazor.Tailwind.Core.Css.Properties.Sizing;
using Maurosoft.Blazor.Tailwind.Core.Css.Properties.Spacing;
using Maurosoft.Blazor.Tailwind.Core.Css.Properties.Tables;
using Maurosoft.Blazor.Tailwind.Core.Css.Properties.Typography;
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
    public static void AddIfNotExist<P>(this IList<ITailwindCssProperty> cssProperties, TailwindCssPropertyScopeBase scope, TailwindCssClassBase value) where P : TailwindCssClassBase
    {
        var found = cssProperties.SingleOrDefault(c => c.Scope == scope && c.Name == typeof(P).Name);

        if (found == null)
            cssProperties.Add(new TailwindCssProperty<P>(value, scope));
    }

    /// <summary>
    /// Reads the value of a CSS property
    /// </summary>
    /// <typeparam name="P"></typeparam>
    /// <param name="cssProperties"></param>
    /// <param name="scope"></param>
    /// <returns></returns>
    public static P? ReadValue<P>(this IEnumerable<ITailwindCssProperty> cssProperties, TailwindCssPropertyScopeBase scope = TailwindCssPropertyScopeBase.All) where P : TailwindCssClassBase
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
    public static bool UpdateValue<P>(this IEnumerable<ITailwindCssProperty> cssProperties, TailwindCssClassBase value) where P : TailwindCssClassBase
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
    public static void UpdateOrAddValueIfNotExist<P>(this IList<ITailwindCssProperty> cssProperties, TailwindCssPropertyScopeBase scope, TailwindCssClassBase value) where P : TailwindCssClassBase
    {
        var found = cssProperties.SingleOrDefault(c => c.Name == typeof(P).Name);

        if (found != null)
            found.Value = value;
        else
            cssProperties.Add(new TailwindCssProperty<P>(value, scope));
    }

    /// <summary>
    /// 
    /// </summary>
    /// <typeparam name="P"></typeparam>
    /// <param name="cssProperties"></param>
    /// <param name="scope"></param>
    /// <param name="value"></param>
    public static void UpdateOrAddValueIfNotExist(this IList<ITailwindCssProperty> cssProperties, ITailwindCssProperty cssPropertyBase)
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
                case Type t when t == typeof(AlignItems):
                    cssProperties.Add(new TailwindCssProperty<AlignItems>(cssPropertyBase.Value, cssPropertyBase.Scope));
                    break;

                case Type t when t == typeof(BackgroundColor):
                    cssProperties.Add(new TailwindCssProperty<BackgroundColor>(cssPropertyBase.Value, cssPropertyBase.Scope));
                    break;

                case Type t when t == typeof(BorderCollapsed):
                    cssProperties.Add(new TailwindCssProperty<BorderCollapsed>(cssPropertyBase.Value, cssPropertyBase.Scope));
                    break;

                case Type t when t == typeof(BorderColor):
                    cssProperties.Add(new TailwindCssProperty<BorderColor>(cssPropertyBase.Value, cssPropertyBase.Scope));
                    break;

                case Type t when t == typeof(BorderRadius):
                    cssProperties.Add(new TailwindCssProperty<BorderRadius>(cssPropertyBase.Value, cssPropertyBase.Scope));
                    break;

                case Type t when t == typeof(BorderWidth):
                    cssProperties.Add(new TailwindCssProperty<BorderWidth>(cssPropertyBase.Value, cssPropertyBase.Scope));
                    break;

                case Type t when t == typeof(BorderWidthBottom):
                    cssProperties.Add(new TailwindCssProperty<BorderWidthBottom>(cssPropertyBase.Value, cssPropertyBase.Scope));
                    break;

                case Type t when t == typeof(BorderWidthLeft):
                    cssProperties.Add(new TailwindCssProperty<BorderWidthLeft>(cssPropertyBase.Value, cssPropertyBase.Scope));
                    break;

                case Type t when t == typeof(BorderWidthRight):
                    cssProperties.Add(new TailwindCssProperty<BorderWidthRight>(cssPropertyBase.Value, cssPropertyBase.Scope));
                    break;

                case Type t when t == typeof(BorderWidthTop):
                    cssProperties.Add(new TailwindCssProperty<BorderWidthTop>(cssPropertyBase.Value, cssPropertyBase.Scope));
                    break;

                case Type t when t == typeof(BoxShadow):
                    cssProperties.Add(new TailwindCssProperty<BoxShadow>(cssPropertyBase.Value, cssPropertyBase.Scope));
                    break;

                case Type t when t == typeof(ColorOpacity):
                    cssProperties.Add(new TailwindCssProperty<ColorOpacity>(cssPropertyBase.Value, cssPropertyBase.Scope));
                    break;

                case Type t when t == typeof(Cursor):
                    cssProperties.Add(new TailwindCssProperty<Cursor>(cssPropertyBase.Value, cssPropertyBase.Scope));
                    break;

                case Type t when t == typeof(Display):
                    cssProperties.Add(new TailwindCssProperty<Display>(cssPropertyBase.Value, cssPropertyBase.Scope));
                    break;

                case Type t when t == typeof(Flex):
                    cssProperties.Add(new TailwindCssProperty<Flex>(cssPropertyBase.Value, cssPropertyBase.Scope));
                    break;

                case Type t when t == typeof(FontSize):
                    cssProperties.Add(new TailwindCssProperty<FontSize>(cssPropertyBase.Value, cssPropertyBase.Scope));
                    break;

                case Type t when t == typeof(FontWeight):
                    cssProperties.Add(new TailwindCssProperty<FontWeight>(cssPropertyBase.Value, cssPropertyBase.Scope));
                    break;

                case Type t when t == typeof(Gap):
                    cssProperties.Add(new TailwindCssProperty<Gap>(cssPropertyBase.Value, cssPropertyBase.Scope));
                    break;

                case Type t when t == typeof(JustifySelf):
                    cssProperties.Add(new TailwindCssProperty<JustifySelf>(cssPropertyBase.Value, cssPropertyBase.Scope));
                    break;

                case Type t when t == typeof(JustifyItems):
                    cssProperties.Add(new TailwindCssProperty<JustifyItems>(cssPropertyBase.Value, cssPropertyBase.Scope));
                    break;

                case Type t when t == typeof(JustifyContent):
                    cssProperties.Add(new TailwindCssProperty<JustifyContent>(cssPropertyBase.Value, cssPropertyBase.Scope));
                    break;

                case Type t when t == typeof(GridColumn):
                    cssProperties.Add(new TailwindCssProperty<GridColumn>(cssPropertyBase.Value, cssPropertyBase.Scope));
                    break;

                case Type t when t == typeof(GridColumnEnd):
                    cssProperties.Add(new TailwindCssProperty<GridColumnEnd>(cssPropertyBase.Value, cssPropertyBase.Scope));
                    break;

                case Type t when t == typeof(GridColumnStart):
                    cssProperties.Add(new TailwindCssProperty<GridColumnStart>(cssPropertyBase.Value, cssPropertyBase.Scope));
                    break;

                case Type t when t == typeof(Height):
                    cssProperties.Add(new TailwindCssProperty<Height>(cssPropertyBase.Value, cssPropertyBase.Scope));
                    break;

                case Type t when t == typeof(MarginLeft):
                    cssProperties.Add(new TailwindCssProperty<MarginLeft>(cssPropertyBase.Value, cssPropertyBase.Scope));
                    break;

                case Type t when t == typeof(MarginTop):
                    cssProperties.Add(new TailwindCssProperty<MarginTop>(cssPropertyBase.Value, cssPropertyBase.Scope));
                    break;

                case Type t when t == typeof(MaxHeight):
                    cssProperties.Add(new TailwindCssProperty<MaxHeight>(cssPropertyBase.Value, cssPropertyBase.Scope));
                    break;

                case Type t when t == typeof(MaxWidth):
                    cssProperties.Add(new TailwindCssProperty<MaxWidth>(cssPropertyBase.Value, cssPropertyBase.Scope));
                    break;

                case Type t when t == typeof(MinHeight):
                    cssProperties.Add(new TailwindCssProperty<MinHeight>(cssPropertyBase.Value, cssPropertyBase.Scope));
                    break;

                case Type t when t == typeof(MinWidth):
                    cssProperties.Add(new TailwindCssProperty<MinWidth>(cssPropertyBase.Value, cssPropertyBase.Scope));
                    break;

                case Type t when t == typeof(Padding):
                    cssProperties.Add(new TailwindCssProperty<Padding>(cssPropertyBase.Value, cssPropertyBase.Scope));
                    break;

                case Type t when t == typeof(PaddingBottom):
                    cssProperties.Add(new TailwindCssProperty<PaddingBottom>(cssPropertyBase.Value, cssPropertyBase.Scope));
                    break;

                case Type t when t == typeof(PaddingEnd):
                    cssProperties.Add(new TailwindCssProperty<PaddingEnd>(cssPropertyBase.Value, cssPropertyBase.Scope));
                    break;

                case Type t when t == typeof(PaddingLeft):
                    cssProperties.Add(new TailwindCssProperty<PaddingLeft>(cssPropertyBase.Value, cssPropertyBase.Scope));
                    break;

                case Type t when t == typeof(PaddingRight):
                    cssProperties.Add(new TailwindCssProperty<PaddingRight>(cssPropertyBase.Value, cssPropertyBase.Scope));
                    break;

                case Type t when t == typeof(PaddingStart):
                    cssProperties.Add(new TailwindCssProperty<PaddingStart>(cssPropertyBase.Value, cssPropertyBase.Scope));
                    break;

                case Type t when t == typeof(PaddingTop):
                    cssProperties.Add(new TailwindCssProperty<PaddingTop>(cssPropertyBase.Value, cssPropertyBase.Scope));
                    break;

                case Type t when t == typeof(PaddingX):
                    cssProperties.Add(new TailwindCssProperty<PaddingX>(cssPropertyBase.Value, cssPropertyBase.Scope));
                    break;

                case Type t when t == typeof(PaddingY):
                    cssProperties.Add(new TailwindCssProperty<PaddingY>(cssPropertyBase.Value, cssPropertyBase.Scope));
                    break;

                case Type t when t == typeof(Position):
                    cssProperties.Add(new TailwindCssProperty<Position>(cssPropertyBase.Value, cssPropertyBase.Scope));
                    break;

                case Type t when t == typeof(Size):
                    cssProperties.Add(new TailwindCssProperty<Size>(cssPropertyBase.Value, cssPropertyBase.Scope));
                    break;

                case Type t when t == typeof(TextAlign):
                    cssProperties.Add(new TailwindCssProperty<TextAlign>(cssPropertyBase.Value, cssPropertyBase.Scope));
                    break;

                case Type t when t == typeof(TextColor):
                    cssProperties.Add(new TailwindCssProperty<TextColor>(cssPropertyBase.Value, cssPropertyBase.Scope));
                    break;

                case Type t when t == typeof(VerticalAlign):
                    cssProperties.Add(new TailwindCssProperty<VerticalAlign>(cssPropertyBase.Value, cssPropertyBase.Scope));
                    break;

                case Type t when t == typeof(Visibility):
                    cssProperties.Add(new TailwindCssProperty<Visibility>(cssPropertyBase.Value, cssPropertyBase.Scope));
                    break;

                case Type t when t == typeof(Width):
                    cssProperties.Add(new TailwindCssProperty<Width>(cssPropertyBase.Value, cssPropertyBase.Scope));
                    break;

                case Type t when t == typeof(ZIndex):
                    cssProperties.Add(new TailwindCssProperty<ZIndex>(cssPropertyBase.Value, cssPropertyBase.Scope));
                    break;
            }
        }
    }
}
