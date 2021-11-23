using OpenQA.Selenium;
using SkillsLabTestFramework.Elements;

namespace SkillsLabTestFramework
{
    public class RegisterUserPage : Navbar, IPage
    {
        private IWebElement CreateStudent { get; }
        private IWebElement CreateStaff { get; }
        private IWebElement CreateAdmin { get; }

        private static string SubUrl = "User/RegisterUser";

        public string Url { get; } = $"{Browser.baseUrl}{SubUrl}";

        public RegisterUserPage()
        {
            var retriever = new Retriever(SubUrl);
            CreateStudent = retriever.getElement("CreateStudent");
            CreateStaff = retriever.getElement("CreateStaff");
            CreateAdmin = retriever.getElement("CreateAdmin");
        }

        public void ClickCreateStudent()
        {
            CreateStudent.Click();
        }

        public void ClickCreateStaff()
        {
            CreateStaff.Click();
        }

        public void ClickCreateAdmin()
        {
            CreateAdmin.Click();
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