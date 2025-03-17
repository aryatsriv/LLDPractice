//Purpose: To provide an interface for creating families of related or dependent objects without specifying their concrete classes.
//Key point: It uses composition to create multiple factories.
//Multiple families / types of objects, usually related.

//IGUIFactory factory;

//// Assume runtime condition
//string os = "Windows";

//if (os == "Windows")
//    factory = new WindowsFactory();
//else
//    factory = new MacFactory();

//UIApplication app = new UIApplication(factory);
//app.Render();


public interface IButton
{
    void Render();
}

// Abstract Product B
public interface ICheckbox
{
    void Render();
}


public class WindowsButton : IButton
{
    public void Render() => Console.WriteLine("Rendering Windows Button");
}

public class WindowsCheckbox : ICheckbox
{
    public void Render() => Console.WriteLine("Rendering Windows Checkbox");
}

// Mac Products
public class MacButton : IButton
{
    public void Render() => Console.WriteLine("Rendering Mac Button");
}

public class MacCheckbox : ICheckbox
{
    public void Render() => Console.WriteLine("Rendering Mac Checkbox");
}


public interface IGUIFactory
{
    IButton CreateButton();
    ICheckbox CreateCheckbox();
}

public class WindowsFactory : IGUIFactory
{
    public IButton CreateButton() => new WindowsButton();
    public ICheckbox CreateCheckbox() => new WindowsCheckbox();
}

public class MacFactory : IGUIFactory
{
    public IButton CreateButton() => new MacButton();
    public ICheckbox CreateCheckbox() => new MacCheckbox();
}


public class UIApplication
{
    private readonly IButton button;
    private readonly ICheckbox checkbox;

    public UIApplication(IGUIFactory factory)
    {
        button = factory.CreateButton();
        checkbox = factory.CreateCheckbox();
    }

    public void Render()
    {
        button.Render();
        checkbox.Render();
    }
}