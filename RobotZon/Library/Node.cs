using System.Collections.Generic;

namespace RobotZon.Salotti
{
    public abstract class Node
    {
        protected string Name;                                  //Doit être unique pour chaque Node !
        public double GCost { get; set; }                       //Coût du chemin du noeud initial jusqu'à ce noeud
        public double HCost { get; set; }                       //Estimation heuristique du coût pour atteindre le noeud final
        public double TotalCost { get; set; }                   //Estimation heuristique du coût pour atteindre le noeud final

        public Node Parent { get; protected set; }
        public List<Node> Children { get; protected set; }

        public Node(string name)
        {
            Name = name;
            Parent = null;
            Children = new List<Node>();
        }

        public void AddParent(Node parent)
        {
            Parent = parent;
            if (Parent != null)
            {
                Parent.Children.Add(this);
            }
        }

        public void DeleteParent()
        {
            if (Parent != null)
            {
                Parent.Children.Remove(this);
                Parent = null;
            }
        }

        public double ComputeTotalCost()
        {
            return GCost + HCost;
        }

        public abstract bool IsEqual(Node other);
        public abstract double GetArcCost(Node other);
        public abstract bool EndState();
        public abstract List<Node> GetListSucc();
        public abstract void CalculeHCost();
        //On peut aussi penser à surcharger ToString() pour afficher correctement un état
    }
}
