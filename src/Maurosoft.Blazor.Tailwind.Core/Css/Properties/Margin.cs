using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Maurosoft.Blazor.Tailwind.Core.Css;

/// <summary>
/// Utilities for controlling an element's margin.
/// </summary>
public sealed class Margin : TailwindCssClassBase
{
    public static readonly Margin NotSet = new("notset", 1);
    public static readonly Margin m_0 = new("m-0", 2);
    public static readonly Margin mx_0 = new("mx-0", 3);
    public static readonly Margin my_0 = new("my-0", 4);
    public static readonly Margin ms_0 = new("ms-0", 5);
    public static readonly Margin me_0 = new("me-0", 6);
    public static readonly Margin mt_0 = new("mt-0", 7);
    public static readonly Margin mr_0 = new("mr-0", 8);
    public static readonly Margin mb_0 = new("mb-0", 9);
    public static readonly Margin ml_0 = new("ml-0", 10);
    public static readonly Margin m_px = new("m-px", 11);
    public static readonly Margin mx_px = new("mx-px", 12);
    public static readonly Margin my_px = new("my-px", 13);
    public static readonly Margin ms_px = new("ms-px", 14);
    public static readonly Margin me_px = new("me-px", 15);
    public static readonly Margin mt_px = new("mt-px", 16);
    public static readonly Margin mr_px = new("mr-px", 17);
    public static readonly Margin mb_px = new("mb-px", 18);
    public static readonly Margin ml_px = new("ml-px", 19);
    public static readonly Margin m_1 = new("m-1", 20);
    public static readonly Margin mx_1 = new("mx-1", 21);
    public static readonly Margin my_1 = new("my-1", 22);
    public static readonly Margin ms_1 = new("ms-1", 23);
    public static readonly Margin me_1 = new("me-1", 24);
    public static readonly Margin mt_1 = new("mt-1", 25);
    public static readonly Margin mr_1 = new("mr-1", 26);
    public static readonly Margin mb_1 = new("mb-1", 27);
    public static readonly Margin ml_1 = new("ml-1", 28);
    public static readonly Margin m_2 = new("m-2", 29);
    public static readonly Margin mx_2 = new("mx-2", 30);
    public static readonly Margin my_2 = new("my-2", 31);
    public static readonly Margin ms_2 = new("ms-2", 32);
    public static readonly Margin me_2 = new("me-2", 33);
    public static readonly Margin mt_2 = new("mt-2", 34);
    public static readonly Margin mr_2 = new("mr-2", 35);
    public static readonly Margin mb_2 = new("mb-2", 36);
    public static readonly Margin ml_2 = new("ml-2", 37);
    public static readonly Margin m_3 = new("m-3", 38);
    public static readonly Margin mx_3 = new("mx-3", 39);
    public static readonly Margin my_3 = new("my-3", 40);
    public static readonly Margin ms_3 = new("ms-3", 41);
    public static readonly Margin me_3 = new("me-3", 42);
    public static readonly Margin mt_3 = new("mt-3", 43);
    public static readonly Margin mr_3 = new("mr-3", 44);
    public static readonly Margin mb_3 = new("mb-3", 45);
    public static readonly Margin ml_3 = new("ml-3", 46);
    public static readonly Margin m_4 = new("m-4", 47);
    public static readonly Margin mx_4 = new("mx-4", 48);
    public static readonly Margin my_4 = new("my-4", 49);
    public static readonly Margin ms_4 = new("ms-4", 50);
    public static readonly Margin me_4 = new("me-4", 51);
    public static readonly Margin mt_4 = new("mt-4", 52);
    public static readonly Margin mr_4 = new("mr-4", 53);
    public static readonly Margin mb_4 = new("mb-4", 54);
    public static readonly Margin ml_4 = new("ml-4", 55);
    public static readonly Margin m_5 = new("m-5", 56);
    public static readonly Margin mx_5 = new("mx-5", 57);
    public static readonly Margin my_5 = new("my-5", 58);
    public static readonly Margin ms_5 = new("ms-5", 59);
    public static readonly Margin me_5 = new("me-5", 60);
    public static readonly Margin mt_5 = new("mt-5", 61);
    public static readonly Margin mr_5 = new("mr-5", 62);
    public static readonly Margin mb_5 = new("mb-5", 63);
    public static readonly Margin ml_5 = new("ml-5", 64);
    public static readonly Margin m_auto = new("m-auto", 65);
    public static readonly Margin mx_auto = new("mx-auto", 66);
    public static readonly Margin my_auto = new("my-auto", 67);
    public static readonly Margin ms_auto = new("ms-auto", 68);
    public static readonly Margin me_auto = new("me-auto", 69);
    public static readonly Margin mt_auto = new("mt-auto", 70);
    public static readonly Margin mr_auto = new("mr-auto", 71);
    public static readonly Margin mb_auto = new("mb-auto", 72);
    public static readonly Margin ml_auto = new("ml-auto", 73);

    private Margin(string name, int value) : base(name, value) { }
}
