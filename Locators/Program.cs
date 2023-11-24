// See https://aka.ms/new-console-template for more information
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;


By searchLocator = By.ClassName("ssrcss-15a3kwz-GlobalNavigationItem"); 

By sportLocator = By.ClassName("ssrcss-1vyfvn-LogoLink");

By moreMenuLocator = By.Id("more-menu-button");

By iframeLocator = By.Name("__uspapiLocator");


By searchLocatorXPath = By.XPath("//div[@role = 'search']");

By sportLocatorXPath = By.XPath("//a[@href ='/sport' and @class = 'ssrcss-1vyfvn-LogoLink esbu9dd4']"); 

By moreMenuLocatorXPath = By.XPath("//*[@id = 'more-menu-button']");

By iframeLocatorXPath = By.XPath("//iframe[@name = '__uspapiLocator']");