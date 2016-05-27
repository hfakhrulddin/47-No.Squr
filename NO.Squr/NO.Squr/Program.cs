using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NO.Squr
{
    class Program
    {
        static void Main(string[] args)
        {
            bool Exit = false;
            while (Exit == false)
            {
                int A = Convert.ToInt32(Console.ReadLine());
                int B = Convert.ToInt32(Console.ReadLine());
                int Max = solution(A, B);
                Console.WriteLine(Max);
            }
        }

        public static int solution(int A, int B)
        {
            int result = 0;

            for (int x = 0; x <= B; x++)
            {
                if ((x * x) <= B && (x * x) >= A)
                { result++; }
            }
            return result;
        }
    }
}
