
public class Node<T>
{
    private T value;
    private Node<T>? next;

    public Node(T value)
    {
        this.value = value;
        this.next = null;
    }

    public Node(T value, Node<T> next)
    {
        this.value = value;
        this.next = next;
    }

    public T GetValue()
    {
        return value;
    }

    public Node<T>? GetNext()
    {
        return next;
    }

    public void SetValue(T value)
    {
        this.value = value;
    }

    public void SetNext(Node<T> next)
    {
        this.next = next;
    }

    public bool HasNext()
    {
        return next != null;
    }

    public override string ToString()
    {
        return value!.ToString()!;
    }
}
class Program
{
    public static int Width(Node<int> head, int num)
    {
        Node<int> temp = head;
        int count = 0;
        if (num > 0) { num *= -1; }
        while (temp != null || temp.GetValue() != num) { temp = temp.GetNext(); }
        if (temp == null) return -1;
        if (temp.GetValue() == num) { count++; }
        while (temp != null || temp.GetValue() != -num)
        {
            count++;
            temp = temp.GetNext();
        }
        if (temp.GetValue() == -num) { return count + 1; }
        return -1;
    }
    public static int Longest(Node<int> head)
    {
        int longest = int.MinValue;
        while (head != null)
        {
            int temp = Width(head, head.GetValue());
            if (temp > longest) { longest = temp; }
            head = head.GetNext();
        }
        return longest;
    }
}