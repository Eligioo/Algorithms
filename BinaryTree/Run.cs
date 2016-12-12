using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinaryTree
{
    public class Run
    {
        static ITree<int> Insert(int value, ITree<int> tree)
        {
            if (tree.IsEmpty)
                return new Node<int>(value, new Empty<int>(), new Empty<int>());

            if (value == tree.Value)
                return tree;

            if (value > tree.Value)
                return new Node<int>(tree.Value, Insert(value, tree.RightJunction), tree.LeftJunction);
            else
                return new Node<int>(tree.Value, tree.RightJunction, Insert(value, tree.LeftJunction));
        }

        static bool SearchElement(ITree<int> tree, int value)
        {
            if (tree.IsEmpty)
                return false;
            else {
                if (tree.Value == value)
                    return true;
                else
                {
                    if (value < tree.Value)
                        return SearchElement(tree.LeftJunction, value);
                    else
                        return SearchElement(tree.RightJunction, value);
                }
            }
        }

        static int CountChildren<T>(ITree<T> tree)
        {
            int count = 0;
            if (tree.LeftJunction.GetType() != typeof(Empty<T>))
                count++;
            if (tree.RightJunction.GetType() != typeof(Empty<T>))
                count++;
            return count;
        }

        static void PreOrder<T>(ITree<T> tree)
        {
            if (tree.IsEmpty)
                return;
            Console.WriteLine(tree.Value);
            PreOrder(tree.LeftJunction);
            PreOrder(tree.RightJunction);
        }

        static void Main(string[] args)
        {
            var tree = new Empty<int>() as ITree<int>;
            tree = Insert(5, tree);
            tree = Insert(4, tree);
            tree = Insert(3, tree);
            tree = Insert(2, tree);
            tree = Insert(6, tree);
            Console.WriteLine(SearchElement(tree, 8));
            PreOrder<int>(tree);
            Console.WriteLine(CountChildren<int>(tree.LeftJunction));
            Console.ReadLine();
        }
    }
}
