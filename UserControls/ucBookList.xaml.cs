using LibraryProject.Classes;
using Microsoft.Data.Sqlite;
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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace LibraryProject.UserControls
{
    /// <summary>
    /// Interaction logic for ucBookList.xaml
    /// </summary>
    public partial class ucBookList : UserControl
    {
        public ucBookList()
        {
            InitializeComponent();
        }
        private void UserControl_Loaded(object sender, RoutedEventArgs e)
        {
            DBprocessor.GridFillInBookList(dtg_BookList);
            GetBookCount();
        }


        public void GetBookCount()
        {
            var bookCount = dtg_BookList.Items.Count.ToString();

            if (bookCount != null)
            {
                lb_BookCount.Content = "Book Count : " + bookCount;
            }
            else
            {
                lb_BookCount.Content = "No Registration";
            }
        }



        //ucBookList Buttons
        #region  

        ///Book Adding
        private void btn_AddBook_Click(object sender, RoutedEventArgs e)
        {
            winAddBook addBook = new winAddBook();
            addBook.ShowDialog();
        }


        ///Book Deletion
        private void btn_DeleteBook_Click(object sender, RoutedEventArgs e)
        {
            DataRowView drv = (DataRowView)dtg_BookList.SelectedItem;
            if (drv != null)
            {
                int id = Convert.ToInt32(drv[0].ToString());
                string dtgBook = drv[2].ToString();

                if (MessageBox.Show("Are you sure you want to delete " + dtgBook + " ? ", "Warning", MessageBoxButton.YesNo, MessageBoxImage.Warning) == MessageBoxResult.Yes)
                {

                    if (DBprocessor.DeleteBookById(id))
                    {
                        MessageBox.Show("Registered data has been deleted.");
                        DBprocessor.GridFillInBookList(dtg_BookList);
                        GetBookCount();
                    };
                }

            }
            else
            {

                MessageBox.Show("Please select a data to delete.");
            }
        }


        ///Book Updating
        private void btn_UpdateBook_Click(object sender, RoutedEventArgs e)
        {

        }


        ///Book Search
        //with book
        public void btn_SearchBook_Click(object sender, RoutedEventArgs e)
        {
            DBprocessor.BookListSearchBook(dtg_BookList, txt_SourceBook.Text);
            txt_SourceBook.Text = "";
            txt_SourceAuthor.Text = "";
            GetBookCount();
        }
        //with author
        public void btn_SearchAuthor_Click(object sender, RoutedEventArgs e)
        {
            DBprocessor.BookListSearchAuthor(dtg_BookList, txt_SourceAuthor.Text);
            txt_SourceAuthor.Text = "";
            txt_SourceBook.Text = "";
            GetBookCount();
        }

        #endregion

    }

}

