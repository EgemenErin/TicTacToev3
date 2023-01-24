namespace TicTacToe
{
    public class Program
    {
        static void Main(string[] args)
        {
            //EXERCISE 1
            /*
            TicTacToe TicTacgame = new TicTacToe();
            Console.Write($"Please input factorial number in range 1-10: ");
            string? UserAnswer = Console.ReadLine();
            long Number  = TicTacgame.Factorial(UserAnswer);
            Console.WriteLine($"Factorial Number = {Number}");
            */
            //EXRCISE 2
            Game game = new Game();
            Display display = new Display();
            game.Start_Game();
        }
    }
}