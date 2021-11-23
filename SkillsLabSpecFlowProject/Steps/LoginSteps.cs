using System;
using TechTalk.SpecFlow;
using SkillsLabTestFramework;
using NUnit.Framework;

namespace SkillsLabSpecFlowProject.Features
{
    [Binding]
    public class LoginSteps
    {
        [Given(@"I navigate to application")]
        public void GivenINavigateToApplication()
        {
            Browser.Initialize();
        }

        [Given(@"I go to Login page")]
        public void GivenIGoToLoginPage()
        {
            Pages.Login.Goto();
        }

        [Given(@"I enter username and password")]
        public void GivenIEnterUsernameAndPassword(Table table)
        {
            Pages.Login.EnterCredentials(table.Rows[0]["UserName"], table.Rows[0]["Password"]);
        }
        
        [When(@"I click login")]
        public void WhenIClickLogin()
        {
            Pages.Login.ClickLogin();
        }
        
        [Then(@"I should see user logged in as admin")]
        public void ThenIShouldSeeUserLoggedInAsAdmin()
        {
            Pages.AdminProfile.ClickCloseSuccessMessage();
            Assert.IsTrue(Pages.AdminProfile.IsAt());
        }
    }
}
