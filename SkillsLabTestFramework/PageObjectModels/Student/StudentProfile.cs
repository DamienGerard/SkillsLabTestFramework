using OpenQA.Selenium;
using SkillsLabTestFramework.Elements;

namespace SkillsLabTestFramework
{
    public class StudentProfile : SharedComponents, IPage
    {
        private static string SubUrl = "Student/Index";

        public string Url { get; } = $"{Browser.baseUrl}{SubUrl}";

        private IWebElement ModifyBtn { get; }

        private IWebElement MyCurriculumBtn { get; }

        private IWebElement AssignmentBtn { get; }

        public StudentProfile()
        {
            var retriever = new Retriever(SubUrl);
            ModifyBtn = retriever.getElement("ModifyBtn");
            MyCurriculumBtn = retriever.getElement("MyCurriculumBtn");
            AssignmentBtn = retriever.getElement("AssignmentBtn");
        }

        public void clickModifyBtn() => ModifyBtn.Click();

        public void clickMyCurriculumBtn() => MyCurriculumBtn.Click();

        public void clickAssignmentBtn() => AssignmentBtn.Click();

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