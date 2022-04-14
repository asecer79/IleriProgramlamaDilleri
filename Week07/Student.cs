using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week07
{
    internal class Student:IComparable<Student>,IEquatable<Student>,IEqualityComparer<Student>,IEnumerable<double>
    {
        public Student()
        {
            AvgGrades = new List<double>();

            for (int i = 0; i < 9; i++)
            {
                AvgGrades.Add(new Random().Next(0,100));
            }
            
        }

        public int Id { get; set; }
        public string Name { get; set; }

        public List<double> AvgGrades { get; set; }

        //public int CompareTo(object? student)
        //{
        //    var incoming = student as Student;

        //    return this.Id.CompareTo(incoming.Id);
        //}
        public int CompareTo(Student? other)
        {
            return Id.CompareTo(other.Id);
        }

        public bool Equals(Student? other)
        {
            if (ReferenceEquals(null, other)) return false;
            if (ReferenceEquals(this, other)) return true;
            return Id == other.Id && Name == other.Name;
        }


        public bool Equals(Student x, Student y)
        {
            if (ReferenceEquals(x, y)) return true;
            if (ReferenceEquals(x, null)) return false;
            if (ReferenceEquals(y, null)) return false;
            if (x.GetType() != y.GetType()) return false;
            return x.Id == y.Id && x.Name == y.Name;
        }

        public int GetHashCode(Student obj)
        {
            return HashCode.Combine(obj.Id, obj.Name);
        }


        public IEnumerator<double> GetEnumerator()
        {
            foreach (var grade in AvgGrades)
            {
                yield return grade;
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
