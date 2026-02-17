using Microsoft.Maui.Hosting;

namespace IconFont.Maui.BootstrapIcons;

/// <summary>
/// Extension methods for registering Bootstrap Icons with a MAUI application.
/// </summary>
public static partial class IconFontBuilderExtensions
{
    /// <summary>
    /// Registers all Bootstrap Icons font aliases.
    /// </summary>
    public static MauiAppBuilder UseIconFont(this MauiAppBuilder builder)
    {
        builder.ConfigureFonts(fonts =>
        {
            foreach (var cfg in IconFontConfigs.All)
            {
                fonts.AddFont(cfg.FontFile, cfg.FontAlias);
            }
        });
        return builder;
    }

    /// <summary>
    /// Registers a specific Bootstrap Icons font by class name.
    /// </summary>
    public static MauiAppBuilder UseIconFont(this MauiAppBuilder builder, string fontClass)
    {
        var cfg = System.Array.Find(IconFontConfigs.All, x => x.ClassName == fontClass);
        if (cfg is not null)
        {
            builder.ConfigureFonts(fonts => fonts.AddFont(cfg.FontFile, cfg.FontAlias));
        }
        return builder;
    }
}
