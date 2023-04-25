using ConsoleUI;

[assembly: log4net.Config.XmlConfigurator(Watch = true)]

static void myMain() 
{
  log4net.ILog log = LogHelper.GetLogger();

  Console.WriteLine("Hello, World!");

  log.Error("This is my error message");
}

myMain();