
using System.Collections;
using System.Collections.Generic;

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

            sozluk.Add("0", 0);
            sozluk.Add("1", 1);
            sozluk.Add("2", 2);
            sozluk.Add("3", 3);

            sozluk.Add("0", 3);
            sozluk.Add("1", 2);
            sozluk.Add("2", 1);
            sozluk.Add("3", 0);

            sozluk.Add("3", 3);
            sozluk.Add("2", 2);
            sozluk.Add("1", 1);
            sozluk.Add("0", 0);

            sozluk["0"] = 100;

            var v1 = sozluk["0"];

            var keys = sozluk.Keys;
            var values = sozluk.Values;

            foreach (var item in sozluk)
            {
                var rec = item.Key;
            }
        }
    }


    class Tree<T>
    {
        public T NodeValue { get; set; }

        public Tree<T> Left { get; set; }

        public Tree<T> Right { get; set; }
    }

    class Sozluk<TKey, TValue>:IEnumerable<KeyValuePair<TKey, TValue>>
    {

        public TValue this[TKey key]
        {
            get
            {
                return GetValue(key);
            }
            set
            {
                Add(key,value);
            }
        }

        public int Count { get; set; } = 0;

        public TKey[] Keys
        {
            get
            {
                return GetKeys();
            }
        }

        public TValue[] Values
        {
            get
            {
                return GetValues();
            }
        }

        private Node Root { get; set; }

        class Node
        {
            public TKey Key { get; set; }
            public TValue Value { get; set; }
            public Node Next { get; set; }
        }

        public void Add(TKey key, TValue value)
        {
            if (Root == null)
            {
                Root = new Node()
                {
                    Key = key,
                    Value = value
                };
                Count++;
            }
            else
            {

                var current = Root;

                if (current.Key.GetHashCode() == key.GetHashCode())
                {
                    current.Value = value;
                    return;
                }

                var newNode = new Node() { Key = key, Value = value, };

                while (current.Next != null)
                {   
                    current = current.Next;
                    //overwrite same key for uniqueness
                    if (current.Key.GetHashCode()==key.GetHashCode())
                    {
                        current.Value = value;
                        return;
                    }
                    
                }

                current.Next = newNode;
                Count++;
            }
        }

        private bool KeyExists(TKey key)
        {
            var current = Root;

            if (key.GetHashCode() == current.Key.GetHashCode())
                return true;
            else
            {
                while (current.Next != null)
                {
                    current = current.Next;
                    if (key.GetHashCode() == current.Key.GetHashCode())
                    {
                        return true;
                    }
                }
            }

            return false;
        }

        private TValue GetValue(TKey key)
        {
            var current = Root;

            if (key.GetHashCode() == current.Key.GetHashCode())
                return current.Value;
            else
            {
                while (current.Next != null)
                {
                    current = current.Next;
                    if (key.GetHashCode() == current.Key.GetHashCode())
                    {
                        return current.Value;
                    }
                }
            }

            return default(TValue);
        }

        private TKey[] GetKeys()
        {
            if (Count > 0)
            {
                TKey[] keys = new TKey[Count];
                var current = Root;
                keys[0] = current.Key;

                int i = 1;
                while (current.Next != null)
                {
                    current = current.Next;
                    keys[i++] = current.Key;
                }

                return keys;
            }
            else
            {
                return null;
            }
        }

        private TValue[] GetValues()
        {
            if (Count > 0)
            {
                TValue[] values = new TValue[Count];
                var current = Root;
                values[0] = current.Value;

                int i = 1;
                while (current.Next != null)
                {
                    current = current.Next;
                    values[i++] = current.Value;
                }

                return values;
            }
            else
            {
                return null;
            }
        }
        
        public IEnumerator<KeyValuePair<TKey, TValue>> GetEnumerator()
        {
            for (int i = 0; i < Count; i++)
            {
                var key = Keys[i];
                var value = Values[i];
                yield return new KeyValuePair<TKey, TValue>(key, value);
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}