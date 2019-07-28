Imports OpenQA.Selenium
Imports OpenQA.Selenium.Firefox
Imports OpenQA.Selenium.Chrome
Imports System.Threading
Public Class Mainform


    Private Sub Mainform_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub AutomateGoogleButton_Click(sender As Object, e As EventArgs) Handles AutomateGoogleButton.Click
        Dim Chromedriver As IWebDriver
        Chromedriver = New ChromeDriver  ' chrome webdriver for selenium
        Chromedriver.Navigate().GoToUrl("https://www.google.com")


        Dim GoogleSearchTextbox As IWebElement = Chromedriver.FindElement(By.Name("q")) ' finding webelement by Id
        GoogleSearchTextbox.SendKeys("Selenium")

        Thread.Sleep(1000) ' wait for 1 sec before clicking search button.
        Dim GoogleSearchButton As IWebElement = Chromedriver.FindElement(By.Name("btnK"))
        GoogleSearchButton.Click()
    End Sub

    Private Sub AutomateUsingFirefox_Click(sender As Object, e As EventArgs) Handles AutomateUsingFirefox.Click
        Dim firefoxdriver As IWebDriver
        firefoxdriver = New FirefoxDriver ' firefox selenium webdriver which is also known as gecko driver
        firefoxdriver.Navigate().GoToUrl("https://www.google.com")

        Try
            Dim GoogleSearchTextbox As IWebElement = firefoxdriver.FindElement(By.Name("q"))
            GoogleSearchTextbox.SendKeys("Selenium")
        Catch ex As Exception

        End Try
        Thread.Sleep(1000)
        Dim GoogleSearchButton As IWebElement = firefoxdriver.FindElement(By.Name("btnK"))
        GoogleSearchButton.Click()
    End Sub
End Class
