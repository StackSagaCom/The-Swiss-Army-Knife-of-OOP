using Exercise;
using ExtensionMethod;
using Exercise.OOP;
using static Exercise.OOP.Inheritance;
using static Exercise.OOP.Composition;

static class Program
{
    static void Main(string[] args)
    {
        // The Constructors 
        CallConstructor();

        //OOP key concepts
        CallEncapsulation();
        CallAbstraction();
        CallInheritance();
        CallPolymorphism();
        CallComposition();

        //Common interview topics
        CallAbstractClass();
        MyPreciousExtension();
        CallMulticastDelegate();
        CallDestructor();
    }

    //First example  - In summary, the code beneath demonstrates the concept of constructors in C#. Constructors are special methods used to initialize objects when they 
    //are created. The Constructor class in the code has a default constructor and a parametrized constructor, 
    //both of which are used to set the name and location fields of instances of the class. 
    //The CallConstructor method showcases how to use these constructors and print out their effects.

    static void CallConstructor()
    {
        Console.WriteLine("1st example EXAMPLE CONSTRUCTOR");
        Console.WriteLine("Default constructor..");
        Constructor constructedUser = new Constructor();
        Console.WriteLine(constructedUser.name);
        Console.WriteLine(constructedUser.location);
        Console.WriteLine("Parametrized constructor. Next step - you define name and location");
        constructedUser = new Constructor("Arpad Diosy", "Osijek");
        Console.WriteLine(constructedUser.name);
        Console.WriteLine(constructedUser.location);
        Console.WriteLine("END OF EXAMPLE CONSTRUCTOR");
        Console.WriteLine("\n ------------------------");
    }

    //Second example - Code example demonstrates the concept of encapsulation in object-oriented programming.
    //Encapsulation is a principle that restricts the direct access to certain fields of a class and provides controlled access through getter and setter
    //methods. In this example, the Encapsulation class uses private fields and properties to achieve encapsulation,
    //allowing controlled access to the name and location fields. The CallEncapsulation method showcases how to use these properties to set
    //and retrieve data while maintaining data integrity and encapsulation.

    static void CallEncapsulation()
    {
        Console.WriteLine("\n ");
        Console.WriteLine("2nd example EXAMPLE Encapsulation");
        Encapsulation encapsulation = new Encapsulation();
        // set accessor will invoke
        encapsulation.Name = "Arpad Diosy";
        // set accessor will invoke
        encapsulation.Location = "Osijek";
        // get accessor will invoke
        Console.WriteLine("Name: " + encapsulation.Name);
        // get accessor will invoke
        Console.WriteLine("Location: " + encapsulation.Location);
        Console.WriteLine("END OF EXAMPLE Encapsulation");
        Console.WriteLine("\n ------------------------");
    }

    //Third example - In summary, the code example demonstrates the concept of abstraction in object-oriented programming.
    //Abstraction is a principle that focuses on exposing only the necessary details of an object while hiding the unnecessary complexities.
    //In this example, the Abstraction class abstracts away the inner workings of laptop details.
    //By using private fields and public properties for brand and model, and encapsulating the implementation details within the LaptopDetails method, the class provides
    //a higher-level interface for interacting with laptop information.
    //The CallAbstraction method showcases how to use the properties to set data and the LaptopDetails method to retrieve and display laptop details,
    //while keeping the underlying implementation abstracted and hidden.

    static void CallAbstraction()
    {
        Console.WriteLine("\n ");
        Console.WriteLine("3rd example EXAMPLE Abstraction");
        Abstraction abstraction = new Abstraction();
        abstraction.Brand = "Dell";
        abstraction.Model = "XPS";
        abstraction.LaptopDetails();
        Console.WriteLine("\"END OF EXAMPLE Abstraction");
        Console.WriteLine("\n ------------------------");
    }

    //Fourth example - In summary, the code example demonstrates the concept of inheritance in object-oriented programming.
    //Inheritance is a mechanism that allows a class to inherit properties and behaviors from another class, fostering code reuse and hierarchy.
    //In this example, the Details class inherits from the User class, showcasing the inheritance relationship.
    //The User class serves as the base class, containing fields for Name and Location, as well as methods to retrieve and display user information.
    //The derived class, Details, inherits from User and adds an additional field, Age, along with a method to display the user's age.
    //The CallInheritance method showcases how inheritance works by creating an instance of the Details class, which inherits the properties and methods from the User class.
    //While the derived class can access the Name field and methods of the base class, it cannot access the Location field directly due to its private access modifier.
    //This demonstrates the concept of encapsulation within inheritance.
    //Overall, the example highlights how inheritance allows for code organization, extensibility, and reusability by establishing a parent-child relationship between classes.

