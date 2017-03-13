namespace RobotZon.Engine
{
    public class Warehouse
    {
        public int[,] Data { get; set; }
        public Robot[] Robots { get; set; }
        public Item[] Items { get; set; }

        public Warehouse(int[,] data, Robot[] robots, Item[] items)
        {
            Data = data;
            Robots = robots;
            Items = items;
        }

        public void MoveRobot(int id, int dr, int dc)
        {
            if (id >= 0 && id < Robots.Length)
            {
                Robot r = Robots[id];

                Position position = r.Position + new Position(dc, dr);
                if (r.Position.x + dc >= 0 && r.Position.x + dc < Data.GetLength(1) && r.Position.y + dr >= 0 && r.Position.y + dr < Data.GetLength(0))
                {
                    r.Position = position;
                }
            }
        }
    }
}
