using Maurosoft.Blazor.Tailwind.Core.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Maurosoft.Blazor.Tailwind.Components.Common;

public record RenderPriority
{
    public RenderPriority()
    {
        Priority = RenderPriorityLevel.Low;
        Order = DateTime.Now.Ticks;
    }

    public RenderPriority(RenderPriorityLevel priority)
    {
        Priority = priority;
    }

    public RenderPriorityLevel Priority { get; init; }

    public long Order { get; init; }
}

