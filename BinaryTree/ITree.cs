using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinaryTree
{
    public interface ITree<T>
    {
        bool IsEmpty { get; }
        ITree<T> LeftJunction { get;}
        ITree<T> RightJunction { get; }
        T Value { get; }
    }

    public class Node<T> : ITree<T>
    {
        public bool IsEmpty
        { get; }

        public ITree<T> LeftJunction
        { get; set; }

        public ITree<T> RightJunction
        { get; set; }

        public T Value
        { get; set; }

        public Node(T value, ITree<T> right, ITree<T> left)
        {
            LeftJunction = left;
            RightJunction = right;
            Value = value;
        }
    }

    public class Empty<T> : ITree<T>
    {
        public bool IsEmpty
        { get { return true; } }

        public ITree<T> LeftJunction
        {
            get
            {
                throw new Exception("Trying to reach junction of emtpy node!");
            }
        }

        public ITree<T> RightJunction
        {
            get
            {
                throw new Exception("Trying to reach junction of emtpy node!");
            }
        }

        public T Value
        {
            get
            {
                throw new Exception("Trying to reach value of emtpy node!");
            }
        }
    }
}
