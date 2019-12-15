using System;

namespace OverloadMethods
{
    /* class Program
        {
         //example 1
         //overload methods in C#
          public void add(int a, int b)
          {
              Console.WriteLine(a + b);
          }
          public void add(float x, float y)
          {
              Console.WriteLine(x + y);
          }
          public void add(string s1, string s2)
          {
              Console.WriteLine(s1 + s2);
          }
          static void Main(string[] args)
          {
              Program obj = new Program();
              obj.add(10, 20);
              obj.add(10.5f, 20.5f);
              obj.add("pranaya", "kumar");
              Console.WriteLine("Press any key to exist.");
              Console.ReadKey();
          }*/

    //example 2
    //inheritance based overloading
    class ADD1
    {
        public void add(int a, int b)
        {
            Console.WriteLine(a + b);
        }
        public void add(float x, float y)
        {
            Console.WriteLine(x + y);
        }
    }
    class ADD2 : ADD1
    {
        public void add(string s1, string s2)
        {
            Console.WriteLine(s1 + s2);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            ADD2 obj = new ADD2();
            obj.add(10, 20);
            obj.add(10.5f, 20.5f);
            obj.add("pranaya", "kumar");
            Console.WriteLine("Press any key to exist.");
            Console.ReadKey();
        }
    }




}
