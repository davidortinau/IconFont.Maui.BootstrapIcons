using Microsoft.Maui.Controls;
using Microsoft.Maui.Graphics;
using Microsoft.Maui.Controls.Internals;

namespace IconFont.Maui.BootstrapIcons;

/// <summary>
/// Provides helper APIs for the Bootstrap Icons font.
/// Glyph constants and FontFamily are emitted at build time by the source generator.
/// </summary>
[Preserve(AllMembers = true)]
public static partial class BootstrapIcons
{
    static BootstrapIcons() { }

    /// <summary>
    /// Creates a <see cref="FontImageSource"/> for the given glyph.
    /// </summary>
    /// <param name="glyph">The glyph string, typically from <c>BootstrapIcons.Search</c>, etc.</param>
    /// <param name="color">Optional foreground color; defaults to <see cref="Colors.Black"/>.</param>
    /// <param name="size">Icon size in device-independent units.</param>
    public static FontImageSource Create(string glyph, Color? color = null, double size = 24d)
    {
        return new FontImageSource
        {
            FontFamily = FontFamily,
            Glyph = glyph,
            Color = color ?? Colors.Black,
            Size = size
        };
    }
}
