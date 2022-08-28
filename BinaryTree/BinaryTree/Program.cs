using BinaryTree;

IEnumerable<int> values = new List<int>() { 9, 83, 5, 7 };
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