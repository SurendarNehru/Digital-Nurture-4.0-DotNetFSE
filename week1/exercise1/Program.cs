using System;

public class Logger
{
    private static Logger? logInstance;
    private Logger()
    {
        Console.WriteLine("Logger is Initialized");
    }
    public static Logger GetInstance()
    {
        if (logInstance == null)
        {
            logInstance = new Logger();
        }
        return logInstance!;
    }
    public void Log(string msg)
    {
        Console.WriteLine(msg);
    }
}

class Program
{
    static void Main(string[] args)
    {
        Logger logger1 = Logger.GetInstance();
        logger1.Log("log msg 1");

        Logger logger2 = Logger.GetInstance();
        logger2.Log("log msg 2");

        if (logger1 == logger2)
        {
            Console.WriteLine("Both log msg 1 and log msg 2 refer to the same instance");
        }
        else
        {
            Console.WriteLine("Different instances exist");
        }
    }
}

