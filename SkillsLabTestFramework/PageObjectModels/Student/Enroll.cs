using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SkillsLabTestFramework.Elements;
using System;
using System.Collections.Generic;
using System.Text;

namespace SkillsLabTestFramework
{
    class Enroll : SharedComponents, IPage
    {
        private SelectElement StudentsDropwdown { get; }
        private SelectElement CurriculumsDropwdown { get; }
        private IWebElement EnrollBtn { get; }

        private static string SubUrl = "Student/Enroll";

        public string Url { get; } = $"{Browser.baseUrl}{SubUrl}";

        public Enroll()
        {
            var retriever = new Retriever(SubUrl);
            StudentsDropwdown = new SelectElement(retriever.getElement("StudentsDropwdown"));
            CurriculumsDropwdown = new SelectElement(retriever.getElement("CurriculumsDropwdown"));
            EnrollBtn = retriever.getElement("EnrollBtn");
        }

        public void SelectStudentByUsername(string username) => StudentsDropwdown.SelectByText(username);

        public void SelectStudentByValue(int userId) => StudentsDropwdown.SelectByValue($"{userId}");

        public void SelectCurriculumByName(string curriculumName) => CurriculumsDropwdown.SelectByText(curriculumName);

        public void SelectCurriculumByValue(int curriculumId) => CurriculumsDropwdown.SelectByValue($"{curriculumId}");

        public void ClickEnrollBtn() => EnrollBtn.Click();

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
