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

namespace CS317_project.Student
{
    /// <summary>
    /// Interaction logic for studentscore.xaml
    /// </summary>
    public partial class studentscore : UserControl
    {
        public studentscore()
        {
            InitializeComponent();
            lstView_student.ItemsSource = QuizStorage.grade;//Ezra Soleymani 
        }

        private void lstView_test_quiz1_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void bttnexit_Click(object sender, RoutedEventArgs e)
        {
            Switcher.Switch(new student_testview());//Ezra Soleymani 
        }
    }
}
