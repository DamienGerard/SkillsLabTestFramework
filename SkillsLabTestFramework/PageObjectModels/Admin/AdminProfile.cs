using OpenQA.Selenium;
using SkillsLabTestFramework;
using SkillsLabTestFramework.Elements;

namespace SkillsLabTestFramework
{
    public class AdminProfile:SharedComponents, IPage
    {
        private IWebElement Modify { get; }
        private IWebElement CreateUsers { get; }
        private IWebElement Curriculum { get; }
        private IWebElement Programmes { get; }
        private IWebElement EnrollStudents { get; }

        public string Url { get; } = $"{Browser.baseUrl}{SubUrl}";
        private static string SubUrl { get; } = "Admin/Index";

        public AdminProfile()
        {
            var retriever = new Retriever(SubUrl);
            Modify = retriever.getElement("Modify");
            CreateUsers = retriever.getElement("CreateUsers");
            Curriculum = retriever.getElement("Curriculum");
            Programmes = retriever.getElement("Programmes");
            EnrollStudents = retriever.getElement("EnrollStudents");
        }

        public void ClickModify()
        {
            Modify.Click();
        }

        public void ClickCreateUsers()
        {
            CreateUsers.Click();
        }

        public void ClickCurriculum()
        {
            Curriculum.Click();
        }

        public void ClickProgrammes()
        {
            Programmes.Click();
        }

        public void ClickEnrollStudents()
        {
            EnrollStudents.Click();
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