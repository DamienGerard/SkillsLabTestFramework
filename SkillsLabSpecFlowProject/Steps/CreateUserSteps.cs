using NUnit.Framework;
using SkillsLabTestFramework;
using System;
using TechTalk.SpecFlow;

namespace SkillsLabSpecFlowProject.Steps
{
    [Binding]
    public class CreateUserSteps
    {
        [Given(@"I click on Create Users")]
        public void GivenIClickOnCreateUsers()
        {
            Pages.AdminProfile.ClickCreateUsers();
        }
        
        [Given(@"I click on Create Student")]
        public void GivenIClickOnCreateStudent()
        {
            Pages.RegisterUser.ClickCreateStudent();
        }
        
        [Given(@"I enter student details")]
        public void GivenIEnterStudentDetails(Table table)
        {
            var createStudentpage = Pages.StudentCreate;
            createStudentpage.EnterUsername(table.Rows[0]["UserName"]);
            createStudentpage.EnterFirstName(table.Rows[0]["FirstName"]);
            createStudentpage.EnterLastName(table.Rows[0]["LastName"]);
            createStudentpage.EnterPassword(table.Rows[0]["Password"]);
            createStudentpage.EnterEmail(table.Rows[0]["Email"]);
            createStudentpage.EnterDOB(table.Rows[0]["DOB"]);
        }
        
        [When(@"I click create")]
        public void WhenIClickCreate()
        {
            Pages.StudentCreate.ClickSubmit();
        }
        
        [Then(@"I should be on the student profle")]
        public void ThenIShouldBeOnTheStudentProfle()
        {
            Assert.IsTrue(Pages.StudentProfile.IsAt());
        }
    }
}
