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

namespace CS317_project.Teacher
{
    /// <summary>
    /// Interaction logic for TestView.xaml
    /// </summary>
    public partial class TestView : UserControl
    {
        //public ObservableCollection<Question> questions;
       // public Teacher.SAQuestion sapage;
        

        public TestView()
        {
            
            InitializeComponent();
            QuizStorage qs = new QuizStorage();//Ezra Soleymani 
            lstView_test_quiz1.ItemsSource = QuizStorage.quiz1_1;//Ezra Soleymani 
            lstView_test_quiz2.ItemsSource = QuizStorage.quiz2_2;//Ezra Soleymani 
            lstView_test_quiz3.ItemsSource = QuizStorage.quiz3_3;//Ezra Soleymani 

            //public static ObservableCollection<Question> qs { get { return QuizStorage.quiz1_1; } }

        }

        private void btnQuit_Click(object sender, RoutedEventArgs e)
        {
            Switcher.Switch(new Nav.Teacher_cntrl());//Ezra Soleymani 
        }

        private void listView_testview_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void lstView_test_quiz3_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
    }
}
