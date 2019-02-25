using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace TestConsole
{
    [DebuggerDisplay("Value={Value}")]
    public class Tree
    {
        public string Value;
        public Tree Left;
        public Tree Right;

        public static Tree CreatFakeTree()
        {
            Tree tree = new Tree() { Value = "A" };
            tree.Left = new Tree()
            {
                Value = "B",
                Left = new Tree() { Value = "D", Left = new Tree() { Value = "G" } },
                Right = new Tree() { Value = "E", Right = new Tree() { Value = "H" } }
            };
            tree.Right = new Tree() { Value = "C", Right = new Tree() { Value = "F" } };

            return tree;
        }
    }
}
