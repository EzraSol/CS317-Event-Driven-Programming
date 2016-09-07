using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;

namespace CS317_project
{
    public class QuizStorage
    {
        public static ObservableCollection<Question> quiz1_1  = new ObservableCollection<Question>(); //Ezra Soleymani 
        public static ObservableCollection<Question> quiz2_2 = new ObservableCollection<Question>();//Ezra Soleymani 
        public static ObservableCollection<Question> quiz3_3 = new ObservableCollection<Question>();//Ezra Soleymani 

        public static ObservableCollection<grades> grade = new ObservableCollection<grades>();

        public static bool allreadyloginin { get; set; }//Ezra Soleymani 
        public static string studentf { get; set; }//Ezra Soleymani 
        public static string stuentl { get; set; }//Ezra Soleymani 

        //public static ObservableCollection<Grade> grade = new ObservableCollection<Grade>();


        //int count1 = 0 , count2 =0, count3=0;


        public static String addQuestion(Question question, int quizNum)//Jacob Jahraus
        {
            if (question != null)//Jacob Jahraus
            {
                if (quizNum == 1)//Jacob Jahraus
                {
                    quiz1_1.Add(question);//Jacob Jahraus
                }
                if (quizNum == 2)//Jacob Jahraus
                { 
                    quiz2_2.Add(question);//Jacob Jahraus
                }
                if (quizNum == 3)//Jacob Jahraus
                {
                    quiz3_3.Add(question);//Jacob Jahraus
                }
                return ("Question added successfully");//Jacob Jahraus
            }
            else//Jacob Jahraus
            {
                return ("Question not added");//Jacob Jahraus
            }
        }
    }
}
