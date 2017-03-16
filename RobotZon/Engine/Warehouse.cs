using System.Collections.Generic;
namespace RobotZon.Engine
{
    public class Warehouse
    {
        public int[,] Data { get; set; }
        public Robot[] Robots { get; set; }
        public Item[] Items { get; set; }

        public NodeWarehouse[,] Graph { get; set; }
        public NodeWarehouse Objective;

        public Warehouse(int[,] data, Robot[] robots, Item[] items)
        {
            Data = data;
            Robots = robots;
            Items = items;

            Graph = new NodeWarehouse[Data.GetLength(0), Data.GetLength(1)];
            for (int r = 0; r < Data.GetLength(0); r++)
            {
                for (int c = 0; c < Data.GetLength(1); c++)
                {
                    List<Position> neighbours = new List<Position>();

                    int n = GetData(r, c);
                    switch (n)
                    {
                        case 0:
                            if (GetData(r + 1, c) == -1 || GetData(r + 1, c) == 0)
                            {
                                neighbours.Add(new Position(r + 1, c));
                            }

                            if (GetData(r - 1, c) == 0)
                            {
                                neighbours.Add(new Position(r - 1, c));
                            }

                            if (GetData(r, c + 1) == 0)
                            {
                                neighbours.Add(new Position(r, c + 1));
                            }

                            if (GetData(r, c - 1) == 0)
                            {
                                neighbours.Add(new Position(r, c - 1));
                            }
                            break;
                    }
                    int a = 2;
                }
            }
        }

        public int GetData(int row, int column)
        {
            int res = -2;

            if (row >= 0 && row < Data.GetLength(0) && column >= 0 && column < Data.GetLength(1))
            {
                res = Data[row, column];
            }

            return res;
        }
    }
}
