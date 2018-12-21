using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kvasova6task
{
    public partial class Form1 : Form
    {
        private Graphics g;
        private LAN lan;
        private Rectangle rectangle;
        private Bitmap bmpBitmap;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lan = new LAN();

            groupBoxRegime.Controls.Add(radioButtonAddConnection);
            groupBoxRegime.Controls.Add(radioButtonDeleteConnection);
            groupBoxRegime.Controls.Add(radioButtonAddVertex);
            groupBoxRegime.Controls.Add(radioButtonDeleteVertex);
            groupBoxRegime.Controls.Add(radioButtonMoveVertex);

            groupBoxVertexType.Controls.Add(radioButtonComputer);
            groupBoxVertexType.Controls.Add(radioButtonPrinter);
            groupBoxVertexType.Controls.Add(radioButtonRouter);
            groupBoxVertexType.Controls.Add(radioButtonForAngle);
            radioButtonForAngle.Checked = true;

            groupBoxConnectionType.Controls.Add(radioButtonWall);
            groupBoxConnectionType.Controls.Add(radioButtonCable);
            radioButtonWall.Checked = true;

            g = pictureBox1.CreateGraphics();
            rectangle = pictureBox1.ClientRectangle;
            rectangle.Width--;
            rectangle.Height--;
        }

        private void pictureBox1_MouseClick(object sender, MouseEventArgs e)
        {
            Graphics gr2 = pictureBox1.CreateGraphics();
            Bitmap bitmap = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            Graphics g = Graphics.FromImage(bitmap);

            this.g.Clear(this.BackColor);
            this.g.DrawRectangle(Pens.Black, rectangle);
            if (radioButtonAddVertex.Checked)
            {
                if (radioButtonForAngle.Checked)
                {
                    lan.AddVertex(e.X, e.Y, radioButtonForAngle.Text);
                }
                if (radioButtonPrinter.Checked)
                {
                    lan.AddVertex(e.X, e.Y, radioButtonPrinter.Text);
                }
                if (radioButtonComputer.Checked)
                {
                    lan.AddVertex(e.X, e.Y, radioButtonComputer.Text);
                }
                if (radioButtonRouter.Checked)
                {
                    lan.AddVertex(e.X, e.Y, radioButtonRouter.Text);
                }

                Drawer.Draw(this.g, lan);
            }

            if (radioButtonDeleteVertex.Checked)
            {
                lan.DeleteVertex(e.X, e.Y);
                Drawer.Draw(this.g, lan);
            }

            if (radioButtonMoveVertex.Checked)
            {
                lan.MoveVertex(e.X, e.Y);
                Drawer.Draw(this.g, lan);
            }

            if (radioButtonAddConnection.Checked)
            {
                if (radioButtonWall.Checked)
                {
                    lan.AddConnection(e.X, e.Y, radioButtonWall.Text);
                }
                if (radioButtonCable.Checked)
                {
                    lan.AddConnection(e.X, e.Y, radioButtonCable.Text);
                }
                Drawer.Draw(this.g, lan);
            }

            if (radioButtonDeleteConnection.Checked)
            {
                lan.DeleteConnection(e.X, e.Y);
                Drawer.Draw(this.g, lan);
            }
            gr2.DrawImage(bitmap, 0, 0);

        }
    }
}
