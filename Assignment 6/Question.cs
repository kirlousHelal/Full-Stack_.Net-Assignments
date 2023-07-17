using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_6
{
    abstract class Question
    {
        public string Header { get; set; }
        public int Marks { get; set; }
        public string Body { get; set; }
        //public int CountQuestions { get; set; }
        //public Answers ModelAnswer { get; set; }


        public abstract void BodyMethod();
        public abstract int MarksMethod();
        public abstract string HeaderMethod();
    }
}
