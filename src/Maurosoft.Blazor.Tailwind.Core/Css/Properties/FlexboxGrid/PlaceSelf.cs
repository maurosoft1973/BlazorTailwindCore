using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Maurosoft.Blazor.Tailwind.Core.Css.Properties.FlexboxGrid;

/// <summary>
/// Utilities for controlling how an individual item is justified and aligned at the same time.
/// For info, see <see href="https://tailwindcss.com/docs/place-self">place-self</see>
/// </summary>
public sealed class PlaceSelf : TailwindCssClassBase
{
    public static readonly PlaceSelf NotSet = new("notset", 1);
    public static readonly PlaceSelf Auto = new("place-self-auto", 2);
    public static readonly PlaceSelf Start = new("place-self-start", 3);
    public static readonly PlaceSelf End = new("place-self-end", 4);
    public static readonly PlaceSelf Center = new("place-self-center", 5);
    public static readonly PlaceSelf Stretch = new("place-self-stretch", 6);

    private PlaceSelf(string name, int value) : base(name, value) { }
}
