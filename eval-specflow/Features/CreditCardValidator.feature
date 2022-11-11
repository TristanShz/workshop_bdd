Feature: CreditCardValidator
Validate credit card inputs

	Scenario: All inputs are good
		Given user fills the three inputs with valid values
		And credit card number is sixteen digits long
		And expiration date is at format MM/YYYY
		And cvc is three digits long
		When submit button is pressed
		Then user is on page paymentConfirmed

	Scenario: Credit card number is not 16 digits long
		Given user fills the three inputs with invalid credit card number
		And credit card number is not sixteen digits long
		And expiration date is at format MM/YYYY
		And cvc is three digits long
		When submit button is pressed
		Then user is on homePage

	Scenario: Expiration is not at format MM/YYYY
		Given user fills the three inputs with invalid expiration date
		And credit card number is sixteen digits long
		And expiration date is not at format MM/YYYY
		And cvc is three digits long
		When submit button is pressed
		Then user is on homePage

	Scenario: CVC is not three digits long
		Given user fills the three inputs with invalid cvc
		And credit card number is sixteen digits long
		And expiration date is at format MM/YYYY
		And cvc is not three digits long
		When submit button is pressed
		Then user is on homePage