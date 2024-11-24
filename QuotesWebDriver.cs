using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace AprendendoSelenium;

public class QuotesWebDriver : IDisposable
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

    public List<Quotes> GetQuotes(int pageNumber = 1 )
    {
       var quotesList  = new List<Quotes>();

       _driver.Navigate().GoToUrl($"https://quotes.toscrape.com/page/{pageNumber}/");

       var elementsQuotes = _driver.FindElements(By.ClassName("quote"));
       
       foreach (var quotesItem in elementsQuotes)
       {
           var quotes = new Quotes();
           quotes.Title = quotesItem.FindElement(By.ClassName("text")).Text;
           quotes.Author = quotesItem.FindElement(By.ClassName("author")).Text;
           
           var elementTags = quotesItem.FindElements(By.ClassName("tag"));
           foreach (var tag in elementTags)
           {
               quotes.Tags.Add(tag.Text);
           }
           quotesList.Add(quotes);
           
       }

       return quotesList;
    }

    public void Dispose()
    {
        _driver.Dispose();
    }
}