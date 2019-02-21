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
            
            lblCPU.Visibility = Visibility.Visible;
            lblMem.Visibility = Visibility.Collapsed;
            lblCase.Visibility = Visibility.Collapsed;
            lblMtb.Visibility = Visibility.Collapsed;
            lblGrC.Visibility = Visibility.Collapsed;
            lblOpd.Visibility = Visibility.Collapsed;
            lblStg.Visibility = Visibility.Collapsed;
            lblMem.Visibility = Visibility.Collapsed;

        }

        private void btnMotherboard_Click(object sender, RoutedEventArgs e)
        {
           
            lblMtb.Visibility = Visibility.Visible;
            lblMem.Visibility = Visibility.Collapsed;
            lblCase.Visibility = Visibility.Collapsed;
            lblGrC.Visibility = Visibility.Collapsed;
            lblOpd.Visibility = Visibility.Collapsed;
            lblStg.Visibility = Visibility.Collapsed;
            lblCPU.Visibility = Visibility.Collapsed;
            lblMem.Visibility = Visibility.Collapsed;
        }

        private void btnStorage_Click(object sender, RoutedEventArgs e)
        {
      
            lblStg.Visibility = Visibility.Visible;
            lblMem.Visibility = Visibility.Collapsed;
            lblCase.Visibility = Visibility.Collapsed;
            lblMtb.Visibility = Visibility.Collapsed;
            lblGrC.Visibility = Visibility.Collapsed;
            lblOpd.Visibility = Visibility.Collapsed;
            lblCPU.Visibility = Visibility.Collapsed;
            lblMem.Visibility = Visibility.Collapsed;
        }

        private void btnCase_Click(object sender, RoutedEventArgs e)
        {
            lblCase.Visibility = Visibility.Visible;
            lblMem.Visibility = Visibility.Collapsed;
            lblMtb.Visibility = Visibility.Collapsed;
            lblGrC.Visibility = Visibility.Collapsed;
            lblOpd.Visibility = Visibility.Collapsed;
            lblStg.Visibility = Visibility.Collapsed;
            lblCPU.Visibility = Visibility.Collapsed;
            lblMem.Visibility = Visibility.Collapsed;
        }

        private void btnGraphicCard_Click(object sender, RoutedEventArgs e)
        {
            
            lblGrC.Visibility = Visibility.Visible;
            lblMem.Visibility = Visibility.Collapsed;
            lblCase.Visibility = Visibility.Collapsed;
            lblMtb.Visibility = Visibility.Collapsed;
            lblOpd.Visibility = Visibility.Collapsed;
            lblStg.Visibility = Visibility.Collapsed;
            lblCPU.Visibility = Visibility.Collapsed;
            lblMem.Visibility = Visibility.Collapsed;
        }

        private void btnOpticalDrive_Click(object sender, RoutedEventArgs e)
        {
            lblOpd.Visibility = Visibility.Visible;
            lblMem.Visibility = Visibility.Collapsed;
            lblCase.Visibility = Visibility.Collapsed;
            lblMtb.Visibility = Visibility.Collapsed;
            lblGrC.Visibility = Visibility.Collapsed;
            lblStg.Visibility = Visibility.Collapsed;
            lblCPU.Visibility = Visibility.Collapsed;
            lblMem.Visibility = Visibility.Collapsed;
        }

        private void btnMemory_Click(object sender, RoutedEventArgs e)
        {
            lblMem.Visibility = Visibility.Visible;
            lblCase.Visibility = Visibility.Collapsed;
            lblMtb.Visibility = Visibility.Collapsed;
            lblGrC.Visibility = Visibility.Collapsed;
            lblOpd.Visibility = Visibility.Collapsed;
            lblStg.Visibility = Visibility.Collapsed;
            lblCPU.Visibility = Visibility.Collapsed;
        }
    }
}
