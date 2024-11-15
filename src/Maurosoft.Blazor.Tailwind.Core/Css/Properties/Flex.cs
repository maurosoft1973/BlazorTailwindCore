using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Maurosoft.Blazor.Tailwind.Core.Css;

/// <summary>
/// Utilities for controlling how flex items both grow and shrink.
/// </summary>
public sealed class Flex : TailwindCssClassBase
{
    public static readonly Flex NotSet = new("notset", 1);
    public static readonly Flex Flex_1 = new("flex-1", 2);
    public static readonly Flex Flex_Auto = new("flex-auto", 3);
    public static readonly Flex Flex_Initial = new("flex-initial", 4);
    public static readonly Flex Flex_None = new("flex-none", 5);

    private Flex(string name, int value) : base(name, value) { }
}
