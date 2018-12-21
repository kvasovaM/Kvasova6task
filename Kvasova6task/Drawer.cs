using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kvasova6task
{
    public static class Drawer
    {
        private static Pen wallPen = new Pen(Color.Firebrick, 5);
        private static Pen cablePen = new Pen(Color.Black);
        private static Pen movePen = new Pen(Color.Crimson);
        private static SolidBrush moveBrush = new SolidBrush(Color.Chartreuse);
        private static Pen anglePen = new Pen(Color.Blue);
        private static SolidBrush angleBrush = new SolidBrush(Color.Blue);
        private static Image computerImage = Image.FromFile("computer.png");
        private static Image routerImage = Image.FromFile("router.png");
        private static Image printerImage = Image.FromFile("printer.png");

        public static void Draw(Graphics g, LAN lan)
        {
            foreach (Vertex vertex in lan.Vertexes)
            {
                if (vertex != null)
                {
                    vertex.IsDrawn = false;
                }
            }

            foreach (Vertex x in lan.Vertexes)
            {
                if (x != null)
                {
                    Draw(g, x, lan); // передаем один из узлов
                }
            }
        }

        private static void Draw(Graphics g, Vertex vertex, LAN lan)
        {
            if (vertex.IsDrawn) return;
            if (vertex.MyConnections != null)
            {
                foreach (MyConnection connection in vertex.MyConnections)
                {
                    if (connection != null)
                    {
                        if (vertex == connection.RightVertex)
                        {
                            if (connection.LeftVertex != null)
                            {
                                if (!connection.LeftVertex.IsDrawn)
                                    DrawConnection(g, vertex, connection.LeftVertex, connection);
                            }
                        }

                        if (vertex == connection.LeftVertex)
                        {
                            if (connection.RightVertex != null)
                            {
                                if (!connection.RightVertex.IsDrawn)
                                    DrawConnection(g, vertex, connection.RightVertex, connection);
                            }
                        }
                    }
                }
            }

            DrawVertex(g, vertex, lan);
            vertex.IsDrawn = true;
        }

        private static void DrawConnection(Graphics g, Vertex p, Vertex n, MyConnection connection)
        {
            if (connection.Type == "WALL")
            {
                g.DrawLine(wallPen, p.X, p.Y, n.X, n.Y);
            }

            if (connection.Type == "CABLE")
            {
                g.DrawLine(cablePen, p.X, p.Y, n.X, n.Y);
            }

        }

        private static void DrawVertex(Graphics g, Vertex vertex, LAN lan)
        {
            if (vertex.Type == "PRINTER")
            {
                g.DrawImage(printerImage, new Point(vertex.X - 25, vertex.Y - 25));
                if (vertex == lan.ToMove)
                    g.DrawEllipse(movePen, vertex.X - 25, vertex.Y - 25, 50, 50);
            }
            if (vertex.Type == "COMPUTER")
            {
                g.DrawImage(computerImage, new Point(vertex.X - 25, vertex.Y - 25));
                if (vertex == lan.ToMove)
                    g.DrawEllipse(movePen, vertex.X - 25, vertex.Y - 25, 60, 60);
            }
            if (vertex.Type == "ROUTER")
            {
                g.DrawImage(routerImage, new Point(vertex.X - 25, vertex.Y - 25));
                if (vertex == lan.ToMove)
                    g.DrawEllipse(movePen, vertex.X - 30, vertex.Y - 30, 60, 60);
            }
            if (vertex.Type == "FOR_ANGLE")
            {
                if (vertex == lan.ToMove)
                {
                    g.FillEllipse(moveBrush, vertex.X - 10, vertex.Y - 10, 20, 20);
                    g.DrawEllipse(movePen, vertex.X - 10, vertex.Y - 10, 20, 20);
                }
                else
                {
                    g.FillEllipse(angleBrush, vertex.X - 10, vertex.Y - 10, 20, 20);
                    g.DrawEllipse(anglePen, vertex.X - 10, vertex.Y - 10, 20, 20);
                }
            }
        }
    }
}
