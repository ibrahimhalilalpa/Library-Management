using LibraryProject.Classes;
using LibraryProject.Classes.Parameters;
using System;
using System.Collections.Generic;
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
    /// Interaction logic for winEscrowBook.xaml
    /// </summary>
    public partial class winEscrowBook : Window
    {
        public winEscrowBook()
        {
            InitializeComponent();
            fill_comboName();
            fill_comboBook();
        }


        private void btn_EscrowBookCancel_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }


        //Transferring data from database to ComboBox
        string sqliteConString = DBconnection.DBaddress;

        //Source: https://www.youtube.com/watch?v=TnKY_8UIul4
        void fill_comboName()
        {
            SQLiteConnection sqliteCon = new SQLiteConnection(sqliteConString);

            try
            {
                sqliteCon.Open();
                string Query = "select * from tbl_Users";
                SQLiteCommand createCommand = new SQLiteCommand(Query, sqliteCon);
                SQLiteDataReader dr = createCommand.ExecuteReader();
                while (dr.Read())
                {
                    int ReaderId = dr.GetInt32(0);
                    string NameSurname = dr.GetString(1);
                    cmb_EscrowUserNameSurname.SelectedValuePath = "Key";
                    cmb_EscrowUserNameSurname.DisplayMemberPath = "Value";
                    cmb_EscrowUserNameSurname.Items.Add(new KeyValuePair<int, string>(ReaderId, NameSurname));
                    //cmb_EscrowUserNameSurname.Items.Add(NameSurname);
                }
                sqliteCon.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        void fill_comboBook()
        {
            SQLiteConnection sqliteCon = new SQLiteConnection(sqliteConString);

            try
            {
                sqliteCon.Open();
                string Query = "select * from tbl_BookList";
                SQLiteCommand createCommand = new SQLiteCommand(Query, sqliteCon);
                SQLiteDataReader dr = createCommand.ExecuteReader();
                while (dr.Read())
                {
                    int BookId = dr.GetInt32(0);
                    string BookName = dr.GetString(2);
                    cmb_EscrowBook.SelectedValuePath = "Key";
                    cmb_EscrowBook.DisplayMemberPath = "Value";
                    cmb_EscrowBook.Items.Add(new KeyValuePair<int, string>(BookId, BookName));
                }
                sqliteCon.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }



        private void Grid_Loaded(object sender, RoutedEventArgs e)
        {

        }

        public void Clear()
        {
            dp_EscrowDate.Text = "";
            dp_ReturnDate.Text = "";
            cmb_EscrowBook.Text = "";
            cmb_EscrowUserNameSurname.Text = "";
        }

        // Adding Escrow Book
        private void btn_addEscrowBook_MouseDown(object sender, MouseButtonEventArgs e)
        {
            Escrow escrow = new Escrow(); 
            escrow.EscrowDate = dp_EscrowDate.Text;
            escrow.ReturnDate = dp_ReturnDate.Text;
            escrow.ReaderID =Convert.ToInt32(cmb_EscrowUserNameSurname.SelectedValue.ToString());
            escrow.BookID = Convert.ToInt32(cmb_EscrowBook.SelectedValue.ToString());

            if (DBprocessor.addEscrow(escrow))
            {
            MessageBox.Show("Registration completed.");
            Clear();
            }
            else
            {
            MessageBox.Show("An error occurred during registration.");
            }

        }
    }
}
