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
    /// Interaction logic for ucReaderList.xaml
    /// </summary>
    public partial class ucReaderList : UserControl
    {
        public ucReaderList()
        {
            InitializeComponent();
        }


        private void UserControl_Loaded(object sender, RoutedEventArgs e)
        {
           DBprocessor.GridFillInReaderList(dtg_ReaderList);
            GetReaderCount();
        }

        public void GetReaderCount()
        {
            var readerCount = dtg_ReaderList.Items.Count.ToString();
            if (readerCount != null)
            {
                lb_ReaderCount.Content = "Reader Count : " + readerCount;
            }
            else
            {
                lb_ReaderCount.Content = "No Registration";
            }
        }

        //ucReaderList Buttons
        #region
        ///Adding
        private void btn_AddUser_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Add button is working...");
        }


        ///Deletion
        private void btn_DeleteUser_Click(object sender, RoutedEventArgs e)
        {
            {
                DataRowView drv = (DataRowView)dtg_ReaderList.SelectedItem;
                if (drv != null)
                {
                    int dltID = Convert.ToInt32(drv[0].ToString());
                    string dtgUser = drv[2].ToString();
                    if (MessageBox.Show("Are you sure you want to delete " + dtgUser + " ? ", "Warning", MessageBoxButton.YesNo, MessageBoxImage.Warning) == MessageBoxResult.Yes)
                    {

                        if (DBprocessor.deleteReaderById(dltID))
                        {
                            MessageBox.Show(" Registered data has been deleted.");
                            DBprocessor.GridFillInEscrowList(dtg_ReaderList);
                        };
                    }
                }

                else
                {

                    MessageBox.Show("Please select a data to delete.");
                }
            }
        }


        ///Updating
        private void btn_UpdateUser_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Update button is working...");
        }

        #endregion


    }
}

