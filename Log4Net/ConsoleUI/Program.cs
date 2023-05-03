using ConsoleUI;

[assembly: log4net.Config.XmlConfigurator(Watch = true)]

static void myMain() 
{
  log4net.ILog log = LogHelper.GetLogger();

  Console.WriteLine("Hello, World!");
  log.Debug("Developer: Tutorial was run");
  log.Info("Maintenance: water pump turned on");
  log.Warn("Maintenance: the water pump is getting hot");
  log.Error("This is my error message");
  log.Fatal("This is my error message");
  log.Fatal("This is my error message2");
}

myMain();