using BinaryTree;

IEnumerable<(int, string)> values = new List<(int, string)>() { ( 9, "João" ), (83, "Pedro"), (5, "Basso"), (7, "Audibert") };
TreeConstructor treeConstructor = new TreeConstructor();

Node? tree = null;

foreach (var value in values)
{
    tree = treeConstructor.InsertValues(tree, value);
}

Console.WriteLine("In Order Read:");
treeConstructor.InOrderRead(tree);
Console.WriteLine("\n\nPre Order Read:");
treeConstructor.PreOrderRead(tree);
Console.WriteLine("\n\nPost Order Read:");
treeConstructor.PostOrderRead(tree);

tree = treeConstructor.RemoveValues(tree, 7);
Console.WriteLine("\n\nTree after removing values:");
treeConstructor.InOrderRead(tree);

Console.WriteLine("\n\n\nSearch:");
treeConstructor.FindElement(tree, 9);
