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
    /// <summary>
    /// Interaktionslogik für MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void startClick(object sender, RoutedEventArgs e)
        {
            const int MAPSIZEX = 10;
            const int MAPSIZEY = 10;

			FieldObject[,] map 		= new FieldObject[MAPSIZEX, MAPSIZEY];
			Vector vector;

			int streetFieldAmount = MAPSIZEX * MAPSIZEY / 5; //amount of streefields

			//create position of the firestation
            Random rnd = new Random();
            int x = rnd.Next(0, MAPSIZEX);
            int y = rnd.Next(0, MAPSIZEY);
			vector = new Vector (x, y);

			Firestation fireStation = new Firestation(map, vector);
            map[x, y] = fireStation;
            fireStation.map = map;

			//first streetposition
			vector = fireStation.getNextField();
			Street street = new Street (map, vector);
			map [vector.getPositonX, vector.getPositonY] = street;

            for (int i = 0; i < streetFieldAmount - 1; i++)
            {

				vector = street.getNextField ();
				street = new Street (map, vector);
				map [vector.getPositonX, vector.getPositonY] = street;
				street.map = map;

            }
            //forechschleife----------


            // river hinzufügen  

            //river -------------


            //Tree hinzufügen 

            //Tree --------------


            //Ausgeben map

            CreateMap.Print(CanvasMap);

            //ausgeben map ---------



        }

        private void brandClick(object sender, RoutedEventArgs e)
        {
            // haus in ein brenendes haus änderen

            SetHouse.ToBurninghouse(CanvasMap);

            /*
             * Man muss noch die zeit aufnähmen wie lang das haus brend  
             * wenn der brand lenger  als 1 min dauert dan ist das haus verbrand
             * */

            //haus änderen----------------


            //schauen ob genug auts da sind 
            
            FireTruckIsAvailable.look();

            //schauen--------


            //kürzesten weg suchen

            shortestPath.Find();

            //weg suchen -----------


            // feuerwehr auto zum brand

            FireTruckDrive.ToBurningHouse(CanvasMap);

            // zum brand ----------------


            /////////////// 10 sec für den brand zu löschen 


            //brand zu ende haus normal wieder 

            SetHouse.ToNormalHouse(CanvasMap);

            // haus normal --------


            // feuerwehrauto geht zurück zur station

            FireTruckDrive.BackFromBurningHouse(CanvasMap);

            //zurück zur station ----------


            // Einsatz in die daten bank eintragen 

            InsertOperation.Operation();

            // eintragen einsatz


        }

        private void neueStadtClick(object sender, RoutedEventArgs e)
        {

        }

        private void einsätzeAnzeigenClick(object sender, RoutedEventArgs e)
        {
            ShowOperations.All();
        }

        private void programEnde(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }
    }


    
}
