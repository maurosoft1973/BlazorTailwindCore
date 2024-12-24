using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Maurosoft.Blazor.Tailwind.Core.Css.Properties.Layout;

/// <summary>
/// Utilities for controlling the aspect ratio of an element.
/// For info, see <see href="https://tailwindcss.com/docs/aspect-ratio">aspect-ratio</see>
/// </summary>
public sealed class AspectRatio : TailwindCssClassBase
{
    public static readonly AspectRatio NotSet = new("notset", 1);
    public static readonly AspectRatio Auto = new("aspect-auto", 2);
    public static readonly AspectRatio Square = new("aspect-square", 3);
    public static readonly AspectRatio Video = new("aspect-video", 4);

    private AspectRatio(string name, int value) : base(name, value) { }
}
