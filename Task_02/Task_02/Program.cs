using System;
using System.Text;


namespace Task_02
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] arr = new char[] { 'd', 'f', 'a', 'q', 'w', 'e', 'r', 't', 'y', ' ' };

            string s = new string(arr);
            StringBuilder sb = new StringBuilder(s);
            Console.WriteLine(sb);

            sb.Replace('d', 'm');
            Console.WriteLine(sb);

            sb.Remove(0, 3);
            Console.WriteLine(sb);

            sb.Insert(0, "csharp ");
            Console.WriteLine(sb);

            Console.ReadKey();
        }
    }
}
