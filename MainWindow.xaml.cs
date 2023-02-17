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

namespace Granblue_Fantasy___Spark_Calculator
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        //holds the 3 text field values for calculation
        public int crystals = 0;
        public int draw = 0;
        public int draw10 = 0;
        public string total = "";

        //hold the verficaiton value of the 3 text field
        public bool checkCrystals = false;
        public bool checkDraws = false;
        public bool check10Draws = false;

        public MainWindow()
        {
            InitializeComponent();
        }

        //Number of crystals text change instance
        /***************************************/
        private void NumberOfCrystals_TextChanged(object sender, TextChangedEventArgs e)
        {
            checkCrystals = false;
            int tempInt = 0;
            //if text is empty
            if (NumberOfCrystals.Text == "")
            {
                NumberOfTotalDraws.Content = "Total draws: ";
                CrystalsWarning.Content = "";
            }
            //if not
            else
            {
                //check if stirng is an int
                if (int.TryParse(NumberOfCrystals.Text, out tempInt))
                {
                    //if int is between 0 and 10 million
                    if ((tempInt >= 0) && (tempInt <= 10000000))
                    {
                        crystals = tempInt;
                        CrystalsWarning.Content = "";
                        checkCrystals = true;
                    }
                    //if outside of bounds, display error
                    else
                    {
                        CrystalsWarning.Content = "Invalid # of crystals! (0 to 10 mil)";
                    }                


                }
                //else, show warning that input is not a string
                else
                {
                    CrystalsWarning.Content = "Must be an integer!";
                }
            }

            //if all 3 checks are true, update total draw count
            if (checkCrystals)
            {
                total = "Total draws: " + (crystals / 300).ToString();
                NumberOfTotalDraws.Content = total;
            }
            else
            {
                NumberOfTotalDraws.Content = "Total draws: ";
            }
        }




        //Number Of Crystals 
    }
}
