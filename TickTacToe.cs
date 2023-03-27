using System;
using System.Collections.Generic;

namespace TicTacToe
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] squares = new string[9];
            for(int i = 0; i < squares.Length; i++)
            {
                squares[i] = Convert.ToString(i+1);
            }

            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("You are playing as X. Please type the number of the square you want to put an X in.");
            Console.ForegroundColor = ConsoleColor.Green;

            string winner = "placeholder";
            string? number;
            int choice = 0;
            bool win = false;
            while(win != true)
            {
                Console.SetCursorPosition(0, 1);
                Console.WriteLine(" " + squares[0] + " | " + squares[1] + " | " + squares[2] + " ");
                Console.WriteLine("---|---|---");  
                Console.WriteLine(" " + squares[3] + " | " + squares[4] + " | " + squares[5] + " ");
                Console.WriteLine("---|---|---");
                Console.WriteLine(" " + squares[6] + " | " + squares[7] + " | " + squares[8] + " ");


                while(true){
                    number = (Console.ReadLine());
                    
                    CCCL();

                    if(number == "1" || number == "2" || number == "3" || number == "4"|| number == "5" || number == "6" || number == "7" || number == "8" || number == "9"){
                        choice = Convert.ToInt32(number);
                        if(squares[choice-1] != "x" && squares[choice-1] != "o"){
                            break;
                        }
                    }
                }

                squares[choice-1] = "x";  

                if(squares[0] == "x" && squares[1] == "x" && squares[2] == "x" || squares[3] == "x" && squares[4] == "x" && squares[5] == "x" || squares[6] == "x" && squares[7] == "x" && squares[8] == "x" || squares[0] == "x" && squares[3] == "x" && squares[6] == "x" || squares[1] == "x" && squares[4] == "x" && squares[7] == "x" || squares[2] == "x" && squares[5] == "x" && squares[8] == "x" || squares[0] == "x" && squares[4] == "x" && squares[8] == "x" || squares[2] == "x" && squares[4] == "x" && squares[6] == "x"){
                    winner = "x";
                    win = true;
                    break;
                }

                while(true){
                    Random numberGen = new Random();
                    number = Convert.ToString(numberGen.Next(1, 10));

                    if(number == "1" || number == "2" || number == "3" || number == "4"|| number == "5" || number == "6" || number == "7" || number == "8" || number == "9"){
                        choice = Convert.ToInt32(number);
                        if(squares[choice-1] != "x" && squares[choice-1] != "o"){
                            break;
                        }
                    }
                }  

                squares[choice-1] = "o";  

                if(squares[0] == "o" && squares[1] == "o" && squares[2] == "o" || squares[3] == "o" && squares[4] == "o" && squares[5] == "o" || squares[6] == "o" && squares[7] == "o" && squares[8] == "o" || squares[0] == "o" && squares[3] == "o" && squares[6] == "o" || squares[1] == "o" && squares[4] == "o" && squares[7] == "o" || squares[2] == "o" && squares[5] == "o" && squares[8] == "o" || squares[0] == "o" && squares[4] == "o" && squares[8] == "o" || squares[2] == "o" && squares[4] == "o" && squares[6] == "o"){
                    winner = "o";
                    win = true;
                    break;
                }               
            }

            Console.SetCursorPosition(0, 1);
            Console.WriteLine(" " + squares[0] + " | " + squares[1] + " | " + squares[2] + " ");
            Console.WriteLine("---|---|---");  
            Console.WriteLine(" " + squares[3] + " | " + squares[4] + " | " + squares[5] + " ");
            Console.WriteLine("---|---|---");
            Console.WriteLine(" " + squares[6] + " | " + squares[7] + " | " + squares[8] + " ");
           
           Console.ForegroundColor = ConsoleColor.Blue;
           Console.WriteLine(winner + " wins!");
           Console.ReadKey(false);
        }

        public static void CCCL()
        {
            Console.SetCursorPosition(0, Console.CursorTop-1);
            Console.Write(new string(' ', Console.WindowWidth)); 
            Console.SetCursorPosition(0, Console.CursorTop);
        }
    }
}
