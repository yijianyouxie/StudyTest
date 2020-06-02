using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestTraversingBinaryTree
{
    class Program
    {
        static void Main(string[] args)
        {
            Test();
        }

        private static void Test()
        {
            Node a = new Node();
            Node b = new Node();
            Node c = new Node();
            Node d = new Node();
            Node e = new Node();
            Node f = new Node();
            Node g = new Node();
            Node h = new Node();
            Node k = new Node();

            //设定数据
            a.SetNodeData(b, e, "a");
            b.SetNodeData(null, c, "b");
            c.SetNodeData(d, null, "c");
            d.SetNodeData(null, null, "d");
            e.SetNodeData(null, f, "e");
            f.SetNodeData(g, null, "f");
            g.SetNodeData(h, k, "g");
            h.SetNodeData(null, null, "h");
            k.SetNodeData(null, null, "k");

            #region====递归方式 开始====
            string orderStr = "";
            //根节点为a
            //前序(根左右)
            Node root = a;
            preOrder(root, ref orderStr);
            Console.WriteLine("================递归前序：" + orderStr);

            orderStr = "";
            //中序（左根右）
            miOrder(root, ref orderStr);
            Console.WriteLine("================递归中序：" + orderStr);

            orderStr = "";
            //后序（左右根）
            postOrder(root, ref orderStr);
            Console.WriteLine("================递归后序：" + orderStr);
            #endregion====递归方式 结束====

            #region====非递归====
            orderStr = "";
            List<Node> handleList = new List<Node>();
            Node newRoot = a;
            while (newRoot != null || handleList.Count > 0)
            {
                if (newRoot != null)
                {
                    handleList.Add(newRoot);
                    orderStr += newRoot.value;
                    newRoot = newRoot.leftNode;
                }
                else
                {
                    if (newRoot == null)
                    {
                        newRoot = handleList[handleList.Count - 1];
                        handleList.Remove(newRoot);

                        newRoot = newRoot.rightNode;
                    }
                }
            }
            Console.WriteLine("================非递归前序：" + orderStr);

            orderStr = "";
            handleList.Clear();
            newRoot = a;
            while (newRoot != null || handleList.Count > 0)
            {
                if (newRoot != null)
                {
                    handleList.Add(newRoot);
                    newRoot = newRoot.leftNode;
                }
                else
                {
                    if (newRoot == null)
                    {
                        newRoot = handleList[handleList.Count - 1];
                        handleList.Remove(newRoot);
                        //如果左边为空了
                        orderStr += newRoot.value;

                        newRoot = newRoot.rightNode;
                    }
                }
            }
            Console.WriteLine("================非递归中序：" + orderStr);

            orderStr = "";
            handleList.Clear();
            newRoot = a;
            while (newRoot != null || handleList.Count > 0)
            {
                if (newRoot != null)
                {
                    //只要左分支可访问就会一直访问左分支的左分支
                    handleList.Add(newRoot);
                    //Console.WriteLine("================非递后归序,Add：" + newRoot.value);
                    newRoot = newRoot.leftNode;
                }
                else
                {
                    Node p = handleList[handleList.Count - 1];
                    if( p.visited)
                    {
                        orderStr += p.value;
                        handleList.Remove(p);
                    }else
                    {
                        newRoot = p.rightNode;
                        //关键点，增加标记看是否被访问过
                        p.visited = true;
                    }
                }
            }
            Console.WriteLine("================非递后归序：" + orderStr);

            #endregion====非递归====

            Console.ReadLine();
        }
        //中序
        private static string miOrder(Node root, ref string str)
        {
            if (null != root)
            {

                Node l = root.leftNode;
                Node r = root.rightNode;

                if (null != l)
                {
                    miOrder(l, ref str);
                }

                str += root.value;

                if (null != r)
                {
                    miOrder(r, ref str);
                }
            }

            return str;
        }
        //前序
        private static string preOrder(Node root, ref string str)
        {
            if (null != root)
            {
                str += root.value;

                Node l = root.leftNode;
                Node r = root.rightNode;

                if (null != l)
                {
                    preOrder(l, ref str);
                }

                if (null != r)
                {
                    preOrder(r, ref str);
                }
            }

            return str;
        }
        //后序
        private static string postOrder(Node root, ref string str)
        {
            if (null != root)
            {

                Node l = root.leftNode;
                Node r = root.rightNode;

                if (null != l)
                {
                    postOrder(l, ref str);
                }

                if (null != r)
                {
                    postOrder(r, ref str);
                }

                str += root.value;
            }

            return str;
        }
    }
}
