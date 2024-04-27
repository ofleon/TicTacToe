namespace TicTacToe.Game;

public class Play
{
    public Player playerturn { get; set; }

    public void Run(Board board, Player player1, Player player2)
    {
        board.DrawBoard(board);
        bool IsRunnin = true;
        playerturn = player1;
        while (IsRunnin)
        {
            PickMovement(board, player1);
            PickMovement(board, player2);
        }
    }

    public void PickMovement(Board board, Player player)
    {
        Console.WriteLine($"It's the turn of the player {player.OptionType}. Select the position that you want to play");

        if (player.OptionType == "X")
        {
            var input = Convert.ToInt32(Console.ReadLine()); //TO-DO: VALIDATE THIS INPUT BETTER
            input = input - 1;
            if (!ValidatePosition(board, input))
            {
                Console.WriteLine("This is incorrect input! Please try again");
                PickMovement(board, player);
            }
            else
            {
                UpdatePositions(board, input);
                board.DrawBoard(board);
            }
           
        }
        else if ( player.OptionType == "O")
        {
            //TO-DO: MAKE THE PLAYER 2 AI(RANDOM PICKER TO USE Random name = new Random())
            var input = Convert.ToInt32(Console.ReadLine());
            input = input - 1;
            if (!ValidatePosition(board, input))
            {
                Console.WriteLine("stop");
            }
            else
            {
                UpdatePositions(board, input);
                board.DrawBoard(board);
            }
        }
    }

    private static bool ValidatePosition(Board board, int input)
    {
        var curentPositions = board.CurrentStateOfBoard;

        if (curentPositions.All(x => x != input))
            return false;

        return true;
    }


    private void UpdatePositions(Board board, int input)
    {
        int playernum = playerturn.OptionType == "X" ? 1 : 2;

        board.Positions[input] = playernum;
        board.CurrentStateOfBoard.Remove(input);

        //Updating the player turn
        playerturn.OptionType = playerturn.OptionType == "X" ? "O" : "X";
    }
}
