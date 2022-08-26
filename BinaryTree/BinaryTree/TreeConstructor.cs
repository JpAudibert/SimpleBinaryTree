namespace BinaryTree;

public class TreeConstructor
{
    public Node InsertValues(Node? node, int value)
    {
        if (node is null)
        {
            node = new Node(value);
            return node;
        }

        if (value > node.Value)
        {
            node.Right = InsertValues(node.Right, value);
            return node;
        }

        node.Left = InsertValues(node.Left, value);
        return node;
    }
}
