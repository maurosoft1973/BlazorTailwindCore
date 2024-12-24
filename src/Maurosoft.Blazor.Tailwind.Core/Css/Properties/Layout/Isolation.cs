using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Maurosoft.Blazor.Tailwind.Core.Css.Properties.Layout;

/// <summary>
/// Utilities for controlling whether an element should explicitly create a new stacking context.
/// </summary>
public sealed class Isolation : TailwindCssClassBase
{
    public static readonly Isolation NotSet = new("notset", 1);
    public static readonly Isolation Isolate = new("isolate", 2);
    public static readonly Isolation Isolation_Auto = new("isolation-auto", 3);

    private Isolation(string name, int value) : base(name, value) { }
}
