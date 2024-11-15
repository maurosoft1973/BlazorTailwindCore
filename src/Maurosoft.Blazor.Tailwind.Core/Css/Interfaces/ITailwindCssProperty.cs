using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Maurosoft.Blazor.Tailwind.Core.Css;

public interface ITailwindCssProperty
{
    string Name { get; }

    TailwindCssClassBase Value { get; set; }
}
