using Maurosoft.Blazor.Tailwind.Core.Css;
using Maurosoft.Blazor.Tailwind.Core.Css.Properties.Backgrounds;
using Maurosoft.Blazor.Tailwind.Core.Css.Properties.Borders;
using Maurosoft.Blazor.Tailwind.Core.Css.Properties.FlexboxGrid;
using Maurosoft.Blazor.Tailwind.Core.Css.Properties.Layout;
using Maurosoft.Blazor.Tailwind.Core.Css.Properties.Sizing;
using Maurosoft.Blazor.Tailwind.Core.Css.Properties.Spacing;
using Maurosoft.Blazor.Tailwind.Core.Css.Properties.Typography;
using Maurosoft.Blazor.Tailwind.Core.Enums;
using Maurosoft.Blazor.Tailwind.Core.ExtensionMethods;
using Maurosoft.Blazor.Tailwind.Core.Interfaces;
using Microsoft.AspNetCore.Components;

namespace Maurosoft.Blazor.Tailwind.Core.DemoTailwind.Components.Custom;

public partial class Countdown : BlazorComponentBase
{
    protected override bool ShouldAutoGenerateId => true;

    protected override string IdSuffix => "countdown-";

    protected override void OnInitializeCssProperties()
    {
        //mt-10 flex flex-wrap justify-center gap-6
        AddOrUpdateCssProperty(new TailwindCssProperty<MarginTop>(MarginTop.mt_10, TailwindCssPropertyScopeBase.Container), false);
        AddOrUpdateCssProperty(new TailwindCssProperty<Display>(Display.Flex, TailwindCssPropertyScopeBase.Container), false);
        AddOrUpdateCssProperty(new TailwindCssProperty<JustifyContent>(JustifyContent.Justify_Center, TailwindCssPropertyScopeBase.Container), false);
        AddOrUpdateCssProperty(new TailwindCssProperty<Gap>(Gap.Gap_6, TailwindCssPropertyScopeBase.Container), false);

        //mb-3 flex items-center gap-2
        AddOrUpdateCssProperty(new TailwindCssProperty<MarginBottom>(MarginBottom.mb_3, TailwindCssPropertyScopeBase.Content), false);
        AddOrUpdateCssProperty(new TailwindCssProperty<Display>(Display.Flex, TailwindCssPropertyScopeBase.Content), false);
        AddOrUpdateCssProperty(new TailwindCssProperty<AlignItems>(AlignItems.Items_Center, TailwindCssPropertyScopeBase.Content), false);
        AddOrUpdateCssProperty(new TailwindCssProperty<Gap>(Gap.Gap_2, TailwindCssPropertyScopeBase.Content), false);

        //relative overflow-hidden rounded-lg
        AddOrUpdateCssProperty(new TailwindCssProperty<Position>(Position.Relative, TailwindCssPropertyScopeBase.Content1), false);
        AddOrUpdateCssProperty(new TailwindCssProperty<BorderRadius>(BorderRadius.Rounded_Lg, TailwindCssPropertyScopeBase.Content1), false);
        AddOrUpdateCssProperty(new TailwindCssProperty<Overflow>(Overflow.Hidden, TailwindCssPropertyScopeBase.Content1), false);

        //block text-center font-medium
        AddOrUpdateCssProperty(new TailwindCssProperty<Display>(Display.Block, TailwindCssPropertyScopeBase.Label), false);
        AddOrUpdateCssProperty(new TailwindCssProperty<FontWeight>(FontWeight.Font_Medium, TailwindCssPropertyScopeBase.Label), false);
        AddOrUpdateCssProperty(new TailwindCssProperty<TextAlign>(TextAlign.Text_Center, TailwindCssPropertyScopeBase.Label), false);

        //items-center justify-center rounded-lg px-3 text-xl font-black bg-black text-white
        AddOrUpdateCssProperty(new TailwindCssProperty<AlignItems>(AlignItems.Items_Center, TailwindCssPropertyScopeBase.Element1), false);
        AddOrUpdateCssProperty(new TailwindCssProperty<JustifyContent>(JustifyContent.Justify_Center, TailwindCssPropertyScopeBase.Element1), false);
        AddOrUpdateCssProperty(new TailwindCssProperty<BorderRadius>(BorderRadius.Rounded_Lg, TailwindCssPropertyScopeBase.Element1), false);
        AddOrUpdateCssProperty(new TailwindCssProperty<PaddingX>(PaddingX.px_3, TailwindCssPropertyScopeBase.Element1), false);
        AddOrUpdateCssProperty(new TailwindCssProperty<FontSize>(FontSize.Text_3Xl, TailwindCssPropertyScopeBase.Element1), false);
        AddOrUpdateCssProperty(new TailwindCssProperty<FontWeight>(FontWeight.Font_Black, TailwindCssPropertyScopeBase.Element1), false);
        AddOrUpdateCssProperty(new TailwindCssProperty<BackgroundColor>(BackgroundColor.Black, TailwindCssPropertyScopeBase.Element1), false);
        AddOrUpdateCssProperty(new TailwindCssProperty<TextColor>(TextColor.White, TailwindCssPropertyScopeBase.Element1), false);
        AddOrUpdateCssProperty(new TailwindCssProperty<Height>(Height.H_20, TailwindCssPropertyScopeBase.Element1), false);
        AddOrUpdateCssProperty(new TailwindCssProperty<MinWidth>(MinWidth.Min_W_16, TailwindCssPropertyScopeBase.Element1), false);
    }

    protected override void OnGenerateCssClasses()
    {

    }
}
