using Exercise.DesignPatterns;
using System;
using System.ComponentModel;
using static Exercise.DesignPatterns.Factory;

static class Program
{
    static void Main(string[] args)
    {
        CallAdapter();
        CallFactory();
        CallObserver();
        CallSingleton();
    }

    // Adapter design pattern, which is a structural design pattern used to enable two incompatible interfaces to work together.
    // Adaptee class (Adaptee) :This class represents an existing component or system with a method called SpecificRequest() that the client code cannot directly use due to incompatibility.

    // Adapter class (Adapter) :This class implements the ITarget interface and contains an instance of the Adaptee class.
    // It acts as a bridge between the client code and the Adaptee.The Request() method in the adapter calls the SpecificRequest() method of the Adaptee,
    // allowing the client code to indirectly use the functionality of the Adaptee.
    static void CallAdapter()
    {
        ITarget target = new Adapter();
        target.Request();
        Console.WriteLine("\n ------------------------");
    }

    //Factory Method design pattern, which is a creational design pattern used to create objects without specifying the exact class of object that will be created
    //In summary, the Factory Method design pattern encapsulates the process of creating objects of different classes under a common interface.
    //The AnimalFactory class acts as a factory for creating different types of animals (dogs and cats in this case).
    //The CallFactory method demonstrates how the Factory pattern is used to create animals and invoke their Speak methods, providing a flexible and extensible
    //way to create objects while hiding the creation details.
    static void CallFactory()
    {
        IAnimal animal = AnimalFactory.CreateAnimal("dog");
        animal.Speak();

        animal = AnimalFactory.CreateAnimal("cat");
        animal.Speak();

        Console.WriteLine("\n ------------------------");
    }

    //Observer design pattern, which is a behavioral design pattern used to define a one-to-many dependency between objects. 
    // In summary, the Observer design pattern establishes a dependency relationship between a subject(publisher) and multiple observers(subscribers).
    // The Subject class maintains a list of observers and provides methods to attach, detach, and notify observers.The ConcreteObserver class implements the IObserver interface
    // to receive notifications from the subject and react accordingly.
    //The CallObserver method demonstrates how the Observer pattern works by creating a subject, attaching multiple observers, and notifying them.When the subject's state changes
    //(notified), each observer updates and responds. This pattern is useful for implementing event handling, logging, and decoupling components in a system.
    static void CallObserver()
    {
        var subject = new Subject();

        var observer1 = new ConcreteObserver("A", subject);
        var observer2 = new ConcreteObserver("B", subject);
        var observer3 = new ConcreteObserver("C", subject);

        subject.Attach(observer1);
        subject.Attach(observer2);
        subject.Attach(observer3);

        subject.Notify();
        Console.WriteLine("\n ------------------------");
    }

    //In this code, the Main method attempts to create two instances of the Singleton class using the Singleton.Instance property.
    //However, since the Singleton pattern ensures that there is only one instance of the class, the instance1 and instance2
    //references will both point to the same instance.
    static void CallSingleton()
    {
        // Attempting to create instances of Singleton
        Singleton instance1 = Singleton.Instance;
        Singleton instance2 = Singleton.Instance;

        // Check if both instances are the same
        bool areInstancesEqual = instance1 == instance2;

        Console.WriteLine($"Are instances equal? {areInstancesEqual}");
    }
}




