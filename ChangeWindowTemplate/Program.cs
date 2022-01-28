AppBuilder.Configure<App>()
    .UsePlatformDetect()
    .UseReactiveUI()
    .StartWithClassicDesktopLifetime(args, ShutdownMode.OnMainWindowClose);