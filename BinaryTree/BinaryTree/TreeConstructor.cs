namespace BinaryTree;

public class TreeConstructor
{
    public List<(int, string)> NodeValues = new List<(int, string)>();

    public Node InsertValues(Node? node, (int, string) value)
    {
        if (node is null)
        {
            node = new Node(value.Item1, value.Item2);
            return node;
        }

        if (value.Item1 > node.Value)
        {
            node.Right = InsertValues(node.Right, value);
            return node;
        }

        node.Left = InsertValues(node.Left, value);
        return node;
    }

    public void InOrderRead(Node? node)
    {
        if (node is not null)
        {
            InOrderRead(node.Left);
            Console.WriteLine($"{node.Value} : {node.Name}");
            InOrderRead(node.Right);
        }
    }

    public void PreOrderRead(Node? node)
    {
        if (node is not null)
        {
            Console.WriteLine($"{node.Value} : {node.Name}");
            PreOrderRead(node.Left);
            PreOrderRead(node.Right);
        }
    }

    public void PostOrderRead(Node? node)
    {
        if (node is not null)
        {
            PostOrderRead(node.Left);
            PostOrderRead(node.Right);
            Console.WriteLine($"{node.Value} : {node.Name}");
        }
    }

    public Node? FindElement(Node? node, int value)
    {
        if (node is null)
        {
            Console.WriteLine($"Element {value}, not found");
            return null;
        }

        if (node.Value == value)
        {
            Console.WriteLine($"{node.Value} : {node.Name}");
            return node;
        }

        if (value > node.Value)
            FindElement(node.Right, value);
        else if (value < node.Value)
            FindElement(node.Left, value);

        return null;
    }
}
