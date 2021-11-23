using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Text;

namespace SkillsLabTestFramework
{
    public class Browser
    {
        public static string baseUrl = "https://localhost:44389/";
        public static WebDriver webDriver = new ChromeDriver(@"C:\Users\P128BF6\source\repos\SkillsLabTestFramework\SkillsLabTestFramework\bin\Debug\netcoreapp3.1");
        public static void Initialize()
        {
            Goto("");
        }

        public static string Title
        {
            get { return webDriver.Title; }
        }

        public static ISearchContext Driver
        {
            get { return webDriver; }
        }

        public static void Goto(string url)
        {
            webDriver.Url = baseUrl + url;
        }

        public static void Close()
        {
            //webDriver.Close();
        }
    }
}
