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
using System.Windows.Shapes;

namespace My_diary
{
    /// <summary>
    /// Interaction logic for CreateAcc.xaml
    /// </summary>
    public partial class CreateAcc : Window
    {
        public CreateAcc()
        {
            InitializeComponent();
        }

        private void cancel_log_btn_Click(object sender, RoutedEventArgs e)
        {
            MainWindow objMainWdw = new MainWindow();
            this.Visibility = Visibility.Hidden;
            objMainWdw.Show();
        }
    }
}
