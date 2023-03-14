using System;

namespace Singleton
{
    class Program
    {
        static void Main(string[] args)
        {
            Singleton singleton1 = Singleton.GetInstance();
            Singleton singleton2 = Singleton.GetInstance();

            Console.WriteLine("singleton1 hashcode: " + singleton1.GetHashCode());
            Console.WriteLine("singleton2 hashcode: " + singleton2.GetHashCode());
        }
    }
}
