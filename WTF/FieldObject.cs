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
        //FieldObject top;
        //FieldObject left;
        //FieldObject right;
        //FieldObject bottom;
        String ObjectType;
        public FieldObject[,] map;
         bool isPassable;
        bool houseStreet;
        bool firestationStreet;

		public FieldObject(FieldObject[,] map, Vector position, bool isPassable, String objectType, bool houseStreet, bool firestationStreet)
		{

			this.map 				= map;
			this.positon 			= position;
			this.isPassable 		= isPassable;
			this.ObjectType 		= objectType;
			this.houseStreet 		= houseStreet;
			this.firestationStreet 	= firestationStreet;

		}

		public FieldObject(FieldObject[,] map, Vector position, bool isPassable, String objectType)
		{

			this.map = map;
			this.positon = position;
			this.isPassable = isPassable;
			this.ObjectType = objectType;

		}

        public Vector getNextField()
        {

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


            /*
             * wenn 3 in der liste sind dan gibt es eine 
             * warscheinlich keit von 10 % das eine  kreutzung entsteht. 
             * 
             *  dan  machst du das so das du dir  2 listen erstelst. Die Erste Nennstst du Aktuellerunde
             *  und die andere NächsteRunde oder so ähnlich egal.  bei der ersten  liste sind jetzt die ersten 3 in der warte schleife sie gehen eine
             *  forech schleife durch und  wen du mit der 1 straße durch bist speicherst du die nächste straße in der anderen liste  und nach den ende der forechschleife  löscht
             *  du die aktuelle runde  und kopierst die liste NächsteRunde in Aktuellerunde  und löscht die Nächsterunde  und so bis 1/5 der Map  mit straße ist. 
             *  am besten machst du es auserhalb die forech schleife ich zeiges dir  unter 1.1  MainWindow.cs 
             * */


            Random rnd = new Random();
            int randomField = rnd.Next(0, posibleFields.Count);





            return posibleFields[randomField];

        }


        public Vector checkTop()
        {
            int x = this.positon.getPositonX();
            int y = this.positon.getPositonY() - 1;

            if (x > 0 && this.map[x, y] == null)
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

            if (y < this.map.GetLength(1) && this.map[x, y] == null)
                return new Vector(x, y);

            return null;

        }

        public Vector checkBottom()
        {

            int x = this.positon.getPositonX();
            int y = this.positon.getPositonY() + 1;

            if (y < this.map.GetLength(0) && this.map[x, y] == null)
                return new Vector(x, y);

            return null;

        }

    }
}
