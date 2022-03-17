using System;
using System.Drawing;
using System.Reflection.Metadata.Ecma335;

namespace Week3
{
    public class Program
    {
        private static int b = 9;
        private static void Main(string[] args)
        {
            b = 9;

            //Person person1 = new Person();
            Person person2 = new Person("Aydın");

            Person person3 = new Person("Aydın", 39, 'M', "Prof");

            var person4 = new Person(age: 39, gender: 'M', name: "Aydın", occupation: "Prof");


            Person.personOrder = 3;

            Person p1 = new Person()
            {
                Age = 15,
                Name = "Ali"
            };

            Person p2 = new Person()
            {
                Age = 15,
                Name = "Safiye"
            };
            Person p3 = new Person()
            {
                Age = 15,
                Name = "Memnune"
            };



            Console.WriteLine(person4[3]);

            Person.personOrder = 5;

            M1();

            var pi = Person.GetPi();
        }
        
        static void M1()
        {
            ;
        }
    }

    class Car
    {
        //fields
        private int year;
        private string brand;

        //properties
        public int TireSize { get; set; }
        public Color Color { get; set; }





    }
    class Person
    {

        public static double GetPi()
        {
            return Math.PI;
        }

        public static int personOrder;

        private string _name;
        private int _age;
        private char gender;
        private string occupation;


        public Person()
        {
            //......
        }

        public Person(string name)
        {
            _name = name;
        }

        public Person(string name, int age, char gender, string occupation)
        {
            _name = name;
            _age = age;
            this.gender = gender;
            this.occupation = occupation;
        }




        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        public int Age
        {
            get { return _age; }
            set { _age = value; }
        }

        public char getGender()
        {
            return gender;
        }

        public void setGender(char _gender)
        {
            gender = _gender;
        }

        //public string Name { get; set; }
        //public int Age { get; set; }
        //public char Gender { get; set; }
        //public string Occupation { get; set; }

        public void Walk()
        {
            Console.WriteLine("I am walking...");
        }

        public void Eat()
        {
            Console.WriteLine("I am eating...");
        }

        public void Sleep()
        {
            Console.WriteLine("I am sleeping...");
        }

        public void Work()
        {
            Console.WriteLine("I am working...");
        }

        ~Person()
        {
            Console.WriteLine("Destructor was called");
        }

        private int[] list = new[] { 1, 2, 3, 4 };

        public int this[int index]
        {
            get
            {
                return list[index];
            }
            set
            {
                list[index] = value;
            }
        }
    }
}


