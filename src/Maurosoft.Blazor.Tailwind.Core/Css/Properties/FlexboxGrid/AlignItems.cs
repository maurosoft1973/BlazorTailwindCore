using Ardalis.SmartEnum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Maurosoft.Blazor.Tailwind.Core.Css.Properties.FlexboxGrid;

/// <summary>
/// Utilities for controlling how flex and grid items are positioned along a container's cross axis.
/// For info, see <see href="https://tailwindcss.com/docs/align-items">align-items</see>
/// </summary>
public sealed class AlignItems : TailwindCssClassBase
{
    public static readonly AlignItems NotSet = new("notset", 1);
    public static readonly AlignItems Items_Start = new("items-start", 2);
    public static readonly AlignItems Items_End = new("items-end", 3);
    public static readonly AlignItems Items_Center = new("items-center", 4);
    public static readonly AlignItems Items_Baseline = new("items-baseline", 5);
    public static readonly AlignItems Items_Stretch = new("items-stretch", 6);

    private AlignItems(string name, int value) : base(name, value) { }
}
