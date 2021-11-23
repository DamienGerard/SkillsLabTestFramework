using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace SkillsLabTestFramework
{
    [TestFixture]
    class TestBase
    {
        [SetUp]
        public static void Initialize()
        {
            Browser.Initialize();
        }

        [TearDown]
        public static void TearDown()
        {
            Browser.Close();
        }
    }
}
