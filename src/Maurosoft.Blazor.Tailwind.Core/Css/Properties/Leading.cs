using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Maurosoft.Blazor.Tailwind.Core.Css;

/// <summary>
/// Utilities for controlling the leading (line height) of an element.
/// </summary>
public class Leading : TailwindCssClassBase
{
    public static readonly Leading NotSet = new("notset", 1);
    public static readonly Leading Leading_3 = new("leading-3", 2);
    public static readonly Leading Leading_4 = new("leading-4", 3);
    public static readonly Leading Leading_5 = new("leading-5", 4);
    public static readonly Leading Leading_6 = new("leading-6", 5);
    public static readonly Leading Leading_7 = new("leading-7", 6);
    public static readonly Leading Leading_8 = new("leading-8", 7);
    public static readonly Leading Leading_9 = new("leading-9", 8);
    public static readonly Leading Leading_10 = new("leading-10", 9);
    public static readonly Leading Leading_11 = new("leading-11", 10);
    public static readonly Leading Leading_12 = new("leading-12", 11);
    public static readonly Leading Leading_None = new("leading-none", 12);
    public static readonly Leading Leading_Snug = new("leading-snug", 13);
    public static readonly Leading Leading_Normal = new("leading-normal", 14);
    public static readonly Leading Leading_Relaxed = new("leading-relaxed", 15);
    public static readonly Leading Leading_Loose = new("leading-loose", 16);

    private Leading(string name, int value) : base(name, value) { }
}
