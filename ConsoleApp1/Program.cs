

using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using WebDriverManager;
using WebDriverManager.DriverConfigs.Impl;

new DriverManager().SetUpDriver(new ChromeConfig());


var options = new ChromeOptions();
// options.AddArgument("--headless"); // Optional: Run in headless mode
IWebDriver driver = new ChromeDriver(options);

try
{
    // Navigate to URL
    driver.Navigate().GoToUrl("https://www.google.com/");
    Thread.Sleep(2000);
    
    IWebElement ele = driver.FindElement(By.Name("username"));
    ele.SendKeys("U72562");
    Thread.Sleep(2000);
    IWebElement pwd = driver.FindElement(By.Name("password"));
    ele.SendKeys("CAFTER1");

    IWebElement ele1 = driver.FindElement(By.ClassName("login_login_btn"));
    //click on the search button  
    ele1.Click();
    Thread.Sleep(3000);
    Console.WriteLine("Page title is: " + driver.Title);
}
catch (WebDriverException ex)
{
    Console.WriteLine("WebDriverException occurred: " + ex.Message);
}
finally
{
    // Clean up and close the browser
    driver.Quit();
}
