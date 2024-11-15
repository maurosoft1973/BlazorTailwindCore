using System.Runtime.Serialization;

namespace Maurosoft.Blazor.Tailwind.Core.Enums;

public enum ColorRgb
{
    [EnumMember(Value = "")]
    NotSet,
    [EnumMember(Value = "#000000")]
    Black,
    [EnumMember(Value = "#FFFFFF")]
    White,
    [EnumMember(Value = "#F8FAFC")]
    Slate_50,
    [EnumMember(Value = "#F1F5F9")]
    Slate_100,
    [EnumMember(Value = "#E2E8F0")]
    Slate_200,
    [EnumMember(Value = "#CBD5E1")]
    Slate_300,
    [EnumMember(Value = "#94A3B8")]
    Slate_400,
    [EnumMember(Value = "#64748B")]
    Slate_500,
    [EnumMember(Value = "#475569")]
    Slate_600,
    [EnumMember(Value = "#334155")]
    Slate_700,
    [EnumMember(Value = "#1E293B")]
    Slate_800,
    [EnumMember(Value = "#0F172A")]
    Slate_900,
    [EnumMember(Value = "#09141D")]
    Slate_950,
    [EnumMember(Value = "#F9FAFB")]
    Gray_50,
    [EnumMember(Value = "#F3F4F6")]
    Gray_100,
    [EnumMember(Value = "#E5E7EB")]
    Gray_200,
    [EnumMember(Value = "#D1D5DB")]
    Gray_300,
    [EnumMember(Value = "#9CA3AF")]
    Gray_400,
    [EnumMember(Value = "#6B7280")]
    Gray_500,
    [EnumMember(Value = "#4B5563")]
    Gray_600,
    [EnumMember(Value = "#374151")]
    Gray_700,
    [EnumMember(Value = "#1F2937")]
    Gray_800,
    [EnumMember(Value = "#111827")]
    Gray_900,
    [EnumMember(Value = "#0D131E")]
    Gray_950,
    [EnumMember(Value = "#FAFAFA")]
    Zinc_50,
    [EnumMember(Value = "#F4F4F5")]
    Zinc_100,
    [EnumMember(Value = "#E4E4E7")]
    Zinc_200,
    [EnumMember(Value = "#D4D4D8")]
    Zinc_300,
    [EnumMember(Value = "#A1A1AA")]
    Zinc_400,
    [EnumMember(Value = "#71717A")]
    Zinc_500,
    [EnumMember(Value = "#52525B")]
    Zinc_600,
    [EnumMember(Value = "#3F3F46")]
    Zinc_700,
    [EnumMember(Value = "#27272A")]
    Zinc_800,
    [EnumMember(Value = "#18181B")]
    Zinc_900,
    [EnumMember(Value = "#0D0D0E")]
    Zinc_950,
    [EnumMember(Value = "#FAFAFA")]
    Neutral_50,
    [EnumMember(Value = "#F5F5F5")]
    Neutral_100,
    [EnumMember(Value = "#E5E5E5")]
    Neutral_200,
    [EnumMember(Value = "#D4D4D4")]
    Neutral_300,
    [EnumMember(Value = "#A3A3A3")]
    Neutral_400,
    [EnumMember(Value = "#737373")]
    Neutral_500,
    [EnumMember(Value = "#525252")]
    Neutral_600,
    [EnumMember(Value = "#404040")]
    Neutral_700,
    [EnumMember(Value = "#262626")]
    Neutral_800,
    [EnumMember(Value = "#171717")]
    Neutral_900,
    [EnumMember(Value = "#0A0A0A")]
    Neutral_950,
    [EnumMember(Value = "#FAFAF9")]
    Stone_50,
    [EnumMember(Value = "#F5F5F4")]
    Stone_100,
    [EnumMember(Value = "#E7E5E4")]
    Stone_200,
    [EnumMember(Value = "#D6D3D1")]
    Stone_300,
    [EnumMember(Value = "#A8A29E")]
    Stone_400,
    [EnumMember(Value = "#78716C")]
    Stone_500,
    [EnumMember(Value = "#57534E")]
    Stone_600,
    [EnumMember(Value = "#44403C")]
    Stone_700,
    [EnumMember(Value = "#292524")]
    Stone_800,
    [EnumMember(Value = "#1C1917")]
    Stone_900,
    [EnumMember(Value = "#0F0E0D")]
    Stone_950,
    [EnumMember(Value = "#FEF2F2")]
    Red_50,
    [EnumMember(Value = "#FEE2E2")]
    Red_100,
    [EnumMember(Value = "#FECACA")]
    Red_200,
    [EnumMember(Value = "#FCA5A5")]
    Red_300,
    [EnumMember(Value = "#F87171")]
    Red_400,
    [EnumMember(Value = "#EF4444")]
    Red_500,
    [EnumMember(Value = "#DC2626")]
    Red_600,
    [EnumMember(Value = "#B91C1C")]
    Red_700,
    [EnumMember(Value = "#991B1B")]
    Red_800,
    [EnumMember(Value = "#7F1D1D")]
    Red_900,
    [EnumMember(Value = "#702525")]
    Red_950,
    [EnumMember(Value = "#FFF7ED")]
    Orange_50,
    [EnumMember(Value = "#FFEDD5")]
    Orange_100,
    [EnumMember(Value = "#FED7AA")]
    Orange_200,
    [EnumMember(Value = "#FDBA74")]
    Orange_300,
    [EnumMember(Value = "#FB923C")]
    Orange_400,
    [EnumMember(Value = "#F97316")]
    Orange_500,
    [EnumMember(Value = "#EA580C")]
    Orange_600,
    [EnumMember(Value = "#C2410C")]
    Orange_700,
    [EnumMember(Value = "#9A3412")]
    Orange_800,
    [EnumMember(Value = "#7C2D12")]
    Orange_900,
    [EnumMember(Value = "#431407")]
    Orange_950,
    [EnumMember(Value = "#FFFBEB")]
    Amber_50,
    [EnumMember(Value = "#FEF3C7")]
    Amber_100,
    [EnumMember(Value = "#FDE68A")]
    Amber_200,
    [EnumMember(Value = "#FCD34D")]
    Amber_300,
    [EnumMember(Value = "#FBBF24")]
    Amber_400,
    [EnumMember(Value = "#F59E0B")]
    Amber_500,
    [EnumMember(Value = "#D97706")]
    Amber_600,
    [EnumMember(Value = "#B45309")]
    Amber_700,
    [EnumMember(Value = "#92400E")]
    Amber_800,
    [EnumMember(Value = "#78350F")]
    Amber_900,
    [EnumMember(Value = "#451A03")]
    Amber_950,
    [EnumMember(Value = "#FEFCE8")]
    Yellow_50,
    [EnumMember(Value = "#FEF9C3")]
    Yellow_100,
    [EnumMember(Value = "#FEF08A")]
    Yellow_200,
    [EnumMember(Value = "#FDE047")]
    Yellow_300,
    [EnumMember(Value = "#FACC15")]
    Yellow_400,
    [EnumMember(Value = "#EAB308")]
    Yellow_500,
    [EnumMember(Value = "#CA8A04")]
    Yellow_600,
    [EnumMember(Value = "#A16207")]
    Yellow_700,
    [EnumMember(Value = "#854D0E")]
    Yellow_800,
    [EnumMember(Value = "#713F12")]
    Yellow_900,
    [EnumMember(Value = "#5E3C10")]
    Yellow_950,
    [EnumMember(Value = "#F7FEE7")]
    Lime_50,
    [EnumMember(Value = "#ECFCCB")]
    Lime_100,
    [EnumMember(Value = "#D9F99D")]
    Lime_200,
    [EnumMember(Value = "#BEF264")]
    Lime_300,
    [EnumMember(Value = "#A3E635")]
    Lime_400,
    [EnumMember(Value = "#84CC16")]
    Lime_500,
    [EnumMember(Value = "#65A30D")]
    Lime_600,
    [EnumMember(Value = "#4D7C0F")]
    Lime_700,
    [EnumMember(Value = "#3F6212")]
    Lime_800,
    [EnumMember(Value = "#365314")]
    Lime_900,
    [EnumMember(Value = "#354A23")]
    Lime_950,
    [EnumMember(Value = "#F0FDF4")]
    Green_50,
    [EnumMember(Value = "#DCFCE7")]
    Green_100,
    [EnumMember(Value = "#BBF7D0")]
    Green_200,
    [EnumMember(Value = "#86EFAC")]
    Green_300,
    [EnumMember(Value = "#4ADE80")]
    Green_400,
    [EnumMember(Value = "#22C55E")]
    Green_500,
    [EnumMember(Value = "#16A34A")]
    Green_600,
    [EnumMember(Value = "#15803D")]
    Green_700,
    [EnumMember(Value = "#166534")]
    Green_800,
    [EnumMember(Value = "#14532D")]
    Green_900,
    [EnumMember(Value = "#144620")]
    Green_950,
    [EnumMember(Value = "#EFF6FF")]
    Blue_50,
    [EnumMember(Value = "#DBEAFE")]
    Blue_100,
    [EnumMember(Value = "#BFDBFE")]
    Blue_200,
    [EnumMember(Value = "#93C5FD")]
    Blue_300,
    [EnumMember(Value = "#60A5FA")]
    Blue_400,
    [EnumMember(Value = "#3B82F6")]
    Blue_500,
    [EnumMember(Value = "#2563EB")]
    Blue_600,
    [EnumMember(Value = "#1D4ED8")]
    Blue_700,
    [EnumMember(Value = "#1E40AF")]
    Blue_800,
    [EnumMember(Value = "#1E3A8A")]
    Blue_900,
    [EnumMember(Value = "#1E365D")]
    Blue_950
}
