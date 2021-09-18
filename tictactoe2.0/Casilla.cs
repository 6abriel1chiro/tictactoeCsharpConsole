using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tictactoe2._0
{
   public class Casilla
    {
        Ficha ficha = Ficha.TIPO_EMPTY;

        public Casilla()
        {
            ficha = Ficha.TIPO_EMPTY;
        }
        public Ficha getFichaState()
        {
            return ficha;
        }
        public bool isEmpty()
        {
            if (ficha != Ficha.TIPO_EMPTY)
                return false;
            return true;
        }

        public void markField(Player player)
        {
            if (isEmpty())
            {
                if (player.getfichaJugador() == 'X')
                    ficha = Ficha.TIPO_X;
                else
                    ficha = Ficha.TIPO_O;

            }


        }

    }
}
