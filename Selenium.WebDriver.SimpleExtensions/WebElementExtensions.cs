using OpenQA.Selenium;
using System;

namespace Selenium.WebDriver.SimpleExtensions
{
    public static class WebElementExtensions
    {
        public static IWebElement GetParent(this IWebElement e)
        {
            return e.FindElement(By.XPath(".."));
        }

        public static IWebElement GetNextSibling(this IWebElement e)
        {
            return e.FindElement(By.XPath("following-sibling::*[1]"));
        }

        public static IWebElement GetPreviousSibling(this IWebElement e)
        {
            return e.FindElement(By.XPath("preceding-sibling::*[1]"));
        }

        public static IWebElement GetSiblingByIndex(this IWebElement e, int index)
        {
            return e.FindElement(By.XPath($"following-sibling::*[{index}]"));
        }

        public static IWebElement GetFirstChild(this IWebElement e)
        {
            return e.FindElement(By.XPath("child::*[1]"));
        }

        public static IWebElement GetLastChild(this IWebElement e)
        {
            return e.FindElement(By.XPath("child::*[last()]"));
        }

        public static IWebElement GetChildByIndex(this IWebElement e, int index)
        {
            return e.FindElement(By.XPath($"child::*[{index}]"));
        }

        public static IWebElement GetChildByText(this IWebElement e, string text)
        {
            return e.FindElement(By.XPath($"child::*[text()='{text}']"));
        }

        public static IWebElement GetChildThatContainsText(this IWebElement e, string text)
        {
            return e.FindElement(By.XPath($"child::*[contains(text(),'{text}')]"));
        }

        /// <summary>
        /// Gets the parent of the element, skipping the specified number of levels.
        /// </summary>
        /// <exception cref="ArgumentException"></exception>
        public static IWebElement GetParent(this IWebElement e, int skip)
        {
            if (skip < 0)
                throw new ArgumentException("skip must be greater than or equal to 0");

            if (skip == 0)
                return e.GetParent();

            var parent = e.GetParent();
            for (int i = 1; i < skip; i++)
                parent = parent.GetParent();

            return parent;
        }
    }
}
