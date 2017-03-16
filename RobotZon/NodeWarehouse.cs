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
            //todo
            //on retourne vrai si les coordonnées correspondent à l'objectif
            return (this.Position.Equals(Warehouse.Objective.Position));
        }

        public override List<Node> GetListSucc()
        {
            List<Node> Succ = new List<Node>();

            //3 boucles :

            //recherche de mon e
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
            
            return Succ;
            //parcours wrehouse.graph
            //pour chaque : verifie si position est égale à l'une des pos de mon tableau de voisin (juste une)

            //todo
            //rendre une liste des noeuds succésseurs
            //tous les noeuds autour de ma position (et libre, pas de mur ou de robot ou en dehors du tableau par ex)
        }

        public override void CalculeHCost()
        {
            //todo
            //rien a faire on retourne tout le temps 1...
        }
    }
}