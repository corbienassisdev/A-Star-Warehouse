using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using RobotZon.Engine;

namespace RobotZon
{
    public partial class FormAskingUser : Form
    {
        public int CartNumber { get; set; }
        public List<Position> CartPosition { get; set; }

        public FormAskingUser()
        {
            InitializeComponent();
            CartPosition = new List<Position>();
        }


        private void FormAskingUser_Load(object sender, EventArgs e)
        {
            listBoxSelectcart.Items.Add("Chariot 1");
            CartPosition.Add(new Position(-1, -1));
        }

        //Affiche la valeur de la position du chariot si elle a été affectée par l'utilisateur
        private void listBoxSelectcart_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (CartPosition.ElementAt(listBoxSelectcart.SelectedIndex).x != -1)
            {
                numericUpDownAbscissa.Value = CartPosition.ElementAt(listBoxSelectcart.SelectedIndex).x ;
            }
            else
            {
                numericUpDownAbscissa.Value = 0;
            }


            if (CartPosition.ElementAt(listBoxSelectcart.SelectedIndex).y != -1)
            {
                numericUpDownOrdinate.Value = CartPosition.ElementAt(listBoxSelectcart.SelectedIndex).y ;
            }
            else
            {
                numericUpDownAbscissa.Value = 0;
            }

            groupBoxCartposition.Text = "Position initiale du Chariot "+ listBoxSelectcart.SelectedIndex+"";
        }

        private void buttonSetPosition_Click(object sender, EventArgs e)
        {
            CartPosition[listBoxSelectcart.SelectedIndex] = new Position((int)numericUpDownAbscissa.Value, (int)numericUpDownOrdinate.Value);
        }

        private void numericUpDownNumberofcarts_ValueChanged(object sender, EventArgs e)
        {
            CartNumber = (int)numericUpDownNumberofcarts.Value;
            listBoxSelectcart.Items.Clear();

            // si l'utilisateur réduit le nombre de chariot, les positions des chariots dont l'index est supérieur
            // au nombre de chariot définit par l'utilisateur sont effacées
            if (CartNumber < CartPosition.Count())
            {
                for (int j = CartNumber -1; j < CartNumber; j++)
                {
                    CartPosition.Remove(CartPosition.ElementAt(j));
                }
            }

            //affiche les chariot et leurs positions dans la listebox si elles ont été définies
            for (int i =0; i< CartNumber; i++)
            {
                string Position = "";
                bool IsAbscissaDefined = false;

                /// Les deux prochains if définissent un string qui indique la position du chariot 
                /// si il a été définie précédemment.

                //récupère dans le string Position l'absisse de la position du chariot si il a été définie précédemment
                if (i < CartPosition.Count() && CartPosition.ElementAt(i).x != -1)
                {
                    Position += "( " + CartPosition.ElementAt(i).x + " ; ";
                    IsAbscissaDefined = true;
                }

                //récupère dans le string Position l'ordonnée de la position du chariot si il a été définie précédemment
                if (i < CartPosition.Count() && CartPosition.ElementAt(i).y != -1)
                { 
                    //cas où l'utilisateur a donné une valeur à l'abscisse et à l'ordonnée
                    if (IsAbscissaDefined)
                    {
                        Position += CartPosition.ElementAt(i).y + " )";
                    }
                    //cas où l'abscisse n'a pas été définie mais où l'ordonnée a été définie
                    else
                    {
                        Position = "( " + " ; " + CartPosition.ElementAt(i).y + " )";
                    }
                }
                
                //cas où l'abscisse a été définit mais pas l'ordonnée
                else
                {
                    Position += " )";
                }

                //La position d'un nouveau chariot est par défaut (-1;-1)
                if (i >= CartPosition.Count())
                {
                    CartPosition.Add(new Position(-1,-1));
                }

                listBoxSelectcart.Items.Add("Chariot " + i + Position);
            }
        }

        private void buttonOK_Click(object sender, EventArgs e)
        {
            FormMain Main = new FormMain();
            Main.Show();
            this.Close();
        }
    }
}
