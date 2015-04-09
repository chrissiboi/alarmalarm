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
    class CreateMap
    {


      

            public static void Print(Canvas CanvasMap)
            {
               // int[,] Map = 0 - 99 Muss man noch füllen  mit objekttyp ;
                int left = 1;
                int top = 1;

               
                for (int x = 0; x < 10; x++)
                {
                    for (int y = 0; y < 10; y++)
                    {

                        Rectangle rectangle = new Rectangle();

                        if (map[x, y] == "streat")
                        {
                            rectangle.Fill = new SolidColorBrush(Colors.Gray);
                        }

                        if (map[x, y] == "house")
                        {
                            rectangle.Fill = new SolidColorBrush(Colors.White);
                        }

                        if (map[x, y] == "tree")
                        {
                            rectangle.Fill = new SolidColorBrush(Colors.Green);
                        }

                        if (map[x, y] == "firestation")
                        {
                            rectangle.Fill = new SolidColorBrush(Colors.IndianRed);
                        }

                        if (map[x, y] == "river")
                        {
                            rectangle.Fill = new SolidColorBrush(Colors.Blue);
                        }




                        rectangle.Stroke = new SolidColorBrush(Colors.Black);
                        rectangle.Width = 50;
                        rectangle.Height = 50;
                        rectangle.SetValue(Canvas.LeftProperty, (double)left);
                        rectangle.SetValue(Canvas.TopProperty, (double)top);
                     
                        CanvasMap.Children.Add(rectangle);


                        //-------------------------------------------

                        left = left + 50;

                    }
                    //-----------------------------------------------
                    top = top + 50;
                    left = 1;
                }
            }

        }

    }

