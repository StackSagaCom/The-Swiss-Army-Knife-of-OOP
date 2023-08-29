using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise.DesignPatterns
{
    // Subject class
    public class Subject
    {
        private List<IObserver> observers = new List<IObserver>();

        public void Attach(IObserver observer)
        {
            observers.Add(observer);
        }

        public void Detach(IObserver observer)
        {
            observers.Remove(observer);
        }

        public void Notify()
        {
            foreach (var observer in observers)
            {
                observer.Update();
            }
        }
    }

    // Observer interface
    public interface IObserver
    {
        void Update();
    }

    // ConcreteObserver class
    public class ConcreteObserver : IObserver
    {
        private string _name;
        private Subject _subject;

        public ConcreteObserver(string name, Subject subject)
        {
            _name = name;
            _subject = subject;
        }

        public void Update()
        {
            Console.WriteLine("Observer {0} updated", _name);
        }
    }

}
