using AprendendoSelenium;

using var quotes = new QuotesWebDriver();

quotes.Login("carvalhoarthur", "123456");

var listQuotes = quotes.GetQuotes(1);
var listQuotesTree = quotes.GetQuotes(3);

foreach (var item in listQuotes.Union(listQuotesTree))
{
    var message = $"Title: {item.Title}  \n";
    message += $"Author: {item.Author} \n";
    message += $"Tags: {string.Join(",", item.Tags)} \n";
    
    Console.WriteLine(message);
}