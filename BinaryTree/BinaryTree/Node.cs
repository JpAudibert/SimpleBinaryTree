namespace BinaryTree;

public class Node
{
    public int Value { get; set; }
    public string Name { get; set; }
    public Node? Left { get; set; }
    public Node? Right { get; set; }

    public Node() { }

    public Node(int value, string name)
    {
        Value = value;
        Name = name;
    }
}
