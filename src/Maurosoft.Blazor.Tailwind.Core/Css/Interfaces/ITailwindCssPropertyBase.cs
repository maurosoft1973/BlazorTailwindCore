using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Maurosoft.Blazor.Tailwind.Core.Css;

public interface ITailwindCssPropertyBase : ITailwindCssProperty
{
    Type Type { get; }
    TailwindCssPropertyScopeBase Scope { get; set; }
}
