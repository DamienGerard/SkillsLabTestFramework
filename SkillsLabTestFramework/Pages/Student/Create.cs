using OpenQA.Selenium;
using SkillsLabTestFramework.Elements;
using System;
using System.Collections.Generic;
using System.Text;

namespace SkillsLabTestFramework
{
    class Create : Navbar, IPage
    {
        private static string SubUrl = "Student/RegisterUser";

        public string Url { get; } = $"{Browser.baseUrl}{SubUrl}";

        private IWebElement UsernameTextField { get; }
        private IWebElement FirstNameTextField { get; }
        private IWebElement LastNameTextField { get; }
        private IWebElement PasswordTextField { get; }
        private IWebElement EmailTextField { get; }
        private IWebElement DOBDatePicker { get; }
        private IWebElement Submit { get; }

        public Create()
        {
            var retriever = new Retriever(SubUrl);
            UsernameTextField = retriever.getElement("UsernameTextField");
            FirstNameTextField = retriever.getElement("FirstNameTextField");
            LastNameTextField = retriever.getElement("LastNameTextField");
            PasswordTextField = retriever.getElement("PasswordTextField");
            EmailTextField = retriever.getElement("EmailTextField");
            Submit = retriever.getElement("CreateBtn");
        }

        public void EnterUsername(string username)
        {
            UsernameTextField.SendKeys(username);
        }

        public void EnterFirstName(string firstname)
        {
            FirstNameTextField.SendKeys(firstname);
        }

        public void EnterLastName(string lastname)
        {
            LastNameTextField.SendKeys(lastname);
        }

        public void EnterPassword(string password)
        {
            PasswordTextField.SendKeys(password);
        }

        public void EnterEmail(string email)
        {
            EmailTextField.SendKeys(email);
        }

        public void EnterDOB(string dob)
        {
            DOBDatePicker.SendKeys(dob);
        }

        public void ClickSubmit() {
            Submit.Click();
        }

        public void Goto()
        {
            Browser.webDriver.Navigate().GoToUrl(Url);
        }

        public bool IsAt()
        {
            return Browser.webDriver.Url.StartsWith(Url);
        }
    }
}
