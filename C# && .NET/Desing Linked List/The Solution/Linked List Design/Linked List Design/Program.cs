namespace Linked_List_Design
{

    /** @author Hristifor Sotirovski
     */
    internal class Program
    {
        static void Main(string[] args)
        {
            MyLinkedList list = new MyLinkedList();
            list.AddAtHead(1); // The list should be [1]
            Console.WriteLine(list.ToString());
            list.AddAtHead(2); // The list should be [2, 1]
            Console.WriteLine(list.ToString());
            list.AddAtTail(3); // the list should be [2, 1, 3]
            Console.WriteLine(list.ToString());
            list.AddAtIndex(0, 0); // the list should be [0, 2, 1, 3]
            Console.WriteLine(list.ToString());
            list.AddAtIndex(2, 10); // the list should be [0, 2, 10, 1, 3]
            Console.WriteLine(list.ToString());
            Console.WriteLine(list.Get(4)); // 3
            list.DeleteAtIndex(1); // list shoulg be [0, 10, 1, 3]
            Console.WriteLine(list.ToString());

            // ...
        }
    }


    public interface IMyLinkedList
    {

        public int Get(int index);

        public void AddAtHead(int val);

        public void AddAtTail(int vaL);

        public void AddAtIndex(int index, int val);

        public void DeleteAtIndex(int index);
    }


    // This class represents a node in linked list
    public class Node
    {

        private Node? prev;
        private int val;
        private Node? next;

        public Node(Node? prev, int val, Node? next)
        {
            this.prev = prev;
            this.val = val;
            this.next = next;
        }

        public void setPrev(Node? prev)
        {
            this.prev = prev;
        }

        public void setVal(int val)
        {
            this.val = val;
        }

        public void setNext(Node? next)
        {
            this.next = next;
        }

        public Node? getPrev()
        {
            return prev;
        }

        public int getVal()
        {
            return val;
        }

        public Node? getNext()
        {
            return next;
        }
    }

    public class MyLinkedList : IMyLinkedList
    {

        private Node? head;
        private Node? tail;
        private int length;



        public MyLinkedList()
        {
            head = null;
            tail = null;
            length = 0;
        }

        /**
         * Delete the indexth node in the linked list, if the index is valid,
         * otherwise nothing.
         * 
         * @param index - the indexth node to be deleted.
         */
        public void DeleteAtIndex(int index)
        {
            if (length != 0)
            {
                if (length == 1)
                {
                    if (index == 0)
                    {
                        head = null;
                        tail = null;
                        length = 0;
                    }
                }
                else if (length == 2)
                {
                    if (index == 0)
                    {
                        head.getNext().setPrev(null);

                        head = head.getNext();
                        length = 1;
                    }
                    else if (index == 1)
                    {
                        tail.getPrev().setNext(null);
                        tail = tail.getPrev();
                        length = 1;
                    }
                }
                else if (length == 3)
                {
                    if (index == 0)
                    {
                        head.getNext().setPrev(null);
                        head = head.getNext();
                        length = 2;
                    }
                    else if (index == 1)
                    {
                        var tmp = head.getNext();
                        tmp.getPrev().setNext(tmp.getNext());
                        tmp.getNext().setPrev(tmp.getPrev());
                        length = 2;
                    }
                    else if (index == 2)
                    {
                        tail.getPrev().setNext(null);
                        tail = tail.getPrev();
                        length = 2;
                    }
                }
                else
                {
                    if (!(0 <= index && index <= length - 1))
                    {
                        return;
                    }
                    else
                    {
                        if (index == 0)
                        {
                            head.getNext().setPrev(null);
                            head = head.getNext();
                            length--;
                        }
                        else if (index == length - 1)
                        {
                            tail.getPrev().setNext(null);
                            tail = tail.getPrev();
                            length--;
                        }
                        else
                        {
                            if (index <= (length / 2) - 1)
                            {
                                Node ptr = head;
                                int i = 0;
                                while (i < index)
                                {
                                    ptr = ptr.getNext();
                                    i++;
                                }
                                ptr.getPrev().setNext(ptr.getNext());
                                ptr.getNext().setPrev(ptr.getPrev());

                                length--;
                            }
                            else
                            {
                                Node ptr = tail;
                                int i = length - 1;
                                while (i > index)
                                {
                                    ptr = ptr.getPrev();
                                    i--;
                                }
                                ptr.getPrev().setNext(ptr.getNext());
                                ptr.getNext().setPrev(ptr.getPrev());

                                length--;

                            }
                        }
                    }
                }
            }
        }



        /**
         * Add a node of value val before the indexth node in the linked list. 
         * If index equals the length of the linked list, the node will be appended 
         * to the end of the linked list. If index is greater than the length, 
         * the node will not be inserted.
         * 
         * @param index - the node will be inserted before indexth node in the list.
         * @param val - the value which will be inserted.
         */
        public void AddAtIndex(int index, int val)
        {
            if (length == 0)
            {
                if (index == 0)
                {
                    AddAtHead(val);
                }
                else
                {
                    return;
                }
            }
            else if (length == 1)
            {
                if (index == 0)
                {
                    AddAtHead(val);
                }
                else if (index == 1)
                {
                    AddAtTail(val);
                }
                else
                {
                    return;
                }
            }
            else
            {
                if (!(0 <= index && index <= length))
                {
                    return;
                }
                else if (index == 0)
                {
                    AddAtHead(val);
                }
                else if (index == length)
                {
                    AddAtTail(val);
                }
                else
                {
                    if (index <= (length / 2) - 1)
                    {
                        Node ptr = head;
                        int i = 0;
                        while (i < index - 1)
                        {
                            ptr = ptr.getNext();
                            i++;
                        }
                        var tmp = new Node(ptr, val, ptr.getNext());
                        ptr.getNext().setPrev(tmp);
                        ptr.setNext(tmp);
                        length++;
                    }
                    else
                    {
                        Node ptr = tail;
                        int i = length - 1;
                        while (i > index)
                        {
                            ptr = ptr.getPrev();
                            i--;
                        }
                        var tmp = new Node(ptr.getPrev(), val, ptr);
                        ptr.getPrev().setNext(tmp);
                        ptr.setPrev(tmp);
                        length++;

                    }
                }
            }
        }


        /**
         * int get(int index) Get the value of the indexth node in 
         * the linked list. If the index is invalid, return -1.
         * 
         * @param index - The value at this index will be returned if index is valid.
         * Otherwise -1.
         * 
         * @return - The value at index "index" if index is valid. Otherwise -1.
         */

        public int Get(int index)
        {
            if (length == 0)
            {
                return -1;
            }
            else if (length == 1)
            {
                if (index == 0)
                {
                    return head.getVal();
                }
                else
                {
                    return -1;
                }
            }
            else if (length == 2)
            {
                if (index == 0)
                {
                    return head.getVal();
                }
                else if (index == 1)
                {
                    return tail.getVal();
                }
                else
                {
                    return -1;
                }
            }
            else
            {
                if (!(0 <= index && index <= length - 1))
                {
                    return -1;
                }
                else if (index == 0)
                {
                    return head.getVal();
                }
                else if (index == length - 1)
                {
                    return tail.getVal();
                }
                else
                {
                    if (index < (length / 2) - 1)
                    {
                        int i = 0;
                        Node pointer = head;
                        while (i < index)
                        {
                            pointer = pointer.getNext();
                            i++;
                        }
                        return pointer.getVal();
                    }
                    else
                    {
                        int i = length - 1;
                        Node pointer = tail;
                        while (i > index)
                        {
                            pointer = pointer.getPrev();
                            i--;
                        }
                        return pointer.getVal();
                    }
                }
            }
        }


        /**
         * Adds an node with value "val" before all elements in the list, so for now on
         * this node will be the 0-th node in the list.
         * 
         * @param val - The value to be added.
         * 
         */
        public void AddAtHead(int val)
        {
            Node tmp = new Node(null, val, null);
            if (length == 0)
            {
                head = tmp;
                tail = tmp;
                length = 1;
            }
            else
            {
                head.setPrev(tmp);
                tmp.setNext(head);
                head = tmp;
                length++;
            }
        }




        /**
         * Adds a node with value val after all elements in the list, so for now on 
         * this will be the last node in the list.
         * 
         * @param val - The value to be added.
         * 
         * 
         */
        public void AddAtTail(int val)
        {
            Node tmp = new Node(null, val, null);
            if (length == 0)
            {
                head = tmp;
                tail = tmp;
            }
            else
            {
                tmp.setPrev(tail);
                tail.setNext(tmp);
                tail = tmp;
            }
            length++;
        }



        // String representation of a list.
        public string ToString()
        {
            if(this.length == 0)
            {
                return "[]";
            }

            if(this.length == 1)
            {
                return "[" + head.getVal() + "]";
            }

            string str = "[";
            Node tmp = head;

            while(tmp != null)
            {
                str += tmp.getVal() + ", ";
                tmp = tmp.getNext();
            }
            return str.Substring(0, str.Length - 2) + "]";

        }

    }
}
