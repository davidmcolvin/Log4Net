[assembly: log4net.Config.XmlConfigurator(Watch = true)]

static void myMain() 
{


  log4net.ILog log = log4net.LogManager.GetLogger("Program.cs");

  Console.WriteLine("Hello, World!");

  log.Error("This is my error message");
}

myMain();