using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Maurosoft.Blazor.Tailwind.Core.Css.Properties.Layout;

/// <summary>
/// Utilities for controlling the wrapping of content around an element.
/// For info, see <see href="https://tailwindcss.com/docs/float">float</see>
/// </summary>
public sealed class Float : TailwindCssClassBase
{
    public static readonly Float NotSet = new("notset", 1);
    public static readonly Float Start = new("float-start", 2);
    public static readonly Float End = new("float-end", 3);
    public static readonly Float Right = new("float-right", 4);
    public static readonly Float Left = new("float-left", 5);
    public static readonly Float None = new("float-none", 6);

    private Float(string name, int value) : base(name, value) { }
}
