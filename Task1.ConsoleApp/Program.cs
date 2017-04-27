using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1.ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {

            Timer timer = new Timer();

            Subscriber1 subs = new Subscriber1();
            Subscriber2 subs2 = new Subscriber2();

            subs.Subscribe(timer);
            subs2.Subscribe(timer);

            timer.Notificate(3);
            subs.UnSubscribe(timer);

            timer.Notificate(2);
        }
    }

    public class Subscriber1
    {
        public void Subscribe(Timer timer)
        {
            timer.Notification += SomeMethod;
            Console.WriteLine("Subscribed 1");
        } 

        public void UnSubscribe(Timer timer)
        {
            timer.Notification -= SomeMethod;
            Console.WriteLine("unsubscribe 2");
        }
        private void SomeMethod(object sender, TimerEventArgs e)
        {
            Console.WriteLine($"Event works after {e.Time}");
        }
    }

    public class Subscriber2
    {
        public void Subscribe(Timer timer)
        {
            timer.Notification += SomeMethod;
            Console.WriteLine("Subscribed 2");
        }

        public void Unregister(Timer timer)
        {
            timer.Notification -= SomeMethod;
            Console.WriteLine("usnubscribe 2");
        }
        private void SomeMethod(object sender, TimerEventArgs e)
        {
            Console.WriteLine($"Event works after {e.Time}");
        }
    }
}
