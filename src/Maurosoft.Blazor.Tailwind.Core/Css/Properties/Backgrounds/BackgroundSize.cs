using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Maurosoft.Blazor.Tailwind.Core.Css.Properties.Backgrounds;

/// <summary>
/// Utilities for controlling the background size of an element's background image.
/// For info, see <see href="https://tailwindcss.com/docs/background-size">background-size</see>
/// </summary>
public sealed class BackgroundSize : TailwindCssClassBase
{
    public static readonly BackgroundSize NotSet = new("notset", 1);
    public static readonly BackgroundSize Auto = new("bg-auto", 2);
    public static readonly BackgroundSize Cover = new("bg-cover", 3);
    public static readonly BackgroundSize Contain = new("bg-contain", 4);

    private BackgroundSize(string name, int value) : base(name, value) { }
}
