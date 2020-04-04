# C-Kartas
My go at various C# kartas with TDD approach

===================================================================================================================================================================================
************************Fizzbuzz************************
Start with a popular drinking game where players take turns replacing any number divisible by 3 with word fizz and any number divisible by five with word buzz
Requirement 1 :- accept all input comma seprated and retrun it back .Ignore if the value is number or string

Requirement 2 :- ensure only integer values are conidered. any string values simply removethem 

Requirement 3 :- ensure that numbers divisible by 3 are replaced with word fizz

Requirement 4 :- ensure that numbers divisible by 5 are replaced with word buzz


do a commit per requirement 

===================================================================================================================================================================================
************************Fibonnaci************************
Fibonnaci is a sequence of numbers where the first number is 0, the second 1 and the subsquent the sum of the previous two. 0, 1, 1, 2, 3, 5, 8, 13, 21, 34, 55, 89, 114 ..

Requirement :- accept the value of n and first two digits and perform fibonnaci series on that



===================================================================================================================================================================================

************************Tennis Scoring*******************
Background
In a game of tennis, a player begins with a score of zero (0). With each success, the player earns more points. The points are earned in this sequence:
0
15
30
40
If a player has 40 and scores again, that player wins the game as long as the other player does not also have 40 points. If both players reach 40 points it is referred to as a 'deuce.'
Scoring during deuce give a player advantage. If the other player scores again, the score returns to deuce. If a player has advantage and scores again, that player wins the game.
Instructions
Write a program to handle each of these requirements while scoring a two player game of tennis.
Players must be able to score points
The game must be able to be completed with a winner
The 'deuce' case should be handled
After a game has been won, a winner must be determined
The current score of either player should be available at any point during the game


Feature 1 - Scoring a Game in Real Time
We want a program that can be used to score a game in real time, so we can use it for all of the tennis related endeavours we plan to undertake in the future. To begin with, we're going to need a way to update the score when a player wins a point, see what the current score is after each service, and see if their is a winner based on the current score and the rules above.

Requirement 1 :- Winning a Point increases Score Correctly
Given the score is 0:0 When the server wins a point Then the score is 15:0
Given the score is 15:15 When the receiver wins a point Then the score is 15:30
Given the score is 30:30 When the server wins a point Then the score is 40:30

Requirement 2 :- Deuce and Advantage are Scored Correctly
Given the score is 40:40 When the receiver wins a point Then the score should be 40:A
Given the score is A:40 When the receiver wins a point Then the score should be 40:40

Requirement 3 :- Winning Points are Scored Correctly
Given the score is 40:30 When the server wins a point Then the server should win
Given the score is 40:A When the receiver wins a point Then the receiver should win