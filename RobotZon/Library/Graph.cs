using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace RobotZon.Salotti
{
    public class Graph
    {
        public List<Node> Opened;
        public List<Node> Closed;

        private Node ChercheNodeDansFermes(Node N2)
        {
            int i = 0;

            while (i < Closed.Count)
            {
                if (Closed[i].IsEqual (N2))
                    return Closed[i];
                i++;
            }
            return null;
        }

        private Node ChercheNodeDansOuverts(Node N2)
        {
            int i = 0;

            while (i < Opened.Count)
            {
                if (Opened[i].IsEqual(N2))
                    return Opened[i];
                i++;
            }
            return null;
        }

        public List<Node> RechercheSolutionAEtoile(Node N0)
        {
            Opened = new List<Node>();
            Closed = new List<Node>();
            // Le noeud passé en paramètre est supposé être le noeud initial
            Node N = N0;
            Opened.Add(N0);

            // tant que le noeud n'est pas terminal et que ouverts n'est pas vide
            while (Opened.Count != 0 && N.EndState() == false)
            {
                // Le meilleur noeud des ouverts est supposé placé en tête de liste
                // On le place dans les fermés
                Opened.Remove(N);
                Closed.Add(N);

                // Il faut trouver les noeuds successeurs de N
                this.MAJSuccesseurs(N);
                // Inutile de retrier car les insertions ont été faites en respectant l'ordre

                // On prend le meilleur, donc celui en position 0, pour continuer à explorer les états
                // A condition qu'il existe bien sûr
                if (Opened.Count > 0)
                {
                    N = Opened[0];
                }
                else
                {
                    N = null;
                }
            }

            // A* terminé
            // On retourne le chemin qui va du noeud initial au noeud final sous forme de liste
            // Le chemin est retrouvé en partant du noeud final et en accédant aux parents de manière
            // itérative jusqu'à ce qu'on tombe sur le noeud initial
            List<Node> _LN = new List<Node>();
            if (N != null)
            {
                _LN.Add(N);

                while (N != N0)
                {
                    N = N.Parent;
                    _LN.Insert(0, N);  // On insère en position 1
                }
            }
            return _LN;
        }

        private void MAJSuccesseurs(Node N)
        {
            // On fait appel à GetListSucc, méthode abstraite qu'on doit réécrire pour chaque
            // problème. Elle doit retourner la liste complète des noeuds successeurs de N.
            List<Node> listsucc = N.GetListSucc();
            foreach (Node N2 in listsucc)
            {
                // N2 est-il une copie d'un nœud déjà vu et placé dans la liste des fermés ?
                Node N2bis = ChercheNodeDansFermes(N2);
                if (N2bis == null)
                {
                    // Rien dans les fermés. Est-il dans les ouverts ?
                    N2bis = ChercheNodeDansOuverts(N2);
                    if (N2bis != null)
                    {
                        // Il existe, donc on l'a déjà vu, N2 n'est qu'une copie de N2Bis
                        // Le nouveau chemin passant par N est-il meilleur ?
                        if (N.GCost + N.GetArcCost(N2) < N2bis.GCost)
                        {
                            // Mise à jour de N2bis
                            N2bis.GCost = N.GCost + N.GetArcCost(N2);
                            // HCost pas recalculé car toujours bon
                            N2bis.ComputeTotalCost(); // somme de GCost et HCost
                            // Mise à jour de la famille ....
                            N2bis.DeleteParent();
                            N2bis.AddParent(N);
                            // Mise à jour des ouverts
                            Opened.Remove(N2bis);
                            this.InsertNewNodeInOpenList(N2bis);
                        }
                        // else on ne fait rien, car le nouveau chemin est moins bon
                    }
                    else
                    {
                        // N2 est nouveau, MAJ et insertion dans les ouverts
                        N2.GCost = N.GCost + N.GetArcCost(N2);
                        N2.CalculeHCost();
                        N2.AddParent(N);
                        N2.ComputeTotalCost(); // somme de GCost et HCost
                        this.InsertNewNodeInOpenList(N2);
                    }
                }
                // else il est dans les fermés donc on ne fait rien,
                // car on a déjà trouvé le plus court chemin pour aller en N2
            }
        }

        public void InsertNewNodeInOpenList(Node NewNode)
        {
            // Insertion pour respecter l'ordre du cout total le plus petit au plus grand
            if (this.Opened.Count == 0)
            { Opened.Add(NewNode); }
            else
            {
                Node N = Opened[0];
                bool trouve = false;
                int i = 0;
                do
                    if (NewNode.TotalCost < N.TotalCost)
                    {
                        Opened.Insert(i, NewNode);
                        trouve = true;
                    }
                    else
                    {
                        i++;
                        if (Opened.Count == i)
                        {
                            N = null;
                            Opened.Insert(i, NewNode);
                        }
                        else
                        { N = Opened[i]; }
                    }
                while ((N != null) && (trouve == false));
            }
        }

        // Si on veut afficher l'arbre de recherche, il suffit de passer un treeview en paramètres
        // Celui-ci est mis à jour avec les noeuds de la liste des fermés, on ne tient pas compte des ouverts
        public void GetSearchTree( TreeView TV )
        {
            if (Closed == null) return;
            if (Closed.Count == 0) return;
            
            // On suppose le TreeView préexistant
            TV.Nodes.Clear();

            TreeNode TN = new TreeNode ( Closed[0].ToString() );
            TV.Nodes.Add(TN);

            AjouteBranche ( Closed[0], TN );
        }

        // AjouteBranche est exclusivement appelée par GetSearchTree; les noeuds sont ajoutés de manière récursive
        private void AjouteBranche( Node GN, TreeNode TN)
        {
            foreach (Node GNfils in GN.Children)
            {
                TreeNode TNfils = new TreeNode(GNfils.ToString());
                TN.Nodes.Add(TNfils);
                if (GNfils.Children.Count > 0) AjouteBranche(GNfils, TNfils); 
            }
        }
  
    }
}
