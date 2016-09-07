using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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
    /// Interaction logic for studentviewFinal.xaml
    /// </summary>
    public partial class studentviewFinal : UserControl
    {
        public ObservableCollection<Question> quiz;//Jacob Jahraus
        Question currentQuestion;//Jacob Jahraus
        public double count = 0; //Stores the number of answered questions//Jacob Jahraus
        public double correct = 0; //Stores the number of correctly answered questions//Jacob Jahraus
        public double total = 0; // Stores Score as a percent at the end//Jacob Jahraus
        public int quiz_num =0;//Ezra Soleymani

        public studentviewFinal(int quiz_num)
        {
            this.quiz_num = quiz_num;//Ezra Soleymani
            if (quiz_num == 1)               //Ezra Soleymani
                quiz = QuizStorage.quiz1_1; //Ezra Soleymani
            else if (quiz_num == 2)//Ezra Soleymani
                quiz = QuizStorage.quiz2_2;//Ezra Soleymani
            else//Ezra Soleymani
                quiz = QuizStorage.quiz3_3;//Ezra Soleymani

            InitializeComponent();

            listQuiz.ItemsSource = quiz;//Jacob Jahraus
            progbar1.Maximum = quiz.Count;//Ezra Soleymani
        }

        private void pageSetup()
        {
            if (currentQuestion != null)
            {
                txtQuestion.Text = currentQuestion.question;//Jacob Jahraus
                btnSubmit.Visibility = Visibility.Visible;//Jacob Jahraus
                if (currentQuestion.type == "sa")//Jacob Jahraus
                {
                    // clear text box

                    txtAnswer.Text = "";
                    //Show UIElements
                    radioA1.Visibility = Visibility.Hidden;//Jacob Jahraus
                    radioA2.Visibility = Visibility.Hidden;//Jacob Jahraus
                    radioA3.Visibility = Visibility.Hidden;//Jacob Jahraus
                    radioA4.Visibility = Visibility.Hidden;//Jacob Jahraus
                    radioTrue.Visibility = Visibility.Hidden;//Jacob Jahraus
                    radioFalse.Visibility = Visibility.Hidden;//Jacob Jahraus

                    txtAnswer.Visibility = Visibility.Visible;//Jacob Jahraus
                    label.Visibility = Visibility.Visible;//Jacob Jahraus
                }

                else if (currentQuestion.type == "mc")//Jacob Jahraus
                {
                    //Show UIElements
                    radioA1.Visibility = Visibility.Visible;//Jacob Jahraus
                    radioA2.Visibility = Visibility.Visible;//Jacob Jahraus
                    radioA3.Visibility = Visibility.Visible;//Jacob Jahraus
                    radioA4.Visibility = Visibility.Visible;//Jacob Jahraus

                    radioTrue.Visibility = Visibility.Hidden;//Jacob Jahraus
                    radioFalse.Visibility = Visibility.Hidden;//Jacob Jahraus

                    txtAnswer.Visibility = Visibility.Hidden;//Jacob Jahraus
                    label.Visibility = Visibility.Hidden;//Jacob Jahraus

                    //Populate Answers
                    radioA1.Content = currentQuestion.mcAnswer1;//Jacob Jahraus
                    radioA2.Content = currentQuestion.mcAnswer2;//Jacob Jahraus
                    radioA3.Content = currentQuestion.mcAnswer3;//Jacob Jahraus
                    radioA4.Content = currentQuestion.mcAnswer4;//Jacob Jahraus
                }

                else if (currentQuestion.type == "tf")//Jacob Jahraus
                {
                    //Show UIElements
                    radioA1.Visibility = Visibility.Hidden;//Jacob Jahraus
                    radioA2.Visibility = Visibility.Hidden;//Jacob Jahraus
                    radioA3.Visibility = Visibility.Hidden;//Jacob Jahraus
                    radioA4.Visibility = Visibility.Hidden;//Jacob Jahraus

                    radioTrue.Visibility = Visibility.Visible;//Jacob Jahraus
                    radioFalse.Visibility = Visibility.Visible;//Jacob Jahraus

                    txtAnswer.Visibility = Visibility.Hidden;//Jacob Jahraus
                    label.Visibility = Visibility.Hidden;//Jacob Jahraus
                }
            }
        }

        private void btnSubmit_Click(object sender, RoutedEventArgs e)
        {
            grades grd = new grades();//Ezra Soleymani 
            //mre.Set();
            MessageBox.Show("Answer Saved!");//Jacob Jahraus
            //Check If answer is correct
            if (currentQuestion.type == "mc")//Jacob Jahraus
            {
                mcCheckAnswer();//Jacob Jahraus
            }
            else if (currentQuestion.type == "tf")//Jacob Jahraus
            {
                tfCheckAnswer();//Jacob Jahraus
            }
            else if (currentQuestion.type == "sa")//Jacob Jahraus
            { 
                saCheckAnswer();//Jacob Jahraus
            }
            if (quiz.Count == 0)//Jacob Jahraus
            {
                total = (correct / count) * 100;  //Ezra Soleymani
                progbar1.Value = progbar1.Maximum;//Ezra Soleymani
                MessageBox.Show("Quiz Completed!");//Jacob Jahraus
                Switcher.Switch(new studentscore());//Jacob Jahraus
                grades grade = new grades { name = (QuizStorage.studentf + " " + QuizStorage.stuentl), score = total  , quiznum = quiz_num};//Ezra Soleymani
                QuizStorage.grade.Add(grade);//Ezra Soleymani
            }

            progbar1.Value += (progbar1.Maximum /4);//Ezra Soleymani

            listQuiz.SelectedIndex = 0;//Jacob Jahraus
        }

        private void mcCheckAnswer()
        {
            int choice;//Jacob Jahraus
            string studentan;//Ezra Soleymani 

            if (radioA1.IsChecked == true)
            {
                choice = 1;//Jacob Jahraus
                studentan = (string)radioA1.Content;//Ezra Soleymani 
            }
            else if (radioA2.IsChecked == true)//Jacob Jahraus
            {
                choice = 2;//Jacob Jahraus
                studentan = (string)radioA2.Content;//Ezra Soleymani 
            }
            else if (radioA3.IsChecked == true)//Jacob Jahraus
            {
                choice = 3;//Jacob Jahraus
                studentan = (string)radioA3.Content;//Ezra Soleymani 

            }
            else if (radioA4.IsChecked == true)//Jacob Jahraus
            {
                choice = 4;//Jacob Jahraus
                studentan = (string)radioA4.Content;//Ezra Soleymani 

            }
            else//Jacob Jahraus
            {
                MessageBox.Show("Please choose an answer");//Jacob Jahraus
                return;//Jacob Jahraus
            }
            if (choice == currentQuestion.mcCorrect)//Jacob Jahraus
                correct++;//Jacob Jahraus
            else//Jacob Jahraus
            {
                grades grade1 = new grades { correctan = currentQuestion.finalAnswer, Studentan = studentan, quiznum = quiz_num, question = currentQuestion.question };//Ezra Soleymani 
                QuizStorage.grade.Add(grade1);//Ezra Soleymani 
            }

      
            count++;//Jacob Jahraus
            quiz.Remove(currentQuestion);//Jacob Jahraus
        }

        private void tfCheckAnswer()//Jacob Jahraus
        {
            bool choice;//Jacob Jahraus
            if (radioTrue.IsChecked == true)//Jacob Jahraus
                choice = true;//Jacob Jahraus
            else if (radioFalse.IsChecked == true)//Jacob Jahraus
                choice = false;//Jacob Jahraus
            else//Jacob Jahraus
            {
                MessageBox.Show("Please choose an answer");//Jacob Jahraus
                return;//Jacob Jahraus
            }

            if (choice == currentQuestion.tfAnswer)//Jacob Jahraus
                correct++;//Jacob Jahraus
            else//Ezra Soleymani
            {
                grades grade1 = new grades { correctan = currentQuestion.finalAnswer, Studentan = choice.ToString(), quiznum = quiz_num, question = currentQuestion.question };//Ezra Soleymani
                QuizStorage.grade.Add(grade1);//Ezra Soleymani
            }

            count++;//Jacob Jahraus
            quiz.Remove(currentQuestion);//Jacob Jahraus
        }

        private void saCheckAnswer()//Jacob Jahraus
        {
            string choice = txtAnswer.Text;//Jacob Jahraus
            //convert strings to lower cass
            choice = choice.ToLower();//Jacob Jahraus
            currentQuestion.saAnswer = currentQuestion.saAnswer.ToLower();//Jacob Jahraus
            if (choice == currentQuestion.saAnswer)//Jacob Jahraus
            { 
                correct++;//Jacob Jahraus
            }
            else
            {//Ezra Soleymani
                grades grade1 = new grades { correctan = currentQuestion.saAnswer, Studentan = txtAnswer.Text, quiznum = quiz_num, question = currentQuestion.question };//Ezra Soleymani 
                QuizStorage.grade.Add(grade1);//Ezra Soleymani 
            }

            count++;//Jacob Jahraus
            quiz.Remove(currentQuestion);//Jacob Jahraus
        }

        private void listQuiz_SelectionChanged(object sender, SelectionChangedEventArgs e)//Jacob Jahraus
        {
            currentQuestion = (Question)listQuiz.SelectedItem;//Jacob Jahraus
            pageSetup();//Jacob Jahraus
        }

        private void bttnexit_Click(object sender, RoutedEventArgs e)
        {
            Switcher.Switch(new student_testview());//Jacob Jahraus
        }
    }
}
