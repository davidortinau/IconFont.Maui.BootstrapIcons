# IconFont.Maui.BootstrapIcons

[![NuGet](https://img.shields.io/nuget/v/IconFont.Maui.BootstrapIcons.svg?label=NuGet)](https://www.nuget.org/packages/IconFont.Maui.BootstrapIcons)

`IconFont.Maui.BootstrapIcons` ships the [Bootstrap Icons](https://icons.getbootstrap.com/) TTF icon font for .NET MAUI:

| Font | File | Class |
|------|------|-------|
| Bootstrap Icons | `bootstrap-icons.ttf` | `BootstrapIcons` |

It registers the font across supported targets when you call `UseBootstrapIcons()` and exposes strongly-typed glyph constants (2,000+ icons) to simplify XAML and C# usage.

Glyph constants are generated at build time by [`IconFont.Maui.SourceGenerator`](https://www.nuget.org/packages/IconFont.Maui.SourceGenerator) — no hand-maintained code.

### ✨ Features

- ⚙️ **One-line setup**: call `builder.UseBootstrapIcons()` to register the font
- 🔤 **Strongly-typed glyphs** via `BootstrapIcons.Search`, `BootstrapIcons.HeartFill`, etc.
- 🧰 **Helper APIs**: `BootstrapIcons.Create()` for `FontImageSource`
- 🔧 **Source-generated**: glyph constants emitted at compile time from the TTF binary
- 📱 **Supported targets**: Android, iOS, Mac Catalyst

### 📦 Install

```
dotnet add package IconFont.Maui.BootstrapIcons
```

### 🚀 Getting Started

#### Register

```csharp
var builder = MauiApp.CreateBuilder()
    .UseMauiApp<App>()
    .UseBootstrapIcons(); // registers the Bootstrap Icons font
```

#### XAML usage

```xml
xmlns:icons="clr-namespace:IconFont.Maui.BootstrapIcons;assembly=IconFont.Maui.BootstrapIcons"

<Image WidthRequest="32" HeightRequest="32">
    <Image.Source>
        <FontImageSource Glyph="{x:Static icons:BootstrapIcons.Search}"
                         FontFamily="{x:Static icons:BootstrapIcons.FontFamily}"
                         Color="#0D6EFD"
                         Size="32" />
    </Image.Source>
</Image>
```

#### C# usage

```csharp
using IconFont.Maui.BootstrapIcons;

// Create a FontImageSource for any glyph
var source = BootstrapIcons.Create(BootstrapIcons.HeartFill, Colors.Red, 32);
```

### 🎨 Using with Bootstrap Themes

This package works great alongside [`Plugin.Maui.BootstrapTheme`](https://www.nuget.org/packages/Plugin.Maui.BootstrapTheme) — but **neither depends on the other**. Use them independently or together:

```csharp
builder.UseMauiApp<App>()
    .UseBootstrapTheme(...)   // optional — Bootstrap theme styling
    .UseBootstrapIcons();     // Bootstrap Icons font
```

When both are installed, use `DynamicResource` to make icons respond to theme changes:

```xml
<FontImageSource Glyph="{x:Static icons:BootstrapIcons.Search}"
                 FontFamily="{x:Static icons:BootstrapIcons.FontFamily}"
                 Color="{DynamicResource OnBackground}" />
```

### 📋 Common Icons

| Constant | Icon Name | Unicode |
|----------|-----------|---------|
| `BootstrapIcons.Search` | search | U+F52A |
| `BootstrapIcons.House` | house | U+F424 |
| `BootstrapIcons.HeartFill` | heart-fill | U+F47F |
| `BootstrapIcons.Gear` | gear | U+F3E5 |
| `BootstrapIcons.PersonFill` | person-fill | U+F4DA |
| `BootstrapIcons.PlusCircle` | plus-circle | U+F4FE |
| `BootstrapIcons.ArrowRight` | arrow-right | U+F138 |
| `BootstrapIcons.Check` | check | U+F26E |
| `BootstrapIcons.XLg` | x-lg | U+F659 |
| `BootstrapIcons.ThreeDots` | three-dots | U+F5D4 |

Browse all 2,000+ icons at [icons.getbootstrap.com](https://icons.getbootstrap.com/).

### 🏗️ Architecture

This package is part of the [IconFont.Maui](https://github.com/jfversluis/IconFont.Maui.Template) ecosystem:

| Package | Purpose |
|---------|---------|
| [`IconFont.Maui.SourceGenerator`](https://www.nuget.org/packages/IconFont.Maui.SourceGenerator) | Shared source generator — parses TTF and emits glyph constants |
| [`IconFont.Maui.FluentIcons`](https://www.nuget.org/packages/IconFont.Maui.FluentIcons) | Fluent UI System Icons |
| **`IconFont.Maui.BootstrapIcons`** | Bootstrap Icons (this package) |

### 🧩 Platforms

| Platform | Minimum |
|----------|---------|
| Android  | 21+     |
| iOS      | 15+     |
| macOS    | 14+     |

### 📄 License

- **Library:** MIT
- **Font:** MIT (see [license](https://github.com/twbs/icons/blob/main/LICENSE))

### 🙏 Attribution

- Upstream font: MIT © The Bootstrap Authors
- Source generator: [IconFont.Maui.SourceGenerator](https://github.com/jfversluis/IconFont.Maui.SourceGenerator)
- This project is not affiliated with or endorsed by Bootstrap.
