using Maurosoft.Blazor.Tailwind.Core.Css;
using Maurosoft.Blazor.Tailwind.Core.Enums;
using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Maurosoft.Blazor.Tailwind.Core.Interfaces;

public interface IBlazorComponentBase
{
    void AddOrUpdateCssProperty(ITailwindCssProperty cssProperty, bool stateHasChanged = true);

    void AddOrUpdateCssProperties(IList<ITailwindCssProperty> cssProperties, bool stateHasChanged = true);

    string RenderCssProperty(TailwindCssPropertyScopeBase tailwindCssPropertyScopeBase = TailwindCssPropertyScopeBase.None);

    bool Disabled { get; set; }

    ElementReference Element { get; set; }

    bool LoadFlowbiteLibrary { get; set; }

    bool HasJavascript { get; set; }

    string? Id { get; set; }

    string JavascriptFile { get; set; }

    string Label { get; set; }

    string Tooltip { get; set; }

    bool Visible { get; set; }
}
