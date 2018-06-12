using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice11
{
    class Program
    {
        static void Main(string[] args)
        {
            char[][]codetable = new char[2][];
            char[] m1 = new char[71] {'А','Б','В','Г','Д','Е','Ё','Ж','З','И','Й','К','Л','М','Н','О','П','Р','С','Т','У','Ф','Х','Ц','Ч','Ш','Щ','Э','Ю','Я', 'а', 'б', 'в', 'г', 'д', 'е', 'ё', 'ж', 'з', 'и', 'й', 'к', 'л', 'м', 'н', 'о', 'п', 'р', 'с', 'т', 'у', 'ф', 'х', 'ц', 'ч', 'ш', 'щ', 'ъ', 'ы', 'ь', 'э', 'ю', 'я', '.', ',', ' ', '-', ':', ';', '!', '?' };
            codetable[0] = m1;
            char[] m2 = new char[71] { 'A','B','C','D','E','F','G','H','I','J','K','L','M','N','O','P','Q','R','S','T','U','V','W','X','Y','Z','_','|','$','~','a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z', '0', '1', '2', '3', '4', '5', '6', '7', '8', '9', '+', '*', '&', '%', '^' };
            codetable[1] = m2;
            int finish = 0;
            do
            {
                Console.WriteLine("Enter your text in Russian with all numbers written in their letter forms.");
                string text = Console.ReadLine();
                char[] txt = text.ToCharArray();
                char[] coded=new char[txt.Length];
                int j = 0;
                foreach(char x in txt)
                {
                    for(int i = 0; i < codetable[0].Length; i++)
                    {
                        if (codetable[0][i] == x)
                        {
                            coded[j] = codetable[1][i];
                            j++;
                        }
                    }
                }
                j = 0;
               char[] coded1 = new char[coded.Length];
                foreach (char x in coded)
                {
                    for (int i = 0; i < codetable[1].Length; i++)
                    {
                        if (codetable[1][i] == x)
                        {
                            coded1[j] = codetable[0][i];
                            j++;
                        }
                    }
                }
                Console.WriteLine("Here is coded version of your text: \t" );
                foreach (char e in coded)
                    Console.Write(e);
                Console.WriteLine();
                Console.WriteLine("Here is code decoded again for you to check: \t");
                foreach (char e in coded1)
                    Console.Write(e);
                Console.WriteLine();
                Console.WriteLine("If you wish to exit enter exit. Otherwise press any other button.");
                string f = Console.ReadLine();
                if (f == "exit"||f=="учше")
                    finish++;
            } while (finish == 0);
        }
    }
}
