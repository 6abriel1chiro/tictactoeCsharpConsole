using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tictactoe2._0
{
    public class Board
    {
        public const int BOARD_SIZE = 3;
        public Casilla[,] board;
        /** 
        Constructor 
            */

        public Board()
        {
            initializeBoard();
        }

        /**
        Initialize Board - set board fields as empty
            */
        private void initializeBoard()
        {
            board = new Casilla[BOARD_SIZE, BOARD_SIZE];
            for (int i = 0; i < BOARD_SIZE; i++)
            {
                for (int j = 0; j < BOARD_SIZE; j++)
                {
                    board[i, j] = new Casilla();
                }
            }
        }

        /**
        Draw board method
    */
        public void printBoard()
        {
            const int ASCII_CODE_0 = 48;
            int fieldNumber = 1;
            Console.WriteLine("-----");
            for (int i = 0; i < BOARD_SIZE; i++)
            {
                for (int j = 0; j < BOARD_SIZE; j++)
                {
                    if (board[i, j].isEmpty())
                        Console.Write((char)(ASCII_CODE_0 + fieldNumber));
                    else
                        Console.Write((char)(board[i, j].getFichaState()));
                    fieldNumber++;

                    if (j < BOARD_SIZE - 1)
                    {
                        Console.Write("|");
                    }
                }
                Console.Write("\n");
            }
            Console.WriteLine("-----");
        }

        public void putMark(Player player, int fieldNumber)
        {

            int verticalY = (fieldNumber - 1) / 3;
            int horizontalX = (fieldNumber - 1) % 3;
            if (board[verticalY, horizontalX].isEmpty())
            {
                board[verticalY, horizontalX].markField(player);

            }

            else
            {
                Console.WriteLine("Este lugar ya esta tomado, selecciona otra posicion: ");
                putMark(player, player.takeTurn());
            }
        }

        public void clearBoard()
        {
            Console.Clear();
        }
    }
}
