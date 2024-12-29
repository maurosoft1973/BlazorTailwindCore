using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Maurosoft.Blazor.Tailwind.Core.Css.Properties.FlexboxGrid;

/// <summary>
/// Utilities for controlling how items are justified and aligned at the same time.
/// For info, see <see href="https://tailwindcss.com/docs/place-items">place-items</see>
/// </summary>
public sealed class PlaceItems : TailwindCssClassBase
{
    public static readonly PlaceItems NotSet = new("notset", 1);
    public static readonly PlaceItems Start = new("place-items-start", 2);
    public static readonly PlaceItems End = new("place-items-end", 3);
    public static readonly PlaceItems Center = new("place-items-center", 4);
    public static readonly PlaceItems Baseline = new("place-items-baseline", 5);
    public static readonly PlaceItems Stretch = new("place-items-stretch", 6);

    private PlaceItems(string name, int value) : base(name, value) { }
}
