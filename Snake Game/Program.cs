using Snake_Game;

Coordinates wall = new Coordinates(20, 60);
Coordinates snake = new Coordinates(10, 30);

Random rand = new Random();
Coordinates Points = new Coordinates(rand.Next(1, wall.X - 1), rand.Next(1, wall.Y - 1));

Directions directions = Directions.right;

List<Coordinates> snakeBody = new List<Coordinates>();

int frameDelay = 100;
int increaseSpeed = 100;

int score = 0;

while (true)
{
    Console.Clear();
    Console.WriteLine($"score : {score}");
    snake.ChangeCoordinates(directions);
    for (int i = 0; i < wall.X; i++)
    {
        for (int j = 0; j < wall.Y; j++)
        {
            Coordinates CurrentCorr = new Coordinates(i, j);
            if (snake.Equals(CurrentCorr) || snakeBody.Contains(CurrentCorr))
            {
                Console.Write("■");
            }
            else if (Points.Equals(CurrentCorr))
            {
                Console.Write("o");
            }
            else if (i == 0 || j == 0 || i == wall.X - 1 || j == wall.Y - 1)
            {
                Console.Write("#");
            }
            else
            {
                Console.Write(" ");
            }
        }
        Console.WriteLine();
    }

    if (snake.X == 0 || snake.Y == 0 || snake.X == wall.X - 1 || snake.Y == wall.Y - 1 || snakeBody.Contains(snake))
    {
        if (snakeBody.Contains(snake))
        {
            Console.WriteLine("You just fucking ate yourself");
        }
        Console.WriteLine("Game Over");
        Console.WriteLine("Score: " + score);
        break;
    }

    snakeBody.Add(new Coordinates(snake.X, snake.Y));
    if (snake.X == Points.X && snake.Y == Points.Y)
    {
        Points = new Coordinates(rand.Next(1, wall.X - 1), rand.Next(1, wall.Y - 1));
        score++;
        increaseSpeed -= 10;
        if (increaseSpeed < 0)
        {
            increaseSpeed = 0;
        }
    }
    else
    {
        snakeBody.RemoveAt(0);
    }

    if (directions == Directions.up || directions == Directions.down)
    {
        frameDelay = increaseSpeed + 100;
    }
    else
    {
        frameDelay = increaseSpeed + 50;
    }

    DateTime Time = DateTime.Now;
    while (Time.AddMilliseconds(frameDelay) > DateTime.Now)
    {
        if (Console.KeyAvailable)
        {
            ConsoleKeyInfo key = Console.ReadKey(true);
            switch (key.Key)
            {
                case ConsoleKey.UpArrow:
                    directions = Directions.up;
                    break;
                case ConsoleKey.DownArrow:
                    directions = Directions.down;
                    break;
                case ConsoleKey.LeftArrow:
                    directions = Directions.left;
                    break;
                case ConsoleKey.RightArrow:
                    directions = Directions.right;
                    break;
            }
        }
    }
}

Console.WriteLine("Press Enter to exit");
Console.ReadLine();


