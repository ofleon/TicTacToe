namespace TicTacToe.Game;

public class Board
{
    public int[] Positions { get; private init; }

    public List<int> CurrentStateOfBoard { get; set; } = [];

    public Board()
    {
        Positions = new int[9];
        InitializeBoard();
    }

    private void InitializeBoard()
    {
        CurrentStateOfBoard = Enumerable.Range(0, Positions.Length).ToList();

        for (var indexd = 0; indexd < Positions.Length; indexd++)
        {
            Positions[indexd] = 0;
        }
    }

    public void DrawBoard(Board board)
    {
        Console.Clear();
        var posindex = 0;
        for (var  row= 0; row < 3; row++)
        {
            for (var col= 0; col < 3; col++)
            {
                
                var value = board.Positions[posindex];

                string valuetoupdate;
                switch (value)
                {
                    case 1:
                        valuetoupdate = "X";
                        break;
                    case 2:
                        valuetoupdate = "O";
                        break;
                    default:
                        valuetoupdate = " "; 
                        break;
                }

                Console.Write($"{valuetoupdate}");
                if (col < 3 -1)
                {
                    Console.Write("|");
                }

                posindex++;


            }
            Console.Write(Environment.NewLine);
            if (row < 3-1)
            {
                Console.WriteLine(new string('-', 3 + 3 -1));
            }

        }
    }

}
