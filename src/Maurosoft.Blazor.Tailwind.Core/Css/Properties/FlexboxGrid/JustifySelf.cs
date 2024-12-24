using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Maurosoft.Blazor.Tailwind.Core.Css.Properties.FlexboxGrid;

/// <summary>
/// Utilities for controlling how grid items are aligned along their inline axis.
/// For info, see <see href="https://tailwindcss.com/docs/justify-items">justify-items</see>
/// </summary>
public sealed class JustifySelf : TailwindCssClassBase
{
    public static readonly JustifySelf NotSet = new("notset", 1);
    public static readonly JustifySelf JustifySelf_Auto = new("justify-self-auto", 2);
    public static readonly JustifySelf JustifySelf_Start = new("justify-self-start", 3);
    public static readonly JustifySelf JustifySelf_End = new("justify-self-end", 4);
    public static readonly JustifySelf JustifySelf_Center = new("justify-self-center", 5);
    public static readonly JustifySelf JustifySelf_Stretch = new("justify-self-stretch", 6);

    private JustifySelf(string name, int value) : base(name, value) { }
}
