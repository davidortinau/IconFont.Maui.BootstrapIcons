namespace IconFont.Maui.BootstrapIcons;

/// <summary>
/// Extension methods for registering Bootstrap Icons with a MAUI application.
/// </summary>
public static class BootstrapIconsExtensions
{
    /// <summary>
    /// Registers the Bootstrap Icons font with the MAUI application.
    /// </summary>
    public static MauiAppBuilder UseBootstrapIcons(this MauiAppBuilder builder)
    {
        builder.ConfigureFonts(fonts =>
        {
            fonts.AddFont("bootstrap-icons.ttf", BootstrapIcons.FontFamily);
        });

        return builder;
    }
}
