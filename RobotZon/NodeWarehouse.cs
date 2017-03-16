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
            //todo
            //return 1 (tous les couts sont égaux)
            return 1;
        }

        public override bool EndState()
        {
            //todo
            //on retourne vrai si les coordonnées correspondent à l'objectif
            return true;
        }

        public override List<Node> GetListSucc()
        {
            //3 boucles :
            //parcours wrehouse.graph
            //pour chaque : verifie si position est égale à l'une des pos de mon tableau de voisin (juste une)

            //todo
            //rendre une liste des noeuds succésseurs
            //tous les noeuds autour de ma position (et libre, pas de mur ou de robot ou en dehors du tableau par ex)
            return null;
        }

        public override void CalculeHCost()
        {
            //todo
            //rien a faire on retorune tout le temps 1...
        }
    }
}