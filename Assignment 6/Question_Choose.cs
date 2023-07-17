using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_6
{
    internal class Question_Choose : Question
    {
        public override void BodyMethod()
        {
            //CountQuestions = 10;
            //for (int i = 0; i < CountQuestions; i++)
            //{
            //    Console.WriteLine($"Question {i + 1}");
            //}
        }

        public override string HeaderMethod()
        {
            Header = "True OR False..";
            return Header;
        }

        public override int MarksMethod()
        {

            //Marks = 2 * CountQuestions;
            return Marks;
        }
    }
}
