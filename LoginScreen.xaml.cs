using LibraryProject.Classes;
using LibraryProject.Classes.Parameters;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;
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

namespace LibraryProject
{
    /// <summary>
    /// Interaction logic for LoginScreen.xaml
    /// </summary>
    public partial class LoginScreen : Window
    {
        public LoginScreen()
        {
            InitializeComponent();
        }

       SQLiteConnection conSQL = new SQLiteConnection(DBconnection.DBaddress);

        private void btn_SignUp_Click(object sender, RoutedEventArgs e)
        {

            if (txt_PasswordSign.Password == txt_PasswordSign2.Password)
            {
                var UserHashedPassword = DBprocessor.ComputeSha256Hash(txt_PasswordSign.Password);
                User user = new User();
                user.NameSurname = txt_NameSurname.Text;
                user.Password = UserHashedPassword;
                user.Username = txt_UsernameSign.Text;
                user.Email = txt_Email.Text;

                if (DBprocessor.addUser(user))
                {
                    MessageBox.Show("Registration completed.");
                }
                else
                {
                    MessageBox.Show("Error occurred during registration.");
                }
            }
            else { MessageBox.Show("Passwords do not match"); }

        }

        private void btn_login_Click(object sender, RoutedEventArgs e)
        {

            try
            {
                if (conSQL.State == ConnectionState.Closed)

                    conSQL.Open();
                var UserHashedPassword = DBprocessor.ComputeSha256Hash(txt_Password.Password);

                String ask = "Select count(1) from tbl_Users where UserName=@Username AND Password=@Password";
                SQLiteCommand comSQL = new SQLiteCommand(ask, conSQL);
                comSQL.CommandType = CommandType.Text;
                comSQL.Parameters.AddWithValue("@Username", txt_Username.Text);
                comSQL.Parameters.AddWithValue("@Password", UserHashedPassword);
                int count = Convert.ToInt32(comSQL.ExecuteScalar());
                if (count == 1)
                {
                    MainWindow dashboard = new MainWindow();
                    dashboard.Show();
                    this.Close();  
                }
                else
                {
                    MessageBox.Show("Username or password is false");
                    txt_Username.Text = "";
                    txt_Password.Password = "";
                    txt_Username.Focus();
                }
            }
            catch (Exception error404)
            {
                MessageBox.Show(error404.Message);
            }
            finally
            {
                conSQL.Close();
            }
        }

        private void Login_Exit_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}