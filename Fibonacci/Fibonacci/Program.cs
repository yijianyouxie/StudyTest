using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fibonacci
{
    class Program
    {
        static int times = 0;
        static void Main(string[] args)
        {
            Test();
        }

        private static void Test()
        {
            Console.WriteLine("=============Rescursion:" + recursion(10) + "--times:"+ times);

            int n = 10;
            int f1 = 1;
            int f2 = 1;

            int f3 = 0;
            for ( int i = 2;i< n;i++)
            {
                f3 = f1 + f2;
                f1 = f2;
                f2 = f3;
            }

            Console.WriteLine("=============Rescursion:" + f3 );
            Console.ReadLine();
        }

        /// <summary>
        /// 递归
        /// </summary>
        /// <param name="n"></param>
        /// <returns></returns>
        private static int recursion(int n)
        {
            if( n == 0)
            {
                times++;
                return 1;
            }else if( n == 1 || n == 2)
            {
                times++;
                return 1;
            }
            times++;
            return recursion(n - 1) + recursion(n - 2);
        }
    }
}
