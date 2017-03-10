using System;
using System.Windows.Forms;
using RobotZon.Engine;
using System.Drawing;

namespace RobotZon
{
    public partial class TestForm : Form
    {
        public Warehouse Warehouse { get; set; }

        public TestForm()
        {
            InitializeComponent();

            Warehouse = new Warehouse(new int[,]
            {
                { 1, 0, 0, 0, 0, 0 },
                { 1, 0, 0, 0, 0, 0 },
                { 1, 0, -1, -1, 0, 0 },
                { 1, 0, -1, -1, 0, 0 },
                { 1, 0, 0, 0, 0, 0 },
                { 1, 0, 0, 0, 0, 0 }
            });

            Warehouse.Robots.Add(new Robot("Robby", new Position(0, 0)));

            Warehouse.Items.Add(new Item("Overpowered toilet cleaner +2 ATK", new Position(2, 2), ItemOrientation.North));

            Log("Initialisation de la simulation");
            Log("Nombre de robots : {0}", Warehouse.Robots.Count);
            Log("Nombre d'objets : {0}", Warehouse.Items.Count);
        }

        public void Log(object content, params object[] args)
        {
            listBoxDebug.Items.Add(string.Format("[{0}] {1}\r\n", DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"), string.Format(content.ToString(), args)));
        }

        private void onDraw(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            int size = 40;

            Font font = new Font("Consolas", (float)size, FontStyle.Regular, GraphicsUnit.Pixel);
            StringFormat format = new StringFormat();
            format.LineAlignment = StringAlignment.Center;
            format.Alignment = StringAlignment.Center;

            //Affichage des cases
            for (int l = 0; l < Warehouse.Data.GetLength(0); l++)
            {
                for (int c = 0; c < Warehouse.Data.GetLength(1); c++)
                {
                    int a = Warehouse.Data[l, c];
                    switch (a)
                    {
                        case 1:
                            g.FillRectangle(new SolidBrush(Color.ForestGreen), new Rectangle(c * size + size, l * size + size, size, size));
                            break;

                        case -1:
                            g.FillRectangle(new SolidBrush(Color.DeepSkyBlue), new Rectangle(c * size + size, l * size + size, size, size));
                            break;

                        default:
                            break;
                    }

                    g.DrawRectangle(new Pen(Color.Black), new Rectangle(c * size + size, l * size + size, size, size));
                }
            }

            //Affichage des robots
            foreach (Robot robot in Warehouse.Robots)
            {
                g.DrawString("R", font, new SolidBrush(Color.Black), new Rectangle(robot.Position.x * size + size - 1, robot.Position.y * size + size, size, size), format);
            }
        }
    }
}
