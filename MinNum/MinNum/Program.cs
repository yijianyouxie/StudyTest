using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// 最小数
/// </summary>
namespace MinNum
{
    class Program
    {
        static void Main(string[] args)
        {
            Test();
            //Test2();
            Console.ReadLine();
        }

        static void Test()
        {
            long time1 = DateTime.Now.Millisecond;
            //定义一个数组
            int[] intArray = new int[10] {2,4,6,8,0,0,1,3,2,9 };

            //冒泡排序
            //外层控制循环次数
            for( int i = 1;i< 10;i++)
            {
                //内层负责冒出一个数
                for( int j = 0;j<10 - 1;j++)
                {
                    if(intArray[j] > intArray[j+1])
                    {
                        int temp = intArray[j+1];
                        intArray[j+1] = intArray[j];
                        intArray[j] = temp;
                    }
                }
            }

            for (int i = 0; i < 10; i++)
            {
                //Console.WriteLine("====="+ intArray[i]);
                //找出第一个不为0的数
                if( intArray[i] > 0 && i >0)
                {
                    int temp = intArray[0];
                    intArray[0] = intArray[i];
                    intArray[i] = temp;
                    break;
                }
            }
            StringBuilder sb = new StringBuilder(16);
            for (int i = 0; i < 10; i++)
            {
                //Console.WriteLine("=====" + intArray[i]);
                sb.Append(intArray[i]);
            }
            long time2 = DateTime.Now.Millisecond;
            Console.WriteLine("=====sb:" + sb.ToString()+ "-:"+time2 +"-"+ time1);
        }

        static void Test2()
        {
            int[] counter = new int[10] { 2, 4, 6, 8, 0, 0, 1, 3, 2, 9 };
            int i;

            //for (i = 0; i < 10; i++)
            //    counter[i] = Console.Read();

            //考虑存在‘0’的情况  
            i = 1;
            string s="";
            if (counter[0] > 0)
            {
                while (counter[i] == 0 && i < 10)
                    i++;
                if (i == 10)
                {
                    //只有‘0’的情况  
                    //s += '0';
                    s += "0";
                }
                else
                {
                    counter[i]--;
                    //s += (char)(i + '0');
                    s += i;
                }
            }

            //双重遍历输出  
            //for (i = 0; i < 10; i++)
            //    for (int j = counter[i]; j > 0; j--)
            //        //s += (char)(i + '0');
            //        s += i;


            Console.WriteLine("=============s:" + s);
        }
    }
}
