using System;

namespace _03.BinaryTree
{
    class BinaryTreeExample
    {
        static void Main()
        {
            BinaryTree<int> binary = 
                new BinaryTree<int>(14,
                    new BinaryTree<int>(19, 
                        new BinaryTree<int>(23), 
                        new BinaryTree<int>(6,
                            new BinaryTree<int>(10),
                            new BinaryTree<int>(21)
                        )
                    ),
                    new BinaryTree<int>(15,
                        new BinaryTree<int>(3),
                        null
                    )
                );


            binary.PrintInOrder();
            Console.WriteLine();
        }
    }
}
