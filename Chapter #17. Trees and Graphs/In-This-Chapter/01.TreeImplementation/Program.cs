using System;
using _01.TreeImplementation;

public static class Program
    {
        static void Main()
        {
            CustomTree<int> tree =
            new CustomTree<int>(100,
                new CustomTree<int>(120,
                    new CustomTree<int>(10,
                        new CustomTree<int>(11,
                            new CustomTree<int>(5555),
                            new CustomTree<int>(6666)
                        ),
                        new CustomTree<int>(12),
                        new CustomTree<int>(13)
                    ),
                    new CustomTree<int>(20),
                    new CustomTree<int>(30)
                ),
                new CustomTree<int>(140,
                    new CustomTree<int>(69,
                        new CustomTree<int>(500),
                        new CustomTree<int>(600)
                    ),
                    new CustomTree<int>(99,
                        new CustomTree<int>(1000),
                        new CustomTree<int>(2000)
                    )
                ),
                new CustomTree<int>(160,
                    new CustomTree<int>(40),
                    new CustomTree<int>(50)
                )
            );
            Console.WriteLine("+++++++++++++++++++++++++++++++++++++++++++++++++++++++++");
            CustomTree<string> names =
                new CustomTree<string>("Peshko",
                    new CustomTree<string>("Frank",
                        new CustomTree<string>("Madonna"),
                        new CustomTree<string>("Bugs Nunny")
                    ),
                    new CustomTree<string>("Fiki",
                        new CustomTree<string>("69")
                    )
                );

            Console.WriteLine("Root element: " + names.Root.Value);

            Console.Write("Childs => " + names.Root.GetChild(1).ChildrenCount + " = > ");
            Console.WriteLine(names.Root.GetChild(1).Value);
           
            names.TraverseDFS();

            Console.WriteLine("+++++++++++++++++++++++++++++++++++++++++++++++++++++++++");
            Console.WriteLine("Root element: " +  tree.Root.Value);
            Console.Write("Childs => " + tree.Root.GetChild(0).ChildrenCount + " = > ");
            Console.WriteLine(tree.Root.GetChild(0).Value);

            tree.TraverseDFS();
        }

        
    }

