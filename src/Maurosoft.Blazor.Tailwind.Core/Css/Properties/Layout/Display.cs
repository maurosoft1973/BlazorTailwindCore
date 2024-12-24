using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Maurosoft.Blazor.Tailwind.Core.Css.Properties.Layout;

/// <summary>
/// Utilities for controlling the display box type of an element.
/// For info, see <see href="https://tailwindcss.com/docs/display">display</see>
/// </summary>
public sealed class Display : TailwindCssClassBase
{
    public static readonly Display NotSet = new("notset", 1);
    public static readonly Display Block = new("block", 2);
    public static readonly Display InlineBlock = new("inline-block", 3);
    public static readonly Display Inline = new("inline", 4);
    public static readonly Display Flex = new("flex", 5);
    public static readonly Display InlineFlex = new("inline-flex", 6);
    public static readonly Display Table = new("table", 7);
    public static readonly Display InlineTable = new("inline-table", 8);
    public static readonly Display TableCaption = new("table-caption", 9);
    public static readonly Display TableRow = new("table-row", 10);
    public static readonly Display TableCell = new("table-cell", 11);
    public static readonly Display TableColumn = new("table-column", 12);
    public static readonly Display TableColumnGroup = new("table-column-group", 13);
    public static readonly Display TableFooterGroup = new("table-footer-group", 14);
    public static readonly Display TableHeaderGroup = new("table-header-group", 15);
    public static readonly Display Grid = new("grid", 16);
    public static readonly Display InlineGrid = new("inline-grid", 17);
    public static readonly Display Contents = new("contents", 18);
    public static readonly Display ListItem = new("list-item", 19);
    public static readonly Display Hidden = new("hidden", 20);

    private Display(string name, int value) : base(name, value) { }
}
