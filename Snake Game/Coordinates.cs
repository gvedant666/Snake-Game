namespace Snake_Game
{
    internal class Coordinates
    {
        private int x;
        private int y;

        public int X
        {
            get { return x; }
            set { x = value; }
        }
        public int Y
        {
            get { return y; }
            set { y = value; }
        }
        public Coordinates(int X, int Y)
        {
            this.x = X;
            this.y = Y;
        }
        public override bool Equals(object? obj)
        {
            if (obj != null && obj is Coordinates)
            {
                Coordinates c = (Coordinates)obj;
                return c.x == x && c.y == y;
            }
            return false;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(x, y);
        }

        public void ChangeCoordinates(Directions directions)
        {
            switch (directions)
            {
                case Directions.up:
                    x--;
                    break;
                case Directions.down:
                    x++;
                    break;
                case Directions.left:
                    y--;
                    break;
                case Directions.right:
                    y++;
                    break;
            }
        }
    }
}
