//// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

//var singleton = Logger.getInstance();
//singleton.IncrVal();
//Console.WriteLine(singleton.Val);
//singleton.IncrVal();
//Console.WriteLine(singleton.Val);
//singleton.IncrVal();
//Console.WriteLine(singleton.Val);
//var singleton2 = Logger.getInstance();
//singleton.IncrVal();
//Console.WriteLine(singleton.Val);
//singleton.IncrVal();
//Console.WriteLine(singleton2.Val);
//singleton.IncrVal();



class Logger
{
    private static Logger? instance;
    private static Object _lockObject = new Object();

    public int Val { get; set; }
    private Logger()
    {
        Val = 1;
    }
    public static Logger getInstance()
    {
        lock (_lockObject)
        {
            if (instance == null)
            {
                instance = new Logger();
            }
            return instance;
        }
    }

    public void IncrVal()
    {
        Val += 1;
    }
}