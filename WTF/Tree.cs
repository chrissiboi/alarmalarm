using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WTF
{
    class Tree : FieldObject
    {
        public fill(FieldObject[,] map, Vector position, bool isPassable, String type, bool houseStreet, bool firestationStreet) :
        base(map, position, isPassable, type, houseStreet, firestationStreet) { }
       
    }
}
