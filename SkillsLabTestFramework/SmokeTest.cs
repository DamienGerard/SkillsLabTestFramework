using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace SkillsLabTestFramework
{
    [TestFixture]
    class SmokeTest : TestBase
    {
        [Test]
        public void CanLogInAsAdmin()
        {
            Pages.Login.Goto();
            Pages.Login.EnterCredentials("jon", "jon");
            Pages.Login.ClickLogin();
            Pages.AdminProfile.ClickCloseSuccessMessage();
            Assert.IsTrue(Browser.webDriver.Url == Pages.AdminProfile.Url);
        }
    }
}
