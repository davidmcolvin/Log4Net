using ConsoleUI;

[assembly: log4net.Config.XmlConfigurator(Watch = true)]

static void myMain() 
{
  log4net.ILog log = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType); //LogHelper.GetLogger();

  Console.WriteLine("Hello, World!");
  log.Debug("Developer: Tutorial was run");
  log.Info("Maintenance: water pump turned on");
  log.Warn("Maintenance: the water pump is getting hot");

  var i = 0;

  try
  {
    var x = 10 / i;
  }
  catch (DivideByZeroException ex)
  {

    log.Error("Developer: we tried to divide by zero again");
  }

  log.Fatal("h");
}

myMain();