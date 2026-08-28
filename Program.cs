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
        }
    }
}
