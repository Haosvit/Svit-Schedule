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

namespace Svit_Schedule
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

        private void btn_Click(object sender, RoutedEventArgs e)
        {
            Button btn = (Button)sender;
            string btnName = btn.Name;

            switch (btnName)
            {
                case "mon1":
                    MessageBox.Show(((TextBlock)btn.Content).Text);
                    break;
                case "mon2":
                    MessageBox.Show(((TextBlock)btn.Content).Text);
                    break;
                case "mon3":
                    MessageBox.Show(((TextBlock)btn.Content).Text);
                    break;
                case "sun1":
                    MessageBox.Show("Sunday task");
                    break;
                default:
                    break;
            }
        }

    }
}