    static void CallInheritance()
    {
        Console.WriteLine("\n ");
        Console.WriteLine("4th example EXAMPLE Inheritance");
        Details details = new Details();
        details.Name = "Arpad Diosy";
        // Compile Time Error
        //details.Location = "Osijek";
        details.Age = 32;
        details.GetUserInfo("Osijek");
        details.GetAge();
        Console.WriteLine("\nPress Any Key to Exit..");
        Console.WriteLine("\"END OF EXAMPLE Inheritance");
        Console.WriteLine("\n ------------------------");
    }

    //Fifth example - In summary, the provided code example demonstrates the concept of polymorphism in object-oriented programming.
    //Polymorphism allows objects of different classes to be treated as objects of a common base class, enabling the same method to exhibit different behaviors based
    //on the specific context. In this example, the Polymorphism class showcases method overloading as a form of compile-time polymorphism.
    //The AddNumbers method in the Polymorphism class is overloaded with two versions: one that takes two integer parameters and another that takes three integer parameters.
    //This demonstrates polymorphism because both methods have the same name but different parameter lists, enabling them to be invoked based on the number of arguments provided.
    //The CallPolymorphism method demonstrates how polymorphism works by creating an instance of the Polymorphism class and invoking the overloaded AddNumbers methods.
    //The compiler determines which version of the method to call based on the number and types of arguments passed.
    //Overall, the example illustrates how polymorphism, through method overloading, enables the same method name to have different implementations, providing flexibility
    //and improved code readability.

    static void CallPolymorphism()
    {
        Console.WriteLine("\n ");
        Console.WriteLine("5th example EXAMPLE Polymorphism");
        Polymorphism polymorphism = new Polymorphism();
        polymorphism.AddNumbers(1, 2);
        polymorphism.AddNumbers(1, 2, 3);
        Console.WriteLine("\nPress Enter Key to Exit..");
        Console.WriteLine("\"END OF EXAMPLE Polymorphism");
        Console.WriteLine("\n ------------------------");
    }

    //Sixth example- In this example, we have two classes: BodyPart and Animal. Instead of creating a hierarchy of animal classes with different body parts using inheritance,
    //we use composition. The Animal class contains a list of BodyPart objects. The AddBodyPart method allows us to add body parts to an animal.
    //In the Main method, we create instances of animals(dog and cat) and add body parts to them.By using composition, we can represent the relationship between
    //animals and their body parts more flexibly. Animals are composed of body parts, and changes to body parts or animals won't affect the other.
    //Composition is a powerful alternative to inheritance when you want to build complex structures while keeping your codebase modular, maintainable,
    //and less prone to inheritance-related issues.
    public static void CallComposition()
    {
        Console.WriteLine("\n ");
        Console.WriteLine("6th EXAMPLE Composition");
        Animal dog = new Animal("Dog");
        dog.AddBodyPart("Leg");
        dog.AddBodyPart("Tail");

        Animal cat = new Animal("Cat");
        cat.AddBodyPart("Leg");
        cat.AddBodyPart("Tail");
        cat.AddBodyPart("Whisker");

        Console.WriteLine("Dog body parts:");
        foreach (var part in dog.BodyParts)
        {
            Console.WriteLine(part.Name);
        }

        Console.WriteLine("\nCat body parts:");
        foreach (var part in cat.BodyParts)
        {
            Console.WriteLine(part.Name);
        }
        Console.WriteLine("END OF EXAMPLE Composition");
        Console.WriteLine("\n ------------------------");
    }

    //Seventh example -In summary, the code example demonstrates the concept of abstract classes and methods in object-oriented programming.
    //Abstract classes serve as blueprints for other classes and cannot be instantiated themselves. Abstract methods declared within abstract classes provide a template for
    //methods that must be implemented by derived classes.
    //In this example, the `Info` class is an abstract class containing an abstract method named `GetDetails`. The `AbstractClass` class inherits from `Info` and
    //provides an implementation for the `GetDetails` method.
    //By marking the `Info` class as abstract and the `GetDetails` method as abstract, you're establishing a contract that any class inheriting from `Info` must implement
    //the `GetDetails` method. The `AbstractClass` class fulfills this contract by providing an implementation for `GetDetails`.
    //The `CallAbstractClass` method showcases how to work with abstract classes and their methods.An instance of the `AbstractClass` class is created and the `GetDetails`
    //method is called, which ultimately invokes the overridden method in the derived class.
    //Overall, this example demonstrates how abstract classes and methods provide a foundation for creating consistent and standardized behavior across derived classes
    //while allowing each derived class to provide its own implementation.

