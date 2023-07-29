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
    /// Interaction logic for ucExpiredBooks.xaml
    /// </summary>
    public partial class ucExpiredBooks : UserControl
    {
        public ucExpiredBooks()
        {
            InitializeComponent();
        }

        private void UserControl_Loaded(object sender, RoutedEventArgs e)
        {
            DBprocessor.GridFillInExpiredList(dtg_ExpiredBooks);
            GetExpiredCount();
        }


        public void GetExpiredCount()
        {
            var expiredCount = dtg_ExpiredBooks.Items.Count.ToString();

            if (expiredCount != null)
            {
                lb_ExpiredCount.Content = "Book Count : " + expiredCount;
            }
            else
            {
                lb_ExpiredCount.Content = "No Registration";
            }
        }



        private void btn_DeleteExpiredBook_Click(object sender, RoutedEventArgs e)
        {
            DataRowView drv = (DataRowView)dtg_ExpiredBooks.SelectedItem;
            if (drv != null)
            {
                int dltID = Convert.ToInt32(drv[0].ToString());
                string dtgBookId = drv[0].ToString();
                if (MessageBox.Show("Are you sure you want to delete the book with the Id value "+ dtgBookId +"?", "Warning", MessageBoxButton.YesNo, MessageBoxImage.Warning) == MessageBoxResult.Yes)
                {

                    if (DBprocessor.deleteEscrowBookById(dltID))
                    {
                        MessageBox.Show(" Registered data has been deleted.");
                        DBprocessor.GridFillInEscrowList(dtg_ExpiredBooks);
                        GetExpiredCount();
                    };
                }
            }

            else
            {

                MessageBox.Show("Please select a data to delete.");
            }
        }
    }
}
