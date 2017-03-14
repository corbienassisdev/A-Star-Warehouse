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
    }
}
