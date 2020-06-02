using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace TestListToArray
{
    class Program
    {
        static void Main(string[] args)
        {

            List<Item> itemList = new List<Item>();
            Item item1 = new Item(1, "1");
            itemList.Add(item1);
            Item item2 = new Item(2, "2");
            itemList.Add(item2);
            Item item3 = new Item(3, "3");
            itemList.Add(item3);

            Console.WriteLine("====itemList:" + /*getMemory(itemList) +*/ "\t" + getMemory(item1) + "\t" + getMemory(item2) + "\t" + getMemory(item3));
            for (int i = 0; i < itemList.Count; ++i)
            {
                Console.WriteLine("====itemList0:" + getMemory(itemList[i]) + "==:" + itemList[i].id);
            }
            //Console.WriteLine("====itemList2:" + getMemory(itemList));
            Item[] itemArray = itemList.ToArray();
            for (int i = 0; i < itemArray.Length; ++i)
            {
                Console.WriteLine("====itemArray0:" + getMemory(itemArray[i]) );
                itemArray[i].id = 5;
            }
            for (int i = 0; i < itemList.Count; ++i)
            {
                Console.WriteLine("====itemList1:" + getMemory(itemList[i]) + "==:" + itemList[i].id);
                itemList[i].id = 7;
            }

            for (int i = 0; i < itemArray.Length; ++i)
            {
                Console.WriteLine("====itemArray1:" + getMemory(itemArray[i]) + "==:" + itemArray[i].id);
                itemArray[i].id = 5;
            }

            //string a = "a";
            //string b = "b";
            //Console.WriteLine("==== a:" + getMemory(a) + "\t" + getMemory(b));
            ////a = "c";
            ////Console.WriteLine("====a2:" + getMemory(a) + "\t" + getMemory(b));

            //List<string> list = new List<string>();
            //list.Add(a);
            //list.Add(b);
            //for( int i = 0;i<list.Count;++i)
            //{
            //    Console.WriteLine("====i:" + getMemory(i) );
            //}
            //for (int i = 0; i < list.Count; ++i)
            //{
            //    Console.WriteLine("===2i:" + getMemory(i));
            //}
            //Console.WriteLine("====a2:" + getMemory(a) + "\t" + getMemory(b));


            Console.ReadKey();
        }

        public static string getMemory(object o) // 获取引用类型的内存地址方法  
        {
            GCHandle h = GCHandle.Alloc(o, GCHandleType.WeakTrackResurrection);

            //IntPtr addr = h.AddrOfPinnedObject();
            IntPtr addr = GCHandle.ToIntPtr(h);
            h.Free();
            return "0x" + addr.ToString("X");
        }
    }


    class Item
    {
        public int id = 0;
        public string name = "";
        public Item(int _id, string _name)
        {
            this.id = _id;
            this.name = _name;
        }
    }
}
