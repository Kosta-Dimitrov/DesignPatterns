using System;

namespace Observer
{
    public class DecimalObserver : Observer
    {
        public DecimalObserver(Subject subject)
        {
            this.subject = subject;
            subject.attach(this);
        }
        public override void update()
        {
            Console.WriteLine($"Decimal value: { this.subject.getState() }");
        }
    }
}
