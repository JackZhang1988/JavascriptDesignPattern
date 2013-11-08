using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

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

            IGrahObject car = new ObjectBuilder();
            car.Children.Add(new Rectangle(x, y));
            car.Children.Add(new Ellipse(x, y + 25));
            car.Children.Add(new Ellipse(x + 40, y + 25));



            IGrahObject player = new ObjectBuilder();
            player.Children.Add(new Rectangle(x + 100, y));
            player.Children.Add(new Ellipse(x + 150, y + 10));
            player.Children.Add(new Ellipse(x + 135, y + 10));

            world.Children.Add(car);
            world.Children.Add(new Rectangle(x, y + 200));
            world.Children.Add(player);


        }

        IGrahObject world = new ObjectBuilder();

        public interface IGrahObject
        {
            int X { get; set; }
            int Y { get; set; }
            IList<IGrahObject> Children { get; }
            void Draw(Graphics graphics);
            void MoveDown();
            void MoveUp();
            void MoveRight();
            void MoveLeft();
        }
         
        public abstract class GrahObject : IGrahObject
        {
            public abstract int X { get; set; }
            public abstract int Y { get; set; }

            public abstract IList<IGrahObject> Children { get; }


            public void Draw(Graphics graphics)
            {
                DrawSelft(graphics);
                foreach (IGrahObject child in Children)
                {
                    child.Draw(graphics);
                }
            }
            protected abstract void DrawSelft(Graphics g);

            public void MoveDown()
            {
                MoveSelfDown();
                foreach (IGrahObject child in Children)
                {
                    child.MoveDown();
                }
            }
            protected abstract void MoveSelfDown();

            public void MoveUp()
            {
                MoveSelfUp();
                foreach (IGrahObject child in Children)
                {
                    child.MoveUp();
                }
            }

            protected abstract void MoveSelfUp();

            public void MoveRight()
            {
                MoveSelfRight();
                foreach (IGrahObject child in Children)
                {
                    child.MoveRight();
                }
            }

            protected abstract void MoveSelfRight();

            public void MoveLeft()
            {
                MoveSelfLeft();
                foreach (IGrahObject child in Children)
                {
                    child.MoveLeft();
                }
            }
            protected abstract void MoveSelfLeft();
             
        }

        public class Rectangle : GrahObject
        {
            public Rectangle(int x, int y)
            {
                this.X = x;
                this.Y = y;
            }
            public override int X { get; set; }
            public override int Y { get; set; }

            private List<IGrahObject> _list = new List<IGrahObject>();

            public override IList<IGrahObject> Children
            {
                get { return _list; }
            }

            protected override void DrawSelft(Graphics g)
            {
                g.FillRectangle(Brushes.Red, this.X, this.Y, 50, 30);
            }

            protected override void MoveSelfDown()
            {
                this.Y += 1;
            }

            protected override void MoveSelfUp()
            {
                this.Y -= 1;
            }

            protected override void MoveSelfRight()
            {
                this.X += 1;
            }

            protected override void MoveSelfLeft()
            {
                this.X -= 1;
            }
        }

        public class Ellipse : GrahObject
        {
            public Ellipse(int x, int y)
            {
                this.X = x;
                this.Y = y;
            }
            public override int X { get; set; }
            public override int Y { get; set; }
            private List<IGrahObject> _child = new List<IGrahObject>();

            protected override void MoveSelfDown()
            {
                Y += 1;
            }
            protected override void MoveSelfUp()
            {
                Y -= 1;
            }
            protected override void MoveSelfLeft()
            {
                X -= 1;
            }
            protected override void MoveSelfRight()
            {
                X += 1;
            }
            protected override void DrawSelft(Graphics g)
            {
                g.FillEllipse(Brushes.Black, this.X, this.Y, 10, 10);

            }

            public override IList<IGrahObject> Children
            {
                get { return _child; }
            }
        }

        public class ObjectBuilder : GrahObject
        {

            public override int X
            {
                get
                {
                    throw new NotImplementedException();
                }
                set
                {
                    throw new NotImplementedException();
                }
            }

            public override int Y
            {
                get
                {
                    throw new NotImplementedException();
                }
                set
                {
                    throw new NotImplementedException();
                }
            }

            List<IGrahObject> _list = new List<IGrahObject>();
            public override IList<IGrahObject> Children
            {
                get { return _list; }
            }

            protected override void DrawSelft(Graphics g)
            {
            }

            protected override void MoveSelfDown()
            {
            }

            protected override void MoveSelfUp()
            {
            }

            protected override void MoveSelfRight()
            {
            }

            protected override void MoveSelfLeft()
            {
            }
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            var graphics = e.Graphics;

            world.Draw(graphics);
             
            //this.Invalidate();
        }

        protected override void OnKeyDown(KeyEventArgs e)
        {
            base.OnKeyDown(e);
            switch (e.KeyCode)
            {
                case Keys.Left:
                    world.MoveLeft();
                    break;
                case Keys.Right:
                    world.MoveRight();
                    break;
                case Keys.Up:
                    world.MoveUp();
                    break;
                case Keys.Down:
                    world.MoveDown();
                    break;
                default:
                    break;
            }

            this.Invalidate();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2.GetInstance().Show();
        }

        private void jumpToForm2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2.GetInstance().Show();
        }

    }
}
