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
    /// Interaction logic for student_testview.xaml
    /// </summary>
    public partial class student_testview : UserControl
    {
        public student_testview()
        {

            InitializeComponent();
            if (QuizStorage.allreadyloginin)
            {
                bttn_testview.Visibility = Visibility.Visible;//Ezra Soleymani 
                bttn_testview2.Visibility = Visibility.Visible;//Ezra Soleymani 
                bttn_testview3.Visibility = Visibility.Visible;//Ezra Soleymani 
                bttn_access.Visibility = Visibility.Hidden;//Ezra Soleymani 
                txtbxfirst.Visibility = Visibility.Hidden;//Ezra Soleymani 
                txtbxlast.Visibility = Visibility.Hidden;//Ezra Soleymani 
                txtBlckname.Text = (QuizStorage.studentf+ " " + QuizStorage.stuentl);//Ezra Soleymani 
                lblfirst.Visibility = Visibility.Hidden;//Ezra Soleymani 
                lbllast.Visibility = Visibility.Hidden;//Ezra Soleymani 
                button_vs.Visibility = Visibility.Visible;//Ezra Soleymani 
                lblheader.Visibility = Visibility.Hidden;//Ezra Soleymani 


            }
        }

        private void btnQuit_Click(object sender, RoutedEventArgs e)//Ezra Soleymani 
        {
            Switcher.Switch(new Nav.Login());//Ezra Soleymani 
            QuizStorage.allreadyloginin = false;//Ezra Soleymani 
        }

        private void bttn_testview_Click(object sender, RoutedEventArgs e)
        {

            
            //  StudentTestPage2 page = new StudentTestPage2(QuizStorage.quiz1_1);
            // page.Show();

            //StudentTestPage2 page = new StudentTestPage2();
            //page.quiz = QuizStorage.quiz1_1;
            //page.DataContext = page.quiz;
            //page.listQuiz.ItemsSource = page.quiz;
            //page.Show();

            //Switcher.Switch(new StudentTestPage2(QuizStorage.quiz1_1));
            Switcher.Switch(new studentviewFinal(1));//Ezra Soleymani 

            //  Switcher.Switch(new StudentTestPage());

        }

        private void bttn_testview2_Click(object sender, RoutedEventArgs e)
        {
            //StudentTestPage2 page = new StudentTestPage2();
            //page.quiz = QuizStorage.quiz2_2;
            //page.listQuiz.ItemsSource = page.quiz;
            //page.Show();

            Switcher.Switch(new studentviewFinal(2));//Ezra Soleymani 
        }

        private void bttn_testview3_Click(object sender, RoutedEventArgs e)
        {
            //StudentTestPage2 page = new StudentTestPage2();
            //page.quiz = QuizStorage.quiz3_3;
            //page.DataContext = page.quiz;
            //page.listQuiz.ItemsSource = page.quiz;
            //page.Show();

            Switcher.Switch(new studentviewFinal(3));//Ezra Soleymani 
        }

        private void bttn_access_Click(object sender, RoutedEventArgs e) //Ezra Soleymnani whole method  
        {
            if (txtbxlast.Text != "" || QuizStorage.allreadyloginin )
            {
                bttn_testview.Visibility = Visibility.Visible;//Ezra Soleymani 
                bttn_testview2.Visibility = Visibility.Visible;//Ezra Soleymani 
                bttn_testview3.Visibility = Visibility.Visible;//Ezra Soleymani 
                bttn_access.Visibility = Visibility.Hidden;//Ezra Soleymani 
                txtbxfirst.Visibility = Visibility.Hidden;//Ezra Soleymani 
                txtbxlast.Visibility = Visibility.Hidden;//Ezra Soleymani 
                txtBlckname.Text = (txtbxfirst.Text + " " + txtbxlast.Text);//Ezra Soleymani 
                QuizStorage.studentf = txtbxfirst.Text;//Ezra Soleymani 
                QuizStorage.stuentl = txtbxlast.Text;//Ezra Soleymani 
                lblfirst.Visibility = Visibility.Hidden;//Ezra Soleymani 
                lbllast.Visibility = Visibility.Hidden;//Ezra Soleymani 
                lblheader.Visibility = Visibility.Hidden;//Ezra Soleymani 

                QuizStorage.allreadyloginin = true;//Ezra Soleymani 

            }
            else
            
                MessageBox.Show("Enter in a First and Last Name ");//Ezra Soleymani 

        }

        private void button_vs_Click(object sender, RoutedEventArgs e)
        {
            Switcher.Switch(new studentscore());//Ezra Soleymani 
        }
    }
}
