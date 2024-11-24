using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;

namespace AprendendoSelenium;

public class Quotes
{
    public string Title { get; set; }
    
    public string Author { get; set; }

    public List<string> Tags { get; set; } = new List<string>();
}