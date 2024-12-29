# Blazor Tailwind Component Core

[![NuGet Downloads](https://img.shields.io/nuget/dt/Maurosoft.Blazor.Tailwind.Core)](https://www.nuget.org/packages/Maurosoft.Blazor.Tailwind.Core/)

### Description
**Blazor Tailwind Component Core** is a library for creating custom Blazor components built on the **Tailwind CSS** framework. This library simplifies the integration of visual components into Blazor applications by providing a base class for component creation and css class mapping with the Tailwind framework.

The library provides the abstract class ***BlazorComponentBase*** for its own customised component and the class ***TailwindCssProperty*** for css properties.

For each css property, it is possible to define a scope per element, so that each html tag receives its own specific css classes (an example will better clarify the usage)

This allows you to optimise the use of css classes through the use of code and greater customisation by the user of your component

It is possible to change the value of the css properties when an event (click) occurs, with the component layout automatically updating to reflect the new configuration.

The library provides the following css files:
- ***style.css***: contains all mapped css classes
- ***colour.css***: contains the text and background colour classes

How to use the file stylesheets them within your project?

1. Install the library from Nuget: https://www.nuget.org/packages/Maurosoft.Blazor.Tailwind.Core/
2. Add ```<link rel="stylesheet" href="_content/Maurosoft.Blazor.Tailwind.Core/css/style.css" />``` or ```<link rel="stylesheet" href="_content/Maurosoft.Blazor.Tailwind.Core/css/colour.css" />``` to your App.razor file, inside <head></head>

### Example

MyComponent.razor
```
@using Maurosoft.Blazor.Tailwind.Core;
@using Maurosoft.Blazor.Tailwind.Core.Css;
@using Maurosoft.Blazor.Tailwind.Core.Enums;
@using Maurosoft.Blazor.Tailwind.Core.ExtensionMethods;
@using Maurosoft.Blazor.Tailwind.Core.Interfaces;
@namespace MyNamespace
@inherits BlazorComponentBase

<div class="@RenderCssProperty(TailwindCssPropertyScopeBase.Container)">
    <div>
        <div class="@RenderCssProperty(TailwindCssPropertyScopeBase.Content)">
            <div class="@RenderCssProperty(TailwindCssPropertyScopeBase.Content1)">
        </div>
        <span class="@RenderCssProperty(TailwindCssPropertyScopeBase.Label)">Label</span>
    </div>
</div>
```

MyComponent.razor.cs
```
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

namespace MyNamespace

public partial class MyComponent : BlazorComponentBase
{
    protected override bool ShouldAutoGenerateId => true;

    protected override string IdSuffix => "mycomponent-";

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
    }

    protected override void OnGenerateCssClasses()
    {

    }
}
```

### Features
- **Base class for components**: Allows the creation of custom Blazor components with a predefined structure.
- **Tailwind CSS mapping**: Facilitates the association of Tailwind classes with Blazor components.

### Requirements
- **.NET 8.0** or later

### List of mapped Tailwind Css Classes (<https://tailwindcss.com/docs/installation>)

#### Layout (17/20)
- [x] Aspect Ratio
- [x] Container
- [x] Columns
- [x] Break After
- [x] Break Before
- [x] Break Inside
- [x] Box Decoration Break
- [x] Box Sizing
- [x] Display
- [x] Floats
- [x] Clear
- [x] Isolation
- [ ] Object Fit
- [ ] Object Position
- [x] Overflow
- [ ] Overscroll Behavior
- [x] Position
- [x] Top / Right / Bottom / Left
- [x] Visibility
- [x] Z-Index

#### Flexbox e Grid (15/24)
- [ ] Flex Basis
- [x] Flex Direction
- [x] Flex Wrap
- [x] Flex
- [x] Flex Grow
- [x] Flex Shrink
- [x] Order
- [x] Grid Template Columns
- [x] Grid Column Start / End
- [x] Grid Template Rows
- [x] Grid Row Start / End
- [ ] Grid Auto Flow
- [ ] Grid Auto Columns
- [ ] Grid Auto Rows
- [x] Gap
- [x] Justify Content
- [x] Justify Items
- [x] Justify Self
- [ ] Align Content
- [x] Align Items
- [ ] Align Self
- [ ] Place Content
- [ ] Place Items
- [ ] Place Self

#### Spacing (3/3)
- [x] Padding ([x] bottom, [x] top, [x] left, [x] right, [x] start, [x] end, [x] x, [x] y)
- [x] Margin ([x] bottom, [x] top, [x] left, [x] right, [x] start, [x] end)
- [x] Space Between ([x]) x, [x] y)

#### Sizing (6/6)
- [x] Width
- [x] Min-Width
- [x] Max-Width
- [x] Height
- [x] Min-Height
- [x] Max-Height
- [x] Size

#### Typography (8/28)
- [x] Font Family
- [x] Font Size
- [ ] Font Smoothing
- [x] Font Style
- [x] Font Weight
- [ ] Font Variant Numeric
- [ ] Letter Spacing
- [ ] Line Clamp
- [x] Line Height
- [ ] List Style Image
- [ ] List Style Position
- [ ] List Style Type
- [x] Text Align
- [x] Text Color ([x] focus, [x] hover)
- [ ] Text Decoration
- [ ] Text Decoration Color
- [ ] Text Decoration Style
- [ ] Text Decoration Thickness
- [ ] Text Underline Offset
- [ ] Text Transform
- [ ] Text Overflow
- [ ] Text Wrap
- [ ] Text Indent
- [x] Vertical Align
- [ ] Whitespace
- [ ] Word Break
- [ ] Hyphens
- [ ] Content

#### Backgrounds (4/9)
- [ ] Background Attachment
- [ ] Background Clip
- [x] Background Color ([x] focus, [x] hover)
- [ ] Background Origin
- [x] Background Position
- [x] Background Repeat
- [x] Background Size
- [ ] Background Image
- [ ] Gradient Color Stops

#### Borders (9/15)
- [x] Border Radius
- [x] Border Width ([x] bottom, [x] top, [x] left, [x] right, [x] start, [x] end)
- [x] Border Color
- [x] Border Style
- [ ] Divide Width
- [ ] Divide Color
- [ ] Divide Style
- [ ] Outline Width
- [x] Outline Color ([x] focus)
- [x] Outline Style ([x] focus)
- [x] Outline Offset
- [x] Ring Width
- [x] Ring Color
- [ ] Ring Offset Width
- [ ] Ring Offset Color

#### Effects (2/5)
- [x] Box Shadow
- [ ] Box Shadow Color
- [x] Opacity
- [ ] Mix Blend Mode
- [ ] Background Blend Mode

#### Filters (0/18)
- [ ] Blur
- [ ] Brightness
- [ ] Contrast
- [ ] Drop Shadow
- [ ] Grayscale
- [ ] Hue Rotate
- [ ] Invert
- [ ] Saturate
- [ ] Sepia
- [ ] Backdrop Blur
- [ ] Backdrop Brightness
- [ ] Backdrop Contrast
- [ ] Backdrop Grayscale
- [ ] Backdrop Hue Rotate
- [ ] Backdrop Invert
- [ ] Backdrop Opacity
- [ ] Backdrop Saturate
- [ ] Backdrop Sepia

#### Tables (1/4)
- [x] Border Collapse
- [ ] Border Spacing
- [ ] Table Layout
- [ ] Caption Side

#### Transitions & Animation (0/5)
- [ ] Transition Property
- [ ] Transition Duration
- [ ] Transition Timing Function
- [ ] Transition Delay
- [ ] Animation

#### Transforms (1/5)
- [ ] Scale
- [ ] Rotate
- [x] Translate
- [ ] Skew
- [ ] Transform Origin

#### Interactivity (1/15)
- [ ] Accent Color
- [ ] Appearance
- [x] Cursor
- [ ] Caret Color
- [ ] Pointer Events
- [ ] Resize
- [ ] Scroll Behavior
- [ ] Scroll Margin
- [ ] Scroll Padding
- [ ] Scroll Snap Align
- [ ] Scroll Snap Stop
- [ ] Scroll Snap Type
- [ ] Touch Action
- [ ] User Select
- [ ] Will Change

#### SVG (0/3)
- [ ] Fill
- [ ] Stroke
- [ ] Stroke Width

#### Accessibility (0/2)
- [ ] Screen Readers
- [ ] Forced Color Adjust

### Contributing
Contributions, bug reports, and feature requests are welcome! To contribute:
1. Fork the repository.
2. Create a new branch for your changes.
3. Submit a pull request for review.

### License
Distributed under the MIT License. See the [LICENSE](LICENSE) file for more details.
