Feature: CreateUser
	Check if create users functionality works


  Background:
	Given I navigate to application
	And I go to Login page
	And I enter username and password
		| UserName | Password |
		| jon      | jon      |
	When I click login

@mytag
Scenario: Create a student
	Given I click on Create Users
	And I click on Create Student
	And I enter student details
		| UserName | FirstName		| LastName | Password | Email					  | DOB			  |
		| Huck     | Huckleberry    | Finn	   | Huck     | huck.finn@mail.com		  |  01/02/2000   |
	When I click create
	Then I should be on the student profle
