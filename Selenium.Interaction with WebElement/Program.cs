using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;


namespace Selenium.Interaction_with_WebElement
{
    class Program
    {
        static void Main(string[] args)
        {
            IWebDriver driver = new ChromeDriver();
            
            driver.Navigate().GoToUrl("https://www.google.com/");

            IWebElement search = driver.FindElement(By.XPath("/html/body/div[1]/div[3]/form/div[1]/div[1]/div[1]/div/div[2]/input"));
            search.SendKeys("It Craft");

            IWebElement find = driver.FindElement(By.XPath("/html/body/div[1]/div[3]/form/div[1]/div[1]/div[3]/center/input[1]"));
            find.Click();

            IWebElement result = driver.FindElement(By.XPath("/html/body/div[7]/div/div[6]/div/div/div/div[1]/div"));
            IWebElement time = driver.FindElement(By.XPath("/html/body/div[7]/div/div[6]/div/div/div/div[1]/div/nobr"));

            IWebElement header = driver.FindElement(By.XPath("/html/body/div[7]/div/div[9]/div[1]/div/div[2]/div[2]/div/div/div[2]/div/div/div[1]/a/h3"));


            string a =  time.Text;
            string b = result.Text;
            string c = header.Text;

            Console.Clear();
            Console.WriteLine($"{ b} { a} { c}");
        }
    }
}
