Feature: Login
	Check if login functionality works


@mytag
Scenario:Login user as Administrator
	Given I navigate to application
	And I go to Login page
	And I enter username and password
		| UserName | Password |
		| jon      | jon      |
	When I click login
	Then I should see user logged in as admin
