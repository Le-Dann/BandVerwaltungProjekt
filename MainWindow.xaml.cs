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
using System.Windows.Shapes;

namespace wndNewBand
{
    /// <summary>
    /// Interaction logic for Main_Window.xaml
    /// </summary>
    public partial class Main_Window : Window
    {
        internal List<Band> bands = new List<Band>();
        public Main_Window()
        { 
            InitializeComponent();
        }

        /// <summary>
        /// Data Grid loads with default objects in band list
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DataGrid_Loaded(object sender, RoutedEventArgs e)
        {
            Band acapella = new Band("Acapella", 4, 10);
            Band backstreet = new Band("Backstreet Boys", 4,15);
            Band Genesis = new Band("Genesis", 3, 20);
            Band take = new Band("Take That", 4, 30);
            bands.Add(acapella);
            bands.Add(backstreet);
            bands.Add(Genesis);
            bands.Add(take);


            foreach (var item in bands)
            {
                BandList.Items.Add(item);
            }

        }

    
        

            


        /// <summary>
        /// Inserts new band object created in band list into the data grid
        /// </summary>
        /// <remarks>New band object created in separate child window</remarks><see cref="NewBand"/>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        internal void butHinzufügen_Click(object sender, RoutedEventArgs e)
        {
         
            NewBand objwndnew = new NewBand();
            objwndnew.Owner = this;

            objwndnew.ShowDialog();// Opens a NewBand window. 

            if (objwndnew.noexception == true)
            {
                BandList.Items.Add(objwndnew.band);//BandList refers to the name of the Data grid
            }
           
           
        }

        /// <summary>
        /// Shuts down the entire programm 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void butSchliessen_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }

        private void butDelete_Click(object sender, RoutedEventArgs e)
        {
            
                BandList.Items.Remove(BandList.SelectedItem);
            
        }
    }
}