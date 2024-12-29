using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Maurosoft.Blazor.Tailwind.Core.Css.Properties.FlexboxGrid;

/// <summary>
/// Utilities for controlling how content is justified and aligned at the same time.
/// For info, see <see href="https://tailwindcss.com/docs/place-content">place-content</see>
/// </summary>
public sealed class PlaceContent : TailwindCssClassBase
{
    public static readonly PlaceContent NotSet = new("notset", 1);
    public static readonly PlaceContent Center = new("place-content-center", 2);
    public static readonly PlaceContent Start = new("place-content-start", 3);
    public static readonly PlaceContent End = new("place-content-end", 4);
    public static readonly PlaceContent Between = new("place-content-between", 5);
    public static readonly PlaceContent Around = new("place-content-around", 6);
    public static readonly PlaceContent Evenly = new("place-content-evenly", 7);
    public static readonly PlaceContent Baseline = new("place-content-baseline", 8);
    public static readonly PlaceContent Stretch = new("place-content-stretch", 9);

    private PlaceContent(string name, int value) : base(name, value) { }
}
