namespace TicTacToe.Game;

public class Player
{
    public string OptionType { get; set; } //X or O

    public Player(string Option)
    {
        OptionType = Option;
    }
}
