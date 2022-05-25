﻿using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace SeleniumTests;

[TestFixture]
public class SLTestRecordReplayTest
{
    private IWebDriver driver;
    public IDictionary<string, object> vars { get; private set; }
    private IJavaScriptExecutor js;

    [SetUp]
    public void SetUp()
    {
        driver = new ChromeDriver();
        js = (IJavaScriptExecutor)driver;
        vars = new Dictionary<string, object>();
    }

    [TearDown]
    protected void TearDown()
    {
        driver.Quit();
    }

    public string waitForWindow(int timeout)
    {
        try
        {
            Thread.Sleep(timeout);
        }
        catch (Exception e)
        {
            Console.WriteLine("{0} Exception caught.", e);
        }
        var whNow = ((IReadOnlyCollection<object>)driver.WindowHandles).ToList();
        var whThen = ((IReadOnlyCollection<object>)vars["WindowHandles"]).ToList();
        if (whNow.Count > whThen.Count)
        {
            return whNow.Except(whThen).First().ToString();
        }
        else
        {
            return whNow.First().ToString();
        }
    }

    [Test]
    public void sLTestRecordReplay()
    {
        driver.Navigate().GoToUrl("https://www.simplilearn.com/");
        driver.Manage().Window.Size = new System.Drawing.Size(1294, 774);
        vars["WindowHandles"] = driver.WindowHandles;
        driver.FindElement(By.LinkText("Job Guarantee")).Click();
        vars["win1038"] = waitForWindow(2000);
        vars["root"] = driver.CurrentWindowHandle;
        driver.SwitchTo().Window(vars["win1038"].ToString());
        vars["WindowHandles"] = driver.WindowHandles;
        driver.FindElement(By.LinkText("Resources")).Click();
        vars["win4394"] = waitForWindow(2000);
        driver.SwitchTo().Window(vars["win4394"].ToString());
        driver.SwitchTo().Window(vars["root"].ToString());
        driver.FindElement(By.CssSelector(".courses-menu > span")).Click();
        driver.FindElement(By.LinkText("Data Science with Python")).Click();
        driver.FindElement(By.Id("header_srch")).Click();
        driver.FindElement(By.Id("header_srch")).SendKeys("R Language");
        driver.FindElement(By.Id("header_srch")).SendKeys(Keys.Enter);
    }
}