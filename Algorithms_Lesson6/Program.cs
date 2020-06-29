using System;

// Шитов Евгений
namespace Algorithms_Lesson6
{
    internal static class Program
    {
        // обход дерева различными способами
        public static void Main()
        {
            BinaryTree<int> tree = new BinaryTree<int>();

            Random rand = new Random();

            for (int i = 0; i < 20; i++)
            {
                int value = rand.Next(100);
                Console.WriteLine($"Adding {value}");
                tree.Add(value);
            }

            Console.WriteLine($"Number of nodes is {tree.Count}");
            Console.WriteLine($"Max value is {tree.MaxVal}");
            Console.WriteLine($"Min value is {tree.MinVal}");
            Console.WriteLine("Preorder traversal:");
            Console.WriteLine(string.Join(" ", tree.Preorder()));
            Console.WriteLine("Inorder traversal:");
            Console.WriteLine(string.Join(" ", tree.Inorder()));
            Console.WriteLine("Postorder traversal:");
            Console.WriteLine(string.Join(" ", tree.Postorder()));
            Console.WriteLine("Levelorder traversal:");
            Console.WriteLine(string.Join(" ", tree.Levelorder()));
            Console.WriteLine("Default traversal (inorder):");

            foreach (int n in tree)
            {
                Console.Write("{0} ", n);
            }

            Console.WriteLine();
            Console.ReadKey(true);

            // сумма кодов символов
            var str = "abc";
            int result = 0;
            for (int i = 0; i < str.Length; ++i)
                result += ((int) str[i]);
            Console.WriteLine(result);
        }
    }
}