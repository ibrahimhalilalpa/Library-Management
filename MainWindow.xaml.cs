using LibraryProject.Classes;
using LibraryProject.UserControls;
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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace LibraryProject
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }


        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            //uc_call.Uc_Add(Content, new ucBookList()); 

            //DBconnection.ConTest();
            //MessageBox.Show(DBconnection.ConnState);
        }


        //Small Buttons (max,min,close buttons and move)
        #region 


        private void btn_Close_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void btn_SymbolState_Click(object sender, RoutedEventArgs e)
        {
            this.WindowState = WindowState.Minimized;
        }

        private void btn_FullScreen_Click(object sender, RoutedEventArgs e)
        {
            if (this.WindowState == WindowState.Normal)
            {
                this.WindowState = WindowState.Maximized;
                btn_FullScreen.Content = "[]";
            }
            else
            {
                this.WindowState = WindowState.Normal;
                btn_FullScreen.Content = "[ ]";
            }
        }

        private void brd_move_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            //Source: https://www.codeproject.com/Questions/284995/DragMove-problem-help-pls
            DragMove();
            base.OnMouseLeftButtonDown(e);
        }


        #endregion

        //Menu Buttons (User Conrol Buttons)
        #region 

        //Menu buttons

        //Choose State

        int ChooseState;
        private object dtg_BookList;

        private void menubutton_bookList_Click(object sender, RoutedEventArgs e)
        {
            ChooseState = 1;
            ChosenState();
            uc_call.Uc_Add(Content, new ucBookList());
        }
        private void menubutton_readerList_Click(object sender, RoutedEventArgs e)
        {
            ChooseState = 2;
            ChosenState();
            uc_call.Uc_Add(Content, new ucReaderList());
        }

        private void menubutton_escrowBooks_Click(object sender, RoutedEventArgs e)
        {
            ChooseState = 3;
            ChosenState();
            uc_call.Uc_Add(Content, new ucEscrowBooks());
        }

        private void menubutton_expiredBooks_Click(object sender, RoutedEventArgs e)
        {
            ChooseState = 4;
            ChosenState();
            uc_call.Uc_Add(Content, new ucExpiredBooks());
        }

        private void menubutton_settings_Click(object sender, RoutedEventArgs e)
        {
            ChooseState = 5;
            ChosenState();
            uc_call.Uc_Add(Content, new ucSettings());
        }

        private void menubutton_about_Click(object sender, RoutedEventArgs e)
        {
            ChooseState = 6;
            ChosenState();
            uc_call.Uc_Add(Content, new ucAbout());
        }

        //Checked Status

        void ChosenState()
        {
            if (ChooseState == 1) { menubutton_bookList.IsChecked = true; }
            else { menubutton_bookList.IsChecked = false; }

            if (ChooseState == 2) { menubutton_readerList.IsChecked = true; }
            else { menubutton_readerList.IsChecked = false; }

            if (ChooseState == 3) { menubutton_escrowBooks.IsChecked = true; }
            else { menubutton_escrowBooks.IsChecked = false; }

            if (ChooseState == 4) { menubutton_expiredBooks.IsChecked = true; }
            else { menubutton_expiredBooks.IsChecked = false; }

            if (ChooseState == 5) { menubutton_settings.IsChecked = true; }
            else { menubutton_settings.IsChecked = false; }

            if (ChooseState == 6) { menubutton_about.IsChecked = true; }
            else { menubutton_about.IsChecked = false; }
        }

        #endregion
    }
}