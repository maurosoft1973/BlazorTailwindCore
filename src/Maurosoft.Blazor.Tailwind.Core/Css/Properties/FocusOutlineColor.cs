﻿using Ardalis.SmartEnum;
using System.Collections.Generic;
using System.Data;
using System.Runtime.Serialization;

namespace Maurosoft.Blazor.Tailwind.Core.Css;

/// <summary>
/// Utilities for controlling the FocusOutlineColor of an element.
/// </summary>
public sealed class FocusOutlineColor : TailwindCssClassBase
{
    public static readonly FocusOutlineColor NotSet = new("notset", 1);
    public static readonly FocusOutlineColor Inherit = new("focus:outline-inherit", 2);
    public static readonly FocusOutlineColor Current = new("focus:outline-current", 3);
    public static readonly FocusOutlineColor Transparent = new("focus:outline-transparent", 4);
    public static readonly FocusOutlineColor Black = new("focus:outline-black", 5);
    public static readonly FocusOutlineColor White = new("focus:outline-white", 6);
    public static readonly FocusOutlineColor Slate_50 = new("focus:outline-slate-50", 7);
    public static readonly FocusOutlineColor Slate_100 = new("focus:outline-slate-100", 8);
    public static readonly FocusOutlineColor Slate_200 = new("focus:outline-slate-200", 9);
    public static readonly FocusOutlineColor Slate_300 = new("focus:outline-slate-300", 10);
    public static readonly FocusOutlineColor Slate_400 = new("focus:outline-slate-400", 11);
    public static readonly FocusOutlineColor Slate_500 = new("focus:outline-slate-500", 12);
    public static readonly FocusOutlineColor Slate_600 = new("focus:outline-slate-600", 13);
    public static readonly FocusOutlineColor Slate_700 = new("focus:outline-slate-700", 14);
    public static readonly FocusOutlineColor Slate_800 = new("focus:outline-slate-800", 15);
    public static readonly FocusOutlineColor Slate_900 = new("focus:outline-slate-900", 16);
    public static readonly FocusOutlineColor Slate_950 = new("focus:outline-slate-950", 17);
    public static readonly FocusOutlineColor Gray_50 = new("focus:outline-gray-50", 18);
    public static readonly FocusOutlineColor Gray_100 = new("focus:outline-gray-100", 19);
    public static readonly FocusOutlineColor Gray_200 = new("focus:outline-gray-200", 20);
    public static readonly FocusOutlineColor Gray_300 = new("focus:outline-gray-300", 21);
    public static readonly FocusOutlineColor Gray_400 = new("focus:outline-gray-400", 22);
    public static readonly FocusOutlineColor Gray_500 = new("focus:outline-gray-500", 23);
    public static readonly FocusOutlineColor Gray_600 = new("focus:outline-gray-600", 24);
    public static readonly FocusOutlineColor Gray_700 = new("focus:outline-gray-700", 25);
    public static readonly FocusOutlineColor Gray_800 = new("focus:outline-gray-800", 26);
    public static readonly FocusOutlineColor Gray_900 = new("focus:outline-gray-900", 27);
    public static readonly FocusOutlineColor Gray_950 = new("focus:outline-gray-950", 28);
    public static readonly FocusOutlineColor Zinc_50 = new("focus:outline-zinc-50", 29);
    public static readonly FocusOutlineColor Zinc_100 = new("focus:outline-zinc-100", 30);
    public static readonly FocusOutlineColor Zinc_200 = new("focus:outline-zinc-200", 31);
    public static readonly FocusOutlineColor Zinc_300 = new("focus:outline-zinc-300", 32);
    public static readonly FocusOutlineColor Zinc_400 = new("focus:outline-zinc-400", 33);
    public static readonly FocusOutlineColor Zinc_500 = new("focus:outline-zinc-500", 34);
    public static readonly FocusOutlineColor Zinc_600 = new("focus:outline-zinc-600", 35);
    public static readonly FocusOutlineColor Zinc_700 = new("focus:outline-zinc-700", 36);
    public static readonly FocusOutlineColor Zinc_800 = new("focus:outline-zinc-800", 37);
    public static readonly FocusOutlineColor Zinc_900 = new("focus:outline-zinc-900", 38);
    public static readonly FocusOutlineColor Zinc_950 = new("focus:outline-zinc-950", 39);
    public static readonly FocusOutlineColor Neutral_50 = new("focus:outline-neutral-50", 40);
    public static readonly FocusOutlineColor Neutral_100 = new("focus:outline-neutral-100", 41);
    public static readonly FocusOutlineColor Neutral_200 = new("focus:outline-neutral-200", 42);
    public static readonly FocusOutlineColor Neutral_300 = new("focus:outline-neutral-300", 43);
    public static readonly FocusOutlineColor Neutral_400 = new("focus:outline-neutral-400", 44);
    public static readonly FocusOutlineColor Neutral_500 = new("focus:outline-neutral-500", 45);
    public static readonly FocusOutlineColor Neutral_600 = new("focus:outline-neutral-600", 46);
    public static readonly FocusOutlineColor Neutral_700 = new("focus:outline-neutral-700", 47);
    public static readonly FocusOutlineColor Neutral_800 = new("focus:outline-neutral-800", 48);
    public static readonly FocusOutlineColor Neutral_900 = new("focus:outline-neutral-900", 49);
    public static readonly FocusOutlineColor Neutral_950 = new("focus:outline-neutral-950", 50);
    public static readonly FocusOutlineColor Stone_50 = new("focus:outline-stone-50", 51);
    public static readonly FocusOutlineColor Stone_100 = new("focus:outline-stone-100", 52);
    public static readonly FocusOutlineColor Stone_200 = new("focus:outline-stone-200", 53);
    public static readonly FocusOutlineColor Stone_300 = new("focus:outline-stone-300", 54);
    public static readonly FocusOutlineColor Stone_400 = new("focus:outline-stone-400", 55);
    public static readonly FocusOutlineColor Stone_500 = new("focus:outline-stone-500", 56);
    public static readonly FocusOutlineColor Stone_600 = new("focus:outline-stone-600", 57);
    public static readonly FocusOutlineColor Stone_700 = new("focus:outline-stone-700", 58);
    public static readonly FocusOutlineColor Stone_800 = new("focus:outline-stone-800", 59);
    public static readonly FocusOutlineColor Stone_900 = new("focus:outline-stone-900", 60);
    public static readonly FocusOutlineColor Stone_950 = new("focus:outline-stone-950", 61);
    public static readonly FocusOutlineColor Red_50 = new("focus:outline-red-50", 62);
    public static readonly FocusOutlineColor Red_100 = new("focus:outline-red-100", 63);
    public static readonly FocusOutlineColor Red_200 = new("focus:outline-red-200", 64);
    public static readonly FocusOutlineColor Red_300 = new("focus:outline-red-300", 65);
    public static readonly FocusOutlineColor Red_400 = new("focus:outline-red-400", 66);
    public static readonly FocusOutlineColor Red_500 = new("focus:outline-red-500", 67);
    public static readonly FocusOutlineColor Red_600 = new("focus:outline-red-600", 68);
    public static readonly FocusOutlineColor Red_700 = new("focus:outline-red-700", 69);
    public static readonly FocusOutlineColor Red_800 = new("focus:outline-red-800", 70);
    public static readonly FocusOutlineColor Red_900 = new("focus:outline-red-900", 71);
    public static readonly FocusOutlineColor Red_950 = new("focus:outline-red-950", 72);
    public static readonly FocusOutlineColor Orange_50 = new("focus:outline-orange-50", 73);
    public static readonly FocusOutlineColor Orange_100 = new("focus:outline-orange-100", 74);
    public static readonly FocusOutlineColor Orange_200 = new("focus:outline-orange-200", 75);
    public static readonly FocusOutlineColor Orange_300 = new("focus:outline-orange-300", 76);
    public static readonly FocusOutlineColor Orange_400 = new("focus:outline-orange-400", 77);
    public static readonly FocusOutlineColor Orange_500 = new("focus:outline-orange-500", 78);
    public static readonly FocusOutlineColor Orange_600 = new("focus:outline-orange-600", 79);
    public static readonly FocusOutlineColor Orange_700 = new("focus:outline-orange-700", 80);
    public static readonly FocusOutlineColor Orange_800 = new("focus:outline-orange-800", 81);
    public static readonly FocusOutlineColor Orange_900 = new("focus:outline-orange-900", 82);
    public static readonly FocusOutlineColor Orange_950 = new("focus:outline-orange-950", 83);
    public static readonly FocusOutlineColor Amber_50 = new("focus:outline-amber-50", 84);
    public static readonly FocusOutlineColor Amber_100 = new("focus:outline-amber-100", 85);
    public static readonly FocusOutlineColor Amber_200 = new("focus:outline-amber-200", 86);
    public static readonly FocusOutlineColor Amber_300 = new("focus:outline-amber-300", 87);
    public static readonly FocusOutlineColor Amber_400 = new("focus:outline-amber-400", 88);
    public static readonly FocusOutlineColor Amber_500 = new("focus:outline-amber-500", 89);
    public static readonly FocusOutlineColor Amber_600 = new("focus:outline-amber-600", 90);
    public static readonly FocusOutlineColor Amber_700 = new("focus:outline-amber-700", 91);
    public static readonly FocusOutlineColor Amber_800 = new("focus:outline-amber-800", 92);
    public static readonly FocusOutlineColor Amber_900 = new("focus:outline-amber-900", 93);
    public static readonly FocusOutlineColor Amber_950 = new("focus:outline-amber-950", 94);
    public static readonly FocusOutlineColor Yellow_50 = new("focus:outline-yellow-50", 95);
    public static readonly FocusOutlineColor Yellow_100 = new("focus:outline-yellow-100", 96);
    public static readonly FocusOutlineColor Yellow_200 = new("focus:outline-yellow-200", 97);
    public static readonly FocusOutlineColor Yellow_300 = new("focus:outline-yellow-300", 98);
    public static readonly FocusOutlineColor Yellow_400 = new("focus:outline-yellow-400", 99);
    public static readonly FocusOutlineColor Yellow_500 = new("focus:outline-yellow-500", 100);
    public static readonly FocusOutlineColor Yellow_600 = new("focus:outline-yellow-600", 101);
    public static readonly FocusOutlineColor Yellow_700 = new("focus:outline-yellow-700", 102);
    public static readonly FocusOutlineColor Yellow_800 = new("focus:outline-yellow-800", 103);
    public static readonly FocusOutlineColor Yellow_900 = new("focus:outline-yellow-900", 104);
    public static readonly FocusOutlineColor Yellow_950 = new("focus:outline-yellow-950", 105);
    public static readonly FocusOutlineColor Lime_50 = new("focus:outline-lime-50", 106);
    public static readonly FocusOutlineColor Lime_100 = new("focus:outline-lime-100", 107);
    public static readonly FocusOutlineColor Lime_200 = new("focus:outline-lime-200", 108);
    public static readonly FocusOutlineColor Lime_300 = new("focus:outline-lime-300", 109);
    public static readonly FocusOutlineColor Lime_400 = new("focus:outline-lime-400", 110);
    public static readonly FocusOutlineColor Lime_500 = new("focus:outline-lime-500", 111);
    public static readonly FocusOutlineColor Lime_600 = new("focus:outline-lime-600", 112);
    public static readonly FocusOutlineColor Lime_700 = new("focus:outline-lime-700", 113);
    public static readonly FocusOutlineColor Lime_800 = new("focus:outline-lime-800", 114);
    public static readonly FocusOutlineColor Lime_900 = new("focus:outline-lime-900", 115);
    public static readonly FocusOutlineColor Lime_950 = new("focus:outline-lime-950", 116);
    public static readonly FocusOutlineColor Green_50 = new("focus:outline-green-50", 117);
    public static readonly FocusOutlineColor Green_100 = new("focus:outline-green-100", 118);
    public static readonly FocusOutlineColor Green_200 = new("focus:outline-green-200", 119);
    public static readonly FocusOutlineColor Green_300 = new("focus:outline-green-300", 120);
    public static readonly FocusOutlineColor Green_400 = new("focus:outline-green-400", 121);
    public static readonly FocusOutlineColor Green_500 = new("focus:outline-green-500", 122);
    public static readonly FocusOutlineColor Green_600 = new("focus:outline-green-600", 123);
    public static readonly FocusOutlineColor Green_700 = new("focus:outline-green-700", 124);
    public static readonly FocusOutlineColor Green_800 = new("focus:outline-green-800", 125);
    public static readonly FocusOutlineColor Green_900 = new("focus:outline-green-900", 126);
    public static readonly FocusOutlineColor Green_950 = new("focus:outline-green-950", 127);
    public static readonly FocusOutlineColor Blue_50 = new("focus:outline-blue-50", 128);
    public static readonly FocusOutlineColor Blue_100 = new("focus:outline-blue-100", 129);
    public static readonly FocusOutlineColor Blue_200 = new("focus:outline-blue-200", 130);
    public static readonly FocusOutlineColor Blue_300 = new("focus:outline-blue-300", 131);
    public static readonly FocusOutlineColor Blue_400 = new("focus:outline-blue-400", 132);
    public static readonly FocusOutlineColor Blue_500 = new("focus:outline-blue-500", 133);
    public static readonly FocusOutlineColor Blue_600 = new("focus:outline-blue-600", 134);
    public static readonly FocusOutlineColor Blue_700 = new("focus:outline-blue-700", 135);
    public static readonly FocusOutlineColor Blue_800 = new("focus:outline-blue-800", 136);
    public static readonly FocusOutlineColor Blue_900 = new("focus:outline-blue-900", 137);
    public static readonly FocusOutlineColor Blue_950 = new("focus:outline-blue-950", 138);
    public static readonly FocusOutlineColor Purple_50 = new("focus:outline-purple-50", 139);
    public static readonly FocusOutlineColor Purple_100 = new("focus:outline-purple-100", 140);
    public static readonly FocusOutlineColor Purple_200 = new("focus:outline-purple-200", 141);
    public static readonly FocusOutlineColor Purple_300 = new("focus:outline-purple-300", 142);
    public static readonly FocusOutlineColor Purple_400 = new("focus:outline-purple-400", 143);
    public static readonly FocusOutlineColor Purple_500 = new("focus:outline-purple-500", 144);
    public static readonly FocusOutlineColor Purple_600 = new("focus:outline-purple-600", 145);
    public static readonly FocusOutlineColor Purple_700 = new("focus:outline-purple-700", 146);
    public static readonly FocusOutlineColor Purple_800 = new("focus:outline-purple-800", 147);
    public static readonly FocusOutlineColor Purple_900 = new("focus:outline-purple-900", 148);
    public static readonly FocusOutlineColor Purple_950 = new("focus:outline-purple-950", 149);
    public static readonly FocusOutlineColor Pink_50 = new("focus:outline-pink-50", 150);
    public static readonly FocusOutlineColor Pink_100 = new("focus:outline-pink-100", 151);
    public static readonly FocusOutlineColor Pink_200 = new("focus:outline-pink-200", 152);
    public static readonly FocusOutlineColor Pink_300 = new("focus:outline-pink-300", 153);
    public static readonly FocusOutlineColor Pink_400 = new("focus:outline-pink-400", 154);
    public static readonly FocusOutlineColor Pink_500 = new("focus:outline-pink-500", 155);
    public static readonly FocusOutlineColor Pink_600 = new("focus:outline-pink-600", 156);
    public static readonly FocusOutlineColor Pink_700 = new("focus:outline-pink-700", 157);
    public static readonly FocusOutlineColor Pink_800 = new("focus:outline-pink-800", 158);
    public static readonly FocusOutlineColor Pink_900 = new("focus:outline-pink-900", 159);
    public static readonly FocusOutlineColor Pink_950 = new("focus:outline-pink-950", 160);

    private FocusOutlineColor(string name, int value) : base(name, value)
    {
    }
}
