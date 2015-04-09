using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WTF
{
    class Firestation : FieldObject
    {
        public Firestation(FieldObject[,] map, Vector position) :
		base(map, position, true, "firestation") { }
    }
}

