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

namespace TempertureConventer
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void BtnConvert_Click(object sender, RoutedEventArgs e)
        {
            // Values
            double inputCelsius;
            double inputFahreneit;
            double ConvertCtoF;
            double ConvertFtoC;
            // Values

            //User Input 
            double.TryParse(txtCelsuisInput.Text, out inputCelsius);

            double.TryParse(txtFahrenheitInput.Text, out inputFahreneit);
            //User Input

            // Conversation
            ConvertCtoF = ((inputCelsius * 9)/5) + 32;
            //MessageBox.Show(ConvertCtoF.ToString());

            ConvertFtoC = ((inputFahreneit - 32) * 5)/9;
            //MessageBox.Show(ConvertFtoC.ToString());
            // Conversation

            // Output titles visibility
            lblCelsuisTitleOutput.Visibility = Visibility.Visible;

            lblFahrenheitInputTitle.Visibility = Visibility.Visible;
            // Output titles visibility

            //Output tempertures
            lblCelsuisOutput.Content = ConvertCtoF.ToString("#.0") + " F";

            lblFahrenheitOutput.Content = ConvertFtoC.ToString("#.0") + " C";
            //Output tempertures








        }
    }
}
