// See https://aka.ms/new-console-template for more information
using TicTacToe.Game;

Console.WriteLine("Hello, To the Game Tic Tac  Toe! make any click to start");
Console.ReadLine();

Play tictactoe = new Play();
Board board = new Board();
Player player1 = new("X");
Player player2 = new("O");

tictactoe.Run(board, player1, player2);

Console.ReadLine();



