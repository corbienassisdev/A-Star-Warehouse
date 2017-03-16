using RobotZon.Engine;
using RobotZon.Salotti;
using System.Collections.Generic;

namespace RobotZon
{
    public class NodeWarehouse : Node
    {
        public Warehouse Warehouse { get; protected set; }
        public Position Position { get; protected set; }
        public List<Position> Neighbours { get; protected set; }
        static int Id = 0;

        public NodeWarehouse(string name, Warehouse warehouse, Position position, List<Position> neighbours) : base(name)
        {
            Warehouse = warehouse;
            Position = position;
            Neighbours = neighbours;

            Id++; ;
            name = Id.ToString();
        }

        public override bool IsEqual(Node N2)
        {
            NodeWarehouse NT = (NodeWarehouse)(N2);
            return (NT.Position.x == Position.x && NT.Position.y == Position.y);
        }

        public override double GetArcCost(Node N2)
        {
            return 1;
        }

        public override bool EndState()
        {
            //Objective doit être défini dans Wahrehouse : il correspond au noeud où se trouve l'objet à aller chercher
            return (this.Position.Equals(Warehouse.Objective.Position));
        }

        public override List<Node> GetListSucc()
        {
            List<Node> Succ = new List<Node>();
            
            for(int r=0; r<Warehouse.Graph.GetLength(0); r++)
            {
                for (int c=0; c< Warehouse.Graph.GetLength(1); c++)
                {
                    foreach(Position pos in Neighbours)
                    {
                        if (Warehouse.Graph[r, c].Position.Equals(pos))
                        {
                            Succ.Add(Warehouse.Graph[r, c]);
                        }
                    }
                }
            }
            
            //TODO: gérer robots
            return Succ;
        }

        public override void CalculeHCost()
        {
            //todo
            //rien a faire on retourne tout le temps 1...
        }
    }
}