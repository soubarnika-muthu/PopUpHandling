/*Project = AlertPopup Handling
 * created by = Soubarnika Muthu
 * dated on = 14/09/21
 */


using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace AlertPopupHandling.Base
{
    public class BaseClass
    {
        //Webdriver interface
        public static IWebDriver driver;

        [SetUp]
        public void start_Browser()
        {
            //Creating an instance webdriver
            driver = new ChromeDriver();
            // To maximize browser
            driver.Manage().Window.Maximize();
            System.Threading.Thread.Sleep(200);
            //opens the url
            driver.Url = "https://the-internet.herokuapp.com/javascript_alerts";
        }
        [TearDown]
        public void close_Browser()
        {
            //closing the browser
            driver.Quit();
        }

    }
}