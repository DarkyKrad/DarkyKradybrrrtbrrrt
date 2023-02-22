using System;
using System.Text;

public class LinkedList
{
    Node? head;

    public class Node
    {
        public string data;
        public Node? next;

        public Node(string d)
        {
            data = d;
            next = null;
        }
    }
    
    public void AddNode(Node node)
    {
        if (head == null)
            head = node;
        else
        {
            Node temp = head;
            while (temp.next != null)
            {
                temp = temp.next;
            }
            temp.next = node;
        }
    }


    public void ReverseList()
    {
        Node? prev = null, current = head, next;
        while (current != null)
        {
            next = current.next;
            current.next = prev;
            prev = current;
            current = next;
        }
        head = prev;
    }

    public override string ToString()
    {
        StringBuilder sb = new StringBuilder();
        Node? current = head;
        while (current != null)
        {
            sb.Append(current.data + " ");
            current = current.next;
        }
        return sb.ToString();
    }

    public void Clearlist()
    {
        head = null;
    }
}
