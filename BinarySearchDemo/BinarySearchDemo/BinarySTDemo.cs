﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearchDemo
{
    internal class BinarySTDemo<T> where T : IComparable<T>
    {
       
            public T NodeData { get; set; }
            public BinarySTDemo<T> leftTree { get; set; }
            public BinarySTDemo<T> rightTree { get; set; }

            public BinarySTDemo(T nodeData)
            {
                this.NodeData = nodeData;
                this.rightTree = null;
                this.leftTree = null;

            }

            int leftCount = 0, rightCount = 0;
            bool result = false;
            public void Insert(T item)
        {
            T currentNodeValue = this.NodeData;
            if ((currentNodeValue.CompareTo(item)) > 0)
            {
                if (this.leftTree == null)
                    this.leftTree = new BinarySTDemo<T>(item);
                else
                    this.leftTree.Insert(item);
            }
            else
            {
                if (this.rightTree == null)
                    this.rightTree = new BinarySTDemo<T>(item);
                else
                    this.rightTree.Insert(item);
            }
        }
        public void Display()
        {
            if (this.leftTree != null)
            {
                this.leftCount++;
                this.leftTree.Display();

            }
            Console.WriteLine(this.NodeData.ToString());
            if (this.rightTree != null)
            {
                this.rightCount++;
                this.rightTree.Display();
            }
        }
        public void GetSize()
        {
            Console.WriteLine("Size" + " " + (1 + this.leftCount + this.rightCount));
        }
    }
}
    
