/*Andrea Bonafini
 *Feb 15,2019
 *New computer projet for McT
*/
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

namespace New_Computer_Project
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            MessageBox.Show("welcome  to my list of component for the new computer","hello");
            Console.WriteLine("The main window is Initialized");
        }

        private void btnCPU_Click(object sender, RoutedEventArgs e)
        {
            string name = txtName.Text;
            message.Content = "this cpu";
        }

        private void btnMotherboard_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btnStorage_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btnCase_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btnGraphicCard_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btnOpticalDrive_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btnMemory_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
