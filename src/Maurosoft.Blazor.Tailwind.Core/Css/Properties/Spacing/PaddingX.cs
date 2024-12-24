using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Maurosoft.Blazor.Tailwind.Core.Css.Properties.Spacing;

/// <summary>
/// Utilities for controlling an element's padding.
/// For info, see <see href="https://tailwindcss.com/docs/padding">padding</see>
/// </summary>
public sealed class PaddingX : TailwindCssClassBase
{
    public static readonly PaddingX NotSet = new("notset", 1);
    public static readonly PaddingX px_0 = new("px-0", 2);
    public static readonly PaddingX px_0_5 = new("px-0-5", 3);
    public static readonly PaddingX px_px = new("px-px", 4);
    public static readonly PaddingX px_1 = new("px-1", 5);
    public static readonly PaddingX px_1_5 = new("px-1-5", 6);
    public static readonly PaddingX px_2 = new("px-2", 7);
    public static readonly PaddingX px_2_5 = new("px-2-5", 8);
    public static readonly PaddingX px_3 = new("px-3", 9);
    public static readonly PaddingX px_4 = new("px-4", 10);
    public static readonly PaddingX px_5 = new("px-5", 11);
    public static readonly PaddingX px_6 = new("px-6", 12);
    public static readonly PaddingX px_7 = new("px-7", 13);
    public static readonly PaddingX px_8 = new("px-8", 14);
    public static readonly PaddingX px_9 = new("px-9", 15);
    public static readonly PaddingX px_10 = new("px-10", 16);

    private PaddingX(string name, int value) : base(name, value) { }
}
