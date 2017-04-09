using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Highscore
{
    class Program
    {
        static void Main(string[] args)
        {
            #region variables
            bool active = true;
            bool loading = false;
            string[] names = new string[10] { "paul", "potato", "edgard", "thor", "freya", "ragnar", "loki", "bjorn", "fenir", "odin" };
            int[] highscore = new int[10] { 20, 10, 30, 40, 60, 70, 90, 50, 80, 100 };
            int newscore;
            int lastscoreposition = highscore.Length - 1;
            int lastnameposition = names.Length - 1;
            int numberplayer = 1;
            int loadingtime = 0;
            int loadinganimation = 200;
            #endregion
            while (active)
            {
                #region bubbleSort
                int length = highscore.Length;

                int temp = highscore[0];
                string temp2 = names[0];
             
                for (int i = 0; i < length; i++)
                {
                    for (int j = i + 1; j < length; j++)
                    {
                        if (highscore[i] < highscore[j])
                        {
                            temp = highscore[i];
                            temp2 = names[i];

                            highscore[i] = highscore[j];
                            names[i] = names[j];

                            highscore[j] = temp;
                            names[j] = temp2;
                        }

                    }
                    Console.ForegroundColor = ConsoleColor.DarkCyan;
                    Console.WriteLine(names[i] + " " + highscore[i]);
                    Console.ForegroundColor = ConsoleColor.Gray;
                }
                #endregion

                #region New scores
                Console.WriteLine("Digite seu nome");

                string newname = Console.ReadLine().ToString();
                if(newname == "" || newname == null)
                {
                    newname = ("Player" + numberplayer);
                    numberplayer++;
                }

                Console.WriteLine("Digite sua pontuação");
                
                while( !int.TryParse(Console.ReadLine(), out newscore))
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("insira um número numerico");
                    Console.ForegroundColor = ConsoleColor.Gray;
                }

                if (newscore <= highscore[lastscoreposition])
                {
                    loading = true;
                    Console.ForegroundColor = ConsoleColor.DarkGreen;
                    while (loading)
                    {
                        Console.WriteLine("Atualizando Highscore");
                        //Console.SetCursorPosition(Console.CursorLeft - 1, Console.CursorTop);
                        System.Threading.Thread.Sleep(loadinganimation);
                        Console.Clear();
                        loadingtime++;

                        Console.WriteLine("Atualizando Highscore.");
                        //Console.SetCursorPosition(Console.CursorLeft - 1, Console.CursorTop);
                        System.Threading.Thread.Sleep(loadinganimation);
                        Console.Clear();
                        loadingtime++;

                        Console.WriteLine("Atualizando Highscore..");
                        //Console.SetCursorPosition(Console.CursorLeft - 1, Console.CursorTop);
                        System.Threading.Thread.Sleep(loadinganimation);
                        Console.Clear();
                        loadingtime++;

                        Console.WriteLine("Atualizando Highscore...");
                        //Console.SetCursorPosition(Console.CursorLeft - 1, Console.CursorTop);
                        System.Threading.Thread.Sleep(loadinganimation);
                        Console.Clear();
                        loadingtime++;

                        if (loadingtime == 12)
                        {
                            loading = false;
                            loadingtime = 0;
                        }
                    }
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Sua pontuação é muito baixa");
                    System.Threading.Thread.Sleep(2000);
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.Gray;
                }

                else
                {
                    highscore[lastscoreposition] = newscore;
                    names[lastnameposition] = newname;
                    Console.Clear();
                    loading = true;
                    //-------------------------------------------------------------
                    Console.ForegroundColor = ConsoleColor.DarkGreen;
                    while (loading)
                    {
                        Console.WriteLine("Atualizando Highscore");
                        //Console.SetCursorPosition(Console.CursorLeft - 1, Console.CursorTop);
                        System.Threading.Thread.Sleep(loadinganimation);
                        Console.Clear();
                        loadingtime++;

                        Console.WriteLine("Atualizando Highscore.");
                        //Console.SetCursorPosition(Console.CursorLeft - 1, Console.CursorTop);
                        System.Threading.Thread.Sleep(loadinganimation);
                        Console.Clear();
                        loadingtime++;

                        Console.WriteLine("Atualizando Highscore..");
                        //Console.SetCursorPosition(Console.CursorLeft - 1, Console.CursorTop);
                        System.Threading.Thread.Sleep(loadinganimation);
                        Console.Clear();
                        loadingtime++;

                        Console.WriteLine("Atualizando Highscore...");
                        //Console.SetCursorPosition(Console.CursorLeft - 1, Console.CursorTop);
                        System.Threading.Thread.Sleep(loadinganimation);
                        Console.Clear();
                        loadingtime++;

                        if(loadingtime == 12)
                        {
                            loading = false;
                            loadingtime = 0;
                        }
                    }
                    Console.ForegroundColor = ConsoleColor.Gray;
                    Console.Clear();
                }
                #endregion
            }
        }

    }
}