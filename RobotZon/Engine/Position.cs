namespace RobotZon.Engine
{
    public struct Position
    {
        public int x;
        public int y;
        public int z;

        public Position(int x = 0, int y = 0, int z = 0)
        {
            this.x = x;
            this.y = y;
            this.z = z;
        }

        public static operator+(Position p1, Position p2)
        {
            return new Position(p1.x + p2.x, p1.y + p2.y);
        }
    }
}
