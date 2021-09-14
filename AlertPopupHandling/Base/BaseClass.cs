/*Project = Popup Handling
 * created by = Soubarnika Muthu
 * dated on = 13/09/21
 */

using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;


namespace AlertPopupHandling.Base
{
    public class BaseClass
    {
        public string testurl = "https://the-internet.herokuapp.com/javascript_alerts";
        public IWebDriver driver;

        [SetUp]
        public void start_Browser()
        {

            ChromeOptions options = new ChromeOptions();
            options.AddArgument("Start-Maximized");
            options.AddArgument("headless");

            //local selenium webdriver
            driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            System.Threading.Thread.Sleep(2000);
        }
        [TearDown]
        public void close_Browser()
        {
            driver.Quit();
        }

    }
}