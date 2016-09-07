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
    /// Interaction logic for QuestionMaker.xaml
    /// </summary>
    public partial class QuestionMaker : UserControl
    {
        int quizNumber;//Jacob Jahraus

        public QuestionMaker(int q)
        {
            InitializeComponent();
            quizNumber = q;//Jacob Jahraus
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            if(rbMultipleChoice.IsChecked == true)//Jacob Jahraus
            {
                Switcher.Switch(new Teacher.MCQuestion(quizNumber));//Ezra Soleymani 
            }
            else if(rbShortAnswer.IsChecked == true)//Jacob Jahraus
            {
                Switcher.Switch(new Teacher.SAQuestion(quizNumber));//Ezra Soleymani 
            }
            else if(rbTrueFalse.IsChecked == true)//Jacob Jahraus
            {
                Switcher.Switch(new Teacher.TFQuestion(quizNumber));//Ezra Soleymani 
            }
            else//Jacob Jahraus
            {
                MessageBox.Show("Please select a question type");
            }
        }

        private void btnQuit_Click(object sender, RoutedEventArgs e)
        {
            Switcher.Switch(new Teacher.QuizMaker_cntrl());//Jacob Jahraus
        }
    }
}
