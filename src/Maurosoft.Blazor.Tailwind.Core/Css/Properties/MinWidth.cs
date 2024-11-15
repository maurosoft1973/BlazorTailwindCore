using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Maurosoft.Blazor.Tailwind.Core.Css;

public sealed class MinWidth : TailwindCssClassBase
{
    public static readonly MinWidth NotSet = new("notset", 0);
    public static readonly MinWidth W_0 = new("min-w-0", 0);
    public static readonly MinWidth W_1 = new("min-w-1", 0);
    public static readonly MinWidth W_Full = new("min-w-full", 0);

    private MinWidth(string name, int value) : base(name, value) { }

}
