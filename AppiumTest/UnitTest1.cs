using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Appium.Android;
using OpenQA.Selenium.IE;
using OpenQA.Selenium.Remote;

namespace AppiumTest
{
    [TestClass]
    public class UnitTest1
    {
        AndroidDriver<AndroidElement> driver;
        DesiredCapabilities options ;


        [SetUp]
        public void InitDriver()
        {
            options = new DesiredCapabilities();
            options.SetCapability("platformName", "Android");         
            options.SetCapability("deviceName", "Google Pixel XL - 9.0 - API 28");
            options.SetCapability("appPackage", "com.android.mms.ui");
            options.SetCapability("appActivity", "ComposeMessageActivity");

            driver = new AndroidDriver<AndroidElement>(new Uri("http://127.0.0.1:4723/wd/hub"), options);

            Console.WriteLine("Device Connected");
        }

        [Test]    
        public void test1()
        {
            Microsoft.VisualStudio.TestTools.UnitTesting.Assert.IsNotNull(driver);
            System.Threading.Thread.Sleep(2000);
        }

        [TearDown]
        public void closeDriver()
        {
            driver.Quit();
        }
    }
}
