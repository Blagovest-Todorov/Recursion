using System;

namespace _29.Recursion
{
    class Program
    {

        // calculate sum with recursion from n till m numbers ;
        public static int CalculateSumRecursively(int n, int m) 
            
        {
            int sum = n;

            if (n < m)
            {
                n++;
                return sum += CalculateSumRecursively(n, m);
            }
            return sum;
        }
        static void Main(string[] args)
        {
            // Recursion concept in which a method is calling itself 
            // So we have to have a conditon to stop the itself calling/
            // Every recursion  method  needs to be terminated, 
            //we need to write a conditon in which to check is the termiation condition satisfied to stop recusrion
           
            Console.WriteLine("Enter a number n: ");
            int n = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter a  numer m: ");
            int m = Convert.ToInt32(Console.ReadLine());

            int sum = CalculateSumRecursively(n, m);
            Console.WriteLine(sum);
            Console.ReadKey();

        }
    }
}
