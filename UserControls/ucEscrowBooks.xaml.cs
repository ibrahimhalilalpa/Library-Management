using LibraryProject.Classes;
using System;
using System.Collections.Generic;
using System.Data;
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
    /// Interaction logic for ucEscrowBooks.xaml
    /// </summary>
    public partial class ucEscrowBooks : UserControl
    {
        public ucEscrowBooks()
        {
            InitializeComponent();
        }

        private void UserControl_Loaded(object sender, RoutedEventArgs e)
        {
            DBprocessor.GridFillInEscrowList(dtg_EscrowBooks);
            GetEscowCount();
        }

        public void GetEscowCount()
        {
            var escrowCount = dtg_EscrowBooks.Items.Count.ToString();

            if (escrowCount != null)
            {
                lb_EscrowCount.Content = "Escrow Count : " + escrowCount;
            }
            else
            {
                lb_EscrowCount.Content = "No Registration";
            }
        }


        //ucEscrowList Buttons
        #region


        ///Escrow Book Adding
        private void btn_AddEscrowBook_Click(object sender, RoutedEventArgs e)
        {
            winEscrowBook add = new winEscrowBook();
            add.ShowDialog();
        }


        ///Escrow Book Deletion
        private void btn_DeleteEscrowBook_Click(object sender, RoutedEventArgs e)
        {
            DataRowView drv = (DataRowView)dtg_EscrowBooks.SelectedItem;  
            if (drv != null)
            {
                int dltID = Convert.ToInt32(drv[1].ToString());
                string dtgEscrowId = drv[0].ToString();
                if (MessageBox.Show("Are you sure you want to delete the book with the Id value " + dtgEscrowId + "?", "Warning", MessageBoxButton.YesNo, MessageBoxImage.Warning) == MessageBoxResult.Yes)
                {

                    if (DBprocessor.deleteEscrowBookById(dltID))
                    {
                        MessageBox.Show(" Registered data has been deleted.");
                        DBprocessor.GridFillInEscrowList(dtg_EscrowBooks);
                        GetEscowCount();
                    };
                }
            }
            
            else
            {
                MessageBox.Show("Please select a data to delete.");
            }
        }


        ///Escrow Book Updating
        private void btn_UpdateEscrowBook_Click(object sender, RoutedEventArgs e)
        {

        }


        ///Escrow Book Source
        //with escrow book
        private void btn_SearchEscrowBook_Click(object sender, RoutedEventArgs e)
        {
            //DBprocessor.EscowListSearchBook(dtg_EscrowBooks, txt_SearchEscrowBook.Text);
            //txt_SearchEscrowBook.Text = "";
            GetEscowCount();
        }
        //with username
        private void btn_SearchUsername_Click(object sender, RoutedEventArgs e)
        {
           //DBprocessor.EscowListSearchUsername(dtg_EscrowBooks, txt_SearchUsername.Text);
            //txt_SearchUsername.Text = "";
            GetEscowCount();
        }
        private void txt_SourceBook_TextChanged(object sender, TextChangedEventArgs e)
        {
            //DBprocessor.EscowListSearchBook(dtg_EscrowBooks, txt_SearchEscrowBook.Text);
        }

        #endregion

    }
}
