using System.Drawing;
using System.Runtime.Intrinsics.X86;

namespace BinarySearchDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //UC2 Ability to create thebinary tree shown in thefigure- Check if all are added with using sizemethod in Binary Tree
            BinarySTDemo<int> binarSearchTree = new BinarySTDemo<int>(56);
            binarSearchTree.Insert(30);
            binarSearchTree.Insert(70);
            binarSearchTree.Insert(22);
            binarSearchTree.Insert(40);
            binarSearchTree.Insert(60);
            binarSearchTree.Insert(95);
            binarSearchTree.Insert(11);
            binarSearchTree.Insert(65);
            binarSearchTree.Insert(3);
            binarSearchTree.Insert(16);
            binarSearchTree.Insert(63);
            binarSearchTree.Insert(67);
            binarSearchTree.Display();
            binarSearchTree.GetSize();
            Console.ReadKey();
        }
    }
}