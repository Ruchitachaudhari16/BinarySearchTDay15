using System.Runtime.Intrinsics.X86;

namespace BinarySearchDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //UC1 Ability to create a BST byadding 56 and then adding 30 & 70 - Use INode to create My Binary
            Console.WriteLine("Welcome to Binary Search Tree Demo!");
            BinarySTDemo<int> binarSearchTree = new BinarySTDemo<int>(56);
            binarSearchTree.Insert(30);
            binarSearchTree.Insert(70);
            binarSearchTree.Display();
        }
    }
}