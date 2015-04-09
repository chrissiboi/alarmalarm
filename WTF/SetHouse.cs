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
    class SetHouse
    {

        public static void ToBurninghouse(Canvas CanvasMap)
        {
            // alle normal häuser finden und in  haus normal array rein 
            int[] hausnormal;
            Random rnd = new Random();
            int brand = rnd.Next(0, 1);
            int brenendeshaus;
            int zähler = 1;
            int top = 1;
            int left = 1;



            //brenendeshaus = hausnormal[brand];

            // hausobj und/oder straße st daneben isnormal auf false setzen  

            //wichtigen code schreiben 



            //Ausgabe  des brenen den hauses 

            for (int x = 0; x < 10; x++)
            {
                for (int y = 0; y < 10; y++)
                {

                    Rectangle rectangle = new Rectangle();

                    if (true)//brenendeshaus == zähler)
                    {
                        rectangle.Fill = new SolidColorBrush(Colors.Red);


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
            }

        }


        public static void ToNormalHouse(Canvas CanvasMap)
        {
            // Brendes haus nähmen  
            //haus in isnormal true ändern

            Rectangle rectangle = new Rectangle();
            
            int brenendeshaus;
            int zähler = 1;
            int top = 1;
            int left = 1;

            for (int x = 0; x < 10; x++)
            {
                for (int y = 0; y < 10; y++)
                {

                    if (true)//brenendeshaus == zähler)
                    {
                        rectangle.Fill = new SolidColorBrush(Colors.White);
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
            }
        }

    }
}
