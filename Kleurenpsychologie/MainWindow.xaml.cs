using System.IO;
using System.Runtime.Intrinsics.X86;
using System;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Kleurenpsychologie
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


        private void RedImage_MouseEnter(object sender, MouseEventArgs e)
        {

            this.Background = new SolidColorBrush(Colors.Red);
        }


        private void YellowImage_MouseEnter(object sender, MouseEventArgs e)
        {

            this.Background = new SolidColorBrush(Colors.Yellow);
        }

        private void GreenImage_MouseEnter(object sender, MouseEventArgs e)
        {

            this.Background = new SolidColorBrush(Colors.Green);
        }
        private void BlueImage_MouseEnter(object sender, MouseEventArgs e)
        {

            this.Background = new SolidColorBrush(Colors.Blue);
        }
        private void RedImage_MouseLeave(object sender, MouseEventArgs e)
        {

            this.Background = new SolidColorBrush(Colors.LightGray);
        }


        private void YellowImage_MouseLeave(object sender, MouseEventArgs e)
        {

            this.Background = new SolidColorBrush(Colors.LightGray);
        }

        private void GreenImage_MouseLeave(object sender, MouseEventArgs e)
        {

            this.Background = new SolidColorBrush(Colors.LightGray);
        }
        private void BlueImage_MouseLeave(object sender, MouseEventArgs e)
        {

            this.Background = new SolidColorBrush(Colors.LightGray);
        }
        private void RedImage_MouseDown(object sender, MouseEventArgs e)
        {
            ColorCode.Text = "#FF0000";
        }

        private void YellowImage_MouseDown(object sender, MouseEventArgs e)
        {
            ColorCode.Text = "#FFFF00";
        }

        private void GreenImage_MouseDown(object sender, MouseEventArgs e)
        {
            ColorCode.Text = "#008000";
        }

        private void BlueImage_MouseDown(object sender, MouseEventArgs e)
        {
            ColorCode.Text = "#0000FF";
        }



    }



}