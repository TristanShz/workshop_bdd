using evalbdd.ComponentHelper;
using NUnit.Framework;
using OpenQA.Selenium;

namespace evalbdd.Steps;

[Binding]
public sealed class CreditCardValidatorSteps
{
    [Given(@"user fills the three inputs with valid values")]
    public void GivenUserFillsTheThreeInputsWithValidValues()
    {
        CreditCardHelper.ClearAllInputs();
        TextBoxHelper.TypeInTextBox(CreditCardHelper.SelectCardNumberInput(), ObjectRepository.Config.GetValidCardNumber());
        TextBoxHelper.TypeInTextBox(CreditCardHelper.SelectExpirationDateInput(), ObjectRepository.Config.GetValidExpirationDate());
        TextBoxHelper.TypeInTextBox(CreditCardHelper.SelectCvcInput(), ObjectRepository.Config.GetValidCvc());
    }
    
    [Given(@"user fills the three inputs with invalid credit card number")]
    public void GivenUserFillsTheThreeInputsWithInvalidCreditCardNumber()
    {  
        CreditCardHelper.ClearAllInputs();
        TextBoxHelper.TypeInTextBox(CreditCardHelper.SelectCardNumberInput(), ObjectRepository.Config.GetInvalidCardNumber());
        TextBoxHelper.TypeInTextBox(CreditCardHelper.SelectExpirationDateInput(), ObjectRepository.Config.GetValidExpirationDate());
        TextBoxHelper.TypeInTextBox(CreditCardHelper.SelectCvcInput(), ObjectRepository.Config.GetValidCvc());
    }

    [Given(@"user fills the three inputs with invalid expiration date")]
    public void GivenUserFillsTheThreeInputsWithInvalidExpirationDate()
    {
        CreditCardHelper.ClearAllInputs();
        TextBoxHelper.TypeInTextBox(CreditCardHelper.SelectCardNumberInput(), ObjectRepository.Config.GetValidCardNumber());
        TextBoxHelper.TypeInTextBox(CreditCardHelper.SelectExpirationDateInput(), ObjectRepository.Config.GetInvalidExpirationDate());
        TextBoxHelper.TypeInTextBox(CreditCardHelper.SelectCvcInput(), ObjectRepository.Config.GetValidCvc());
    }

    [Given(@"user fills the three inputs with invalid cvc")]
    public void GivenUserFillsTheThreeInputsWithInvalidCvc()
    {
        CreditCardHelper.ClearAllInputs();
        TextBoxHelper.TypeInTextBox(CreditCardHelper.SelectCardNumberInput(), ObjectRepository.Config.GetValidCardNumber());
        TextBoxHelper.TypeInTextBox(CreditCardHelper.SelectExpirationDateInput(), ObjectRepository.Config.GetValidExpirationDate());
        TextBoxHelper.TypeInTextBox(CreditCardHelper.SelectCvcInput(), ObjectRepository.Config.GetInvalidCvc());
    }
    
    [Given(@"credit card number is sixteen digits long")]
    public void GivenCreditCardNumberIsSixteenDigitsLong()
    {
        Assert.AreEqual(16, CreditCardHelper.GetCardNumberInputValue().Length);
    }

    [Given(@"expiration date is at format MM/YYYY")]
    public void GivenExpirationDateIsAtFormatMmyyyy()
    {
        var expirationDate = CreditCardHelper.GetExpirationDateInputValue();
        Assert.That(expirationDate, Does.Match("^[0-9]{1,2}\\/[0-9]{4}$"));
    }

    [Given(@"cvc is three digits long")]
    public void GivenCvcIsThreeDigitsLong()
    {
        Assert.AreEqual(3, CreditCardHelper.GetCvcInputValue().Length);
    }

    [When(@"submit button is pressed")]
    public void WhenSubmitButtonIsPressed()
    {
        ButtonHelper.ClickButton(CreditCardHelper.SelectSubmitButton());
    }

    [Then(@"user is on page paymentConfirmed")]
    public void ThenUserIsOnPagePaymentConfirmed()
    {
        Assert.IsTrue(GenericHelper.IsElementPresentOnce(By.Id("paymentConfirmed")));
    }

    [Given(@"credit card number is not sixteen digits long")]
    public void GivenCreditCardNumberIsNotSixteenDigitsLong()
    {
        Assert.AreNotEqual(16, CreditCardHelper.GetCardNumberInputValue().Length);
    }

    [Then(@"user is on homePage")]
    public void ThenUserIsOnHomePage()
    {
        Assert.AreEqual(PageHelper.GetPageTitle(),"Page Workshop noté");
    }

    [Given(@"expiration date is not at format MM/YYYY")]
    public void GivenExpirationDateIsNotAtFormatMmyyyy()
    {
        Assert.That(CreditCardHelper.GetExpirationDateInputValue(), Does.Not.Match("^[0-9]{1,2}\\/[0-9]{4}$"));
    }

    [Given(@"cvc is not three digits long")]
    public void GivenCvcIsNotThreeDigitsLong()
    {
        Assert.AreNotEqual(3, CreditCardHelper.GetCvcInputValue().Length);
    }
}