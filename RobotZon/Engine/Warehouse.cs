using RobotZon.Salotti;
using System.Collections.Generic;

namespace RobotZon.Engine
{
    public class Warehouse
    {
        public int[,] Data { get; set; }
        public List<Robot> Robots { get; set; }
        public List<Item> Items { get; set; }

        public Warehouse(int[,] data)
        {
            Data = data;
            Robots = new List<Robot>();
            Items = new List<Item>();
        }

        public void MoveRobot(int id, int dr, int dc)
        {
            if (id >= 0 && id < Robots.Count)
            {
                Robot r = Robots[id];
                r.Position += new Position(dr, dc);
            }
        }
    }
}
