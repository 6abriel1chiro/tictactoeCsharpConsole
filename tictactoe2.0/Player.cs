using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tictactoe2._0
{
   public class Player
    {

        char fichaJugador;
        /**
        constructor
        */
        public Player(char ficha)
        {
            fichaJugador = ficha;
        }

        /**
           get player fichaJugador
        */
        public char getfichaJugador()
        {
            return fichaJugador;
        }

        /**
            Read Ficha from player.
        */
        public int takeTurn()
        {
            int FichaNumber = int.Parse(Console.ReadLine());
            return FichaNumber;
        }

        /**
            Check all rows for win
        */
        private bool checkRowsForWin(Board Board)
        {
            for (int i = 0; i < Board.BOARD_SIZE; i++)
            {
                if (checkRowCol(Board.board[i, 0].getFichaState(), Board.board[i, 1].getFichaState(), Board.board[i, 2].getFichaState()))
                    return true;
            }
            return false;
        }
        /**
           Check all columns for win
       */
        private bool checkColumnsForWin(Board Board)
        {
            for (int i = 0; i < Board.BOARD_SIZE; i++)
            {
                if (checkRowCol(Board.board[0, i].getFichaState(), Board.board[1, i].getFichaState(), Board.board[2, i].getFichaState()))
                    return true;
            }
            return false;
        }

        /** 
        Check the two diagonals to see if either is a win. Return true if either wins.
        
            */
        private bool checkDiagonalsForWin(Board Board)
        {
            return ((checkRowCol(Board.board[0, 0].getFichaState(), Board.board[1, 1].getFichaState(), Board.board[2, 2].getFichaState()) == true) || (checkRowCol(Board.board[0, 2].getFichaState(), Board.board[1, 1].getFichaState(), Board.board[2, 0].getFichaState()) == true));
        }

        /**
        Check to see if all three values are the same (and not empty) indicating a win.
    */
        private bool checkRowCol(Ficha c1, Ficha c2, Ficha c3)
        {

            return (c1 != Ficha.TIPO_EMPTY) && (c1 == c2) && (c2 == c3);
        }

        /**
        Check to see if all three conditions are true indicating win.
    */
        public bool checkWin(Board Board)
        {
            return (checkRowsForWin(Board) || checkColumnsForWin(Board) || checkDiagonalsForWin(Board));
        }

    
    }
}
