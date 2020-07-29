# Eric Perez 7/28/20

## Project Step 4

### Minimum-Viable Product
## Functional

Feature: Creates an Election

  # Creates and stores candidates into the application by name.
  
  Scenario: The main admin user wants to create an election.
  
    Given the main admin will tally the votes.
    Given the main admin is bipartisan.
    When the main admin has been verified as the bipartisan mediator.
	Then applications must be created for administration use.
    The valid email must be verified in order to begin.
    Then main admin can create an election with a valid email.


Feature: Input Candidates Names

  # Allows the administration to input Candidate for the running.
  
  Scenario: The administration want to input running Candidates into the election.
  
    Given the candidates do not have an account.
    When the administration has a valid email address.
    Then create an account with the email address as the user name.
    Then assign a password to the account.
    Then associate roles and permissions to the account in order to input Candidates names.


Feature: Input Votes

  # Allow the main admin to input the votes.
  
  Scenario: The main admin will be required to input the votes.
  
    Given all the votes are in the least to greatest format.
    When the main admin has the application pulled up.
    Then the main admin will input the votes manually one by one.


Feature: Displays Results by Percentages

  # Be able to see the percentage of the tallied polls
  
  Scenario: A user wants to view the results by the percentage.
  
    Given the "view" permissions for all basic users. 
    When the user has a valid voting email address. 
    When the user has basic access.
    Then give access to the results by the percentage when elections have closed.


Feature: Displays who the winner is. 

  # When an elections has closed, the winner will be displayed at the end.
  
  Scenario: An election has ended, the users want the winner to be presented.
  
    Given a user with a valid account
	Given the "view" permissions for all basic users.
    When a user has basic access.
    Then when an elections has closed, the winner will be displayed.


Feature: Detects Draws.

  # Detects a draw between candidates when any two candidates have the same amount of votes.
  
  Scenario: An elections has ended, the users want the results.
  
    Given the same amount of voters for each candidate.
    When the voters vote equall across the board.
    Then a draw will be detected.





## Full
## Non-Functional

Feature: Easy to use graphical interface

	# Allows the user to easily use the application.
	
	Scenario: In order to use the application, the application itself needs to be user friendly.
	
	Given the complexity of the application.
	Given the bigger text buttons.
	Given the easy to read font.
	When the user opens the application.
	Then the user will be able to utilize the application to complete the user's intended needs.
	
Feature: Bright Colorful Interface

	# Allows the user to be attracted to the application.
	
	Scenario: In order for the application to be an attractive application, the application needs color to bring to life.
	
	Given the easy to read font.
	Given the graphical user interface.
	When the user opens the application.
	Then the colors will be the attractive pieces of the applications.
	Then the users will be reminded to check the applications daily.






## Stretch
## Functional


Feature: New User Login

  # Allow the patient to register themself for an appointment
  
  Scenario: When a new user wants basic access.
  
    Given the user has a valid email address.
	Given the user has a valid driver's license.
    When the user activates account to vote.
	When the user goes to email to validate it.
	When the user gets verified with a picture of the driver's license.
    Then the user will activate a voter's basic account access.
	Then the user will have View and Vote access.
  


Feature: New Candidate Login

  # Allow the administration to create and update candidate login.
  
	Scenario: When a new candidate wants to create and update their information.
	
	Given the candidates do not have an account.
	Given the administration has created an account.
	Given the administration has uploaded Candidates information.
    When the administration has a valid email address.
	Then the administration can upload and maintain Candidates up-to-date information.
    Then the administration can ensure the profile is accurate.

Feature: Ensuring the user is human.
	
 # Allow the application to weed out bots from manipulating data
 
	Scenario: A bot/program has opened the application and attempted to vote.
	
	Given the built-in "Not A Bot" picture questions.
	When the bot/program has entered the voting section.
	When the bot/program fails the questions.
	Then the bot/program will not be allowed to vote when prompt.

Feature: Constantly updating application

# Allows the real-time data to be updated onto the application.

	Scenario: To ensure an up to date application.
	
	Given the data to reflect the candidates in the running.
	Given the administration has access to the candidates information.
	When the administration needs to up date the information.
	Then the administration will need to ensure it reflects up to date data.
	



