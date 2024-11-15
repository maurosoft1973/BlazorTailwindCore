using Maurosoft.Blazor.Tailwind.Core.Css;
using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Maurosoft.Blazor.Tailwind.Core.Interfaces;

public interface IBlazorComponentBase
{
    void AddCssProperty(ITailwindCssPropertyBase cssProperty);

    void RegenerateCssContainerClasses(bool stateHasChanged = false);

    bool Disabled { get; set; }

    ElementReference Element { get; set; }

    bool HasJavascript { get; set; }

    string? Id { get; set; }

    string JavascriptFile { get; set; }

    string Label { get; set; }

    string Tooltip { get; set; }

    bool Visible { get; set; }
}
