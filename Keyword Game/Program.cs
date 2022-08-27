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
            game();

            void test()
            {
                
            }

            void game()
            {
                begin:
                //Bắt đầu game
                Console.WriteLine("KEYWORD GAME ");
                Console.WriteLine("(*Tắt Capslock trước khi vào game*)");
                Console.WriteLine("Ấn phím bất kỳ để tiếp tục...");
                Console.ReadKey();
                Console.Clear();
                
                //Chọn độ khó
                Console.WriteLine("Chọn độ khó");
                Console.WriteLine("Dễ -- Nhập số 1");
                Console.WriteLine("Trung bình -- Nhập số 2");
                Console.WriteLine("Khó -- Nhập số 3");
                int level = int.Parse(Console.ReadLine());
                
                
                Console.Clear();
                
                if (level==1)
                {
                    Console.WriteLine("Bạn chọn cấp độ DỄ");
                    
                }
                else
                {
                    if (level == 2)
                    {
                        Console.WriteLine("Bạn chọn cấp độ TRUNG BÌNH");
                    }
                    else
                    {
                        if (level == 3)
                        {
                            Console.WriteLine("Bạn chọn cấp độ KHÓ");
                        }
                        else
                        {
                            Console.WriteLine("CHỌN SAI, CHỌN LẠI");
                            goto begin;
                        }
                    }
                }

                
                Console.WriteLine("Chọn phím bất kỳ để bắt đầu......");
                
                Console.ReadKey();
                Console.Clear();

                //Tạo score 
                int score = 0;
                int speed = 250;

            NewKeyWord:

                //Tạo random chữ cái
                Random rnd = new Random();
                int OutputNumber = rnd.Next(65, 91);
                char OutPut = Convert.ToChar(OutputNumber);

                //Cho chữ rơi 

                for (int i = 0; i < Console.WindowHeight; i++)
                {
                    // Cho chữ ở vị trí ban đầu
                    Console.SetCursorPosition(Console.WindowWidth / 2, i);
                    
                    // In chữ random
                    Console.Write(OutPut);

                    // Thiet lap thoi gian rơi
                    System.Threading.Thread.Sleep(speed);

                    //Cho nhập kí tự + Kiểm tra keyInput
                    if (Console.KeyAvailable)
                    {

                        ConsoleKeyInfo keyInput = Console.ReadKey();

                        if (keyInput.Key != ConsoleKey.Escape)
                        {
                            if ((int)keyInput.KeyChar == (OutputNumber+32))
                            {
                                score++;
                                Console.Clear();
                                goto NewKeyWord;
                            }
                            else
                            {
                                break;
                                goto endgame;
                            }
                        }
                        else
                        {
                            break;
                            goto endgame;
                        }
                    }

                }

            endgame:
                Console.Clear();
                Console.WriteLine("Kết thúc game");
                Console.WriteLine("Số điểm của bạn là: {0}",score);
                Console.WriteLine("Speed của bạn là: {0}", speed);
                Console.ReadKey();
            }
        }
    }
}

