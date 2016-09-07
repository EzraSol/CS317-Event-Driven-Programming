using CS317_project;
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

namespace CS317_project.Nav
{
    /// <summary>
    /// Interaction logic for Teacher_cntrl.xaml
    /// </summary>
    public partial class Teacher_cntrl : UserControl
    {
        public Teacher_cntrl()
        {
            InitializeComponent();
        }

        private void bttn_logout_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show(" Bye ");
            Switcher.Switch(new Nav.Login());
        }

        private void bttncreate_Click(object sender, RoutedEventArgs e)
        {
            Switcher.Switch(new Teacher.QuizMaker_cntrl() );
        }

        private void bttnview_Click(object sender, RoutedEventArgs e)
        {
            Switcher.Switch(new Teacher.TestView());
        }

        private void bttn_studentview_Click(object sender, RoutedEventArgs e)
        {
            Switcher.Switch(new Student.student_testview());
        }

        private void bttnscore_Click(object sender, RoutedEventArgs e)
        {
            Switcher.Switch(new  Teacher.teacherscore());
        }
    }
}
