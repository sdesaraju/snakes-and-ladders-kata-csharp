# snakes-and-ladders-kata-csharp
Feature 1 - Moving Your Token of Snakes and Ladders Kata. Ref [Agile Katas](http://agilekatas.co.uk/katas/SnakesAndLadders-Kata)

## Approach

I followed SOLID, Test Driven Development approaches and implemented the solution, by writing failed test cases, implement the code to pass the test and then refactor the code finally to keep the code clean and maintainable. To achieve this, I have written Interfaces for the key objects and written test cases using them. 

In a nut shell, the solution has the following parts
1. Board - This entity defines the squares, start and end positions (and in future can be expanded to include Snakes, Ladders etc)
2. Dice - This is the dice entity and is used by the player to roll and move the token
3. Player - This is the entity that rolls the dice, moves to the respective square, and can win the game
4. Game - The entity that drives everything

Game is started when player places the token on Square 1 and finishes when player reachers square 100 with the help of dice rolls and movements

### Assumptions
1. Board contains the squares from 1 to 100
2. We are using only 1 die, and it has values from 1 to 6 (both inclusive)
3. Only 1 player is playing the game
4. When the game is started, player's token is placed on Sqaure 1

## Design Decisions

I created the solution using `.Net Standard`, `.Net Core`, `nUnit` and `Moq` frameworks. I was familiar with Microsoft Tests and used them before for various projects, however, I used nUnit tests this time as we can create the nUnit Test project with .Net Core framework.

Feature 1 - Moving Your Token of Snakes and Ladders Kata has basic requirements and do not require a complex implementation of objects. I have followed SOLID architecture priniciples, created Interfaces and Classes that has single purpose, Open for extension in future, and implemented Interfaces so that the individual components can be tested easily.

## The Future

I foresee that the following interfaces and classes will be expanded in future based on the requirements
1. Board - This can be extended to include Snakes, and Ladders to introduce an element of chance
2. Dice - This can be extended to use 2 dice, and hence the values it can generate can be extended to 12
3. Player - For Muti player mode, type of player (human or computer) and mode etc
4. Game - The game itself can be evovled by providing multi player mode, single player mode, order of plays etc

## Installation

### Prerequisites

The project requires `Visual Studio 2017` to view the code and the `.NET Core SDK` to be installed on your computer. This also requires `nUnit` and `Moq` NuGet packages to be restored to the solution

## Tests

Tests can be run from Visual Studio `Test Explorer` area. Please see the below screenshot of all the tests run 

![Project Tests](./snakes-and-ladders-kata-csharp/snakes-and-ladders-kata-feature1-tests.png)
