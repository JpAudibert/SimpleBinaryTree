using BinaryTree;

IEnumerable<int> values = new List<int>() { 4, 5, 8, 9 };
TreeConstructor treeConstructor = new TreeConstructor();

Node? tree = null;

foreach (var value in values)
{
     tree = treeConstructor.InsertValues(tree, value);
}

Console.WriteLine(tree);