
using System.Collections;

namespace Week09
{

    class Program
    {
        static void Main(string[] args)
        {
            //ArrayList list = new ArrayList();

            //list.Add(3);
            //list.Add(36);

            //int sum = 0;

            //foreach (var item in list)
            //{
            //    sum += (int)item;
            //}


            //List<int> list2 = new List<int>();
            //list2.Add(3);
            //list2.Add(36);

            //foreach (var item in list2)
            //{
            //    sum += item;
            //}



            //Hashtable hashtable = new Hashtable();
            //hashtable.Add("key",369);

            //foreach (var item in hashtable)
            //{
            //    Console.WriteLine(((DictionaryEntry)item).Value);
            //}

            //Queue queue = new Queue();
            //queue.Enqueue("sa");
            //queue.Enqueue(12);
            //foreach (var item in queue)
            //{
            //    Console.WriteLine(item);
            //}

            //Stack stack = new Stack();
            //stack.Push(1233);
            //stack.Push("123");

            //foreach (var item in stack)
            //{
            //    Console.WriteLine(item);
            //}


            //List<int> list1 = new List<int>();
            //list1.Add(2);

            //Dictionary<string, double> dictionary = new Dictionary<string, double>();

            //foreach (var item in dictionary)
            //{

            //}

            //Stack<string> stack1 = new Stack<string>();
            //HashSet<int> hashSet = new HashSet<int>();

            //hashSet.Add(2);
            //hashSet.Add(1);

            //LinkedList<double> list3 = new LinkedList<double>();

            //list3.Remove(new LinkedListNode<double>(3));

            //Tree<double> rootNode = new Tree<double>();
            //rootNode.NodeValue = 1;
            //rootNode.Left = new Tree<double>() { NodeValue = 2 };
            //rootNode.Left.Left = new Tree<double>() { NodeValue = 3 };
            //rootNode.Left.Right = new Tree<double>() { NodeValue = 3 };

            //rootNode.Right = new Tree<double>() { NodeValue = 3 };
            //rootNode.Right.Left = new Tree<double>() { NodeValue = 4 };
            //rootNode.Right.Right = new Tree<double>() { NodeValue = 5 };

            Sozluk<string, double> sozluk = new Sozluk<string, double>();

            sozluk.Add("ad1", 1);
            sozluk.Add("ad1", 2);
            sozluk.Add("ad2", 3);
            sozluk.Add("ad3", 4);
            sozluk.Add("ad2", 5);

        }
    }


    class Tree<T>
    {
        public T NodeValue { get; set; }

        public Tree<T> Left { get; set; }

        public Tree<T> Right { get; set; }
    }

    class Sozluk<TKey, TValue>
    {
        private Node Root { get; set; }

        class Node
        {
            public TKey Key { get; set; }
            public TValue Value { get; set; }
            public Node Next { get; set; }
        }

        public void Add(TKey key, TValue value)
        {
            if (Root==null)
            {
                Root = new Node()
                {
                    Key = key,
                    Value = value
                };
            }
            else
            {
                //overwrite same key for uniqueness
                if (key.GetHashCode()==Root.Key.GetHashCode())
                {
                    Root.Value= value;
                    return;//overwrite same key for uniqueness
                }

                var current = Root;
                var newNode = new Node()
                {
                    Key = key,
                    Value = value,
                };

                while (current.Next != null)
                {
                    //overwrite same key for uniqueness
                    if (key.GetHashCode() == current.Key.GetHashCode())
                    {
                        current.Value = value;
                        return;//overwrite same key for uniqueness
                    } 
                    
                    current = current.Next;
                }

                current.Next = newNode;
            }
        }
    }
}