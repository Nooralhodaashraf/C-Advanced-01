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
