using System;

namespace Singleton
{
    public sealed class Singleton
    {
        // private to prevent direct construction calls
        private Singleton() { }

        // single static field which is always returned when needed
        private static Singleton instance;

        //access to the singleton instance on the first try, it creates a singleton object
        //every other try it returns the same instance
        public static Singleton GetInstance()
        {
            if (instance == null)
            {
                instance = new Singleton();
            }
            return instance;
        }

        public void someBusinessLogic()
        {
            Console.WriteLine("Do work");
        }
    }
}
