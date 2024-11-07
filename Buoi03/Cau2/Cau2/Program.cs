using System;


namespace Cau2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string s;
            Console.WriteLine("Nhap chuoi : ");
            s = Console.ReadLine();
            bool check = true;

            Stack<char> list = new Stack<char>();


            for (int i = 0; i < s.Length; i++)
            {
                
                if (s[i] == '(' || s[i] == '{' || s[i] == '(')
                    list.Push(s[i]);
                if(list.Count == 0)
                {
                    continue;
                }
                char c = list.Pop();

                if ( (c != '(' && s[i] == ')') || (c != '[' && s[i] == ')') || (c != '{' && s[i] == '}') )
                {
                    check = false;
                    break;
                }

            }

            if (check)
                Console.WriteLine("Yes");
            else
                Console.WriteLine("No");
        }
    }
}
