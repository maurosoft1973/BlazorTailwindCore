using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Maurosoft.Blazor.Tailwind.Core.Css.Properties.Backgrounds;

/// <summary>
/// Utilities for controlling the position of an element's background image.
/// For info, see <see href="https://tailwindcss.com/docs/background-position">background-position</see>
/// </summary>
public sealed class BackgroundPosition : TailwindCssClassBase
{
    public static readonly BackgroundPosition NotSet = new("notset", 1);
    public static readonly BackgroundPosition Bottom = new("bg-bottom", 1);
    public static readonly BackgroundPosition Center = new("bg-center", 1);
    public static readonly BackgroundPosition Left = new("bg-left", 1);
    public static readonly BackgroundPosition LeftBottom = new("bg-left-bottom", 1);
    public static readonly BackgroundPosition LeftTop = new("bg-left-top", 1);
    public static readonly BackgroundPosition Right = new("bg-right", 1);
    public static readonly BackgroundPosition RightBottom = new("bg-right-bottom", 1);
    public static readonly BackgroundPosition RightTop = new("bg-right-top", 1);
    public static readonly BackgroundPosition Top = new("bg-top", 1);

    private BackgroundPosition(string name, int value) : base(name, value) { }
}
