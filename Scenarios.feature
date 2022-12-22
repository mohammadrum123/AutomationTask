Feature: Scenarios

@tag1 
Scenario: Login Page
	Given Navigate to URL
	When Click on Login button
	Then Login Page is displayed

@tag2
Scenario: Leaving Email and Password fields empty
	Given Navigate to Login Page
	When Click on Sign In button
	Then Error messaged displayed saying Email and Password required

@tag3
Scenario: Enter Valid Email and Valid Password
	Given Navigate to Login Page 
	When Enter Valid Email and Valid Password and click on Sign in button 
	Then Successfully logged in
	
@tag4
Scenario: Enter Invalid Email and Valid Password
	Given Navigate to Login Page
	When Enter Invalid Email and Valid Password and click on Sign in button 
	Then Error message displayed saying to enter valid Email

@tag5
Scenario: Enter Valid Email and Invalid Password
	Given Navigate to Login Page
	When Enter Valid Email and Invalid Password and click on Sign in button 
	Then Error message displayed saying Incorrect Password

@tag8
Scenario: Google Sign in button
	Given Navigate to Login Page
	When Click on Google Sign In button
	Then Google Account Window is displayed

 
