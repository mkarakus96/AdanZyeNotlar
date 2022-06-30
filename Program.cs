using System;

namespace ProjectExample
{
    class Program
    {
        static void Main(string[] args)
        {
            #region (_a, _b) =(a, b) Tuple Türüyle Değer Atama
            (int a, string b) c = (5, "deneme");
            Console.WriteLine(c.a);
            #endregion
        }
    }
}
