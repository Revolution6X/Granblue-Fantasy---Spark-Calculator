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
        public int draws = 0;
        public int draws10 = 0;
        public string total = "";

        //hold the verficaiton value of the 3 text field
        public bool checkCrystals = true;
        public bool checkDraws = true;
        public bool check10Draws = true;

        public MainWindow()
        {
            InitializeComponent();
            //resets warning to blank
            CrystalsWarning.Content = "";
            DrawsWarning.Content = "";
            Draws10Warning.Content = "";
        }

        /***************************************/
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
                //set crystals to 0
                crystals = 0;
                checkCrystals = true;
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
            if ((checkCrystals) && (checkDraws) && (check10Draws))
            {
                //total draws calculation
                total = "Total draws: " + (crystals / 300 + draws + draws10*10).ToString();
                NumberOfTotalDraws.Content = total;
            }
            //if not, reset text to default
            else
            {
                NumberOfTotalDraws.Content = "Total draws: ";
            }
        }

        /***************************************/
        //Number of draws text change instance
        /***************************************/
        private void NumberOfDraws_TextChanged(object sender, TextChangedEventArgs e)
        {
            checkDraws = false;
            int tempInt = 0;
            //if text is empty
            if (NumberOfDraws.Text == "")
            {
                NumberOfTotalDraws.Content = "Total draws: ";
                DrawsWarning.Content = "";
                //set draws to 0
                draws = 0;
                checkDraws = true;
            }
            //if not
            else
            {
                //check if stirng is an int
                if (int.TryParse(NumberOfDraws.Text, out tempInt))
                {
                    //if int is between 0 and 100,000
                    if ((tempInt >= 0) && (tempInt <= 100000))
                    {
                        draws = tempInt;
                        DrawsWarning.Content = "";
                        checkDraws = true;
                    }
                    //if outside of bounds, display error
                    else
                    {
                        DrawsWarning.Content = "Invalid # of draws! (0 to 100,000)";
                    }


                }
                //else, show warning that input is not a string
                else
                {
                    DrawsWarning.Content = "Must be an integer!";
                }
            }

            //if all 3 checks are true, update total draw count
            if ((checkCrystals) && (checkDraws) && (check10Draws))
            {
                //total draws calculation
                total = "Total draws: " + (crystals / 300 + draws + draws10 * 10).ToString();
                NumberOfTotalDraws.Content = total;
            }
            //if not, reset text to default
            else
            {
                NumberOfTotalDraws.Content = "Total draws: ";
            }
        }

        /***************************************/
        //Number of 10-draws text change instance
        /***************************************/
        private void NumberOf10Draws_TextChanged(object sender, TextChangedEventArgs e)
        {
            check10Draws = false;
            int tempInt = 0;
            //if text is empty
            if (NumberOf10Draws.Text == "")
            {
                NumberOfTotalDraws.Content = "Total draws: ";
                Draws10Warning.Content = "";
                //set 10-draws to 0
                draws10 = 0;
                check10Draws = true;
            }
            //if not
            else
            {
                //check if stirng is an int
                if (int.TryParse(NumberOf10Draws.Text, out tempInt))
                {
                    //if int is between 0 and 1000
                    if ((tempInt >= 0) && (tempInt <= 1000))
                    {
                        draws10 = tempInt;
                        Draws10Warning.Content = "";
                        check10Draws = true;
                    }
                    //if outside of bounds, display error
                    else
                    {
                        Draws10Warning.Content = "Invalid # of draws! (0 to 1,000)";
                    }


                }
                //else, show warning that input is not a string
                else
                {
                    Draws10Warning.Content = "Must be an integer!";
                }
            }

            //if all 3 checks are true, update total draw count
            if ((checkCrystals) && (checkDraws) && (check10Draws))
            {
                //total draws calculation
                total = "Total draws: " + (crystals / 300 + draws + draws10 * 10).ToString();
                NumberOfTotalDraws.Content = total;
            }
            //if not, reset text to default
            else
            {
                NumberOfTotalDraws.Content = "Total draws: ";
            }
        }
    }
}
