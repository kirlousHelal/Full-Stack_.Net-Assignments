namespace Assignment_6
{
    internal class Program
    {
        public static int setIO()
        {
            Console.WriteLine("1. Practice Exam");
            Console.WriteLine("2. Final Exam\n");
            int choice;
            do
            {
                Console.Write("Please Choose One From The Previous Choices: ");
            } while (!int.TryParse(Console.ReadLine(), out choice) || choice > 2 || choice < 1);

            return choice;
        }
        static void Main(string[] args)
        {
            PracticeExam practiceExam = new PracticeExam();
            FinalExam finalExam = new FinalExam();

            if (setIO() == 1)
                Console.WriteLine("Practice Exam");
                //practiceExam.ToString();
            else
                Console.WriteLine("Final Exam");
                //finalExam.ToString();
        }
    }
}