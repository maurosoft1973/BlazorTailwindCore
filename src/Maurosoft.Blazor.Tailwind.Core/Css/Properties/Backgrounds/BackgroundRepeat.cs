using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Maurosoft.Blazor.Tailwind.Core.Css.Properties.Backgrounds;

/// <summary>
/// Utilities for controlling the repetition of an element's background image.
/// For info, see <see href="https://tailwindcss.com/docs/background-repeat">background-repeat</see>
/// </summary>
public sealed class BackgroundRepeat : TailwindCssClassBase
{
    public static readonly BackgroundRepeat NotSet = new("notset", 1);
    public static readonly BackgroundRepeat Repeat = new("bg-repeat", 1);
    public static readonly BackgroundRepeat NoRepeat = new("bg-no-repeat", 1);
    public static readonly BackgroundRepeat RepeatX = new("bg-repeat-x", 1);
    public static readonly BackgroundRepeat RepeatY = new("bg-repeat-y", 1);
    public static readonly BackgroundRepeat RepeatRound = new("bg-repeat-round", 1);
    public static readonly BackgroundRepeat RepeatSpace = new("bg-repeat-space", 1);

    private BackgroundRepeat(string name, int value) : base(name, value) { }
}
