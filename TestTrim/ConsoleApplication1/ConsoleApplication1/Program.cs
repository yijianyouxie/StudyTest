using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            string testStr = " a  b    c ";
            TestTrim(testStr);
        }

        private static void TestTrim(string testStr)
        {
            StringBuilder sb = new StringBuilder(testStr.Trim());
            int index = 1;
            int spaceCount = 0;
            for (int i = sb.Length - 1; i >= 0; i--)
            {
                spaceCount = 0;
                while (sb[i] == ' ' && (i - 1) >= 0 && sb[i - 1] == ' ')
                {
                    spaceCount++;
                    //逐个删除空格
                    //sb.Remove(i - 1, 1);
                    //找到连续的空格后就向前移动一个位置
                    i--;
                    Console.WriteLine("==============index:" + index);
                    index++;
                }
                //批量删除空格
                sb.Remove(i, spaceCount);

                Console.WriteLine("==============i:" + i);
            }
            Console.WriteLine("==============sb.toString():" + sb.ToString());
            Console.ReadKey();
        }
    }
}
