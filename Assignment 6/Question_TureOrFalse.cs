using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.PortableExecutable;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_6
{
    internal class Question_TureOrFalse : Question
    {
        public override void BodyMethod()
        {
            //CountQuestions = 5;
            //for (int i = 0; i < CountQuestions; i++)
            //{
            //    Console.WriteLine($"Question {i + 1}");
            //}
        }

        public override string HeaderMethod()
        {
            Header = "Choose OF Mulitple Choices..";
            return Header;
        }

        public override int MarksMethod()
        {

            //Marks = 1 * CountQuestions;
            return Marks;
        }
    }
}
