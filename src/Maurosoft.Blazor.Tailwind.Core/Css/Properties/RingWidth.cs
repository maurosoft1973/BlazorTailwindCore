using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Maurosoft.Blazor.Tailwind.Core.Css;

/// <summary>
/// Utilities for creating outline rings with box-shadows.
/// </summary>
public sealed class RingWidth : TailwindCssClassBase
{
    public static readonly RingWidth NotSet = new("notset", 1);
    public static readonly RingWidth Ring_0 = new("ring-0", 2);
    public static readonly RingWidth Ring_1 = new("ring-1", 3);
    public static readonly RingWidth Ring_2 = new("ring-2", 4);
    public static readonly RingWidth Ring = new("ring", 5);
    public static readonly RingWidth Ring_4 = new("ring-4", 6);
    public static readonly RingWidth Ring_8 = new("ring-8", 7);
    public static readonly RingWidth Ring_Inset = new("ring-inset", 8);

    private RingWidth(string name, int value) : base(name, value)
    {
    }
}

