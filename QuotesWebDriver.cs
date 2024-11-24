using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace AprendendoSelenium;

public class QuotesWebDriver
{
    private IWebDriver _driver;

    public QuotesWebDriver()
    {
        _driver = new ChromeDriver();
    }

    public void Login(string username, string password)
    {
        _driver.Navigate().GoToUrl("https://quotes.toscrape.com/login");
        
        _driver.FindElement(By.Id("username")).SendKeys(username);
        _driver.FindElement(By.Id("password")).SendKeys(password);
        
        _driver.FindElement(By.XPath("/html/body/div[1]/form/input[2]")).Click();
        
    }
}