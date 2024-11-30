using System;

namespace EstruturaAULA.Quiz
{
    class Program
    {
        static void Main(string[] args)
        {
            BinaryTree<int> tree = new BinaryTree<int>();

            // Inserindo valores na árvore
            tree.Insert(50);
            tree.Insert(30);
            tree.Insert(70);
            tree.Insert(20);
            tree.Insert(40);
            tree.Insert(60);
            tree.Insert(80);

            // Exibindo a árvore em ordem
            Console.WriteLine("Árvore em ordem:");
            tree.PrintInOrder();

            // Realizando buscas
            Console.WriteLine("Busca pelo valor 40: " + (tree.Search(40) ? "Encontrado" : "Não encontrado"));
            Console.WriteLine("Busca pelo valor 100: " + (tree.Search(100) ? "Encontrado" : "Não encontrado"));
        }
    }
}
