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
            InitializeData();
        }

        public void InitializeData()
        {
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
        }

        public void Log(object content)
        {
            listBoxDebug.Items.Add(string.Format("[{0}] {1}\r\n", DateTime.Now.ToString("yyyy-MM-dd HH-mm-ss"), content.ToString()));
        }

        private void panelMain_Paint(object sender, PaintEventArgs e)
        {
            int size = 40;
            Graphics g = e.Graphics;
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
        }
    }
}
