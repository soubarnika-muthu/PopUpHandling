/*Project = Popup Handling
 * created by = Soubarnika Muthu V
 * dated on = 13/09/21
 */
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;

namespace AlertPopupHandling
{
    public class Tests : Base.BaseClass
    {
        [Test, Order(0)]
        public void test_alert()
        {
            string button_xpath = "//button[.='Click for JS Alert']";
            var expectedAlertText = "I am a JS Alert";

            WebDriverWait wait = new WebDriverWait(driver, new TimeSpan(20));
            driver.Url = testurl;
            System.Threading.Thread.Sleep(2000);
            IWebElement alertbutton = wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementExists(By.XPath(button_xpath)));
            

            System.Threading.Thread.Sleep(2000);
            alertbutton.Click();

            var alert_win = driver.SwitchTo().Alert();
            Assert.AreEqual(expectedAlertText, alert_win.Text);
            System.Threading.Thread.Sleep(2000);
            alert_win.Accept();

            var clickResult = wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementExists(By.Id("result")));
            Console.WriteLine(clickResult.Text);

            if (clickResult.Text == "You successfully clicked an alert")
            {
                Console.WriteLine("Alert Text successful");
            }
        }
        [Test, Order(1)]
        public void test_confirm()
        {
            string button_css_selector = "button[onclick = 'jsConfirm()']";
            var expectedAlertText = "I am a JS Confirm";

            WebDriverWait wait = new WebDriverWait(driver, new TimeSpan(20));
            driver.Url = testurl;

            IWebElement confirmButton = wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementExists(By.CssSelector(button_css_selector)));
            confirmButton.Click();

            var confirm_win = driver.SwitchTo().Alert();
            confirm_win.Accept();

            IWebElement clickResult = driver.FindElement(By.Id("result"));
            Console.WriteLine(clickResult.Text);
            if (clickResult.Text == "You clicked: Ok")
            {
                Console.WriteLine("Confirm Text Successful");
            }
        }
        [Test, Order(2)]
        public void test_dismiss()
        {
            String button_css_selector = "button[onclick='jsConfirm()']";
            var expectedAlertText = "I am a JS Confirm";

            WebDriverWait wait = new WebDriverWait(driver, new TimeSpan(10));
            driver.Url = testurl;

            IWebElement confirmButton = wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementExists(By.CssSelector(button_css_selector)));

            confirmButton.Click();

            var confirm_win = driver.SwitchTo().Alert();
            confirm_win.Dismiss();

            IWebElement clickResult = driver.FindElement(By.Id("result"));
            Console.WriteLine(clickResult.Text);

            if (clickResult.Text == "You clicked: Cancel")
            {
                Console.WriteLine("Dismiss Test Successful");
            }
        }
        [Test, Order(3)]
        public void test_sendalert()
        {
            string button_css_selector = "button[onclick = 'jsPrompt()']";
            var expectedAlertText = "I am a JS prompt";
            WebDriverWait wait = new WebDriverWait(driver, new TimeSpan(20));
            driver.Url = testurl;
            IWebElement confirmButton = wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementExists(By.CssSelector(button_css_selector)));
            confirmButton.Click();
            var confirm_win = driver.SwitchTo().Alert();
            confirm_win.SendKeys("Confirm as Soubarnika");
            confirm_win.Accept();
            IWebElement clickResult = driver.FindElement(By.Id("result"));
            Console.WriteLine(clickResult.Text);
            if (clickResult.Text == "Confirm as Soubarnika")
            {
                Console.WriteLine("Accept Test Successful");
            }

        }
    }
}