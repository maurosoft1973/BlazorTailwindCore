using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Maurosoft.Blazor.Tailwind.Core.Css.Properties.FlexboxGrid;

/// <summary>
/// Utilities for controlling how content is justified and aligned at the same time.
/// For info, see <see href="https://tailwindcss.com/docs/place-content">place-content</see>
/// </summary>
public sealed class AlignContent : TailwindCssClassBase
{
    public static readonly AlignContent NotSet = new("notset", 1);
    public static readonly AlignContent Normal = new("content-normal", 2);
    public static readonly AlignContent Center = new("content-center", 3);
    public static readonly AlignContent Start = new("content-start", 4);
    public static readonly AlignContent End = new("content-end", 5);
    public static readonly AlignContent Between = new("content-between", 6);
    public static readonly AlignContent Around = new("content-around", 7);
    public static readonly AlignContent Evenly = new("content-evenly", 8);
    public static readonly AlignContent Baseline = new("content-baseline", 9);
    public static readonly AlignContent Stretch = new("content-stretch", 10);

    private AlignContent(string name, int value) : base(name, value) { }
}
