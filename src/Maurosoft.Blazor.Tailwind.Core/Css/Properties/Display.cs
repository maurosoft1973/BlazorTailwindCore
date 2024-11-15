using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Maurosoft.Blazor.Tailwind.Core.Css;

/// <summary>
/// Utilities for controlling the display box type of an element.
/// </summary>
public sealed class Display : TailwindCssClassBase
{
    public static readonly Display NotSet = new("notset", 0);
    public static readonly Display Block = new("block", 1);
    public static readonly Display InlineBlock = new("inline-block", 1);
    public static readonly Display Inline = new("inline", 2);
    public static readonly Display Flex = new("flex", 3);
    public static readonly Display InlineFlex = new("inline-flex", 4);
    public static readonly Display Table = new("table", 5);
    public static readonly Display InlineTable = new("inline-table", 6);
    public static readonly Display TableCaption = new("table-caption", 7);
    public static readonly Display TableRow = new("table-row", 8);
    public static readonly Display TableCell = new("table-cell", 9);
    public static readonly Display TableColumn = new("table-column", 10);
    public static readonly Display TableColumnGroup = new("table-column-group", 11);
    public static readonly Display TableFooterGroup = new("table-footer-group", 12);
    public static readonly Display TableHeaderGroup = new("table-header-group", 13);
    public static readonly Display Grid = new("grid", 14);
    public static readonly Display InlineGrid = new("inline-grid", 15);
    public static readonly Display Contents = new("contents", 16);
    public static readonly Display ListItem = new("list-item", 17);
    public static readonly Display Hidden = new("hidden", 99);

    private Display(string name, int value) : base(name, value)
    {
    }
}

//public enum Display
//{
//    [EnumMember(Value = "")]
//    NotSet,
//    [EnumMember(Value = "block")]
//    Block,
//    [EnumMember(Value = "inline-block")]
//    InlineBlock,
//    [EnumMember(Value = "inline")]
//    Inline,
//    [EnumMember(Value = "flex")]
//    Flex,
//    [EnumMember(Value = "inline-flex")]
//    InlineFlex,
//    [EnumMember(Value = "table")]
//    Table
//}