    static void CallAbstractClass()
    {
        Console.WriteLine("\n ");
        Console.WriteLine("7th example EXAMPLE Calling abstract class");
        AbstractClass abstractClass = new AbstractClass();
        abstractClass.GetDetails("Arpad Diosy", "Osijek", 32);
        Console.WriteLine("END OF EXAMPLE Calling Abstract Class");
        Console.WriteLine("\n ------------------------");
    }

    //Eighth example - In summary, the code example showcases the concept of extension methods in C#. Extension methods allow you to add new functionality to existing classes
    //without modifying their source code. They are especially useful when working with classes that you don't have control over or cannot modify directly.
    //In this example, a static class named MyExtension is defined within the ExtensionMethod namespace.This class contains an extension method named WordCount
    //that operates on strings.The extension method splits the input string using spaces, commas, and periods as delimiters,
    //then counts the number of non-empty segments to determine the word count.
    //The MyPreciousExtension method demonstrates how to use the extension method.It creates a string wordNumber, and then calls the WordCount extension method on it.
    //The result is printed to the console, showing the number of words in the string.
    //Overall, the example illustrates how extension methods can be used to enhance the capabilities of existing classes, enabling you to write more concise
    //and readable code by encapsulating additional functionality in separate methods.

    public static void MyPreciousExtension()
    {
        Console.WriteLine("\n ");
        Console.WriteLine("8th EXAMPLE MyPreciousExtension");
        string wordNumber = "Show me number of words";
        Console.WriteLine("Number of words is: " + wordNumber.WordCount());
        Console.WriteLine("END OF EXAMPLE MyPreciousExtension");
        Console.WriteLine("\n ------------------------");
    }

    //Ninth example- In summary, the provided code example demonstrates the concept of multicast delegates in C#. A delegate is a type that references methods,
    //and a multicast delegate can hold references to multiple methods. When invoked, a multicast delegate will call all the methods it references in the order
    //they were added.
    //In this example, a delegate named SampleDelegate is declared within the Exercise namespace.The MathOperations class defines three methods:
    //Add, Subtract, and Multiply, each performing respective mathematical operations.The CallMulticastDelegate method demonstrates the use of multicast delegates.
    //The SampleDelegate delegate is instantiated with the Add method of the MathOperations class. Then, two more methods, Subtract and Multiply,
    //are added to the delegate using the += operator. When the delegate is invoked with arguments (10, 90), it calls all three methods, resulting in the addition,
    //subtraction, and multiplication operations being executed and their results printed to the console.
    //Overall, this example illustrates how multicast delegates provide a way to call multiple methods through a single delegate instance, offering a flexible and
    //powerful mechanism for handling multiple operations in a sequential manner.
    
    public static void CallMulticastDelegate()
    {
        Console.WriteLine("\n ");
        Console.WriteLine("9th EXAMPLE CallMulticastDelegate");
        MathOperations m = new MathOperations();
        // Instantiate delegate with add method
        SampleDelegate dlgt = m.Add;
        dlgt += m.Subtract;
        dlgt += m.Multiply;
        dlgt(10, 90);
        Console.WriteLine("END OF EXAMPLE CallMulticastDelegate");
        Console.WriteLine("\n ------------------------");
    }

    

    //Tenth example- In summary, code  demonstrates the concept of destructors in C#. Destructors are special methods in a class that are called automatically
    //when an instance of the class is no longer needed and is being garbage-collected.
    //Destructors are primarily used for cleaning up resources or performing cleanup operations before an object is removed from memory.
    // In this example, the Destructor class defines a constructor and a destructor.The constructor is called when an instance of the class is created,
    // and it prints a message indicating that an instance has been created.The destructor is denoted by the ~symbol followed by the class name,
    // and it prints a message indicating that an instance is being destroyed.The Details method creates an instance of the Destructor class.
    //The CallDestructor method showcases the concept of destructors.It calls the Details method to create an instance of the Destructor class.
    //After that, it explicitly calls GC.Collect() to initiate garbage collection, which in turn triggers the destructor to be called for the instance of the Destructor
    //class that was created earlier.
    //Overall, the example demonstrates how destructors can be used to perform cleanup operations when an object is being removed from memory,
    //and how they are automatically invoked during garbage collection.

    static void CallDestructor()
    {
        Console.WriteLine("\n ");
        Console.WriteLine("10th example EXAMPLE Calling Destructor");
        Details();
        GC.Collect();
    }
    public static void Details()
    {
        // Created instance of the class
        Destructor user = new Destructor();
    }
}
