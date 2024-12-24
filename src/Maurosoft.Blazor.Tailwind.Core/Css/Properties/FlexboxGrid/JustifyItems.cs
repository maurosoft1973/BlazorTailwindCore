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
public sealed class JustifyItems : TailwindCssClassBase
{
    public static readonly JustifyItems NotSet = new("notset", 1);
    public static readonly JustifyItems JustifyItems_Start = new("justify-items-start", 2);
    public static readonly JustifyItems JustifyItems_End = new("justify-items-end", 3);
    public static readonly JustifyItems JustifyItems_Center = new("justify-items-center", 4);
    public static readonly JustifyItems JustifyItems_Stretch = new("justify-items-stretch", 9);

    private JustifyItems(string name, int value) : base(name, value) { }
}
