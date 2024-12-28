using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Maurosoft.Blazor.Tailwind.Core.Css;
using Maurosoft.Blazor.Tailwind.Core.Enums;

namespace Maurosoft.Blazor.Tailwind.Core.Interfaces;

public interface ITailwindCssProperty
{
    string Name { get; }

    TailwindCssClassBase Value { get; set; }

    TailwindCssPropertyScopeBase Scope { get; set; }

    Type Type { get; }
}
