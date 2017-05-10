
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.IE;

namespace MyTest
{
	class Nunit
    {
        IWebDriver webDriver;
        IWebElement eMail;
        IWebElement passWord;
        IWebElement showPassWord;
        IWebElement logIn;

        [SetUp]
        public void InitializeBrowser()
        {
            webDriver = new InternetExplorerDriver(@"C:\Users\e_talay\Downloads\IEDriverServer_beta_Win32_3.3.99.4");
        }
        [Test]
        public void TestNunit()
        {
            webDriver.Navigate().GoToUrl("https://accounts.trivago.com/login#/sign-up");
            eMail = webDriver.FindElement(By.Id("emailRegister"));
            eMail.Clear();
            eMail.SendKeys("example" + Keys.Alt + "q" + "example.com");
            showPassWord = webDriver.FindElement(By.Id("register-show-pass"));
            showPassWord.Click();
            passWord = webDriver.FindElement(By.Id("register-pass"));
            passWord.SendKeys("1q2w3e4r5T");
            logIn = webDriver.FindElement(By.CssSelector("button[class='btn btn--primary btn--submit login-btn--submit mb-gutter fl-trailing js_tlgSignupSubmit']"));
            logIn.Click();
        }

        [TearDown]
        public void CloseBrowser()
        {
            webDriver.Close();
        }

      
    }
}
