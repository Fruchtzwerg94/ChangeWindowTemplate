namespace ChangeWindowTemplate;

public class BorderedWindow : Window
{
    public BorderedWindow()
    {
        var template = Template.Build(this);

        if (template.Control.GetType() != typeof(Border))
            throw new Exception($"Template {template.Control.GetType()} expect {typeof(Border)}");
    }
}