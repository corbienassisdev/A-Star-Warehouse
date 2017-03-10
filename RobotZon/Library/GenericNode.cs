using System.Collections.Generic;

namespace RobotZon.Salotti
{
    public abstract class GenericNode
    {
        protected string Name;                          //Doit être unique pour chaque Node !
        public double GCost { get; set; }               //Coût du chemin du noeud initial jusqu'à ce noeud
        public double HCost { get; set; }               //Estimation heuristique du coût pour atteindre le noeud final
        public double TotalCost { get; set; }               //Estimation heuristique du coût pour atteindre le noeud final

        public GenericNode Parent { get; protected set; }
        public List<GenericNode> Children { get; protected set; }

        public GenericNode(string name)
        {
            Name = name;
            Parent = null;
            Children = new List<GenericNode>();
        }

        public void AddParent(GenericNode parent)
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

        public abstract bool IsEqual(GenericNode other);
        public abstract double GetArcCost(GenericNode other);
        public abstract bool EndState();
        public abstract List<GenericNode> GetListSucc();
        public abstract void CalculeHCost();
        //On peut aussi penser à surcharger ToString() pour afficher correctement un état
    }
}
