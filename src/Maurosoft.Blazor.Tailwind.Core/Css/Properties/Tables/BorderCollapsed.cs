using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Maurosoft.Blazor.Tailwind.Core.Css.Properties.Tables;

/// <summary>
/// Utilities for controlling whether table borders should collapse or be separated.
/// For info, see <see href="https://tailwindcss.com/docs/border-collapse">border-collapse</see>
/// </summary>
public class BorderCollapsed : TailwindCssClassBase
{
    public static readonly BorderCollapsed NotSet = new("notset", 1);
    public static readonly BorderCollapsed Collapse = new("border-collapse", 2);
    public static readonly BorderCollapsed Separate = new("border-separate", 3);

    private BorderCollapsed(string name, int value) : base(name, value) { }
}
