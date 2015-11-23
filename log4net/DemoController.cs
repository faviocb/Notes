public class ReportController : ApiController
 {

     private static readonly ILog Log = LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);



      ...

      public ActionResult Index()
      {

        //Metareport (using log4net):
        log4net.GlobalContext.Properties["Date"] = DateTime.Now.Date.ToShortDateString();
        log4net.GlobalContext.Properties["Time"] = DateTime.Now.Hour.ToString() + ":" + DateTime.Now.Minute.ToString();
        log4net.GlobalContext.Properties["Username"] = username.Replace(",", " ");
        log4net.GlobalContext.Properties["FileName"] = fileModel.FileName.Replace(",", " ");
        Log.Info("Metareport");

        ...



        try
        {
            ...
        }
        catch (Exception e)
        {
            Log.Error("An error occurred when savign metareport", e);
        }


      }
