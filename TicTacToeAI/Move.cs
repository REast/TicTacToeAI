using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToe
{
   public class Move
   {  

      #region Constructor

      /// <summary>
      /// Create a new attempted move for the given player to a given square
      /// </summary>
      /// <param name="player">Player who is moving</param>
      /// <param name="square">Square that the player is attempting to play</param>
      public Move(Player player, Square square)
      {
         _player = player;
         _square = square;
      }

      #endregion

      #region Properties

      private Player _player;

      /// <summary>
      /// Player making this move
      /// </summary>
      public Player Player
      {
         get { return _player; }
      }

      private Square _square;

      /// <summary>
      /// Square that the player is attempting to take
      /// </summary>
      public Square Square
      {
            get { return _square; }
         }

         #endregion
      }
}
