﻿using Ardalis.SmartEnum;
using System.Collections.Generic;
using System.Data;
using System.Runtime.Serialization;

namespace Maurosoft.Blazor.Tailwind.Core.Css;

/// <summary>
/// Utilities for controlling the FocusBackgroundColor of an element.
/// </summary>
public sealed class FocusBackgroundColor : TailwindCssClassBase
{
    public static readonly FocusBackgroundColor NotSet = new("notset", 1);
    public static readonly FocusBackgroundColor Inherit = new("focus::bg-inherit", 2);
    public static readonly FocusBackgroundColor Current = new("focus:bg-current", 3);
    public static readonly FocusBackgroundColor Transparent = new("focus:bg-transparent", 4);
    public static readonly FocusBackgroundColor Black = new("focus:bg-black", 5);
    public static readonly FocusBackgroundColor White = new("focus:bg-white", 6);
    public static readonly FocusBackgroundColor Slate_50 = new("focus:bg-slate-50", 7);
    public static readonly FocusBackgroundColor Slate_100 = new("focus:bg-slate-100", 8);
    public static readonly FocusBackgroundColor Slate_200 = new("focus:bg-slate-200", 9);
    public static readonly FocusBackgroundColor Slate_300 = new("focus:bg-slate-300", 10);
    public static readonly FocusBackgroundColor Slate_400 = new("focus:bg-slate-400", 11);
    public static readonly FocusBackgroundColor Slate_500 = new("focus:bg-slate-500", 12);
    public static readonly FocusBackgroundColor Slate_600 = new("focus:bg-slate-600", 13);
    public static readonly FocusBackgroundColor Slate_700 = new("focus:bg-slate-700", 14);
    public static readonly FocusBackgroundColor Slate_800 = new("focus:bg-slate-800", 15);
    public static readonly FocusBackgroundColor Slate_900 = new("focus:bg-slate-900", 16);
    public static readonly FocusBackgroundColor Slate_950 = new("focus:bg-slate-950", 17);
    public static readonly FocusBackgroundColor Gray_50 = new("focus:bg-gray-50", 18);
    public static readonly FocusBackgroundColor Gray_100 = new("focus:bg-gray-100", 19);
    public static readonly FocusBackgroundColor Gray_200 = new("focus:bg-gray-200", 20);
    public static readonly FocusBackgroundColor Gray_300 = new("focus:bg-gray-300", 21);
    public static readonly FocusBackgroundColor Gray_400 = new("focus:bg-gray-400", 22);
    public static readonly FocusBackgroundColor Gray_500 = new("focus:bg-gray-500", 23);
    public static readonly FocusBackgroundColor Gray_600 = new("focus:bg-gray-600", 24);
    public static readonly FocusBackgroundColor Gray_700 = new("focus:bg-gray-700", 25);
    public static readonly FocusBackgroundColor Gray_800 = new("focus:bg-gray-800", 26);
    public static readonly FocusBackgroundColor Gray_900 = new("focus:bg-gray-900", 27);
    public static readonly FocusBackgroundColor Gray_950 = new("focus:bg-gray-950", 28);
    public static readonly FocusBackgroundColor Zinc_50 = new("focus:bg-zinc-50", 29);
    public static readonly FocusBackgroundColor Zinc_100 = new("focus:bg-zinc-100", 30);
    public static readonly FocusBackgroundColor Zinc_200 = new("focus:bg-zinc-200", 31);
    public static readonly FocusBackgroundColor Zinc_300 = new("focus:bg-zinc-300", 32);
    public static readonly FocusBackgroundColor Zinc_400 = new("focus:bg-zinc-400", 33);
    public static readonly FocusBackgroundColor Zinc_500 = new("focus:bg-zinc-500", 34);
    public static readonly FocusBackgroundColor Zinc_600 = new("focus:bg-zinc-600", 35);
    public static readonly FocusBackgroundColor Zinc_700 = new("focus:bg-zinc-700", 36);
    public static readonly FocusBackgroundColor Zinc_800 = new("focus:bg-zinc-800", 37);
    public static readonly FocusBackgroundColor Zinc_900 = new("focus:bg-zinc-900", 38);
    public static readonly FocusBackgroundColor Zinc_950 = new("focus:bg-zinc-950", 39);
    public static readonly FocusBackgroundColor Neutral_50 = new("focus:bg-neutral-50", 40);
    public static readonly FocusBackgroundColor Neutral_100 = new("focus:bg-neutral-100", 41);
    public static readonly FocusBackgroundColor Neutral_200 = new("focus:bg-neutral-200", 42);
    public static readonly FocusBackgroundColor Neutral_300 = new("focus:bg-neutral-300", 43);
    public static readonly FocusBackgroundColor Neutral_400 = new("focus:bg-neutral-400", 44);
    public static readonly FocusBackgroundColor Neutral_500 = new("focus:bg-neutral-500", 45);
    public static readonly FocusBackgroundColor Neutral_600 = new("focus:bg-neutral-600", 46);
    public static readonly FocusBackgroundColor Neutral_700 = new("focus:bg-neutral-700", 47);
    public static readonly FocusBackgroundColor Neutral_800 = new("focus:bg-neutral-800", 48);
    public static readonly FocusBackgroundColor Neutral_900 = new("focus:bg-neutral-900", 49);
    public static readonly FocusBackgroundColor Neutral_950 = new("focus:bg-neutral-950", 50);
    public static readonly FocusBackgroundColor Stone_50 = new("focus:bg-stone-50", 51);
    public static readonly FocusBackgroundColor Stone_100 = new("focus:bg-stone-100", 52);
    public static readonly FocusBackgroundColor Stone_200 = new("focus:bg-stone-200", 53);
    public static readonly FocusBackgroundColor Stone_300 = new("focus:bg-stone-300", 54);
    public static readonly FocusBackgroundColor Stone_400 = new("focus:bg-stone-400", 55);
    public static readonly FocusBackgroundColor Stone_500 = new("focus:bg-stone-500", 56);
    public static readonly FocusBackgroundColor Stone_600 = new("focus:bg-stone-600", 57);
    public static readonly FocusBackgroundColor Stone_700 = new("focus:bg-stone-700", 58);
    public static readonly FocusBackgroundColor Stone_800 = new("focus:bg-stone-800", 59);
    public static readonly FocusBackgroundColor Stone_900 = new("focus:bg-stone-900", 60);
    public static readonly FocusBackgroundColor Stone_950 = new("focus:bg-stone-950", 61);
    public static readonly FocusBackgroundColor Red_50 = new("focus:bg-red-50", 62);
    public static readonly FocusBackgroundColor Red_100 = new("focus:bg-red-100", 63);
    public static readonly FocusBackgroundColor Red_200 = new("focus:bg-red-200", 64);
    public static readonly FocusBackgroundColor Red_300 = new("focus:bg-red-300", 65);
    public static readonly FocusBackgroundColor Red_400 = new("focus:bg-red-400", 66);
    public static readonly FocusBackgroundColor Red_500 = new("focus:bg-red-500", 67);
    public static readonly FocusBackgroundColor Red_600 = new("focus:bg-red-600", 68);
    public static readonly FocusBackgroundColor Red_700 = new("focus:bg-red-700", 69);
    public static readonly FocusBackgroundColor Red_800 = new("focus:bg-red-800", 70);
    public static readonly FocusBackgroundColor Red_900 = new("focus:bg-red-900", 71);
    public static readonly FocusBackgroundColor Red_950 = new("focus:bg-red-950", 72);
    public static readonly FocusBackgroundColor Orange_50 = new("focus:bg-orange-50", 73);
    public static readonly FocusBackgroundColor Orange_100 = new("focus:bg-orange-100", 74);
    public static readonly FocusBackgroundColor Orange_200 = new("focus:bg-orange-200", 75);
    public static readonly FocusBackgroundColor Orange_300 = new("focus:bg-orange-300", 76);
    public static readonly FocusBackgroundColor Orange_400 = new("focus:bg-orange-400", 77);
    public static readonly FocusBackgroundColor Orange_500 = new("focus:bg-orange-500", 78);
    public static readonly FocusBackgroundColor Orange_600 = new("focus:bg-orange-600", 79);
    public static readonly FocusBackgroundColor Orange_700 = new("focus:bg-orange-700", 80);
    public static readonly FocusBackgroundColor Orange_800 = new("focus:bg-orange-800", 81);
    public static readonly FocusBackgroundColor Orange_900 = new("focus:bg-orange-900", 82);
    public static readonly FocusBackgroundColor Orange_950 = new("focus:bg-orange-950", 83);
    public static readonly FocusBackgroundColor Amber_50 = new("focus:bg-amber-50", 84);
    public static readonly FocusBackgroundColor Amber_100 = new("focus:bg-amber-100", 85);
    public static readonly FocusBackgroundColor Amber_200 = new("focus:bg-amber-200", 86);
    public static readonly FocusBackgroundColor Amber_300 = new("focus:bg-amber-300", 87);
    public static readonly FocusBackgroundColor Amber_400 = new("focus:bg-amber-400", 88);
    public static readonly FocusBackgroundColor Amber_500 = new("focus:bg-amber-500", 89);
    public static readonly FocusBackgroundColor Amber_600 = new("focus:bg-amber-600", 90);
    public static readonly FocusBackgroundColor Amber_700 = new("focus:bg-amber-700", 91);
    public static readonly FocusBackgroundColor Amber_800 = new("focus:bg-amber-800", 92);
    public static readonly FocusBackgroundColor Amber_900 = new("focus:bg-amber-900", 93);
    public static readonly FocusBackgroundColor Amber_950 = new("focus:bg-amber-950", 94);
    public static readonly FocusBackgroundColor Yellow_50 = new("focus:bg-yellow-50", 95);
    public static readonly FocusBackgroundColor Yellow_100 = new("focus:bg-yellow-100", 96);
    public static readonly FocusBackgroundColor Yellow_200 = new("focus:bg-yellow-200", 97);
    public static readonly FocusBackgroundColor Yellow_300 = new("focus:bg-yellow-300", 98);
    public static readonly FocusBackgroundColor Yellow_400 = new("focus:bg-yellow-400", 99);
    public static readonly FocusBackgroundColor Yellow_500 = new("focus:bg-yellow-500", 100);
    public static readonly FocusBackgroundColor Yellow_600 = new("focus:bg-yellow-600", 101);
    public static readonly FocusBackgroundColor Yellow_700 = new("focus:bg-yellow-700", 102);
    public static readonly FocusBackgroundColor Yellow_800 = new("focus:bg-yellow-800", 103);
    public static readonly FocusBackgroundColor Yellow_900 = new("focus:bg-yellow-900", 104);
    public static readonly FocusBackgroundColor Yellow_950 = new("focus:bg-yellow-950", 105);
    public static readonly FocusBackgroundColor Lime_50 = new("focus:bg-lime-50", 106);
    public static readonly FocusBackgroundColor Lime_100 = new("focus:bg-lime-100", 107);
    public static readonly FocusBackgroundColor Lime_200 = new("focus:bg-lime-200", 108);
    public static readonly FocusBackgroundColor Lime_300 = new("focus:bg-lime-300", 109);
    public static readonly FocusBackgroundColor Lime_400 = new("focus:bg-lime-400", 110);
    public static readonly FocusBackgroundColor Lime_500 = new("focus:bg-lime-500", 111);
    public static readonly FocusBackgroundColor Lime_600 = new("focus:bg-lime-600", 112);
    public static readonly FocusBackgroundColor Lime_700 = new("focus:bg-lime-700", 113);
    public static readonly FocusBackgroundColor Lime_800 = new("focus:bg-lime-800", 114);
    public static readonly FocusBackgroundColor Lime_900 = new("focus:bg-lime-900", 115);
    public static readonly FocusBackgroundColor Lime_950 = new("focus:bg-lime-950", 116);
    public static readonly FocusBackgroundColor Green_50 = new("focus:bg-green-50", 117);
    public static readonly FocusBackgroundColor Green_100 = new("focus:bg-green-100", 118);
    public static readonly FocusBackgroundColor Green_200 = new("focus:bg-green-200", 119);
    public static readonly FocusBackgroundColor Green_300 = new("focus:bg-green-300", 120);
    public static readonly FocusBackgroundColor Green_400 = new("focus:bg-green-400", 121);
    public static readonly FocusBackgroundColor Green_500 = new("focus:bg-green-500", 122);
    public static readonly FocusBackgroundColor Green_600 = new("focus:bg-green-600", 123);
    public static readonly FocusBackgroundColor Green_700 = new("focus:bg-green-700", 124);
    public static readonly FocusBackgroundColor Green_800 = new("focus:bg-green-800", 125);
    public static readonly FocusBackgroundColor Green_900 = new("focus:bg-green-900", 126);
    public static readonly FocusBackgroundColor Green_950 = new("focus:bg-green-950", 127);
    public static readonly FocusBackgroundColor Blue_50 = new("focus:bg-blue-50", 128);
    public static readonly FocusBackgroundColor Blue_100 = new("focus:bg-blue-100", 129);
    public static readonly FocusBackgroundColor Blue_200 = new("focus:bg-blue-200", 130);
    public static readonly FocusBackgroundColor Blue_300 = new("focus:bg-blue-300", 131);
    public static readonly FocusBackgroundColor Blue_400 = new("focus:bg-blue-400", 132);
    public static readonly FocusBackgroundColor Blue_500 = new("focus:bg-blue-500", 133);
    public static readonly FocusBackgroundColor Blue_600 = new("focus:bg-blue-600", 134);
    public static readonly FocusBackgroundColor Blue_700 = new("focus:bg-blue-700", 135);
    public static readonly FocusBackgroundColor Blue_800 = new("focus:bg-blue-800", 136);
    public static readonly FocusBackgroundColor Blue_900 = new("focus:bg-blue-900", 137);
    public static readonly FocusBackgroundColor Blue_950 = new("focus:bg-blue-950", 138);
    public static readonly FocusBackgroundColor Purple_50 = new("focus:bg-purple-50", 139);
    public static readonly FocusBackgroundColor Purple_100 = new("focus:bg-purple-100", 140);
    public static readonly FocusBackgroundColor Purple_200 = new("focus:bg-purple-200", 141);
    public static readonly FocusBackgroundColor Purple_300 = new("focus:bg-purple-300", 142);
    public static readonly FocusBackgroundColor Purple_400 = new("focus:bg-purple-400", 143);
    public static readonly FocusBackgroundColor Purple_500 = new("focus:bg-purple-500", 144);
    public static readonly FocusBackgroundColor Purple_600 = new("focus:bg-purple-600", 145);
    public static readonly FocusBackgroundColor Purple_700 = new("focus:bg-purple-700", 146);
    public static readonly FocusBackgroundColor Purple_800 = new("focus:bg-purple-800", 147);
    public static readonly FocusBackgroundColor Purple_900 = new("focus:bg-purple-900", 148);
    public static readonly FocusBackgroundColor Purple_950 = new("focus:bg-purple-950", 149);
    public static readonly FocusBackgroundColor Pink_50 = new("focus:bg-pink-50", 150);
    public static readonly FocusBackgroundColor Pink_100 = new("focus:bg-pink-100", 151);
    public static readonly FocusBackgroundColor Pink_200 = new("focus:bg-pink-200", 152);
    public static readonly FocusBackgroundColor Pink_300 = new("focus:bg-pink-300", 153);
    public static readonly FocusBackgroundColor Pink_400 = new("focus:bg-pink-400", 154);
    public static readonly FocusBackgroundColor Pink_500 = new("focus:bg-pink-500", 155);
    public static readonly FocusBackgroundColor Pink_600 = new("focus:bg-pink-600", 156);
    public static readonly FocusBackgroundColor Pink_700 = new("focus:bg-pink-700", 157);
    public static readonly FocusBackgroundColor Pink_800 = new("focus:bg-pink-800", 158);
    public static readonly FocusBackgroundColor Pink_900 = new("focus:bg-pink-900", 159);
    public static readonly FocusBackgroundColor Pink_950 = new("focus:bg-pink-950", 160);

    private FocusBackgroundColor(string name, int value) : base(name, value)
    {
    }
}
