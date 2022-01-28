namespace ChangeWindowTemplate;

public class App : Application
{
    public App()
    {
    }

    public override void Initialize() => AvaloniaXamlLoader.Load(this);

    public override void OnFrameworkInitializationCompleted()
    {
        switch (ApplicationLifetime)
        {
            case IClassicDesktopStyleApplicationLifetime classicDesktop:
                classicDesktop.MainWindow = new BorderedWindow();
                break;
        }

        base.OnFrameworkInitializationCompleted();
    }
}