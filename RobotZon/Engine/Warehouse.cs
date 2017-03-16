using System.Collections.Generic;
namespace RobotZon.Engine
{
    public class Warehouse
    {
        public int[,] Data { get; set; }
        public Robot[] Robots { get; set; }
        public Item[] Items { get; set; }

        public NodeWarehouse[,] Graph { get; set; }

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
                    int up = GetData(r + 1, c);
                    int down = GetData(r - 1, c);
                    int right = GetData(r, c + 1);
                    int left = GetData(r, c - 1);
                    switch (n)
                    {
                        case 0:
                            if (up == -1 || up == 0 || up == 1)
                            {
                                neighbours.Add(new Position(c, r + 1));
                            }

                            if (down == -1 || down == 0 || up == 1)
                            {
                                neighbours.Add(new Position(c, r - 1));
                            }

                            if (right == 0 || up == 1)
                            {
                                neighbours.Add(new Position(c + 1, r));
                            }

                            if (left == 0 || up == 1)
                            {
                                neighbours.Add(new Position(c - 1, r));
                            }
                            break;
                    }

                    Graph[r, c] = new NodeWarehouse("NodeWarehouse " + "(" + c + ", " + r + ")", this, new Position(c, r), neighbours); 
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
