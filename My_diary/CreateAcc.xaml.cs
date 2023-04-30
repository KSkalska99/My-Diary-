using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
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

        private void cr_acc_clear_btn_Click(object sender, RoutedEventArgs e)
        {
            AccCr_log_txtBox.Clear();
            AccCr_log_txtBox.Clear();
            //AccCr_email_txtBox.Clear();
        }
        public static string CorrectEmail()
        {
            string strEMail = "youremail@host.com";
            Regex regx = new Regex(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$");
            Match match = regx.Match(strEMail);
            if (match.Success)
            {
                MessageBox.Show("Your login is correct");
            }
            else
            {
                MessageBox.Show("Your login is not correct");
            }
            return strEMail;

                
        }

    }
}
