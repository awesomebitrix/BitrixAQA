using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.IE;
using ATS;
using MiscMethods;
using System.Xml.XPath;


namespace SeleniumSpace
{
    class Selenium
    {
        private IWebDriver driver;
        MainForm mainForm;
        OptionsForm optionsForm;
        Misc misc;

        public Selenium(MainForm mainForm)
        {
            this.mainForm = mainForm;
        }
        public Selenium(OptionsForm optionsForm)
        {
            this.optionsForm = optionsForm;
        }

        public void FixtureSetup()
        {
            FirefoxProfile firefoxProfile = new FirefoxProfile();
            driver = new FirefoxDriver();
            driver.Manage().Timeouts().ImplicitlyWait(new TimeSpan(0, 0, 30));   
        }

        public void InstallWizardGeneralPart()
        {
            FixtureSetup();
            //driver.Navigate().GoToUrl("http://127.0.0.1:6448");
            driver.Navigate().GoToUrl("http://localhost:999/");
            //driver.FindElement(By.XPath(BitrixInstallWizard.WizardNextButton)).Click();
            //driver.FindElement(By.XPath(BitrixInstallWizard.AgreeLicenseId)).Click();
            //log.Info(BitrixInstallWizard.AgreeLicenseId.ToString());
            //driver.FindElement(By.Name("q")).SendKeys("".PadLeft(2, (char)(int)System.Windows.Forms.Keys.Back));
        }
    }
}
