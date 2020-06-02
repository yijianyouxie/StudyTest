using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestPermute
{
    /// <summary>
    /// 全排列
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            //非重复
            //string s = "acd";
            //TestNonRepeate(s, 0);

            //存在重复
            string s2 = "aacd";
            TestRepeate(s2);
            Console.ReadKey();
        }
        #region====非重复方式====
        /// <summary>
        /// 非重复
        /// </summary>
        /// <param name="s"></param>
        static void TestNonRepeate(string s, int index)
        {
            //将字符串转化为数组
            int len = s.Length;
            char[] sarr = new char[len];
            for ( int i = 0;i< len;i++)
            {
                sarr[i] = s[i];
            }

            TestNoRepeateRecursion(sarr, 0);
        }

        /// <summary>
        /// 轮流当head，选出一个head后，剩余的部分重新选择head
        /// </summary>
        /// <param name="arr"></param>
        /// <param name="index"></param>
        static void TestNoRepeateRecursion(char[] arr, int index)
        {
            if( index + 1 >= arr.Length)
            {
                for (int i = 0; i < arr.Length; i++)
                {
                    Console.Write( arr[i]);
                }
                Console.WriteLine("========");
                return; 
            }

            //轮流当head
            for (int i = index; i < arr.Length; i++)
            {
                char temp = arr[index];
                arr[index] = arr[i];
                arr[i] = temp;

                TestNoRepeateRecursion(arr, index + 1);
                //执行完成后将交换的值重新交换回来，否则会出现循环中会直接使用上次循环中改变后的值
                char temp2 = arr[i];
                arr[i] = arr[index];
                arr[index] = temp2;
            }
        }
        #endregion====非重复方式====

        #region====重复方式====
        /// <summary>
        /// 重复
        /// </summary>
        /// <param name="s"></param>
        static void TestRepeate(string s)
        {//将字符串转化为数组
            int len = s.Length;
            char[] sarr = new char[len];
            for (int i = 0; i < len; i++)
            {
                sarr[i] = s[i];
            }

            TestRepeateRecursion(sarr, 0);
        }

        /// <summary>
        /// 轮流当head，选出一个head后，剩余的部分重新选择head
        /// </summary>
        /// <param name="arr"></param>
        /// <param name="index"></param>
        static void TestRepeateRecursion(char[] arr, int index)
        {
            if (index + 1 >= arr.Length)
            {
                for (int i = 0; i < arr.Length; i++)
                {
                    Console.Write(arr[i]);
                }
                Console.WriteLine("========");
                return;
            }

            //轮流当head
            for (int i = index; i < arr.Length; i++)
            {
                //判断尝试当head的元素与【起始检测的元素到此元素之间是否有相同的元素】
                //在[index,i)区间内，是否存在arr[j] == arr[i],如果存在，这说明之前肯定有过此类型的排列方式
                bool can = true;
                for( int j = index;j< i;j++)
                {
                    if( arr[j] == arr[i])
                    {
                        can = false;
                    }
                }

                if( !can)
                {
                    continue;
                }

                char temp = arr[index];
                arr[index] = arr[i];
                arr[i] = temp;

                TestRepeateRecursion(arr, index + 1);
                //执行完成后将交换的值重新交换回来，否则会出现循环中会直接使用上次循环中改变后的值
                char temp2 = arr[i];
                arr[i] = arr[index];
                arr[index] = temp2;
            }
        }
        #endregion====重复方式====
    }
}
