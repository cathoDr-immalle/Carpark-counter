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
using System.Windows.Threading;

namespace WpfApp1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private int carCounter = 0;

        public MainWindow()
        {
            InitializeComponent();
           
        }

        private void ButtonEntre_Click(object sender, RoutedEventArgs e)
        {
            int vol = 20;
            carCounter = carCounter + 1;
            

            if (carCounter > vol)
            {
                MessageBox.Show("The car park is full", "No space", MessageBoxButton.OK, MessageBoxImage.Error);
            }
            else
            {
                LabelCounter.Content = Convert.ToString(carCounter);
            }
        }

        private void ButtonLeave_Click(object sender, RoutedEventArgs e)
        {
            int leeg = 0;
            carCounter = carCounter - 1;


            if (carCounter < leeg)
            {
                MessageBox.Show("The car park is empty, there are no cars who can leave annymore!", "No cars", MessageBoxButton.OK, MessageBoxImage.Error);
            }
            else
            {
                LabelCounter.Content = Convert.ToString(carCounter);
            }
        }
    }   
}
