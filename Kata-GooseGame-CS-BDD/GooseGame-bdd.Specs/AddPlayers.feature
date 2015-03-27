Feature: Add Players
	As a player,
	I'd like to join to the group
	to be able to play

@mytag
Scenario: Add first player
	Given There are no player in the group
	When Player "Pippo" request to join the group
	Then On the screen will be printed the message "Players: Pippo"

Scenario: Add Second player
	Given The player "Pippo" is already in the group
	When Player "Pluto" request to join the group
	Then On the screen will be printed the message "Players: Pippo, Pluto"

Scenario: Try to add a player already present
	Given The player "Pippo" is already in the group
	When Another player "Pippo" request to join the group
	Then On the screen will be printed the message "Pippo already present"