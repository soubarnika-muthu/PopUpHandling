/*Project = AlertPopup Handling
 * created by = Soubarnika Muthu
 * dated on = 14/09/21
 */

using System;
using AlertPopupHandling.PopupClass;

namespace AlertPopupHandling.Action
{
    public class DoAction :Base.BaseClass
    {
        public static void JS_Alert()
        {
            //creating instance of AlertPopup class
            AlertPopup alert = new AlertPopup(driver);
            alert.jsAlert.Click();
            System.Threading.Thread.Sleep(2000);
            // Switching to Alert  and Capturing alert message.
            var alert_win = driver.SwitchTo().Alert();
            // Accepting alert
            alert_win.Accept();
            // Displaying alert message
            System.Threading.Thread.Sleep(2000);
            Console.WriteLine(alert.clickResult.Text);
            if (alert.clickResult.Text == "You successfully clicked an alert")
            {
                Console.WriteLine("Alert Text successful");
            }
        }
        public static void JS_Confirm()
        {
            //creating instance of AlertPopup class
            AlertPopup alert = new AlertPopup(driver);
            alert.jsConfirm.Click();
            System.Threading.Thread.Sleep(2000);
            var alert_win = driver.SwitchTo().Alert();
            alert_win.Accept();
            // Displaying confirm message
            System.Threading.Thread.Sleep(2000);
            Console.WriteLine(alert.clickonResult.Text);
            if (alert.clickonResult.Text == "You clicked: Ok")
            {
                Console.WriteLine("Confirm Text Successful");
            }
        }
        public static void JS_Dismiss()
        {
            AlertPopup alert = new AlertPopup(driver);
            alert.jsDismiss.Click();
            System.Threading.Thread.Sleep(2000);
            var alert_win = driver.SwitchTo().Alert();
            alert_win.Dismiss();
            // Displaying dissmiss message
            System.Threading.Thread.Sleep(2000);
            Console.WriteLine(alert.clickforResult.Text);
            if (alert.clickforResult.Text == "You clicked: Cancel")
            {
                Console.WriteLine("Dismiss Test Successful");
            }
        }
    }
}
