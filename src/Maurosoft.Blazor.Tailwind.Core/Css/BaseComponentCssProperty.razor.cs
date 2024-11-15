using Maurosoft.Blazor.Tailwind.Core.Css;
using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Maurosoft.Blazor.Tailwind.Core;

public partial class BaseComponentCssProperty<CssProperty> : ITailwindCssPropertyBase
{
    public BaseComponentCssProperty()
    {

    }

    public BaseComponentCssProperty(TailwindCssPropertyScopeBase scope, TailwindCssClassBase value)
    {
        Scope = scope;
        Value = value;
    }

    public string Name { get; } = typeof(CssProperty).Name;

    public Type Type { get; } = typeof(CssProperty);

    [Parameter]
    public TailwindCssPropertyScopeBase Scope { get; set; } = TailwindCssPropertyScopeBase.All;

    [Parameter]
    public TailwindCssClassBase Value { get; set; } = default!;

    /// <summary>
    /// Parent Component
    /// </summary>
    [CascadingParameter(Name = "Component")]
    public BlazorComponentBase Component { get; set; } = default!;

    protected override void OnInitialized()
    {
        Component.AddCssProperty(this);
    }
}
