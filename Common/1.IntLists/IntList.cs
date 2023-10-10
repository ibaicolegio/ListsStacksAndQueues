using System;

namespace Common
{
    public class IntListNode
    {
        public int Value;
        public IntListNode Next = null;

        public IntListNode(int value)
        {
            Value = value;
        }
    }

    public class IntList : IList
    {
        IntListNode First = null;

        //This method returns all the elements on the list as a string
        //Use it as an example on how to access all the elements on the list
        public string AsString()
        {
            IntListNode node = First;
            string output = "[";

            while (node != null)
            {
                output += node.Value + ",";
                node = node.Next;
            }
            output = output.TrimEnd(',') + "] " + Count() + " elements";

            return output;
        }

        
        public void Add(int value)
        {
            //TODO #1: add a new integer to the end of the list
            IntListNode listNode = First;
            IntListNode lastNode = new IntListNode(value);

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

        private IntListNode GetNode(int index)
        {
            //TODO #2: Return the element in position 'index'
            IntListNode listNode = First;
            if (listNode != null && index==0)
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

        
        public int Get(int index)
        {
            //TODO #3: return the element on the index-th position. YOU MUST USE GetNode(int). O if the position is out of bounds
            if (GetNode == null)
                return 0;
            return GetNode(index).Value;
        }

        
        public int Count()
        {
            //TODO #4: return the number of elements on the list
            IntListNode listNode = First;
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
            IntListNode listNode = First;
            if (index==0 && listNode != null)
            {
                First = listNode.Next;
            }
            while(listNode.Next != null && index > 1)
            {
                listNode=listNode.Next;
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
}