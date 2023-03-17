using System;

namespace Observer
{
    public class BinaryObserver : Observer
    {
        public BinaryObserver(Subject subject)
        {
            this.subject = subject;
            subject.attach(this);
        }

        public override void update()
        {
            Console.WriteLine($"Binary value: { Convert.ToString(subject.getState(), 2) }");
        }
    }
}
