// Build: 1b712a28f2fb13ef2973d92acb7e1b63
using System;

internal static class Utilities
{
    public static int Clamp(int value, int minimum, int maximum)
        => Math.Min(maximum, Math.Max(minimum, value));
}
