using System;
using System.Windows.Forms;
using RobotZon.Engine;
using System.Drawing;
using System.Collections.Generic;
using System.Drawing.Drawing2D;

namespace RobotZon
{
    public partial class FormMain : Form
    {
        public Timer Timer { get; protected set; }
        public Dictionary<string, Image> Images { get; protected set; }

        public Warehouse Warehouse { get; set; }
        public int SizeUnit { get; protected set; }

        public FormMain()
        {
            InitializeComponent();
            InitalizeThreads();
            InitializeData();
            InitializeResources();

            SizeUnit = 10;
            Size = new Size(800, 800);

            Log("Initialisation de la simulation");
            Log("Nombre de robots : {0}", Warehouse.Robots.Length);
            Log("Nombre d'objets : {0}", Warehouse.Items.Length);
        }

        public void InitalizeThreads()
        {
            Timer = new Timer();
            Timer.Tick += onWork;
            Timer.Interval = 500;

            Timer.Start();
        }

        public void InitializeData()
        {
            Warehouse = new Warehouse
            (
                new int[,]
                {
                    { 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
                    { 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
                    { 1, 0, -1, -1, -1, -1, -1, -1, -1, -1, -1, 0, 0, 0, -1, -1, -1, -1, -1, -1, -1, -1, -1, 0, 0 },
                    { 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
                    { 1, 0, -1, -1, -1, -1, -1, -1, -1, -1, -1, 0, 0, 0, -1, -1, -1, -1, -1, -1, -1, -1, -1, 0, 0 },
                    { 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
                    { 1, 0, -1, -1, -1, -1, -1, -1, -1, -1, -1, 0, 0, 0, -1, -1, -1, -1, -1, -1, -1, -1, -1, 0, 0 },
                    { 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
                    { 1, 0, -1, -1, -1, -1, -1, -1, -1, -1, -1, 0, 0, 0, -1, -1, -1, -1, -1, -1, -1, -1, -1, 0, 0 },
                    { 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
                    { 1, 0, -1, -1, -1, -1, -1, -1, -1, -1, -1, 0, 0, 0, -1, -1, -1, -1, -1, -1, -1, -1, -1, 0, 0 },
                    { 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
                    { 1, 0, -1, -1, -1, -1, -1, -1, -1, -1, -1, 0, 0, 0, -1, -1, -1, -1, -1, -1, -1, -1, -1, 0, 0 },
                    { 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
                    { 1, 0, -1, -1, -1, -1, -1, -1, -1, -1, -1, 0, 0, 0, -1, -1, -1, -1, -1, -1, -1, -1, -1, 0, 0 },
                    { 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
                    { 1, 0, -1, -1, -1, -1, -1, -1, -1, -1, -1, 0, 0, 0, -1, -1, -1, -1, -1, -1, -1, -1, -1, 0, 0 },
                    { 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
                    { 1, 0, -1, -1, -1, -1, -1, -1, -1, -1, -1, 0, 0, 0, -1, -1, -1, -1, -1, -1, -1, -1, -1, 0, 0 },
                    { 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
                    { 1, 0, -1, -1, -1, -1, -1, -1, -1, -1, -1, 0, 0, 0, -1, -1, -1, -1, -1, -1, -1, -1, -1, 0, 0 },
                    { 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
                    { 1, 0, -1, -1, -1, -1, -1, -1, -1, -1, -1, 0, 0, 0, -1, -1, -1, -1, -1, -1, -1, -1, -1, 0, 0 },
                    { 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
                    { 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 }
                },
                new Robot[]
                {
                    new Robot("Robby", new Position(0, 0))
                },
                new Item[]
                {
                    new Item("Overpowered toilet cleaner +2 ATK", new Position(2, 2), ItemOrientation.North)
                }
            );
        }

        public void InitializeResources()
        {
            Images = new Dictionary<string, Image>()
            {
                { "robot",  new Bitmap("Resources/robot.png") }
            };
        }

        public void Log(object content, params object[] args)
        {
            Console.WriteLine("[{0}] {1}", DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"), string.Format(content.ToString(), args));
            //listBoxDebug.Items.Add(string.Format("[{0}] {1}\r\n", DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"), string.Format(content.ToString(), args)));
            //listBoxDebug.SelectedIndex = listBoxDebug.Items.Count - 1;
            //listBoxDebug.SelectedIndex = -1;
        }

        private void onWork(object sender, EventArgs e)
        {
            Warehouse.MoveRobot(0, 1, 1);
            Refresh();
        }

        private void onDraw(object sender, PaintEventArgs e)
        {

            Graphics g = e.Graphics;
            g.SmoothingMode = SmoothingMode.AntiAlias;

            Font font = new Font("Consolas", SizeUnit, FontStyle.Regular, GraphicsUnit.Pixel);
            Position offset = new Position((ClientRectangle.Width / 2) - (((Warehouse.Data.GetLength(1) + 2) * SizeUnit) / 2), (ClientRectangle.Height / 2) - (((Warehouse.Data.GetLength(0) + 2) * SizeUnit) / 2));

            //Affichage des cases
            for (int r = 0; r < Warehouse.Data.GetLength(0); r++)
            {
                for (int c = 0; c < Warehouse.Data.GetLength(1); c++)
                {
                    int a = Warehouse.Data[r, c];
                    switch (a)
                    {
                        case 1:
                            g.FillRectangle(new SolidBrush(Color.ForestGreen), new Rectangle(c * SizeUnit + SizeUnit + offset.x, r * SizeUnit + SizeUnit + offset.y, SizeUnit, SizeUnit));
                            break;

                        case -1:
                            g.FillRectangle(new SolidBrush(Color.DeepSkyBlue), new Rectangle(c * SizeUnit + SizeUnit + offset.x, r * SizeUnit + SizeUnit + offset.y, SizeUnit, SizeUnit));
                            break;

                        default:
                            break;
                    }

                    g.DrawRectangle(new Pen(Color.FromArgb(40, 45, 53)), new Rectangle(c * SizeUnit + SizeUnit + offset.x, r * SizeUnit + SizeUnit + offset.y, SizeUnit, SizeUnit));
                }
            }

            //Affichage des robots
            foreach (Robot robot in Warehouse.Robots)
            {
                g.DrawImage(Images["robot"], new Rectangle(robot.Position.x * SizeUnit + SizeUnit + offset.x, robot.Position.y * SizeUnit + SizeUnit + offset.y, SizeUnit, SizeUnit));
            }
        }

        private void onResize(object sender, EventArgs e)
        {
            SizeUnit = Math.Min((int)Math.Ceiling((float)ClientRectangle.Height / (Warehouse.Data.GetLength(0) + 2)), (int)Math.Ceiling((float)ClientRectangle.Width / (Warehouse.Data.GetLength(1) + 2)));
            Refresh();
        }
    }
}
