using Snake_Game;
Coord gridDimensions = new Coord(50, 20);
Coord snakePos = new Coord(10, 1);
Random rand = new Random();
Coord applePos = new Coord(rand.Next(1, gridDimensions.X - 1), rand.Next(1, gridDimensions.Y - 1));
int frameDelayMilli = 100;
Direction movementDirection = Direction.Down;

while (true)
{ 
    Console.Clear();
    snakePos.ApplyMovementDirection(movementDirection);

    for (int y = 0; y < gridDimensions.Y; y++)
    {
        for (int x = 0; x < gridDimensions.X; x++)
        {
            Coord currentCoord = new Coord(x, y);

            if (snakePos.Equals(currentCoord))
                Console.Write('■');
            else if (applePos.Equals(currentCoord))
                Console.Write("a");
            else if (x == 0 || y == 0 || x == gridDimensions.X - 1 || y == gridDimensions.Y - 1)
                Console.Write("#");
            else
            {
                Console.Write(" ");
            }
        }
        Console.WriteLine();
       
    }
    DateTime time = DateTime.Now;

    while((DateTime.Now -time).Milliseconds < frameDelayMilli)
    {
        if(Console.KeyAvailable)
        {
            ConsoleKey key = Console.ReadKey().Key;
            switch(key)
            {
                case ConsoleKey.LeftArrow:
                    movementDirection = Direction.Left;
                    break;
                case ConsoleKey.RighttArrow:
                    movementDirection = Direction.Right;
                    break;
                case ConsoleKey.UpArrow:
                    movementDirection = Direction.Up;
                    break;
                case ConsoleKey.DownArrow:
                    movementDirection = Direction.Down;
                    break;
            }
        }


    }

}
