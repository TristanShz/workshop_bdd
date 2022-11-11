using Microsoft.VisualStudio.TestTools.UnitTesting;
using evalbdd.ComponentHelper;

namespace evalbdd.Tests.TextBoxTests
{
	[TestClass]
	public class TextBoxTests
	{
		[TestMethod]
		public void TextBoxTest()
		{
			CreditCardHelper.GetCardNumberInput().SendKeys(ObjectRepository.Config.GetValidCardNumber());
			CreditCardHelper.GetExpirationDateInput().SendKeys(ObjectRepository.Config.GetValidExpirationDate());
			CreditCardHelper.GetCvcInput().SendKeys(ObjectRepository.Config.GetValidCvc());
        }

		[TestMethod]
		public void TextBoxFromHelperTest()
		{
			TextBoxHelper.TypeInTextBox(CreditCardHelper.SelectCardNumberInput(), ObjectRepository.Config.GetValidCardNumber());
			TextBoxHelper.TypeInTextBox(CreditCardHelper.SelectExpirationDateInput(), ObjectRepository.Config.GetValidExpirationDate());
            TextBoxHelper.TypeInTextBox(CreditCardHelper.SelectCvcInput(), ObjectRepository.Config.GetValidCvc());
        }

		[TestMethod]
		public void ClearTextBoxTest()
		{
			TextBoxHelper.ClearTextBox(CreditCardHelper.SelectCardNumberInput());
			TextBoxHelper.ClearTextBox(CreditCardHelper.SelectExpirationDateInput());
            TextBoxHelper.ClearTextBox(CreditCardHelper.SelectCvcInput());
        }
    }
}

