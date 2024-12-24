using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Maurosoft.Blazor.Tailwind.Core.Css.Properties.Layout;

/// <summary>
/// A component for fixing an element's width to the current breakpoint.
/// none = 100%
/// sm = 640px
/// md = 768px
/// lg = 1024px
/// xl = 1280px
/// 2xl = 1536px
/// For info, see <see href="https://tailwindcss.com/docs/container">container</see>
/// </summary>
public sealed class Container : TailwindCssClassBase
{
    public static readonly Container NotSet = new("notset", 1);
    public static readonly Container Container_None = new("none", 2);
    public static readonly Container Container_Sm = new("sm", 3);
    public static readonly Container Container_Md = new("md", 4);
    public static readonly Container Container_Lg = new("lg", 5);
    public static readonly Container Container_Xl = new("xl", 6);
    public static readonly Container Container_2xl = new("2xl", 7);

    private Container(string name, int value) : base(name, value) { }
}
