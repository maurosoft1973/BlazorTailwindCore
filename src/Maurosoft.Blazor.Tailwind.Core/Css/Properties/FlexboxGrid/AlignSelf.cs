using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Maurosoft.Blazor.Tailwind.Core.Css.Properties.FlexboxGrid;

/// <summary>
/// Utilities for controlling how an individual flex or grid item is positioned along its container's cross axis.
/// For info, see <see href="https://tailwindcss.com/docs/align-self">align-self</see>
/// </summary>
public sealed class AlignSelf : TailwindCssClassBase
{
    public static readonly AlignSelf NotSet = new("notset", 1);
    public static readonly AlignSelf Auto = new("self-auto", 2);
    public static readonly AlignSelf Start = new("self-start", 3);
    public static readonly AlignSelf End = new("self-end", 4);
    public static readonly AlignSelf Center = new("self-center", 5);
    public static readonly AlignSelf Stretch = new("self-stretch", 6);
    public static readonly AlignSelf Baseline = new("self-baseline", 7);

    private AlignSelf(string name, int value) : base(name, value) { }
}
