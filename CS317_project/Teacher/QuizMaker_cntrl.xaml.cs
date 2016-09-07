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
    /// Interaction logic for QuizMaker_contr.xaml
    /// </summary>
    public partial class QuizMaker_cntrl : UserControl
    {
        public QuizMaker_cntrl()
        {
            InitializeComponent();
        }

        private void btnQuiz1_Click(object sender, RoutedEventArgs e)//Ezra Soleymani 
        {
            Switcher.Switch(new Teacher.QuestionMaker(1));//Ezra Soleymani 
        }

        private void btnQuiz2_Click(object sender, RoutedEventArgs e)//Ezra Soleymani 
        {
            Switcher.Switch(new Teacher.QuestionMaker(2));//Ezra Soleymani 
        }

        private void btnQuiz3_Click(object sender, RoutedEventArgs e)//Ezra Soleymani 
        {
            Switcher.Switch(new Teacher.QuestionMaker(3));//Ezra Soleymani 
        }

        private void btnQuit_Click(object sender, RoutedEventArgs e)//Ezra Soleymani 
        {
            Switcher.Switch(new Nav.Teacher_cntrl());//Ezra Soleymani 
        }
    }
}
