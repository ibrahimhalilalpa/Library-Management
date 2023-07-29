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

namespace LibraryProject.UserControls
{
    /// <summary>
    /// Interaction logic for ucAbout.xaml
    /// </summary>
    public partial class ucAbout : UserControl
    {
        public ucAbout()
        {
            InitializeComponent();
        }

        private void btn_About_Books_Click(object sender, RoutedEventArgs e)
        {
            lbl_About.Content = "Information on the books";
            txt_About.Text = "There are hundreds of different beautiful books in the library.";
        }

        private void btn_About_Authors_Click(object sender, RoutedEventArgs e)
        {
            lbl_About.Content = "Information on the Authors";
            txt_About.Text = "There are dozens of authors who have written books in different fields in the library.";
        }

        private void btn_About_Users_Click(object sender, RoutedEventArgs e)
        {
            lbl_About.Content = "Information on the Users";
            txt_About.Text = "Library users consist of students and faculty members of Toros University.";
        }

        private void btn_About_Admin_Click(object sender, RoutedEventArgs e)
        {
            lbl_About.Content = "Information on the Admin";
            txt_About.Text = "Library admini is a first year student at the faculty of software engineering at Toros University.";
        }

        private void btn_About_Library_Click(object sender, RoutedEventArgs e)
        {
            lbl_About.Content = "Information on the Library";
            txt_About.Text = "This library is designed for a course passing project.";
        }

        private void btn_About_Rules_Click(object sender, RoutedEventArgs e)
        {
            lbl_About.Content = "RULES";
            txt_About.Text = "1- Please make sure that the registration information is correct.\n2- Take care to deliver the books on time.\n3- Ask for help at ibrahimhalilalpa21@gmail.com for your related problems.";
        }
    }

}
