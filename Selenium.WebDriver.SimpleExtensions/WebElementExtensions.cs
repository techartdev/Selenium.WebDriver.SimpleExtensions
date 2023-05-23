using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Xml.Linq;

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

        public static IReadOnlyCollection<IWebElement> GetChildren(this IWebElement e)
        {
            return e.FindElements(By.XPath("child::*"));
        }

        public static void Delete(this IWebElement e)
        {
            var element = (WebElement)e;
            IJavaScriptExecutor js = (IJavaScriptExecutor)element.WrappedDriver;
            js.ExecuteScript("arguments[0].remove()", e);
        }

        public static void AppendHtml(this IWebElement e, string elementHtml)
        {
            var element = (WebElement)e;
            IJavaScriptExecutor js = (IJavaScriptExecutor)element.WrappedDriver;
            js.ExecuteScript("arguments[0].innerHTML += arguments[1]", element, elementHtml);
        }

        public static void SetText(this IWebElement e, string text)
        {
            var element = (WebElement)e;
            IJavaScriptExecutor js = (IJavaScriptExecutor)element.WrappedDriver;
            js.ExecuteScript("arguments[0].innerText = arguments[1]", e, text);
        }

        public static void SetAttribute(this IWebElement e, string attributeName, string attributeValue)
        {
            var element = (WebElement)e;
            IJavaScriptExecutor js = (IJavaScriptExecutor)element.WrappedDriver;
            js.ExecuteScript($"arguments[0].setAttribute('{attributeName}', '{attributeValue}')", e);
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
