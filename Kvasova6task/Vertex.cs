using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kvasova6task
{
    public class Vertex
    {
        public string Type { get; set; }
        //Type == "COMPUTER" - компьютер
        //Type == "PRINTER" - принтер
        //Type == "ROUTER" - роутер
        //Type == "FOR_ANGLE" - для создания точки видимого угла
        public bool IsDrawn { get; set; }
        public int X { get; set; }
        public int Y { get; set; }
        public List<MyConnection> MyConnections { get; set; }
    }
}
