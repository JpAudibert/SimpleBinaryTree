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

    public void CreateListOfValues(Node? node, bool reIntegrateValues)
    {
        if (node is not null)
        {
            CreateListOfValues(node.Left, false);
            CreateListOfValues(node.Right, false);
            NodeValues.Add((node.Value, node.Name));
        }

        if (reIntegrateValues)
            foreach (var value in NodeValues)
                InsertValues(node, value);
        else
            CreateListOfValues(node, true);
    }

    static int MinimumValue(Node? node)
    {
        if(node is null)
            return 0;

        while (node.Left is not null)
            node = node.Left;

        return node.Value;
    }

    static int MaximumValue(Node? node)
    {
        if (node is null)
            return 0;

        while (node.Right is not null)
            node = node.Right;

        return node.Value;
    }

    public Node? RemoveValues(Node? node, int value)
    {
        if (node is null)
            return null;

        if (node.Value > value)
            node.Left = RemoveValues(node.Left, value);
        else if (node.Value < value)
            node.Right = RemoveValues(node.Right, value);
        else
        {
            if (node.Left is null)
                return node.Right;
            else if (node.Right is null)
                return node.Left;
            else
            {
                int substitute = MinimumValue(node.Right);
                node.Value = substitute;
                node.Right = RemoveValues(node.Right, substitute);
            }
        }

        return node;
    }
}
