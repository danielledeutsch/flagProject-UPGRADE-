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
using System.Windows.Media.Effects;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace flagProject
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
     
        private void countryBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            ComboBoxItem selectedItem= this.countryBox.SelectedItem as ComboBoxItem;
            switch (selectedItem.Content .ToString ( ).ToLower ())
            {
                case "italy":
                    this.rec1.Fill = new SolidColorBrush(Colors.Green);
                    this.rec2.Fill = new SolidColorBrush(Colors.White );
                    this.rec3.Fill = new SolidColorBrush(Colors.Red );
                    this.rec4.Fill = new SolidColorBrush(Colors.Green);
                    this.rec5.Fill = new SolidColorBrush(Colors.White);
                    this.rec6.Fill = new SolidColorBrush(Colors.Red );
                    this.rec7.Fill = new SolidColorBrush(Colors.Green);
                    this.rec8.Fill = new SolidColorBrush(Colors.White );
                    this.rec9.Fill = new SolidColorBrush(Colors.Red);
                    break;

                case "germany":
                    this.rec1.Fill = new SolidColorBrush(Colors.Black );
                    this.rec2.Fill = new SolidColorBrush(Colors.Black );
                    this.rec3.Fill = new SolidColorBrush(Colors.Black );
                    this.rec4.Fill = new SolidColorBrush(Colors.Red );
                    this.rec5.Fill = new SolidColorBrush(Colors.Red );
                    this.rec6.Fill = new SolidColorBrush(Colors.Red);
                    this.rec7.Fill = new SolidColorBrush(Colors.Yellow );
                    this.rec8.Fill = new SolidColorBrush(Colors.Yellow);
                    this.rec9.Fill = new SolidColorBrush(Colors.Yellow );
                    break;

                case "france":
                    this.rec1.Fill = new SolidColorBrush(Colors.Blue );
                    this.rec2.Fill = new SolidColorBrush(Colors.White);
                    this.rec3.Fill = new SolidColorBrush(Colors.Red);
                    this.rec4.Fill = new SolidColorBrush(Colors.Blue);
                    this.rec5.Fill = new SolidColorBrush(Colors.White);
                    this.rec6.Fill = new SolidColorBrush(Colors.Red);
                    this.rec7.Fill = new SolidColorBrush(Colors.Blue);
                    this.rec8.Fill = new SolidColorBrush(Colors.White);
                    this.rec9.Fill = new SolidColorBrush(Colors.Red);
                    break;

                case "belgium":
                    this.rec1.Fill = new SolidColorBrush(Colors.Black );
                    this.rec2.Fill = new SolidColorBrush(Colors.Yellow);
                    this.rec3.Fill = new SolidColorBrush(Colors.Red);
                    this.rec4.Fill = new SolidColorBrush(Colors.Black );
                    this.rec5.Fill = new SolidColorBrush(Colors.Yellow);
                    this.rec6.Fill = new SolidColorBrush(Colors.Red);
                    this.rec7.Fill = new SolidColorBrush(Colors.Black);
                    this.rec8.Fill = new SolidColorBrush(Colors.Yellow);
                    this.rec9.Fill = new SolidColorBrush(Colors.Red);
                    break;

                case "austria":
                    this.rec1.Fill = new SolidColorBrush(Colors.Red);
                    this.rec2.Fill = new SolidColorBrush(Colors.Red );
                    this.rec3.Fill = new SolidColorBrush(Colors.Red);
                    this.rec4.Fill = new SolidColorBrush(Colors.White);
                    this.rec5.Fill = new SolidColorBrush(Colors.White);
                    this.rec6.Fill = new SolidColorBrush(Colors.White);
                    this.rec7.Fill = new SolidColorBrush(Colors.Red);
                    this.rec8.Fill = new SolidColorBrush(Colors.Red);
                    this.rec9.Fill = new SolidColorBrush(Colors.Red);
                    break;

            }
        }
    }
}
