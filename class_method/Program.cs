using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace class_method
{
    class Program
    {
        static void Main(string[] args)
        {
            Person tom = new Person();
            tom.Print();
            Person1 ben = new Person1("ben", 64);
            ben.Print1();
        }
    }

    /*
     * Work first class
     */
    class Person
    {
        public string name = "Undefined";
        public int age=12;

        public void Print()
        {
            Console.WriteLine($"Имя: {name}  Возраст: {age}");
        }
    }

    /*
     * constructors
     */

    class Person1
    {
        public string name;
        public int age;
        public Person1(string name) { name = "Undefined"; age = 12; }
        public Person1(string name, int age)
        {
            this.name = name;
            this.age = age;
        }
        public void Print1()
        {
            Console.WriteLine($"Имя: {name}  Возраст: {age}");
        }
    }




}
