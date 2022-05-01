using System;
using System.Collections.Generic;


namespace CortSimpson // Note: actual namespace depends on the project name.
{
    internal class Tictactoe

    {
        static void Main(string[] args)
        {
            List<string> board = gameboard();
            string Player = "X";

            while(!Gameover(board))
            {
                Displayboard(board);

                int Choice = Playerchoice(Player);


                Taketurn(board, Choice, Player);

                Player = Otherplayer(Player);
            }
            Displayboard(board);
            Console.WriteLine("GAME OVER");
        }

        static List<string> gameboard()
        {
            List<string> board = new List<string>();

            for (int i = 1; i <= 9; i++)
            {
                board.Add(i.ToString());
            }

            return board;
        }

        static void Displayboard(List<string> board)
        {
            Console.WriteLine($"{board[0]}|{board[1]}|{board[3]}");
            Console.WriteLine("-+-+-");
            Console.WriteLine($"{board[4]}|{board[5]}|{board[6]}");
            Console.WriteLine("-+-+-");
            Console.WriteLine($"{board[7]}|{board[8]}|{board[9]}");
            

        }

        static int Playerchoice(string Player)
        {
            Console.WriteLine($"{Player}'s turn, Choose # 1-9: ");

            string move_string = Console.ReadLine();
            int Choice = int.Parse(move_string);
            return Choice;
        }

        static void Taketurn(List<string> board, int Choice, string Player)
        {
            int index = Choice - 1;
            board[index] = Player;
        }

        static bool Gameover(List<string> board)
        {
            bool Gameover = false;

            if (Winner(board, "x") || Winner(board, "o") || Catgame(board))
            {
                Gameover = true;
            }

            return Gameover;

        }

        static bool Winner(List<string> board, string player)
        {
            bool Winner = false;

            if ((board[0] == player && board[1] == player && board[2] == player) || (board[3] == player && board[4] == player && board[5] == player) || (board[6] == player && board[7] == player && board[8] == player) || (board[0] == player && board[3] == player && board[6] == player) || (board[1] == player && board[4] == player && board[7] == player) || (board[2] == player && board[5] == player && board[8] == player) || (board[0] == player && board[4] == player && board[8] == player) || (board[6] == player && board[4] == player && board[2] == player))
            {
                Winner = true;
            }
            return Winner;

        }

        static bool Catgame(List<string> board)
        {
            bool Catgame = false;

            if (board[0] != "1" && board[1] != "2" && board[2] != "3" && board[3] != "4" && board[4] != "5" && board[5] != "6" && board[6] != "7" && board[7] != "8" && board[8] != "9")
            {
                Catgame = true;
            }

            return Catgame;

            
        }

        static string Otherplayer(string Player)
        {
            string nextplayer = "x";
            if (Player ==  "x")
            {
                nextplayer = "o";
            }
            return nextplayer;
        }


    }
}