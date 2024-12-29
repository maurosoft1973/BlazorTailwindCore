using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Maurosoft.Blazor.Tailwind.Core.Css.Properties.FlexboxGrid;

/// <summary>
/// Utilities for controlling the order of flex and grid items.
/// For info, see <see href="https://tailwindcss.com/docs/order">order</see>
/// </summary>
public sealed class Order : TailwindCssClassBase
{
    public static readonly Order NotSet = new("notset", 1);
    public static readonly Order Order_1 = new("order-1", 2);
    public static readonly Order Order_2 = new("order-2", 3);
    public static readonly Order Order_3 = new("order-3", 4);
    public static readonly Order Order_4 = new("order-4", 5);
    public static readonly Order Order_5 = new("order-5", 6);
    public static readonly Order Order_6 = new("order-6", 7);
    public static readonly Order Order_7 = new("order-7", 8);
    public static readonly Order Order_8 = new("order-8", 9);
    public static readonly Order Order_9 = new("order-9", 10);
    public static readonly Order Order_10 = new("order-10", 11);
    public static readonly Order Order_11 = new("order-11", 12);
    public static readonly Order Order_12 = new("order-12", 13);
    public static readonly Order Order_First = new("order-first", 14);
    public static readonly Order Order_Last = new("order-last", 15);
    public static readonly Order Order_None = new("order-none", 16);

    private Order(string name, int value) : base(name, value) { }
}
