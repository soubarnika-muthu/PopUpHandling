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
            Action.DoAction.JS_Alert();

        }
        [Test, Order(1)]
        public void test_confirm()
        {
            Action.DoAction.JS_Confirm();
        }
        [Test, Order(2)]
        public void test_Dismiss()
        {
            Action.DoAction.JS_Dismiss();
        }
    }
}