using BinaryTree;

IEnumerable<int> values = new List<int>() { 9, 83, 5, 7 };
TreeConstructor treeConstructor = new TreeConstructor();

Node? tree = null;

foreach (var value in values)
{
    tree = treeConstructor.InsertValues(tree, value);
}

treeConstructor.InOrderRead(tree);