using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using Maurosoft.Blazor.Tailwind.Core.Css;
using Maurosoft.Blazor.Tailwind.Core.Enums;
using Maurosoft.Blazor.Tailwind.Core.Interfaces;
using Microsoft.AspNetCore.Components;

namespace Maurosoft.Blazor.Tailwind.Core;

public partial class TailwindCssProperty<CssClass> : ITailwindCssProperty where CssClass : TailwindCssClassBase
{
    public TailwindCssProperty()
    {

    }

    public TailwindCssProperty(TailwindCssClassBase value, TailwindCssPropertyScopeBase scope = TailwindCssPropertyScopeBase.All)
    {
        Value = value;
        Scope = scope;
    }

    public string Name { get; } = typeof(CssClass).Name;

    public TailwindCssPropertyScopeBase Scope { get; set; } = TailwindCssPropertyScopeBase.All;

    public TailwindCssClassBase Value { get; set; } = default!;

    public Type Type => typeof(CssClass);
}
