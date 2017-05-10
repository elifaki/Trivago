using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.IE;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            IWebDriver webDriver = new InternetExplorerDriver();
            webDriver.Navigate().GoToUrl("info.thy.com");
        }
    }
}
