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
using System.Collections.ObjectModel;
using System.Threading;

namespace CS317_project.Teacher
{
    /// <summary>
    /// Interaction logic for SAQuestion.xaml
    /// </summary>
    public partial class SAQuestion : UserControl
    {
        int quizNumber;//Jacob Jahraus
        int count = 0;


        public SAQuestion(int q)
        {
            InitializeComponent();

            quizNumber = q;//Jacob Jahraus

        }

        private void btnQuit_Click(object sender, RoutedEventArgs e)
        {
            Switcher.Switch(new Teacher.QuizMaker_cntrl());//Jacob Jahraus
        }

        private  void submit_Click(object sender, RoutedEventArgs e)
        {
            if(q_textBox.Text != "" && a_textBox.Text != "")//Jacob Jahraus
            {
                count++;
                Question myQuestion = new Question(q_textBox.Text, a_textBox.Text);//Jacob Jahraus
                myQuestion.qsIndex = count++;
                MessageBox.Show(QuizStorage.addQuestion(myQuestion, quizNumber));//Jacob Jahraus
                Switcher.Switch(new Teacher.QuestionMaker(quizNumber));//Jacob Jahraus
            }
            else
            {
                MessageBox.Show("Please enter both a question and an answer");//Jacob Jahraus
            }
        }

        //async Task PutTaskDelay()
        //{
        //    await Task.Delay(3000);
        //}

        //private async void button_Click(object sender, RoutedEventArgs e)
        //{
        //    //TestView testview = new TestView();
        //    //Switcher.Switch(new Teacher.TestView());

        //    //testview.questions = new ObservableCollection<Question>();
        //    //testview.questions = createdtest;
        //    //testview.DataContext = testview.questions;
        //    //testview.lstView_test.ItemsSource = testview.questions;
        //    //testview.comboBox_qs.ItemsSource = testview.questions;
        //    //testview.sapage = this;
        //    // Switcher.Switch(new Teacher.QuestionMaker(quizNumber));
        //    //await PutTaskDelay();


        //    await PutTaskDelay();
        //    Switcher.Switch(new Teacher.TestView());

        //}
    }
}
