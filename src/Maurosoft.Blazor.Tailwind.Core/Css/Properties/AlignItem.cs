using Ardalis.SmartEnum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Maurosoft.Blazor.Tailwind.Core.Css;

/// <summary>
/// Utilities for controlling how flex and grid items are positioned along a container's cross axis.
/// For info, see <see href="https://tailwindcss.com/docs/align-items">align-items</see>
/// </summary>
public sealed class AlignItem : TailwindCssClassBase
{
    public static readonly AlignItem NotSet = new("notset", 1);
    public static readonly AlignItem Items_Start = new("items-start", 2);
    public static readonly AlignItem Items_End = new("items-end", 3);
    public static readonly AlignItem Items_Center = new("items-center", 4);
    public static readonly AlignItem Items_Baseline = new("items-baseline", 5);
    public static readonly AlignItem Items_Stretch = new("items-stretch", 6);

    private AlignItem(string name, int value) : base(name, value) { }
}
