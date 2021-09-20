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

namespace Week4Lab1
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

        private void PigLatinButton_Click(object sender, RoutedEventArgs e)
        {
            string first_name = FirstNameTextBox.Text.ToLower();
            string last_name = LastNameTextBox.Text.ToLower();
            string pig_first = first_name.Substring(1, 1).ToUpper() + first_name.Substring(2) + first_name.Substring(0, 1) + "ay";
            string pig_last = last_name.Substring(1, 1).ToUpper() + last_name.Substring(2) + last_name.Substring(0, 1) + "ay";

            MessageBox.Show("Your name in Pig Latin is: " + pig_first + " " + pig_last);
        }

    }
}
