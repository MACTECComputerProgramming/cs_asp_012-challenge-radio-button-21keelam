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

namespace CS_ASP_012
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

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            labelAnswer.Content = " ";

            if (pencilRadioButton.IsChecked == true)
            {
                labelAnswer.Content = " Oldy but a goody.";
            }

            else if (pinRadioButton.IsChecked == true)
            {
                labelAnswer.Content = " College ready?";
            }

            else if (phoneRadioButton.IsChecked == true)
            {
                labelAnswer.Content = " It's new but gets the job done.";
            }

            else if (padRadioButton.IsChecked == true)
            {
                labelAnswer.Content = " Welcome to 2020!";
            }
        }
    }
}
