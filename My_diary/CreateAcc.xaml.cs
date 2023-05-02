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
            AccCr_pswd_txtBox.Clear();
            AccCr_email_txtBox.Clear();
        }
        public void CorrectEmail()
        {
            var email = AccCr_email_txtBox.Text;

            if (string.IsNullOrWhiteSpace(email))
            {
                MessageBox.Show("Your email is not correct");
            }
            else if (!email.Contains("@"))
            {
                MessageBox.Show("Your email is not correct");
            }
            else if (email.Count(count => count == '.') < 1)
            {
                MessageBox.Show("Your email is not correct");
            }
            else
            {
                MessageBox.Show("Your email is correct");
            }

            //return true;

        }

        public bool IsPasswordValid(string password)
        {
            bool hasUppercaseLetter = false;
            bool hasDigit = false;
            bool hasSpecialCharacter = false;
            bool hasEightChars = password.Length >= 8;

            foreach (char znak in password)
            {
                if (char.IsUpper(znak))
                {
                    hasUppercaseLetter = true;
                }
                else if (char.IsDigit(znak))
                {
                    hasDigit = true;
                }
                else if (char.IsSymbol(znak) || char.IsPunctuation(znak))
                {
                    hasSpecialCharacter = true;
                }
            }


            return hasUppercaseLetter && hasDigit && hasSpecialCharacter && hasEightChars;
        }
        private void ok_cracc_btn_Click(object sender, RoutedEventArgs e)
        {
            string password = AccCr_pswd_txtBox.Text;
            bool isPasswordValid = IsPasswordValid(password);

            if (isPasswordValid)
            {
                MessageBox.Show("Your password is correct");
            }
            else
            {
                MessageBox.Show("Your password is not correct");
            }
            IsPasswordValid(isPasswordValid.ToString());
            if (isPasswordValid != true)
            {
                MessageBox.Show("Your password requires min 8 letters \n with min one uppercase letter, \n " +
                  "one digit and one special character");
            }
            CorrectEmail();
        }
    }
}
