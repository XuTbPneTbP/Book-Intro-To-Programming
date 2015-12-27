namespace _04.OrderedBinarySearchTree
{
    class Program
    {
        static void Main()
        {
            BinarySearchTree<string> names = new BinarySearchTree<string>();
            names.Insert("PitEr");
            names.Insert("Minetkq");
            names.Insert("Akbar");
            names.Insert("Qbalka");
            names.Insert("QbAlka");
            names.Insert("Piter");
            names.Insert("Elza");
            names.Traverse();

            //BinarySearchTree<int> numbers = new BinarySearchTree<int>();

            //numbers.Insert(0);
            //numbers.Insert(47);
            //numbers.Insert(-18);
            //numbers.Insert(-12);
            //numbers.Insert(90);
            //numbers.Insert(69);
            //numbers.Insert(69);
            //numbers.Insert(-69);
            //numbers.Insert(30);
            //numbers.Insert(300);
            //numbers.Traverse();
        }
    }
}
