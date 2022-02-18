using System;

namespace Degiskenler
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Değişken isimlendirmede alt tire kullanılıyor");
            
            byte b = 1;
            sbyte c = 1;

            short s = 2; 
            ushort us = 2; 

            Int16 i16 = 2;
            int i = 4;
            Int32 i32 = 4;
            Int64 i64 = 8;

            uint ui = 4;
            long l = 8;
            ulong ul = 8;

            float f = 4;
            double d = 8;
            decimal dc = 16;


            char ch = '2';
            string str = "sınırsız";

            bool b1 = true;
            bool b2 = false;
            
            DateTime dt = DateTime.Now;

            Console.WriteLine(dt);

            object o1 = "x";
            object o2 = 'c';
            object o3 = 90;
            object o4= 1993.69;

            string str1 = string.Empty;
            str1 = "Kodlarız mı ;)";
            string a1 = "Kodlarız";
            string a2 = "mı ;)";
            string cumle = a1 + " " + a2;
            Console.WriteLine(cumle);











        }
    }
}
