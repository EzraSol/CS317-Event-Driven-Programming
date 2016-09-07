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
    /// Interaction logic for TFQuestion.xaml
    /// </summary>
    public partial class TFQuestion : UserControl
    {
        int quizNumber;//Jacob Jahraus
        public TFQuestion(int q)
        {
            InitializeComponent();
            quizNumber = q;//Jacob Jahraus
        }

        private void btnQuit_Click(object sender, RoutedEventArgs e)
        {
            Switcher.Switch(new Teacher.QuizMaker_cntrl());//Jacob Jahraus
        }

        private void submit_Click(object sender, RoutedEventArgs e)
        {
            if (q_textBox.Text != "")//Jacob Jahraus
            {
                if (rbTrue.IsChecked == true)//Jacob Jahraus
                {
                    Question myQuestion = new Question(q_textBox.Text, true);//Ezra Soleymani 
                    MessageBox.Show(QuizStorage.addQuestion(myQuestion, quizNumber));//Ezra Soleymani 
                    Switcher.Switch(new Teacher.QuestionMaker(quizNumber));//Ezra Soleymani 
                }
                else if (rbFalse.IsChecked == true)//Jacob Jahraus
                {
                    Question myQuestion = new Question(q_textBox.Text, false);//Ezra Soleymani 
                    MessageBox.Show(QuizStorage.addQuestion(myQuestion, quizNumber));//Ezra Soleymani 
                    Switcher.Switch(new Teacher.QuestionMaker(quizNumber));//Ezra Soleymani 
                }
                else//Jacob Jahraus
                {
                    MessageBox.Show("Please select True or False");
                }
            }
            else
            {
                MessageBox.Show("Please enter a question");//Jacob Jahraus
            }
        }
    }
}
