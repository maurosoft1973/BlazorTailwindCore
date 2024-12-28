using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Maurosoft.Blazor.Tailwind.Core.Css.Properties.Layout;

/// <summary>
/// Utilities for controlling how an element handles content that is too large for the container.
/// For info, see <see href="https://tailwindcss.com/docs/overflow">overflow</see>
/// </summary>
public sealed class Overflow : TailwindCssClassBase
{
    public static readonly Overflow NotSet = new("notset", 1);
    public static readonly Overflow Auto = new("overflow-auto", 2);
    public static readonly Overflow Hidden = new("overflow-hidden", 3);
    public static readonly Overflow Clip = new("overflow-clip", 4);
    public static readonly Overflow Visible = new("overflow-visible", 5);
    public static readonly Overflow Scroll = new("overflow-scroll", 6);
    public static readonly Overflow XAuto = new("overflow-x-auto", 7);
    public static readonly Overflow Yauto = new("overflow-y-auto", 8);
    public static readonly Overflow XHidden = new("overflow-x-hidden", 9);
    public static readonly Overflow YHidden = new("overflow-y-hidden", 10);
    public static readonly Overflow XClip = new("overflow-x-clip", 11);
    public static readonly Overflow YClip = new("overflow-y-clip", 12);
    public static readonly Overflow XVisible = new("overflow-x-visible", 13);
    public static readonly Overflow YVisible = new("overflow-y-visible", 14);
    public static readonly Overflow XScroll = new("overflow-x-scroll", 15);
    public static readonly Overflow YScroll = new("overflow-y-scroll", 16);

    private Overflow(string name, int value) : base(name, value) { }
}
