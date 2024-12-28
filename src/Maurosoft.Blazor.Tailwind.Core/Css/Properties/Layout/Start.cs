using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Maurosoft.Blazor.Tailwind.Core.Css.Properties.Layout;

/// <summary>
/// Utilities for controlling the start placement of positioned elements.
/// For info, see <see href="https://tailwindcss.com/docs/top-right-bottom-left">start</see>
/// </summary>
public class Start : TailwindCssClassBase
{
    public static readonly Start NotSet = new("notset", 1);
    public static readonly Start Start_0 = new("start-0", 2);
    public static readonly Start Start_0v5 = new("start-0.5", 3);
    public static readonly Start Start_1 = new("start-1", 4);
    public static readonly Start Start_1v5 = new("start-1.5", 5);
    public static readonly Start Start_2 = new("start-2", 6);
    public static readonly Start Start_2v5 = new("start-2.5", 7);
    public static readonly Start Start_3 = new("start-3", 8);
    public static readonly Start Start_3v5 = new("start-3.5", 9);
    public static readonly Start Start_4 = new("start-4", 10);
    public static readonly Start Start_5 = new("start-5", 11);
    public static readonly Start Start_6 = new("start-6", 12);
    public static readonly Start Start_7 = new("start-7", 13);
    public static readonly Start Start_8 = new("start-8", 14);
    public static readonly Start Start_9 = new("start-9", 15);
    public static readonly Start Start_10 = new("start-10", 16);

    private Start(string name, int value) : base(name, value) { }
}
