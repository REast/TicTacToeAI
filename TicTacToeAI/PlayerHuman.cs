using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace TicTacToe
{
    public class PlayerHuman : Player
    {

      #region Constructor

      /// <summary>
      /// Create a new human-controlled player
      /// </summary>
      /// <param name="symbol">Symbol that represents this player's moves visually (ie. X or O)</param>
      /// <param name="promptForMove">EventHandler that will be triggered when this player is prompted for a move by the game object</param>
      public PlayerHuman(char symbol, EventHandler promptForMove) : base(symbol)
      {         
         _promptForMove += promptForMove;
      }

      #endregion

      #region EventHandlers

      private EventHandler _promptForMove;

      #endregion

      #region Player Overrides

      /// <summary>
      /// Method called when the game passes control to this player
      /// </summary>
      /// <param name="game">Game object that this player belongs to</param>
      public override void PromptForMove(Game game)
      {
         _promptForMove(game, null);
      }

      #endregion
   }
}
