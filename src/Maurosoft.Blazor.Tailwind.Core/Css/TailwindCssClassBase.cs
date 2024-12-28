using Ardalis.SmartEnum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Maurosoft.Blazor.Tailwind.Core.Css;

public abstract class TailwindCssClassBase(string name, int value) : SmartEnum<TailwindCssClassBase>(name, value)
{
}
