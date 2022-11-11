using OpenQA.Selenium;

namespace evalbdd.ComponentHelper;

public static class CreditCardHelper
{
    private static readonly string CardNumberInputId = "creditCardNumber";
    private static readonly string ExpirationDateInputId = "expirationDate";
    private static readonly string CvcInputId = "cvc";
    private static readonly string ButtonInputId = "submitCard";
    public static By SelectCardNumberInput()
    {
        return By.Id(CardNumberInputId);
    }

    public static By SelectExpirationDateInput()
    {
        return By.Id(ExpirationDateInputId);
    }

    public static By SelectCvcInput()
    {
        return By.Id(CvcInputId);
    }

    public static By SelectSubmitButton()
    {
        return By.Id(ButtonInputId);
    }
    
    public static IWebElement GetCardNumberInput()
    {
        return GenericHelper.GetElement(SelectCardNumberInput());
    }
    
    public static IWebElement GetExpirationDateInput()
    {
        return GenericHelper.GetElement(SelectExpirationDateInput());
    }
    
    public static IWebElement GetCvcInput()
    {
        return GenericHelper.GetElement(SelectCvcInput());
    }

    public static IWebElement GetSubmitButtonInput()
    {
        return GenericHelper.GetElement(SelectSubmitButton());
    }
    
    public static string GetCardNumberInputValue()
    {
        return GetCardNumberInput().GetAttribute("value");
    }

    public static string GetExpirationDateInputValue()
    {
        return GetExpirationDateInput().GetAttribute("value");
    }

    public static string GetCvcInputValue()
    {
        return GetCvcInput().GetAttribute("value");
    }

    public static void ClearAllInputs()
    {
        TextBoxHelper.ClearTextBox(SelectCardNumberInput());
        TextBoxHelper.ClearTextBox(SelectExpirationDateInput());
        TextBoxHelper.ClearTextBox(SelectCvcInput());
    }
}