using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToe
{
   public class GameState
   {

      #region Constructor

      /// <summary>
      /// Create a new GameState object
      /// </summary>
      /// <param name="isCompleted">True if the game has ended, otherwise False</param>
      /// <param name="winner">Winning player (null if tie or if the game has not completed)</param>
      public GameState(bool isCompleted, Player winner)
      {
         _isCompleted = isCompleted;
         _winner = winner;
      }

      #endregion

      #region Properties

      private bool _isCompleted;

      /// <summary>
      /// True if the game has ended, otherwise False
      /// </summary>
      public bool IsCompleted
      {
         get { return _isCompleted; }
      }

      private Player _winner;

      /// <summary>
      /// Winning player (null if tie or if the game has not completed)
      /// </summary>
      public Player Winner
      {
         get { return _winner; }
      }

      #endregion
   }
}
