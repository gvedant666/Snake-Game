Snake Game

A simple console-based Snake game built in C# using object-oriented principles. The game involves controlling a snake that moves around the screen, eating food to grow longer and increase the score, while avoiding walls and its own body.

Features

    Playable Snake game with arrow key controls.
    Score tracking.
    Increasing game speed as the snake grows.
    Game over when the snake hits a wall or collides with itself.

Installation

To run the game, you'll need to have the .NET runtime installed on your machine.

    Clone the repository:

git clone https://github.com/your-username/snake-game.git

Navigate into the project directory:

cd snake-game

Build and run the project:

    dotnet run

Gameplay

    Use the arrow keys to control the snake's direction (Up, Down, Left, Right).
    The snake grows in length as it eats the food represented by "o".
    Avoid hitting the walls or the snake’s own body.
    The game ends when the snake collides with itself or the walls.
    Press Enter to exit the game after it ends.

Controls

    Up Arrow: Move up
    Down Arrow: Move down
    Left Arrow: Move left
    Right Arrow: Move right

Code Structure

Coordinates: Class used to represent the position of the snake, food, and walls on the grid.
Directions: Enum representing the possible directions the snake can move (up, down, left, right).
The game runs in an infinite loop where the snake moves, checks for collisions, and updates the screen until the game is over.


Screenshot

![Screenshot 2024-11-09 215356](https://github.com/user-attachments/assets/e4b82420-89d6-4f22-8096-b6515566aff7)
![Screenshot 2024-11-09 215250](https://github.com/user-attachments/assets/5bef15f6-c194-4e9d-899a-6b4ce0856853)

