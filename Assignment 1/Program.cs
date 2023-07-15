//#define task_1
//#define task_2
//#define task_3
//#define task_4
//#define task_5

namespace Assignment_1
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region longest distance Two equal cells  ///task 1
#if task_1

            #region Intial_Reading
            Console.Write("Please Enter The Number Of The Elemnts : ");
                int N = Convert.ToInt32(Console.ReadLine());
                int[] arr = new int[N];
                Console.WriteLine("Please Enter The values Of The Elemnts : ");
                for (int i = 0; i < N; i++)
                {
                    arr[i] = Convert.ToInt32(Console.ReadLine());
                }
            #endregion

            #region Calculate Distance

                int maxSoFar = 0;
                for (int i = 0; i < N; i++)
                {
                    for (int j = i+1; j < N; j++)
                    {
                        if(arr[i] == arr[j])
                            maxSoFar= Math.Max(maxSoFar,j-i);
                    }
                }
                maxSoFar--;
                Console.WriteLine($"The Max Dif Of Two Equals cells is {maxSoFar}");
            #endregion
#endif
            #endregion    


            #region reverse the order of the words ///task 2
#if task_2

            Console.Write("Please Enter Your Line: ");
            string str = Console.ReadLine();
            string[] words = str.Split(" ");
            string newStr = "";
            for (int i = words.Length - 1; i >= 0; i--)
            {
                newStr = $"{newStr} {words[i]}";
            }
            Console.WriteLine($"The Reversed Line is : {newStr}");
#endif
            #endregion 


            #region count the occurrence of 1 (from 1 to 100 million) => String Way ///task 3
#if task_3
            Stopwatch time= new Stopwatch();
            time.Start();
            int count = 0;
            for (int i = 0; i < Math.Pow(10,8); i++)
            {
                string str = i.ToString();
                for (int j = 0; j < str.Length; j++)
                {
                    if (str[j] == '1') count++;
                }
            }
            time.Stop();
            Console.WriteLine($"The Total Count Of Ones is {count:n}");
            Console.WriteLine($"The Total Time is {time.ElapsedMilliseconds}");
#endif
            #endregion


            #region count the occurrence of 1 (from 1 to 100 million) => Math Way ///task 4
#if task_4
            Stopwatch time= new Stopwatch();
            time.Start();
            int count = 0;
            for (int i = 0; i < Math.Pow(10,8); i++)
            {
                int val = i;
                while (val > 0) 
                {
                    if (val % 10 == 1) count++;
                    val/= 10;
                }

            }
            time.Stop();
            Console.WriteLine($"The Total Count Of Ones is {count:n}");
            Console.WriteLine($"The Total Time is {time.ElapsedMilliseconds}");
#endif
            #endregion


            #region count the occurrence of 1 (from 1 to 100 million) => Fastest Way -> less than 1 sec  ///task 5
#if task_5
            Stopwatch time = new Stopwatch();
            time.Start();

            int range = (int)Math.Pow(10, 8);
            int count = 0;
            int factor = 1;

            while (factor < range)
            {
                int quotient = range / (factor * 10);
                int remainder = range % (factor * 10);

                count += quotient * factor;

                if (remainder >= (2 * factor) - 1)
                    count += factor;
                else if (remainder >= factor)
                    count += remainder - factor + 1;

                factor *= 10;
            }

            time.Stop();
            Console.WriteLine($"The Total Count Of Ones is {count:n}");
            Console.WriteLine($"The Total Time is {time.ElapsedMilliseconds}");
#endif
            #endregion
        }
    }
}