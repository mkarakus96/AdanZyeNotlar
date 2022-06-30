using System;

namespace ProjectExample
{
    class Program
    {
        static void Main(string[] args)
        {
            #region tuple Örneği
            (int a, string b) c = (5, "deneme");
            Console.WriteLine(c.a);
            #endregion
        }
    }
}
