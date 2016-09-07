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
    /// Interaction logic for UserControl1.xaml
    /// </summary>
    public partial class MCQuestion : UserControl
    {
        int quizNumber;//Jacob Jahraus
        public MCQuestion(int q)
        {
            InitializeComponent();
            quizNumber = q;//Jacob Jahraus
        }

        private void submit_Click(object sender, RoutedEventArgs e)
        {
            Question myQuestion = new Question(q_textBox.Text, a1_textBox.Text, a2_textBox.Text, a3_textBox.Text, a4_textBox.Text);//Ezra Soleymani 
            //add question to list
            if (rbtnAnswer1.IsChecked == true)//Jacob Jahraus
            {
                myQuestion.mcCorrect = 1;//Jacob Jahraus
                myQuestion.finalAnswer = a1_textBox.Text;//Jacob Jahraus
                MessageBox.Show(QuizStorage.addQuestion(myQuestion, quizNumber));//Jacob Jahraus
                Switcher.Switch(new QuestionMaker(quizNumber));//Jacob Jahraus
            }
            else if (rbtnAnswer2.IsChecked == true)//Jacob Jahraus
            {
                myQuestion.mcCorrect = 2;//Jacob Jahraus
                myQuestion.finalAnswer = a2_textBox.Text;//Jacob Jahraus
                MessageBox.Show(QuizStorage.addQuestion(myQuestion, quizNumber));//Jacob Jahraus
                Switcher.Switch(new QuestionMaker(quizNumber));//Jacob Jahraus

            }

            else if (rbtnAnswer3.IsChecked == true)//Jacob Jahraus
            {
                myQuestion.mcCorrect = 3;//Jacob Jahraus
                myQuestion.finalAnswer = a3_textBox.Text;//Jacob Jahraus
                MessageBox.Show(QuizStorage.addQuestion(myQuestion, quizNumber));//Jacob Jahraus
                Switcher.Switch(new QuestionMaker(quizNumber));//Jacob Jahraus

            }
            else if (rbtnAnswer4.IsChecked == true)//Jacob Jahraus
            {
                myQuestion.mcCorrect = 4;//Jacob Jahraus
                myQuestion.finalAnswer = a4_textBox.Text;//Jacob Jahraus
                MessageBox.Show(QuizStorage.addQuestion(myQuestion, quizNumber));//Jacob Jahraus
                Switcher.Switch(new QuestionMaker(quizNumber));//Jacob Jahraus
            }
            else//Jacob Jahraus
            {
                MessageBox.Show("Please select the correct answer");//Jacob Jahraus
            }
        }

        private void btnQuit_Click(object sender, RoutedEventArgs e)
        {
            Switcher.Switch(new Teacher.QuizMaker_cntrl());//Jacob Jahraus
        }
    }
}
