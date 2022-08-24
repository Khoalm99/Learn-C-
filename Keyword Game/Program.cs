using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Keyword_Game
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            test();
        }

        static void test()
        {
            Console.Write("Chọn phím bất kỳ để bắt đầu: ");

            ConsoleKeyInfo c = new ConsoleKeyInfo();

            begin:

            do
            {
                Random rnd = new Random();
                int keyNumber = rnd.Next(65, 91);
                char key = Convert.ToChar(keyNumber);
                for (int i = 0; i <= Console.WindowHeight; i++)
                {
                    //Tạo random chữ cái
                    
                    Console.SetCursorPosition(Console.WindowWidth / 2, i);

                    Console.Write(key);
                    if (true)
                    {

                    }
                    Console.Clear();

                    // Thiet lap thoi gian xuat hien
                    System.Threading.Thread.Sleep(200);
                    if (c.Key == ConsoleKey.Q)
                    {
                        goto begin;
                    }

                }
            } while (c.Key != ConsoleKey.Escape);




        }

    }
}
