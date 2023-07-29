using LibraryProject.Classes;
using LibraryProject.Classes.Parameters;
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

namespace LibraryProject
{
    /// <summary>
    /// Interaction logic for winAddBook.xaml
    /// </summary>
    public partial class winAddBook : Window
    {

        public winAddBook()
        {
            InitializeComponent();
        }
        //Character restriction for TextBox
        #region 
        //With this line of code, only number characters can be entered into text Boxes.Other characters can't write.
        //Source: http://cuneytbayrak.com/?p=15
        private void txt_printing_number_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            if (!char.IsDigit(e.Text, e.Text.Length - 1))
            {
                e.Handled = true;
            }
        }
        private void txt_page_number_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            if (!char.IsDigit(e.Text, e.Text.Length - 1))
            {
                e.Handled = true;
            }
        }
        private void txt_stock_number_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            if (!char.IsDigit(e.Text, e.Text.Length - 1))
            {
                e.Handled = true;
            }
        }
        #endregion

        //Small buttons in the add window
        #region 
        private void btn_BookAddCancel_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        #endregion

        void clean()
        {
            txt_Barcode.Text = "";
            txt_BookName.Text = "";
            txt_Author.Text = "";
            cmb_BookType.Text = "";
            txt_Author.Text = "";
            cmb_BookType.Text = "";
            txt_subject_of_book.Text = ""; ;
            txt_page_number.Text = "";
            txt_subject_of_book.Text = "";
            cmb_BookLanguage.Text = "";
            txt_stock_number.Text = "";
            dp_PrintingDate.Text = "";
            txt_Publisher.Text = "";
            txt_State.Text = "";
            txt_EscrowBook.Text = "";
            txt_printing_number.Text = "";
        }


        //Adding Book
        private void btn_addBook_MouseDown(object sender, MouseButtonEventArgs e)
        {

            if (txt_BookName.Text != "" && cmb_BookType.Text != "")
            {
                Books data = new Books();
                data.Barcode = txt_Barcode.Text;
                data.BookName = txt_BookName.Text;
                data.Author = txt_Author.Text;
                data.BookType = cmb_BookType.Text;
                data.SubjectOfBook = txt_subject_of_book.Text;
                data.PageNumber = txt_page_number.Text;
                data.SubjectOfBook = txt_subject_of_book.Text;
                data.LanguageOfBook = cmb_BookLanguage.Text;
                data.AmountOfStock = txt_stock_number.Text;
                data.PrintingDate = dp_PrintingDate.Text;
                data.Publisher = txt_Publisher.Text;
                if (txt_State.Text == "1")
                {
                    data.State = Convert.ToInt32(txt_State.Text);
                }

                if (txt_EscrowBook.Text == "1")
                {
                    data.EscrowStatus = Convert.ToInt32(txt_EscrowBook.Text);
                }


                if (DBprocessor.addBook(data))
                {
                    MessageBox.Show("Registration completed.");
                   clean();
                }
                else
                {
                    MessageBox.Show("An error occurred during registration!");
                }
            }
            else
            {
                MessageBox.Show("Fill in the required fields! \nBook Name or Book Type");
            }
        }
        private void CB_State_Checked(object sender, RoutedEventArgs e)
        {
            txt_State.Text = "1";
        }

        private void CB_Escrow_Checked(object sender, RoutedEventArgs e)
        {
            txt_EscrowBook.Text = "1";
        }




        private void Grid_Loaded(object sender, RoutedEventArgs e)
        {
            //var d = txt_Barcode.Text;
            //MessageBox.Show(d);
            //var myValue = ((Button)sender).CommandParameter.ToString();
            //MessageBox.Show(myValue != null ? myValue : "yok");
        }

    }
}
