/*Project = AlertPopup Handling
 * created by = Soubarnika Muthu
 * dated on = 14/09/21
 */


using log4net;
using log4net.Config;
using log4net.Repository;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.IO;
using System.Reflection;

namespace AlertPopupHandling.Base
{
    public class BaseClass
    {
        //Webdriver interface
        public static IWebDriver driver;
        //Get Logger for fully qualified name for type of 'Tests'
        private static readonly ILog log = LogManager.GetLogger(typeof(Tests));

        //Get the default ILoggingRepository
        private static readonly ILoggerRepository repository = log4net.LogManager.GetRepository(Assembly.GetCallingAssembly());


        [SetUp]
        public void start_Browser()
        {
            // Configuring Log4Net
           // BasicConfigurator.Configure();
            // Valid XML file with Log4Net Configurations
           var fileInfo = new FileInfo(@"Log4net.config");

            // Configure default logging repository with Log4Net configurations
           log4net.Config.XmlConfigurator.Configure(repository, fileInfo);
            try
            {
                log.Info("Entering Setup");
                //Creating an instance webdriver
                driver = new ChromeDriver();
                // To maximize browser
                driver.Manage().Window.Maximize();
                System.Threading.Thread.Sleep(200);
                //opens the url
                driver.Url = "https://the-internet.herokuapp.com/javascript_alerts";
                log.Debug("navigating to url");

                log.Info("Exiting setup");
            }
            catch(Exception ex)
            {
                log.Error(ex.Message);
            }
        }
        [TearDown]
        public void close_Browser()
        {
            //closing the browser
            driver.Quit();
        }

    }
}