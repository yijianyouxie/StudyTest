using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8Huanghou
{
    class Program
    {

        static int N = 8;
        static int[] index = new int[N];
        static int solution = 0;


        static void Main(string[] args)
        {
            for (int i = 0; i < N; i++)
                index[i] = 0;

            //Test8Huanghou();
            //Test8Huanghou2();
            //默认列索引0开始
            Test8Huanghou3(0);
            Console.ReadLine();
        }

        //参数为列的索引，从0开始
        private static void Test8Huanghou3(int col)
        {
            //选定一列后，循环这一列的每一行
            for( int i = 0;i < N;i++)
            {
                if( col == N)
                {
                    if( solution > 2)
                    {
                        return;
                    }
                    solution++;
                    Console.WriteLine("-solution:" + solution);
                    PrintMap();
                    return;
                }
                //假定将一个皇后放到col列的i行
                index[col] = i;//注意此处，数组的索引是列索引，数组索引对应值是这一列的第几行放置了皇后（同时注意索引从0开始）

                //检测当前放置的是否可以放
                if(CheckCanSet(col))
                {
                    //如果可以放置，则开始进行下一列的放置
                    Test8Huanghou3(col + 1);
                }
            }
        }

        //检测某个位置是否可放置
        private static bool CheckCanSet(int col)
        {
            //根据传递进来的列，我们从左往右进行检测，从0到(col-1)依次检测
            for( int i = 0;i < col;i++)
            {
                //如果是同一行，返回false
                if( index[i] == index[col])
                {
                    return false;
                }
                //是否存在斜线上的元素，返回false,这里用到了斜率
                if( Math.Abs(index[col] - index[i]) == Math.Abs(col - i))
                {
                    return false;
                }
            }

            return true;
        }

        private static void PrintMap()
        {
            for( int i = 0;i< N;i++)
            {
                //+1输出是为了看着清晰
                Console.Write("(" + (i+1) + "," + (index[i] + 1) + ")");
                Console.WriteLine("=====");
            }
        }

        //private static void Test8Huanghou2()
        //{
        //    find1(0);

        //    Console.ReadLine();
        //}
        //public static bool decision(int inn)
        //{
        //    //判决，不在同一行和同一列和不在对角线上  
        //    for (int i = 0; i < inn; i++)    
        //    {
        //        Console.WriteLine("-i:" + i + "index["+i+"]:" + index[i] + "-inn:"+ inn);
        //        if (Math.Abs(index[i] - index[inn]) == Math.Abs(i - inn) || index[i] == index[inn])
        //            return false;
        //    }
        //    return true;
        //}

        //public static void print()
        //{
        //    //打印
        //    Console.WriteLine("Solution:" + solution + "----------------------");
        //    for (int i = 0; i < N; i++)
        //    {
        //        for (int k = 0; k < N; k++)
        //            if (k == index[i])
        //                Console.Write("1");
        //            else
        //                Console.Write("0");
        //        Console.WriteLine('\n');
        //    }
        //}


        //public static void find1(int i)
        //{
        //    //递归法解决八皇后问题  
        //    for (int j = 0; j < N; j++)
        //    {
        //        //test
        //        if(j >= 3)
        //        {
        //            return;
        //        }

        //        index[i] = j;
        //        if (decision(i))
        //        {
        //            if (i == N - 1)
        //            {
        //                solution++;
        //                print();
        //            }
        //            else
        //                find1(i + 1);
        //        }
        //    }
        //}


        //static void Test8Huanghou()
        //{
        //    //开辟一个8长度的二维数组
        //    int[][] eightHuanghou = new int[8][];
        //    for( int i = 0;i<8;i++)
        //    {
        //        //初始值为0
        //        eightHuanghou[i] = new int[8];

        //        //for ( int j = 0;j < 8;j++)
        //        //{
        //        //    Console.WriteLine("===============" + eightHuanghou[i][j]);
        //        //}
        //    }

        //    //设定初始值,设定为1表示放置了一个皇后
        //    eightHuanghou[0][0] = 1;
        //    Console.WriteLine("===============line:" + 0 + "-row:" + 0);
        //    TrySet(eightHuanghou, 0);

        //    Console.ReadLine();
        //}

        //static void TrySet(int[][] eightHuanghou, int lineIndex)
        //{
        //    for( int i = lineIndex + 1; i < 8;i++)
        //    {
        //        for ( int j =0;j< 8;j++)
        //        {
        //            Console.WriteLine("===============eightHuanghou[i][j]:" + i + "-j:" + j + "-CanDuijiaoxian:" + CanDuijiaoxian(eightHuanghou, i, j) + "-CanLie:"+ CanLie(eightHuanghou, j));
        //            if (eightHuanghou[i][j] <= 0 && CanDuijiaoxian(eightHuanghou, i, j) && CanLie(eightHuanghou, j))
        //            {
        //                Console.WriteLine("===============line:" + i + "-row:" + j);
        //                eightHuanghou[i][j] = 1;
        //                break;
        //            }
        //        }
        //    }
        //}

        //static bool CanDuijiaoxian(int[][] eightHuanghou, int m, int n)
        //{
        //    if( m != n)
        //    {
        //        return true;
        //    }
        //    for (int i = 0; i < 8; i++)
        //    {
        //        for (int j = 0; j < 8; j++)
        //        {
        //            if(i == j && eightHuanghou[i][j] >= 1)
        //            {
        //                return false;
        //            }
        //        }
        //    }

        //    return true;
        //}
        //static bool CanLie(int[][] eightHuanghou, int j)
        //{
        //    for (int i = 0; i < 8; i++)
        //    {
        //        if (eightHuanghou[i][j] >= 1)
        //        {
        //            return false;
        //        }
        //    }

        //    return true;
        //}
    }
}
