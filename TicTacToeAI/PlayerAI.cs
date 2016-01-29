using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace TicTacToe
{
    public class PlayerAI : Player
    {

      #region Constructor

      /// <summary>
      /// Create an AI player
      /// </summary>
      /// <param name="symbol">Symbol that represents this player's moves visually (ie. X or O)</param>
      /// <param name="minTurnTime">Minimum time to wait before submitting a found move to the game object</param>
      public PlayerAI(char symbol, int minTurnTime) : base(symbol)
      {
         _minTurnTime = minTurnTime;
      }

      #endregion

      #region Fields
            
      private Player _playerOpponent;

      #endregion

      #region Properties

      private int _minTurnTime;

      /// <summary>
      /// Minimum time to wait before submitting a found move to the game object
      /// </summary>
      public int MinTurnTime
      {
         get { return _minTurnTime; }
      }

      #endregion

      #region Player Overrides

      /// <summary>
      /// Method called when the game passes control to this player
      /// </summary>
      /// <param name="game">Game object that this player belongs to</param>
      public override void PromptForMove(Game game)
      {
         Stopwatch stopwatch = new Stopwatch();
         stopwatch.Start();

         Square bestSquare = null;
         int bestValue = int.MinValue;

         _playerOpponent = game.Players[0];

         if (_playerOpponent == this)
         {
            _playerOpponent = game.Players[1];
         }

         foreach (Square square in game.Board.Squares)
         {
            if (square.Owner == null)
            {
               square.Owner = this;
               int curValue = AlphaBetaPrune(game, int.MinValue, int.MaxValue, false);
               square.Owner = null;

               if (bestSquare == null || curValue > bestValue)
               {
                  bestValue = curValue;
                  bestSquare = square;
               }
            }
         }

         int curTurnTime = (int)stopwatch.ElapsedMilliseconds;
         int turnTimeDiff = _minTurnTime - curTurnTime;

         Move move = new Move(this, bestSquare);

         Action playMove = () => game.PlayMove(move);

         int sleepMs = Math.Max(0, turnTimeDiff);

         // Ensure that the AI waits at least the minTurnTime before playing a move,
         // making the AI seem more human-like in that it won't make all of its moves near instantaniously.
         using (Timer timer = new Timer(PlayMoveAfterDelayCallback, playMove, sleepMs, Timeout.Infinite))
         {
         } 
      }

      #endregion

      #region Protected Methods

      protected void PlayMoveAfterDelayCallback(object state)
      {
         if (state != null)
         {
            Action playMove = (Action)state;
            playMove();
         }
      }

      /// <summary>
      /// AlphaBeta Pruning algorithm adapted from genric AlphaBeta Pseudo-code: https://en.wikipedia.org/wiki/Alpha%E2%80%93beta_pruning
      /// </summary>
      /// <param name="game">Current game object (containing up-to-date board simulation)</param>
      /// <param name="alpha">Alpha value</param>
      /// <param name="beta">Beta value</param>
      /// <param name="maximizingPlayer">Maximizing player (True when it is THIS AI's turn in the simulation)</param>
      /// <returns></returns>
      private int AlphaBetaPrune(Game game, int alpha, int beta, bool maximizingPlayer)
      {
         // Check the current game state and if it is completed, return the (maximizing player's) value associated with the game outcome
         GameState state = game.GetGameState();

         if (state.IsCompleted)
         {
            if (state.Winner == null)
            {
               return 0;
            }
            else if (state.Winner == this)
            {
               return 1;
            }
            else
            {
               return -1;
            }
         }

         // If the game was not completed by the previous move, continue recursing through possible moves
         int value;

         if (maximizingPlayer)
         {
            value = int.MinValue;

            foreach (Square square in game.Board.Squares)
            {
               if (square.Owner == null)
               {
                  square.Owner = this;
                  value = Math.Max(value, AlphaBetaPrune(game, alpha, beta, false));
                  alpha = Math.Max(alpha, value);
                  square.Owner = null;

                  if (beta <= alpha)
                  {
                     break;
                  }
               }               
            }
         }
         else
         {
            value = int.MaxValue;

            foreach (Square square in game.Board.Squares)
            {
               if (square.Owner == null)
               {
                  square.Owner = _playerOpponent;
                  value = Math.Min(value, AlphaBetaPrune(game, alpha, beta, true));
                  beta = Math.Min(beta, value);
                  square.Owner = null;

                  if (beta <= alpha)
                  {
                     break;
                  }
               }
            }
         }
         return value;
      }

      #endregion
   }
}
