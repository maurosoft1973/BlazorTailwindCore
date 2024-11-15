using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Maurosoft.Blazor.Tailwind.Core.Css;

/// <summary>
/// Utilities for controlling the space between child elements.
/// </summary>
public sealed class SpaceBetween : TailwindCssClassBase
{
    public static readonly SpaceBetween NotSet = new("notset", 0);


    private SpaceBetween(string name, int value) : base(name, value) { }
}
