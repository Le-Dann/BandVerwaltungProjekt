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


namespace wndNewBand
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class NewBand : Window
    {
       internal bool noexception = false;//checks if an exception was found before creating a new band object
        internal Band band = new Band();
        public NewBand()
        {
            InitializeComponent();
        
        }

        /// <summary>
        /// Adds new band object to the band list, closes after completion
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        internal void butOK_Click(object sender, RoutedEventArgs e)
        {
            string bandname = tbBandName.Text;
            band.Name = bandname;

             try
             {
                int albumcount = Convert.ToInt32(tbAnzahlAlben.Text);
                band.AnzahlAlben = albumcount;
                band.GetRating();
                noexception = true;
             }
             catch (NegativeNumberExcpetion ex)
             {
                 MessageBox.Show(ex.Message);
                noexception = false;

            }
             catch(Exception ex)
             {
                 MessageBox.Show(ex.Message);
                noexception = false;
            }

             try
             {
                int membercount = Convert.ToInt32(tbAnzahlMitglieder.Text);
                band.AnzahlMitglieder = membercount;
                noexception = true;
            }
             catch (NegativeNumberExcpetion ex)
             {
                 MessageBox.Show(ex.Message);
                noexception = false;

            }
             catch (Exception ex)
             {
                 MessageBox.Show(ex.Message);
                 noexception = false;
             }

            Main_Window main = new Main_Window();

            if (noexception == true)
            {


                 main.bands.Add(band);
                 
                
                
                   main.BandList.Items.Add(band);
                
            }

            
           


            this.Close();

        }

        /// <summary>
        /// Cancel button closes window without adding new band object to the list
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void butAbbrechen_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
