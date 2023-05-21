using Newtonsoft.Json;
using OpenQA.Selenium;
using OpenQA.Selenium.DevTools;
using System;
using System.Collections.Generic;
using System.Text;
using OpenQA.Selenium.DevTools.V113.Network;
using OpenQA.Selenium.Chrome;

namespace Selenium.WebDriver.SimpleExtensions
{
    public static class WebDriverExtensions
    {
        public static T ExecuteJavaScript<T>(this IWebDriver driver, string script)
        {
            var executor = (IJavaScriptExecutor)driver;
            var result = executor.ExecuteScript(script);
            return (T)Convert.ChangeType(result, typeof(T));
        }

        public static T ExecuteJavaScriptAndDeserialize<T>(this IWebDriver driver, string script)
        {
            var executor = (IJavaScriptExecutor)driver;
            var result = executor.ExecuteScript(script);

            var serializedResult = JsonConvert.SerializeObject(result);
            return JsonConvert.DeserializeObject<T>(serializedResult);
        }
    }
}
