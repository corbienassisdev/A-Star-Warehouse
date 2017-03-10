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
    }
}
