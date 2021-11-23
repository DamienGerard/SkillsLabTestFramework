using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace SkillsLabTestFramework.Elements
{
    class Retriever
    {
        public JObject Elements;
        //private const string relativizer = "../../../Elements/Repository/";
        private string relativizer;
        public Retriever(string pageName) { 
            InitRelativizer();
            Elements = JObject.Parse(File.ReadAllText($"{relativizer}{pageName}Elements.json"));
        }

        private void InitRelativizer()
        {
            var execDirectory = AppDomain.CurrentDomain.BaseDirectory;
            var indexOfBaseDir = execDirectory.IndexOf(@"SkillsLabTestFramework\", 0);
            relativizer = $"{execDirectory.Substring(0, indexOfBaseDir+23)}SkillsLabTestFramework/Elements/Repository/";
        }

        public IWebElement getElement(string elementName) {
            var byMethod = typeof(By).GetMethod((string)Elements[elementName]["Selector"]["Type"]);
            IWebElement elementToReturn;
            try
            {
                elementToReturn = Browser.webDriver.FindElement((By)byMethod.Invoke(null, new object[] { (string)Elements[elementName]["Selector"]["Name"] }));
            }
            catch {
                elementToReturn = null;
            }
            return elementToReturn;
        }
    }
}
