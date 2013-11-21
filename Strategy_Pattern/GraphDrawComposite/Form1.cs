using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using GraphDrawComposite.Implement;

namespace GraphDrawComposite
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.SetStyle(ControlStyles.UserPaint, true);
            this.SetStyle(ControlStyles.OptimizedDoubleBuffer, true);
            this.SetStyle(ControlStyles.AllPaintingInWmPaint, true);


            int x = 50;
            int y = 50;

            var rectanble = new Rectangle(x, y);
            var ellipse1 = new Ellipse(x, y + 25);
            var ellipse2 = new Ellipse(x + 40, y + 25);

            world.Children.Add(rectanble);
            world.Children.Add(ellipse1);
            world.Children.Add(ellipse2);
            world.Children.Add(new Rectangle(0, 90));
            world.Children.Add(new Rectangle(50, 90));
            world.Children.Add(new Rectangle(100, 90));
            world.Children.Add(new Rectangle(150, 90));
            world.Children.Add(new Rectangle(200, 90));
            world.Children.Add(new Rectangle(250, 90));


            car = new ArrowMover();
            car.MovableList.Add(rectanble);
            car.MovableList.Add(ellipse1);
            car.MovableList.Add(ellipse2);
            car.SpeedStrategy = new SimpleMoverStrategy();

            timer1.Start();
        }
        ArrowMover car;
        private void timer1_Tick(object sender, EventArgs e)
        {
            panel1.Invalidate();
        }

        void panel1_Paint(object sender, PaintEventArgs e)
        {
            var graphics = e.Graphics;
            world.Draw(graphics);
        }

        IGrahObject world = new ObjectBuilder();

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            int value = (int)msg.WParam;
            if (value == 37)
            {
                car.Move(Direction.Left);
            }
            else if (value == 39)
            {
                car.Move(Direction.Right);
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }

        public int speed { get { return (int)numericUpDown1.Value; } }


    }
}
