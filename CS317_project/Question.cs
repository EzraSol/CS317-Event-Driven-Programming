using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS317_project
{
    public class Question
    {
        //Question Object

        public string type { get; set; } //mc, tf, or sa //Jacob Jahraus
        public string question{ get; set; }//Jacob Jahraus
        public string finalAnswer { get; set; }//Jacob Jahraus


        //True/False
        public bool tfAnswer { get; set; }//Jacob Jahraus
        //Short Answer
        public string saAnswer { get; set; }//Jacob Jahraus
        //Multiple Choice
        public string mcAnswer1 { get; set; }//Jacob Jahraus
        public string mcAnswer2 { get; set; }//Jacob Jahraus
        public string mcAnswer3 { get; set; }//Jacob Jahraus
        public string mcAnswer4 { get; set; }//Jacob Jahraus
        public int mcCorrect { get; set; }//Jacob Jahraus
        public int qsIndex { get; set; }



        public Question(string q, bool tf) //Constructor for True/False//Jacob Jahraus
        {
            type = "tf";//Jacob Jahraus
            question = q;//Jacob Jahraus
            tfAnswer = tf;//Jacob Jahraus
            if (tf == true)//Jacob Jahraus
                finalAnswer = "True";//Jacob Jahraus
            if (tf == false)//Jacob Jahraus
                finalAnswer = "False";//Jacob Jahraus
        }

        public Question(string q, string a) //Constructor for short answer//Jacob Jahraus
        {
            type = "sa";//Jacob Jahraus
            question = q;//Jacob Jahraus
            saAnswer = a;//Jacob Jahraus
            finalAnswer = a;//Jacob Jahraus
        }

        public Question(string q, string a1, string a2, string a3, string a4) //Constructor for Multiple Choice
        {
            type = "mc";//Jacob Jahraus
            question = q;//Jacob Jahraus
            //Multiple choice options
            mcAnswer1 = a1;//Jacob Jahraus
            mcAnswer2 = a2;//Jacob Jahraus
            mcAnswer3 = a3;//Jacob Jahraus
            mcAnswer4 = a4;//Jacob Jahraus

        }

        //public override string ToString()
        //{
        //    return "Type: " + type + "   Question: " + question + "Awnswer " +saAnswer;
        //}

    }
}
