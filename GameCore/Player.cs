using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameCore
{
    enum identity {X,O}
    class Player
    {
        private identity playerIdentity;
        public bool turn = false;
     
        public void setPlayer(identity iden)
        {
            playerIdentity = iden;
        }
        public char getIdentity(Player currentPlayer)
        {
            return (char)currentPlayer.playerIdentity;
        }
    }
}
