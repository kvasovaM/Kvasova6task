using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kvasova6task
{
    public class LAN
    {
        public List<Vertex> Vertexes = new List<Vertex>();
        public List<MyConnection> Connections = new List<MyConnection>();
        public Vertex ToMove;
        public MyConnection ForAdding;

        public void AddVertex(int x, int y, string type)
        {
            if (FindUsingXY(x, y) == null)
            {
                Vertex vertex = new Vertex();
                vertex.X = x;
                vertex.Y = y;
                vertex.Type = type;
                vertex.MyConnections = new List<MyConnection>();
                vertex.IsDrawn = false;
                Vertexes.Add(vertex);
            }
        }

        public void DeleteConnection(int x, int y)
        {
            double s, s1, xSy;
            for (int i = 0; i < Connections.Count; i++)
            {
                if (Connections[i] != null)
                {
                    s = Math.Sqrt(Math.Pow(x - Connections[i].LeftVertex.X, 2) +
                                  Math.Pow(y - Connections[i].LeftVertex.Y, 2));
                    s1 = Math.Sqrt(Math.Pow(x - Connections[i].RightVertex.X, 2) +
                                   Math.Pow(y - Connections[i].RightVertex.Y, 2));
                    xSy = Math.Sqrt(Math.Pow(Connections[i].LeftVertex.X - Connections[i].RightVertex.X, 2) +
                                    Math.Pow(Connections[i].LeftVertex.Y - Connections[i].RightVertex.Y, 2));
                    if (Math.Abs(s + s1 - xSy) < 0.1)
                    {
                        for (int k = 0; k < Connections[i].LeftVertex.MyConnections.Count; k++)
                        {
                            if (Connections[i] == Connections[i].LeftVertex.MyConnections[k])
                            {
                                Connections[i].LeftVertex.MyConnections[k] = null;
                                Connections[i].LeftVertex.MyConnections.RemoveAt(k);
                                k--;
                            }
                        }

                        for (int c = 0; c < Connections[i].RightVertex.MyConnections.Count; c++)
                        {
                            if (Connections[i] == Connections[i].RightVertex.MyConnections[c])
                            {
                                Connections[i].RightVertex.MyConnections[c] = null;
                                Connections[i].RightVertex.MyConnections.RemoveAt(c);
                                c--;
                            }
                        }

                        Connections[i] = null;
                        Connections.RemoveAt(i);
                        i--;
                        break;
                    }
                }
            }
        }

        public Vertex FindUsingXY(int x, int y)
        {
            foreach (Vertex vertex in Vertexes)
            {
                if (vertex != null)
                {
                    if ((vertex.X - x) * (vertex.X - x) + (vertex.Y - y) * (vertex.Y - y) < 30 * 30)
                        return vertex;
                }
            }

            return null;
        }

        public void DeleteVertex(int x, int y)
        {
            if (FindUsingXY(x, y) != null)
            {
                for (int v = 0; v < Vertexes.Count; v++)
                {
                    for (int j = 0; j < Vertexes[v].MyConnections.Count; j++)
                    {
                        if (Vertexes[v].MyConnections[j].RightVertex == FindUsingXY(x, y) ||
                            Vertexes[v].MyConnections[j].LeftVertex == FindUsingXY(x, y))
                        {
                            Vertexes[v].MyConnections[j] = null;
                            Vertexes[v].MyConnections.RemoveAt(j);
                            j--;
                        }
                    }
                }

                if (FindUsingXY(x, y).MyConnections != null)
                {
                    for (int i = 0; i < FindUsingXY(x, y).MyConnections.Count; i++)
                    {
                        FindUsingXY(x, y).MyConnections[i] = null;
                        FindUsingXY(x, y).MyConnections.RemoveAt(i);
                        i--;
                    }
                }

                for (int k = 0; k < Vertexes.Count; k++)
                {
                    if (Vertexes[k] == FindUsingXY(x, y))
                    {
                        Vertexes[k] = null;
                        Vertexes.RemoveAt(k);
                        k--;
                        break;
                    }
                }
            }

            for (int q = 0; q < Vertexes.Count; q++)
            {
                for (int j = 0; j < Vertexes[q].MyConnections.Count; j++)
                {
                    if (Vertexes[q].MyConnections[j].RightVertex == null ||
                        Vertexes[q].MyConnections[j].LeftVertex == null)
                    {
                        Vertexes[q].MyConnections[j] = null;
                        Vertexes[q].MyConnections.RemoveAt(j);
                        j--;
                    }
                }
            }

            for (int m = 0; m < Connections.Count; m++)
            {
                if (Connections[m].RightVertex == null || Connections[m].LeftVertex == null)
                {
                    Connections[m] = null;
                    Connections.RemoveAt(m);
                    m--;
                }
            }
        }

        public void MoveVertex(int x, int y)
        {
            if (ToMove == null)
            {
                ToMove = FindUsingXY(x, y);
                return;
            }
            else
            {
                ToMove.X = x;
                ToMove.Y = y;
                ToMove = null;
            }
        }

        public void AddConnection(int x, int y, string type)
        {
            if (ForAdding == null)
            {
                ForAdding = new MyConnection();
                ForAdding.Type = type;
                ForAdding.LeftVertex = FindUsingXY(x, y);
                if (ForAdding.LeftVertex != null)
                {
                    FindUsingXY(x, y).MyConnections.Add(ForAdding);
                }

                return;
            }
            else
            {
                ForAdding.RightVertex = FindUsingXY(x, y);
                if (ForAdding.RightVertex != null)
                {
                    FindUsingXY(x, y).MyConnections.Add(ForAdding);
                    Connections.Add(ForAdding);
                    ForAdding = null;
                }
            }
        }

    }
}
