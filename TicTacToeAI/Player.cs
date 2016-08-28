using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToe
{
   public abstract class Player
   {

      #region Constructor

      /// <summary>
      /// Create a new player instance
      /// </summary>
      /// <param name="symbol">Symbol used to visually represent this player</param>
      protected Player(char symbol)
      {
         _symbol = symbol;
      }

      #endregion

      #region Properties

      private char _symbol;

      /// <summary>
      /// Symbol that represents this player's moves visually (ie. X or O)
      /// </summary>
      public char Symbol
      {
         get { return _symbol; }
      }

      #endregion

      #region Abstract Methods

      /// <summary>
      /// Method called when the game passes control to this player
      /// </summary>
      /// <param name="game">Game object that this player belongs to</param>
      public abstract void PromptForMove(Game game);

      #endregion
   }
}
