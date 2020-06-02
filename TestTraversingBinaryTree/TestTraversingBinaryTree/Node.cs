using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestTraversingBinaryTree
{
    public class Node
    {
        public Node leftNode = null;
        public Node rightNode = null;

        public string value = "";

        public bool visited = false;//是否访问过

        public Node()
        {

        }
        public Node(Node l, Node r, string v)
        {
            leftNode = l;
            rightNode = r;

            value = v;
        }

        /// <summary>
        /// 外部设定二叉树节点数据
        /// </summary>
        /// <param name="l"></param>
        /// <param name="r"></param>
        /// <param name="v"></param>
        public void SetNodeData(Node l, Node r, string v)
        {
            leftNode = l;
            rightNode = r;

            value = v;
        }
    }
}
