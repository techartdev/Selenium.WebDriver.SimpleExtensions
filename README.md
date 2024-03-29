# Selenium.WebDriver.SimpleExtensions

![Nuget](https://img.shields.io/nuget/v/Selenium.WebDriver.SimpleExtensions)

A robust and versatile Selenium WebDriver extension library to simplify web element and browser interactions.

## OverviewOverview
This library consists of two primary sets of extension methods: WebElementExtensions and WebDriverExtensions. These methods enhance the usability of Selenium WebDriver by extending the IWebElement and IWebDriver interfaces with additional functionalities.

## WebElementExtensions
This class offers a series of helper methods to easily traverse the DOM:

**GetParent**

Returns the parent of the current element.

**GetNextSibling**

Returns the next sibling of the current element.

**GetPreviousSibling**

Returns the previous sibling of the current element.

**GetSiblingByIndex**

Returns a sibling of the current element at a specified index.

**GetFirstChild**

Returns the first child of the current element.

**GetLastChild**

Returns the last child of the current element.

**GetChildByIndex**

Returns a child of the current element at a specified index.

**GetChildByText**

Returns a child of the current element that matches a specified text.

**GetChildThatContainsText**

Returns a child of the current element that contains a specified text.

**GetParent(int skip)**

Returns the parent of the current element, skipping a specified number of levels.

**GetChildren** 

Retrieves a read-only collection of web elements that are direct children of the given web element.

**Delete:**

Deletes the specified web element from the web page using JavaScript.

**AppendHtml:**

This method appends the provided HTML content to the inner HTML of the given web element using JavaScript.

**SetText:** 

This method sets the text content of the specified web element to the given text using JavaScript.

**SetAttribute:** 

Sets the attribute of the specified web element to the provided attribute name and value using JavaScript.

*Please note that the GetParent(int skip) method throws an ArgumentException if the skip parameter is less than 0.*

## WebDriverExtensions
This class includes methods to execute JavaScript scripts directly in the browser:

**ExecuteJavaScript:**

Executes a JavaScript script in the browser and returns the result casted to a specified type.

**ExecuteJavaScriptAndDeserialize:**

Executes a JavaScript script in the browser, serializes the result into a JSON string, and then deserializes that string into an object of a specified type.

## Getting Started
To use these extensions, first add a reference to this library in your project. Then, in your code, use the methods on instances of IWebElement and IWebDriver as required.

## License
This project is licensed under the MIT License - see the LICENSE.md file for details.

## Contact
Visit https://scrapeweb.site

Or join the **Web Scraping and Automation** community on Discord: https://discord.gg/f3EfBQamnT

## Disclaimer
The extensions provided by this library are subject to the reliability of the Selenium WebDriver and the browser being automated. Please ensure the elements are available and interactable before using these extension methods to avoid any unexpected exceptions or behavior.

---

If you find this app helpful and would like to support the development of more tools and projects, consider buying me a coffee. Your support is greatly appreciated!

[![Buy Me A Coffee](https://www.buymeacoffee.com/assets/img/custom_images/orange_img.png)](https://www.buymeacoffee.com/techartdev)

Thank you for your support!

