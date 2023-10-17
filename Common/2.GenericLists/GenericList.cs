using Common;

public class GenericListNode<T>
{
    public T Value;
    public GenericListNode<T> Next = null;

    public GenericListNode(T value)
    {
      Value = value;
    }

    public override string ToString()
    {
      return Value.ToString();
    }
}

public class GenericList<T> : IGenericList<T>
{
    GenericListNode<T> First = null;

    public string AsString()
    {
      GenericListNode<T> node = First;
      string output = "[";

      while (node != null)
      {
        output += node.ToString() + ",";
        node = node.Next;
      }
      output = output.TrimEnd(',') + "] " + Count() + " elements";
      
      return output;
    }

    public void Add(T value)
    {
        //TODO #1: add a new element to the end of the list
        GenericListNode<T> listNode = First;
        GenericListNode<T> lastNode = new GenericListNode<T>(value);

        if (listNode == null)
        {
            First = lastNode;
        }
        else
        {
            while (listNode.Next != null)
            {
                listNode = listNode.Next;
            }
            listNode.Next = lastNode;
        }
    }

    public GenericListNode<T> FindNode(int index)
    {
        //TODO #2: Return the element in position 'index'
        GenericListNode<T> listNode = First;
        if (listNode != null && index == 0)
        {
            return listNode;
        }
        while (listNode.Next != null && index > 0)
        {
            listNode = listNode.Next;
            index--;
        }
        return listNode;
    }

    public T Get(int index)
    {
        //TODO #3: return the element on the index-th position. YOU MUST USE GetNode(int). Return the default value for object class T if the position is out of bounds
        GenericListNode<T> nulo = null;
        if (FindNode == null)
            return nulo.Value;
        return FindNode(index).Value;
    }
    public int Count()
    {
        //TODO #4: return the number of elements on the list
        GenericListNode<T> listNode = First;
        int cant = 0;
        if (listNode != null)
            cant++;
        while (listNode != null && listNode.Next != null)
        {
            listNode = listNode.Next;
            cant++;
        }
        return cant;
    }


    public void Remove(int index)
    {
        //TODO #5: remove the element on the index-th position. Do nothing if position is out of bounds
        GenericListNode<T> listNode = First;
        if (index == 0 && listNode != null)
        {
            First = listNode.Next;
        }
        while (listNode.Next != null && index > 1)
        {
            listNode = listNode.Next;
            index--;
        }
        if (index == 1)
        {
            listNode.Next = listNode.Next.Next;
        }
    }

    public void Clear()
    {
        //TODO #6: remove all the elements on the list
        First = null;
    }
}