using System;

namespace Observer
{
    class HexObserver : Observer
    {
        public HexObserver(Subject subject)
        {
            this.subject = subject;
            subject.attach(this);
        }
        public override void update()
        {
            Console.WriteLine($"Hex value: { this.subject.getState().ToString("X") }");
        }
    }
}
