using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tictactoe2._0
{
    class game
    {
        public game()
        {
            play();
        }

        public void play()
        {
            Board Board = new Board();
            Player playerX = new Player('X');
            Player playerO = new Player('O');
            Player currentPlayer = playerX;
            int moveCounter = 0;
            bool play = true;
            while (play)
            {
                Board.printBoard();
                Console.WriteLine("Player: {0} Ingresa la posicion donde haras tu movimiento: ", currentPlayer.getfichaJugador());
                try
                {
                    Board.putMark(currentPlayer, playerX.takeTurn());
                    Board.clearBoard();
                    moveCounter++;
                    if (currentPlayer.checkWin(Board))
                    {
                        Console.WriteLine("Player: {0} Gana!", currentPlayer.getfichaJugador());
                        Board.printBoard();
                        play = false;
                    }
                    else if (checkDraw(moveCounter))
                    {
                        Console.WriteLine("EMPATE");
                        Board.printBoard();
                        play = false;
                    }
                    currentPlayer = changeCurrentPlayer(currentPlayer, playerX, playerO);
                }
                catch (Exception)
                {
                    Console.WriteLine("Ingreso invalido.Selecciona un numero entre 1-9!");
                    Console.ReadLine();
                    Console.Clear();
                }
            }
        }
        private Player changeCurrentPlayer(Player currentPlayer, Player playerX, Player playerO)
        {
            return currentPlayer == playerX ? playerO : playerX;

        }

        private bool checkDraw(int turnCounter)
        {
            if (turnCounter == 9)
                return true;
            return false;
        }


    }
}
