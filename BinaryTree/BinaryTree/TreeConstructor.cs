﻿namespace BinaryTree;

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

    public void InOrderRead(Node? node)
    {
        if (node is not null)
        {
            InOrderRead(node.Left);
            Console.Write(node.Value + " ");
            InOrderRead(node.Right);
        }
    }

    public void PreOrderRead(Node? node)
    {
        if (node is not null)
        {
            Console.Write(node.Value + " ");
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
            Console.Write(node.Value + " ");
        }
    }
}
