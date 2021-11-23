using OpenQA.Selenium;
using SkillsLabTestFramework.Elements;
using System;
using System.Collections.Generic;
using System.Text;

namespace SkillsLabTestFramework
{
    public class Navbar
    {
        private IWebElement logBtn { get; }
        public bool IsLoggedIn { get; }

        public Navbar() {
            var retriever = new Retriever("Navbar");
            logBtn = retriever.getElement("logBtn");
            IsLoggedIn = (logBtn.Text == "Login") ? true : false;
        }

        public void ClicklogBtn() {
            logBtn.Click();
        }
    }
}
