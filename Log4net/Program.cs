using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using log4net;
using log4net.Config;
using System.Reflection;

[assembly: log4net.Config.XmlConfigurator(ConfigFile ="log4net.Config", Watch =true)]
namespace Log4net
{

    class Program
    {
        // Define a static logger variable so that it references the
        // Logger instance named "MyApp".
        private static readonly ILog m_log = LogManager.GetLogger("myErrorLogger");

        static void Main(string[] args)
        {
            //XmlConfigurator.ConfigureAndWatch(new System.IO.FileInfo(@"E:\wyman\practics\Practice\Log4net\log4net.Config"));
            //Console.WriteLine("Begin Run");
            //Console.WriteLine(AppDomain.CurrentDomain.BaseDirectory);

            ////XmlConfigurator.Configure();
            ////Type type = MethodBase.GetCurrentMethod().DeclaringType;
            ////ILog m_log = LogManager.GetLogger(type);
            ////m_log.Debug("这是一个Debug日志");
            //m_log.Info("这是一个Info日志");
            ////m_log.Warn("这是一个Warn日志");
            //m_log.Error("这是一个Error日志",new Exception("aaasdfasdf"));
            ////m_log.Fatal("这是一个Fatal日志");


            m_log.Fatal("this is myErrorLogger of database");

            Console.WriteLine("End");
            Console.Read();
        }
    }
}
