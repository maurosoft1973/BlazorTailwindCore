using Ardalis.SmartEnum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Maurosoft.Blazor.Tailwind.Core.Css;

public sealed class Cursor : TailwindCssClassBase
{
    public static readonly Cursor NotSet = new("notset", 1);
    public static readonly Cursor Cursor_Auto = new("cursor-auto", 2);
    public static readonly Cursor Cursor_Default = new("cursor-default", 3);
    public static readonly Cursor Cursor_Pointer = new("cursor-pointer", 4);
    public static readonly Cursor Cursor_Wait = new("cursor-wait", 5);
    public static readonly Cursor Cursor_Text = new("cursor-text", 6);
    public static readonly Cursor Cursor_Move = new("cursor-move", 7);
    public static readonly Cursor Cursor_Help = new("cursor-help", 8);

    private Cursor(string name, int value) : base(name, value) { }
}
