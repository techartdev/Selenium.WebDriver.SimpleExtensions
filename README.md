# Selenium.WebDriver.SimpleExtensions

A robust and versatile Selenium WebDriver extension library to simplify web element and browser interactions.

## OverviewOverview
This library consists of two primary sets of extension methods: WebElementExtensions and WebDriverExtensions. These methods enhance the usability of Selenium WebDriver by extending the IWebElement and IWebDriver interfaces with additional functionalities.

## WebElementExtensions
This class offers a series of helper methods to easily traverse the DOM:

**GetParent:** Returns the parent of the current element.

**GetNextSibling:** Returns the next sibling of the current element.

**GetPreviousSibling:** Returns the previous sibling of the current element.

**GetSiblingByIndex:** Returns a sibling of the current element at a specified index.

**GetFirstChild:** Returns the first child of the current element.

**GetLastChild:** Returns the last child of the current element.

**GetChildByIndex:** Returns a child of the current element at a specified index.

**GetChildByText:** Returns a child of the current element that matches a specified text.

**GetChildThatContainsText:** Returns a child of the current element that contains a specified text.

**GetParent(int skip):** Returns the parent of the current element, skipping a specified number of levels.

*Please note that the GetParent(int skip) method throws an ArgumentException if the skip parameter is less than 0.*

## WebDriverExtensions
This class includes methods to execute JavaScript scripts directly in the browser:

**ExecuteJavaScript:** Executes a JavaScript script in the browser and returns the result casted to a specified type.

**ExecuteJavaScriptAndDeserialize:** Executes a JavaScript script in the browser, serializes the result into a JSON string, and then deserializes that string into an object of a specified type.

## Getting Started
To use these extensions, first add a reference to this library in your project. Then, in your code, use the methods on instances of IWebElement and IWebDriver as required.

## License
This project is licensed under the MIT License - see the LICENSE.md file for details.

## Contact
Visit https://scrapeweb.site

Or join us on Discord: https://discord.gg/f3EfBQamnT

## Disclaimer
The extensions provided by this library are subject to the reliability of the Selenium WebDriver and the browser being automated. Please ensure the elements are available and interactable before using these extension methods to avoid any unexpected exceptions or behavior.
