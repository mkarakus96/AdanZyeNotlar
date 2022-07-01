using System;

namespace ProjectExample
{
    class Program
    {
        static void Main(string[] args)
        {

            #region Ternary Operatoru
            bool medeniHal = false;
            string evli = "evli";
            string bekar = "bekar";
            string mesaj;
            mesaj = medeniHal ? evli : bekar;
            Console.WriteLine(mesaj);
            #endregion
            #region Birden Fazla Condition Uygulama
            int yas = 25;

            string sonuc = yas < 25 ? "A" : (yas == 25 ? "B" : "C");
            Console.WriteLine(sonuc);
            #endregion
            //#region (_a, _b) =(a, b) Tuple Türüyle Değer Atama
            //(int a, string b) c = (5, "deneme");
            //Console.WriteLine(c.a);
            //#endregion

            //#region Değişken Türüne Uygun Default Değer Atama
            //bool x = default(bool);//değişkene default değerini atamak için kullanılır.
            //int y = default(int);
            //string z = default(string);
            //char d = default(char);

            ////main içerisinde oluşturulan değişkenlerin ilk değerlerini manuel atmaya özen göstermeliyiz.

            //#endregion
            //#region Default Literals Default değer atama(C# 7.1)
            //bool e = default;
            //decimal u = default;
            ////7.1'den sonra bu şekilde yazmamz yeterli 
            //#endregion

        }
    }
}
