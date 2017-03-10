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
                { 0, 0, 0, 0, 0, 1 },
                { 0, 0, 0, 0, 0, 0 },
                { 0, 0, -1, -1, 0, 0 },
                { 0, 0, -1, -1, 0, 0 },
                { 0, 0, 0, 0, 0, 0 },
                { 0, 0, 0, 0, 0, 0 }
            });

            Warehouse.Robots.Add(new Robot("Elmer"));
            Warehouse.Robots.Add(new Robot("Patrick"));
            Warehouse.Robots.Add(new Robot("Robby"));

            Warehouse.Items.Add(new Item("Overpowered toilet cleaner +2 ATK", new Position(2, 3), ItemOrientation.North));
        }

        public void Log(object content)
        {
            listBoxDebug.Items.Add(string.Format("[{0}] {1}\r\n", DateTime.Now.ToString("yyyy-MM-dd HH-mm-ss"), content.ToString()));
        }

        private void TestForm_Load(object sender, EventArgs e)
        {

        }

        private void panelMain_Paint(object sender, PaintEventArgs e)
        {
            int size = 40;
            Graphics g = e.Graphics;
            for (int i = 0; i < Warehouse.Data.GetLength(0); i++)
            {
                for (int j = 0; j < Warehouse.Data.GetLength(1); j++)
                {
                    g.DrawRectangle(new Pen(Color.Black), new Rectangle(i * size + size, j * size + size, size, size));
                }
            }
        }
    }
}
