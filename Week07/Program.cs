

using System.Collections;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using Week07.Annotations;

namespace Week07
{
    class Program:IComparer<Student>
    {
        static void Main(string[] args)
        {


            //Student student = new Student();

            //foreach (var grade in student)
            //{
            //    Console.WriteLine(grade);
            //}

            MyList<Student> myList = new MyList<Student>();

            myList.Add(new Student());

            foreach (var item in myList)
            {
                foreach (var grade in item)
                {
                    Console.WriteLine(grade);
                }
            }

            //List<Student> list = new List<Student>();
            //list.Add(new Student() { Id = 89, Name = "Melih" });
            //list.Add(new Student() { Id = 5, Name = "Ahmet" });
            //list.Add(new Student() { Id = 45, Name = "Mustafa" });
            //list.Add(new Student() { Id = 2, Name = "Emine" });
            //list.Add(new Student() { Id = 17, Name = "Ceyda" });

            //list.Sort();

            //Program prg = new Program();

            //Console.WriteLine(prg.Compare(list[1], list[1]));
      
            //Console.WriteLine();
            //Console.WriteLine(list[1].Equals(list[2]));

            //Console.WriteLine(list[1].Equals(list[2],list[2]));

            //foreach (var item in list)
            //{
            //    Console.WriteLine($"{item.Id}-{item.Name}");
            //}

            //MessageSender sender = new MessageSender();

            //sender.SendMessage();
        }

        public int Compare(object? x, object? y)
        {
            throw new NotImplementedException();
        }

        public int Compare(Student x, Student y)
        {
            return x.Id.CompareTo(y.Id);
        }
    }






    class MessageSender : INotifyPropertyChanged
    {
        public void SendMessage()
        {
            //....
            IsSent = true;
            // 
        }

        private bool isSent;
        public bool IsSent
        {
            get
            {
                return isSent;
            }
            set
            {
                isSent = value;

                if (value)
                {
                    OnPropertyChanged(nameof(IsSent));
                }
            }
        }

        public event PropertyChangedEventHandler? PropertyChanged;

        [NotifyPropertyChangedInvocator]
        protected virtual void OnPropertyChanged([CallerMemberName] string? propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));

            Console.WriteLine(propertyName + ": Message sent successfully...");

            new Logger().LogEvent();
        }
    }

    class Logger
    {
        public void LogEvent()
        {
            Console.WriteLine("Logged Successfully");
        }
    }
}