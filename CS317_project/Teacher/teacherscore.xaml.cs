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

namespace CS317_project.Teacher
{
    /// <summary>
    /// Interaction logic for teacherscore.xaml
    /// </summary>
    public partial class teacherscore : UserControl
    {
        

        public teacherscore()
        {
            InitializeComponent();
            lstView_student.ItemsSource = QuizStorage.grade;//Ezra Soleymani 

        }

        private void bttnexit_Click(object sender, RoutedEventArgs e)
        {
            Switcher.Switch(new Nav.Teacher_cntrl());//Ezra Soleymani 
        }
    }
}
