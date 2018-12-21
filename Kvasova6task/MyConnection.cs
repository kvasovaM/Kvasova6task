using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kvasova6task
{
    public class MyConnection
    {
        public string Type { get; set; }
        //Type == "WALL" - стена
        //Type == "CABLE" - кабель
        public Vertex LeftVertex { get; set; }
        public Vertex RightVertex { get; set; }
    }
}
