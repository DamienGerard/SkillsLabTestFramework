using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using SkillsLabTestFramework.Elements;

namespace SkillsLabTestFramework
{
    public class LoginPage : Navbar, IPage
    {
        private IWebElement usernameTextField { get; }

        private IWebElement passwordTextField { get; }

        private IWebElement logInButton { get; }

        public string Url { get; } = $"{Browser.baseUrl}{subUrl}";

        private static readonly string subUrl = "User/Login";

        public LoginPage() {
            var retriever = new Retriever(subUrl);
            usernameTextField = retriever.getElement("UsernameTextField");
            passwordTextField = retriever.getElement("PasswordTextField");
            logInButton = retriever.getElement("LoginButton");
        }

        public void EnterCredentials(string username, string password)
        {
            usernameTextField.SendKeys(username);
            passwordTextField.SendKeys(password);
        }

        public void ClickLogin()
        {
            logInButton.Click();
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