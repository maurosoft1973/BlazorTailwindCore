using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Maurosoft.Blazor.Tailwind.Core.Css.Properties.Borders;

/// <summary>
/// Utilities for controlling the offset of an element's outline.
/// For info, see <see href="https://tailwindcss.com/docs/outline-offset">outline-offset</see>
/// </summary>
public sealed class OutlineOffset : TailwindCssClassBase
{
    public static readonly OutlineOffset NotSet = new("notset", 1);
    public static readonly OutlineOffset Outline_Offset0 = new("outline-offset-0", 2);
    public static readonly OutlineOffset Outline_Offset1 = new("outline-offset-1", 3);
    public static readonly OutlineOffset Outline_Offset2 = new("outline-offset-2", 4);
    public static readonly OutlineOffset Outline_Offset4 = new("outline-offset-4", 5);
    public static readonly OutlineOffset Outline_Offset8 = new("outline-offset-8", 6);

    private OutlineOffset(string name, int value) : base(name, value) { }
}
