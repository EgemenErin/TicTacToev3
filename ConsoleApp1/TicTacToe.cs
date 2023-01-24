using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace TicTacToe
{
    //EXERCISE 1
    /*
    public class TicTacToe
    {
        private long Result;
        public TicTacToe()
        {
            Result = 1;
            //here you put some values private int/string/double
        }
        private int validationInt(string valid)
        {
            bool ValidString = int.TryParse(valid, out int ValidNumber);
            if (!ValidString) { Console.WriteLine("Number is not valid!"); Environment.Exit(0); }
            return ValidNumber;
        }
        public long Factorial(string x)
        {
            int Userinput = validationInt(x);
            if (Userinput > 0 && Userinput < 11)
            {
                for (int i = 1; i <= Userinput; i++)
                {
                    Result *= i;
                }
                return Result;
            }
            else
            {
                Console.WriteLine("User input out of range!");
                Environment.Exit(0);
                return Result;
            }

        }
    }
    */
    public class Game
    {
        public static string[] Board = new string[9];
        private bool First_Run = true;
        private int Draw = 0;
        public Game()
        {
            Board = new string[9];
            //First_Run= true;
        }
        private string CheckUserInput(string Y)
        {
            bool StringToInt = int.TryParse(Y, out int Number);
            if (StringToInt || Y != "" || Y != " ")
            {
                if (!(Number > 0 && Number < 10)) 
                {
                    //Console.WriteLine("Wrong input(1-9)\nTry Again!\n");
                    return ("Wrong input(1-9)\nTry Again!\n");
                    //CheckUserInput(Console.ReadLine());
                }
                else
                {
                    Number -= 1;
                    return Number.ToString();
                }
            }
            else
            {
                return "Input not a number!";
            }
        }
        public void Start_Game()
        {
            for (int i = 0; i < Board.Length;i++) { Board[i] = " "; }
            if (First_Run)
            {
                Console.Clear();
                Console.WriteLine("Welcome to tic tac toe!");
                Display.DisplayBoard();
                First_Run= false;
                XsTurn();
            }
            else { First_Run_Check(); }
        }
        private void First_Run_Check() 
        {
            if (First_Run)
            {
                First_Run = false;
                Start_Game();
            }
            else 
            {
                Console.Write($"Would you like to restart the Game?(yes/no) ");
                RestartGame(Console.ReadLine()); 
            }
        }
        private void RestartGame(string R)
        {
            if (R.ToLower() != "yes" && R.ToLower() != "y") 
            {
                Console.WriteLine("No restart, end of the Game!");
                Environment.Exit(0);
            }
            else
            {
                First_Run= true;
                Start_Game();
            }
        }
        private void CheckGameStatus()
        {
            if (Board[0] == "X" && Board[1] == "X" && Board[2] == "X") { Console.Clear(); Console.WriteLine("THE WINNER IS X!"); Draw = 0; Display.DisplayBoard(); Start_Game();Console.Clear(); Console.WriteLine("THE WINNER IS X!"); Draw = 0; Display.DisplayBoard(); Start_Game(); }
            else if (Board[3] == "X" && Board[4] == "X" && Board[5] == "X") { Console.Clear(); Console.WriteLine("THE WINNER IS X!"); Draw = 0; Display.DisplayBoard(); Start_Game();Console.Clear(); Console.WriteLine("THE WINNER IS X!"); Draw = 0; Display.DisplayBoard(); Start_Game(); }
            else if (Board[6] == "X" && Board[7] == "X" && Board[8] == "X") { Console.Clear(); Console.WriteLine("THE WINNER IS X!"); Draw = 0; Display.DisplayBoard(); Start_Game();Console.Clear(); Console.WriteLine("THE WINNER IS X!"); Draw = 0; Display.DisplayBoard(); Start_Game(); }
            else if (Board[2] == "X" && Board[5] == "X" && Board[8] == "X") { Console.Clear(); Console.WriteLine("THE WINNER IS X!"); Draw = 0; Display.DisplayBoard(); Start_Game();Console.Clear(); Console.WriteLine("THE WINNER IS X!"); Draw = 0; Display.DisplayBoard(); Start_Game(); }
            else if (Board[1] == "X" && Board[4] == "X" && Board[7] == "X") { Console.Clear(); Console.WriteLine("THE WINNER IS X!"); Draw = 0; Display.DisplayBoard(); Start_Game();Console.Clear(); Console.WriteLine("THE WINNER IS X!"); Draw = 0; Display.DisplayBoard(); Start_Game(); }
            else if (Board[0] == "X" && Board[3] == "X" && Board[6] == "X") { Console.Clear(); Console.WriteLine("THE WINNER IS X!"); Draw = 0; Display.DisplayBoard(); Start_Game();Console.Clear(); Console.WriteLine("THE WINNER IS X!"); Draw = 0; Display.DisplayBoard(); Start_Game(); }
            else if (Board[2] == "X" && Board[4] == "X" && Board[6] == "X") { Console.Clear(); Console.WriteLine("THE WINNER IS X!"); Draw = 0; Display.DisplayBoard(); Start_Game();Console.Clear(); Console.WriteLine("THE WINNER IS X!"); Draw = 0; Display.DisplayBoard(); Start_Game(); }
            else if (Board[0] == "X" && Board[4] == "X" && Board[8] == "X") { Console.Clear(); Console.WriteLine("THE WINNER IS X!"); Draw = 0; Display.DisplayBoard(); Start_Game();Console.Clear(); Console.WriteLine("THE WINNER IS X!"); Draw = 0; Display.DisplayBoard(); Start_Game(); }
            else if (Board[0] == "O" && Board[1] == "O" && Board[2] == "O") { Console.Clear(); Console.WriteLine("THE WINNER IS O!"); Draw = 0; Display.DisplayBoard(); Start_Game();Console.Clear(); Console.WriteLine("THE WINNER IS X!"); Draw = 0; Display.DisplayBoard(); Start_Game(); }
            else if (Board[3] == "O" && Board[4] == "O" && Board[5] == "O") { Console.Clear(); Console.WriteLine("THE WINNER IS O!"); Draw = 0; Display.DisplayBoard(); Start_Game();Console.Clear(); Console.WriteLine("THE WINNER IS X!"); Draw = 0; Display.DisplayBoard(); Start_Game(); }
            else if (Board[6] == "O" && Board[7] == "O" && Board[8] == "O") { Console.Clear(); Console.WriteLine("THE WINNER IS O!"); Draw = 0; Display.DisplayBoard(); Start_Game();Console.Clear(); Console.WriteLine("THE WINNER IS X!"); Draw = 0; Display.DisplayBoard(); Start_Game(); }
            else if (Board[2] == "O" && Board[5] == "O" && Board[8] == "O") { Console.Clear(); Console.WriteLine("THE WINNER IS O!"); Draw = 0; Display.DisplayBoard(); Start_Game();Console.Clear(); Console.WriteLine("THE WINNER IS X!"); Draw = 0; Display.DisplayBoard(); Start_Game(); }
            else if (Board[1] == "O" && Board[4] == "O" && Board[7] == "O") { Console.Clear(); Console.WriteLine("THE WINNER IS O!"); Draw = 0; Display.DisplayBoard(); Start_Game();Console.Clear(); Console.WriteLine("THE WINNER IS X!"); Draw = 0; Display.DisplayBoard(); Start_Game(); }
            else if (Board[0] == "O" && Board[3] == "O" && Board[6] == "O") { Console.Clear(); Console.WriteLine("THE WINNER IS O!"); Draw = 0; Display.DisplayBoard(); Start_Game();Console.Clear(); Console.WriteLine("THE WINNER IS X!"); Draw = 0; Display.DisplayBoard(); Start_Game(); }
            else if (Board[2] == "O" && Board[4] == "O" && Board[6] == "O") { Console.Clear(); Console.WriteLine("THE WINNER IS O!"); Draw = 0; Display.DisplayBoard(); Start_Game();Console.Clear(); Console.WriteLine("THE WINNER IS X!"); Draw = 0; Display.DisplayBoard(); Start_Game(); }
            else if (Board[0] == "O" && Board[4] == "O" && Board[8] == "O") { Console.Clear(); Console.WriteLine("THE WINNER IS O!"); Draw = 0; Display.DisplayBoard(); Start_Game();Console.Clear(); Console.WriteLine("THE WINNER IS X!"); Draw = 0; Display.DisplayBoard(); Start_Game(); }
            else if (Draw == 9) { Console.Clear(); Console.WriteLine("DRAW = NO WINNER!"); Draw = 0; Display.DisplayBoard(); Start_Game(); }
            //Draw += 1;
        }
        private void XsTurn()
        {
            CheckGameStatus();
            Console.Write("X's turn: ");
            string ReturnOfCheck = CheckUserInput(Console.ReadLine());
            bool BoardPlaceNumbercheck = int.TryParse(ReturnOfCheck, out int result);
            if (!BoardPlaceNumbercheck)
            {
                Console.WriteLine(ReturnOfCheck);
                XsTurn();
            }

            string Check = BoardPositionTaken(result);
            bool CheckBoard = int.TryParse(Check, out int x);
            if (CheckBoard) 
            {
                Board[x] = "X";
                Draw += 1;
                Display.DisplayBoard();
                OsTurn();
            }
            else { Console.WriteLine(Check); XsTurn(); }

        }
        private void OsTurn()
        {
            CheckGameStatus();
            Console.Write("O's turn: ");
            string ReturnOfCheck = CheckUserInput(Console.ReadLine());
            bool BoardPlaceNumbercheck = int.TryParse(ReturnOfCheck, out int result);
            if (!BoardPlaceNumbercheck)
            {
                Console.WriteLine(ReturnOfCheck);
                OsTurn();
            }

            string Check = BoardPositionTaken(result);
            bool CheckBoard = int.TryParse(Check, out int x);
            if (CheckBoard)
            {
                Board[x] = "O";
                Draw += 1;
                Display.DisplayBoard();
                XsTurn();
            }
            else { Console.WriteLine(Check); OsTurn(); }
        }

        private string BoardPositionTaken(int position)
        {
            /*
                if (position < 1 && position > 9) { Environment.Exit(1); return "Wrong input(1-9)\nTry Again!\n"; }
                else
                {
                    if (Board[position].ToLower() == "x" || Board[position].ToLower() == "o")
                    {
                        return "Board position is taken!";
                    }
                    else { return position.ToString(); }
                }
            */
            if (Board[position].ToLower() == "x" || Board[position].ToLower() == "o")
            {
                return "Board position is taken!";
            }
            else { return position.ToString(); }
        }
    }
    public class Display
    {
        public Display()
        {
            
        }
        public static void DisplayBoard()
        {
            Console.WriteLine($" {Game.Board[0]} | {Game.Board[1]} | {Game.Board[2]} \n---+---+---\n {Game.Board[3]} | {Game.Board[4]} | {Game.Board[5]} \n---+---+---\n {Game.Board[6]} | {Game.Board[7]} | {Game.Board[8]} ");
        }

    }
}
