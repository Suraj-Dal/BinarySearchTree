Console.WriteLine("BST Operations\n0.Exit\n1.Add node\n2.Display tree\n3.Search Node\nEnter your choice:");
int choice =Convert.ToInt32(Console.ReadLine());
BinaryTree.BinarySearchTree<int> tree = new BinaryTree.BinarySearchTree<int>(0);
while (choice != 0)
{
    switch (choice)
    {
        case 1:
            Console.WriteLine("How many nodes you want to add.");
            int noOfnode = Convert.ToInt32(Console.ReadLine());
            while (noOfnode != 0)
            {
                Console.Write("Enter node:");
                int node = Convert.ToInt32(Console.ReadLine());
                
                tree.AddNode(node);
                noOfnode--;
            }
            break;
        case 2:
            Console.WriteLine("Root Node is:" + tree.right.data);
            tree.Display();
            break;
        case 3:
            Console.WriteLine("Enter node to search:");
            int element = Convert.ToInt32(Console.ReadLine());
            tree.search(element, tree);
            break;
        default:
            Console.WriteLine("Enter valid option.");
            break;
    }
    Console.Write("BST Operations\n0.Exit\n1.Add node\n2.Display tree\n3.Search Node\nEnter your choice:");
    choice = Convert.ToInt32(Console.ReadLine());
}



