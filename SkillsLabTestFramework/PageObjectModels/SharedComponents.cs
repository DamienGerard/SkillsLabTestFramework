using OpenQA.Selenium;
using SkillsLabTestFramework.Elements;
using System;
using System.Collections.Generic;
using System.Text;

namespace SkillsLabTestFramework
{
    public class SharedComponents
    {
        private IWebElement logBtn { get; }
        private IWebElement CloseErrorMessage { get; }
        private IWebElement CloseSuccessMessage { get; }
        //*[@id="errorModal"]/div/div/div[3]/button
        public bool IsLoggedIn { get; }

        public SharedComponents() {
            var retriever = new Retriever("SharedComponents");
            logBtn = retriever.getElement("logBtn");
            CloseErrorMessage = retriever.getElement("CloseErrorMessage");
            CloseSuccessMessage = retriever.getElement("CloseSuccessMessage");
            IsLoggedIn = (logBtn.Text == "Login") ? true : false;
        }

        public void ClicklogBtn() {
            logBtn.Click();
        }

        public void ClickCloseErrorMessage()
        {
            System.Threading.Thread.Sleep(2500);
            CloseErrorMessage.Click();
        }

        public void ClickCloseSuccessMessage() {
            System.Threading.Thread.Sleep(2500);
            CloseSuccessMessage.Click();
        }
    }
}
