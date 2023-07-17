using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_6
{
    internal class Exam
    {
        //Time, number of Questions
        int time;
        int CountQuestions;
        Question[] questions; 
        Answers []answers; 

        public int Time { get => time; set => time = value; }
        public int CountQuestions1 { get => CountQuestions; set => CountQuestions = value; }
    }
}
