using System;
using System.Collections.Generic;

namespace L11
{
    public class TreeNode<T>
    {
        public T Data;
        public static bool notCalled = true;
        public List<TreeNode<T>> Children = new List<TreeNode<T>>();

        public TreeNode<T> CreateNode(T data)
        {
            TreeNode<T> newNode = new TreeNode<T>
            {
                Data = data
            };
            return newNode;
        }

        public void AppendChild(TreeNode<T> child)
        {
            Children.Add(child);
        }

        public void RemoveChild(TreeNode<T> child)
        {
            Children.Remove(child);
        }

        public void PrintTree(String AddTree = "")
        {
            Console.WriteLine(AddTree + Data);
            foreach (TreeNode<T> child in Children)
            {
                child.PrintTree(AddTree + "*");
            }
        }

        public void ForEach(Action<string> function) 
        {
            if (notCalled)
            {
                Console.Write(this.Data.ToString()  + " | ");
            }
            notCalled = false;

            foreach (TreeNode<T> child in Children)
            {
                function(child.Data.ToString());
                child.ForEach(Program.Func);
            }
        }

        public List<TreeNode<T>> FindChild(T search, List<TreeNode<T>> Nodes = null)
        {
            if (Nodes == null)
            {
                Nodes = new List<TreeNode<T>>();
            }
            if (Data.Equals(search))
            {
                Nodes.Add(this);
            }
            foreach (TreeNode<T> child in Children)
            {
                child.FindChild(search, Nodes);
            }
            return Nodes;
        }
        
        public override string ToString()
        {
            return Data.ToString();
        }
    }
}