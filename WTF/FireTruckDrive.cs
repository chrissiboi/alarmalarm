using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WTF
{
    class FireTruckDrive
    {

        public static void ToBurningHouse(Canvas CanvasMap)
        {
            // mit die kürzeste strecke und  gibt sie dan wider aus  


            List<object> kürzesterweg;
            int zähler = 1;
            int top = 1;
            int left = 1;


            // forech  list  kürzesterweg  

            for (int x = 0; x < 10; x++)
            {
                for (int y = 0; y < 10; y++)
                {

                    Rectangle rectangle = new Rectangle();

                    if ((x == x) && y == y)
                    {
                        rectangle.Fill = new SolidColorBrush(Colors.DarkRed);


                        rectangle.Stroke = new SolidColorBrush(Colors.Black);
                        rectangle.Width = 50;
                        rectangle.Height = 50;
                        rectangle.SetValue(Canvas.LeftProperty, (double)left);
                        rectangle.SetValue(Canvas.TopProperty, (double)top);

                        CanvasMap.Children.Add(rectangle);

                    }

                    //-------------------------------------------

                    left = left + 50;
                    zähler = zähler + 1;
                }
                //-----------------------------------------------
                top = top + 50;
                left = 1;

                //slepp(3000);



            }
        }

        public static void BackFromBurningHouse(Canvas CanvasMap)
        {
            // und den selben weg wieder zurück  blos  mit einer quoue

            // mit die kürzeste strecke und  gibt sie dan wider aus  


            Queue<object> kürzesterweg;
            int zähler = 1;
            int top = 1;
            int left = 1;


            // forech  Queue  kürzesterweg  

            for (int x = 0; x < 10; x++)
            {
                for (int y = 0; y < 10; y++)
                {

                    Rectangle rectangle = new Rectangle();

                    if ((x == x) && y == y)
                    {
                        rectangle.Fill = new SolidColorBrush(Colors.DarkRed);


                        rectangle.Stroke = new SolidColorBrush(Colors.Black);
                        rectangle.Width = 50;
                        rectangle.Height = 50;
                        rectangle.SetValue(Canvas.LeftProperty, (double)left);
                        rectangle.SetValue(Canvas.TopProperty, (double)top);

                        CanvasMap.Children.Add(rectangle);

                    }

                    //-------------------------------------------

                    left = left + 50;
                    zähler = zähler + 1;
                }
                //-----------------------------------------------
                top = top + 50;
                left = 1;

                //slepp(3000);



            }


        }

    }
}
