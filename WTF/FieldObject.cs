using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WTF
{
    class FieldObject
    {

        public Vector positon;
        public FieldObject[,] map;
        String objectType;
        bool isPassable;
        bool houseStreet;
        bool firestationStreet;

        public FieldObject(FieldObject[,] map, Vector position, bool isPassable, String objectType, bool houseStreet, bool firestationStreet)
        {

            this.map = map;
            this.positon = position;
            this.isPassable = isPassable;
            this.objectType = objectType;
            this.houseStreet = houseStreet;
            this.firestationStreet = firestationStreet;

        }

        public FieldObject(FieldObject[,] map, Vector position, bool isPassable, String objectType)
        {

            this.map = map;
            this.positon = position;
            this.isPassable = isPassable;
            this.objectType = objectType;

        }

        public Vector getNextField()
        {

            Console.WriteLine(1);
            List<Vector> posibleFields = new List<Vector>();

            if (checkTop() != null)
            {
                posibleFields.Add(checkTop());
            }

            if (checkRight() != null)
            {
                posibleFields.Add(checkRight());
            }

            if (checkLeft() != null)
            {
                posibleFields.Add(checkLeft());
            }

            if (checkBottom() != null)
            {
                posibleFields.Add(checkBottom());
            }

            Random rnd = new Random();
            int randomField = rnd.Next(0, posibleFields.Count);

            return posibleFields[randomField];

        }

        public Vector checkTop()
        {
            int x = this.positon.getPositonX();
            int y = this.positon.getPositonY() - 1;

            if (y > 0 && this.map[x, y] == null)
                return new Vector(x, y);

            return null;
        }

        public Vector checkLeft()
        {
            int x = this.positon.getPositonX() - 1;
            int y = this.positon.getPositonY();

            if (x > 0 && this.map[x, y] == null)
                return new Vector(x, y);

            return null;
        }

        public Vector checkRight()
        {

            int x = this.positon.getPositonX() + 1;
            int y = this.positon.getPositonY();

            if (x < this.map.GetLength(0) && this.map[x, y] == null)
                return new Vector(x, y);

            return null;

        }

        public Vector checkBottom()
        {

            int x = this.positon.getPositonX();
            int y = this.positon.getPositonY() + 1;

            if (y < this.map.GetLength(1) && this.map[x, y] == null)
                return new Vector(x, y);

            return null;

        }

        public String getObjectType()
        {

            return this.objectType;

        }

    }
}
