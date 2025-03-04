//Builder design pattern is used when you want to take away logic of building a complex object and give it to some other objext.


ApplicationBuilder builder = new ApplicationBuilder();
Application appl=builder.SetConfigA(1).SetConfigB(2).SetConfigC(3).Build();
Console.WriteLine(appl.AddAllConfigs());


class Application
{
    public int ConfigA { get; set; }
    public int ConfigB { get; set; }
    public int ConfigC { get; set; }
    
    public int AddAllConfigs()
    {
        return ConfigA+ConfigB+ConfigC;
    }

}

class ApplicationBuilder
{
    private Application application;

    public ApplicationBuilder()
    {
        application = new Application();
    }
    public ApplicationBuilder SetConfigA(int configA)
    {
        application.ConfigA = configA;
        return this;
    }
    public ApplicationBuilder SetConfigB(int configB)
    {
        application.ConfigB = configB;
        return this;
    }

    public ApplicationBuilder SetConfigC(int configC)
    {
        application.ConfigC = configC;
        return this;
    }
    public Application Build()
    {
        return application;
    }

}