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

namespace OmaCarHarjoitus
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

        private void button_Click(object sender, RoutedEventArgs e)
        {
            Car myCar = new Car();
            Car chevy = new Car();

            int maxSpeed = int.Parse(maxSpeedTextBox.Text);
            myCar.Color = "Grey";
            myCar.MaxSpeed = maxSpeed;
          //  MessageBox.Show("Huippunopeus asetettu ominaisuuden kautta");
            myCar.Model = "Corolla";
            myCar.StartEngine();
            ShowCarInfo(myCar);

            chevy.Color = "Red";
           chevy.MaxSpeed = 300;
            chevy.Model = "Corvette";
            chevy.StartEngine();
            ShowCarInfo(chevy);

            MessageBox.Show(chevy.ToString());

        }

        public void ShowCarInfo(Car c)
        {
            string message = "Model: " + c.Model + "\r\n" + "Color: " + c.Color + "\r\n" + "Max speed: " 
                + c.MaxSpeed;
            MessageBox.Show(message);
        }

    }
}
