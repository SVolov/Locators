// See https://aka.ms/new-console-template for more information
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

WebDriver driver = new ChromeDriver();
By searchLocator = By.Name("q"); //https://www.bbc.co.uk/search?d=SEARCH_PS


driver.Url = "https://www.bbc.com/sport";
driver.Navigate();
//IWebElement searchEl = driver.FindElement(searchLocator);
//searchEl.SendKeys("Arsenal");

//By sportLocator = By.ClassName("ssrcss-9ow4nk-LogoIcon");
//IWebElement sportEl = driver.FindElement(sportLocator);
//sportEl.Click();

//By bBCLocator = By.ClassName("ssrcss-jqeoyw-BBCBlocks");
//IWebElement bBCEl = driver.FindElement(bBCLocator);
//bBCEl.Click();

//IWebElement sportLocator = driver.FindElement(By.XPath("//a[@href ='/sport' and @class = 'ssrcss-1vyfvn-LogoLink esbu9dd4']")); 
//sportLocator.Click();

//IWebElement searchEl = driver.FindElement(By.XPath("//div[@role = 'search']"));

IWebElement bBCEl = driver.FindElement(By.XPath("//a[@id ='homepage-link']"));
bBCEl.Click();