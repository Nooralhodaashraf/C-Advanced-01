using System.Data;
using System.Reflection.Metadata;
using System.Runtime.Intrinsics.X86;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace C__Advanced_01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Q1
            //What is a generic class? Why use generics?
            //generic class is a class that can work with different data types without specifying the exact type when the class is created using <T>=> for identfing any type 
            //why generics :
            // Type Safety - Code Reusability - Better Performance - Cleaner Code
            #endregion

            #region Q2
            //Write a generic class Container<T> with Add and Get methods.
            //class created ... lets use it :
            //Container<int> intContainer = new Container<int>();
            //intContainer.Add(100);
            //Console.WriteLine(intContainer.Get());//100
            ////================================================
            //Container<string> stringContainer = new Container<string>();
            //stringContainer.Add("Hello");
            //Console.WriteLine(stringContainer.Get());//Hello
            #endregion

            #region Q3
            //What are multiple type parameters? Write Pair<TKey, TValue>.
            //Multiple type parameters means that a generic class or method can accept more than one data type.
            //class was created ..lets use it :
            //Pair<int, string> student = new Pair<int, string>(1, "Noor");
            //Console.WriteLine(student.Key);//1
            //Console.WriteLine(student.Value);//Noor
            #endregion

            #region Q4
            //What is a generic method? Write Swap<T> method.
            //generic method is a method that can work with different data types without specifying the exact type when the method is defined.
            //method was created ...lets use it :
            //int x = 10;
            //int y = 20;

            //Swap(ref x, ref y);

            //Console.WriteLine(x); // 20
            //Console.WriteLine(y); // 10
            ////==========================================
            //string first = "Hello";
            //string second = "World";

            //Swap(ref first, ref second);

            //Console.WriteLine(first);  // World
            //Console.WriteLine(second); // Hello
            #endregion

            #region Q5
            //Write a generic method FindMax < T > that finds maximum value
            //Method created ...lets use it :
            //int maxInt = FindMax(10, 20);
            //Console.WriteLine(maxInt); // 20
            ////========================================================
            //string maxString = FindMax("Apple", "Banana");
            //Console.WriteLine(maxString); // Banana
            #endregion

            #region Q6
            // What is a generic interface? Write IRepository<T>.
            //generic interface is an interface that uses a type parameter<T> so it can work with different data types while maintaining type safety.
            //Interface was created ...
            //IRepository<string> stringRepository;//wont work with thw constrain 
            //IRepository<int> intRepository;
            //can be used with opjects too
            #endregion

            #region Q7
            //What is the 'struct' constraint? Write an example.
            //The struct constraint in C# is used with generics to specify that the type T must be a value type.
            //where T : struct => the word "where" define a constrain 
            //check the inteface for the example.
            #endregion

            #region Q8
            //What is the 'class' constraint? Write an example.
            //The class constraint in C# is used with generics to specify that the type T must be a reference type (class)
            //check Container class for example...
            #endregion

            #region Q9
            //What is the 'new()' constraint? Write an example.
            //The new() constraint specifies that the generic type T must have a public parameterless constructor.

            //Factory<Student> factory = new Factory<Student>();
            //Student student = factory.Create();
            #endregion

            #region Q10
            //What is the interface constraint? Write an example
            //The interface constraint is used in generics to specify that the type T must implement a specific interface.
            //Printer<Student> printer = new Printer<Student>();
            //printer.PrintItem(new Student());
            #endregion

            #region Q11
            //What is the base class constraint? Write an example.
            //The base class constraint is used with generics to specify that the type T must inherit from a specific base class.
            //Zoo<Dog> Zoo1 = new Zoo<Dog>();
            //Zoo1.Hear(new Dog());
            #endregion

            #region Q12
            //How do you apply multiple constraints? Write an example. 
            //by writing (where T: (constrain1 , constrain2 ))
            //check Zoo class for Ex.
            //Zoo<Dog> Zoo01 = new Zoo<Dog>();

            //Dog dog = new Dog();
            //dog.Print();//Dog
            //dog.Sound(); //sound

            #endregion

            #region Q13
            //What does the 'default' keyword do in generics ?
            //The default keyword returns the default value of a generic type T.
            #endregion

            #region Q14
            //Write a SafeList < T > that returns default when the index is invalid.
            SafeList<int> numbers = new SafeList<int>(3);
            numbers.Add(0, 10);
            numbers.Add(1, 20);
            Console.WriteLine(numbers.Get(0));  // 10
            Console.WriteLine(numbers.Get(5));  // 0
            Console.WriteLine(numbers.Get(-1)); // 0
            #endregion

            #region Task
            #region Q15 
            //What is covariance? Explain the 'out' keyword.
            //Covariance allows you to use a more derived type where a base type is expected.
            //The out keyword tells C#:
            //"T is only used to produce/return values, not to receive values."
            #endregion

            #region Q16
            //What is contravariance? Explain the 'in' keyword.
            //"T is only used as an input/parameter."
            #endregion
            #endregion
        }

        //Genaric Method => Q4
        public static void Swap<T>(ref T a, ref T b)
        {
            T temp = a;
            a = b;
            b = temp;
        }

        public static T FindMax<T>(T a, T b) where T : IComparable<T>
        {
            return a.CompareTo(b) > 0 ? a : b;
        }
    }
}
