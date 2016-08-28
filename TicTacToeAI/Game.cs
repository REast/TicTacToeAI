using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace TicTacToe
{
   public class Game
   {

      #region Constructor

      /// <summary>
      /// Create a new game instance between the two given players
      /// </summary>
      /// <param name="player1">Player one</param>
      /// <param name="player2">Player two</param>
      public Game(Player player1, Player player2)
      {
         _board = new Board();
         _players = new Collection<Player>(){ player1, player2 };         
         _isInitialized = false;
      }

      #endregion

      #region Fields

      private bool _isInitialized = false;

      #endregion

      #region Properties

      private Board _board;

      /// <summary>
      /// The current game board
      /// </summary>
      public Board Board
      {
         get { return _board; }
      }

      private Collection<Player> _players;

      /// <summary>
      /// The players involved in this game instance
      /// </summary>
      public Collection<Player> Players
      {
         get { return _players; }
      }

      private Node<Player> _activePlayerNode;

      /// <summary>
      /// The player whose turn it is
      /// </summary>
      public Player ActivePlayer
      {
         get { return _activePlayerNode.Member; }
      }

      #endregion

      #region Events

      /// <summary>
      /// Event raised when a move or turn change takes place
      /// </summary>
      public event EventHandler GameUpdate;

      protected void OnGameUpdate()
      {
         EventHandler handler = GameUpdate;

         if (handler != null)
         {
            handler.Invoke(this, null);
         }
      }

      #endregion

      #region Public Methods

      /// <summary>
      /// Begin the game and pass control to the first player
      /// </summary>
      public void Start()
      {
         if (_isInitialized)
         {
            throw new StartGameException("Cannot start game because game has already started.");
         }

         Node<Player> prevPlayerNode = null;
         Node<Player> lastPlayerNode = null;

         // Generic way of instantiating active player node (supports more than 2 players)
         for (int i = _players.Count - 1; i >= 0; i--)
         {
            Node<Player> curPlayerNode = new Node<Player>(_players[i], prevPlayerNode);

            if (lastPlayerNode == null)
            {
               lastPlayerNode = curPlayerNode;
            }
            if (i == 0)
            {
               _activePlayerNode = curPlayerNode;
            }

            prevPlayerNode = curPlayerNode;
         }

         lastPlayerNode.Next = _activePlayerNode;

         _isInitialized = true;
         OnGameUpdate();

         ActivePlayer.PromptForMove(this);
      }
      
      /// <summary>
      /// Attempt to play the given move
      /// </summary>
      /// <param name="move">Move to try and play</param>
      public void PlayMove(Move move)
      {
         if (move == null)
         {
            throw new InvalidMoveException("Cannot play null move.");
         }

         if (move.Player != ActivePlayer)
         {
            throw new InvalidMoveException("It is not this player's [" + move.Player.ToString() + "] turn.");
         }

         if (move.Square.Owner != null)
         {
            throw new InvalidMoveException("Board square [" + move.Square.ToString() + "] already has an owner.");
         }

         move.Square.Owner = move.Player;
         OnGameUpdate();
         AdvanceTurn();         

         if (GetGameState().IsCompleted == false)
         {
            ActivePlayer.PromptForMove(this);
         }
      }

      /// <summary>
      /// Get the current game state (whether the game is complete and if so, which player won
      /// </summary>
      /// <returns>Gamestate containing IsComplete bool and winner (if not a tie)</returns>
      public GameState GetGameState()
      {
         bool isCompleted = false;
         Player winner = null;

         // Horizontal
         if (winner == null)
         {
            for (int i = 0; i < 3; i++)
            {
               for (int j = 0; j < 3; j++)
               {
                  Player owner = _board.Squares[i, j].Owner;

                  if (owner == null)
                  {
                     winner = null;
                     break;
                  }
                  else if (winner == null)
                  {
                     winner = owner;
                  }
                  else if (owner != winner)
                  {
                     winner = null;
                     break;
                  }
               }

               if (winner != null)
               {
                  break;
               }
            }
         }

         // Vertical
         if (winner == null)
         {
            for (int i = 0; i < 3; i++)
            {
               for (int j = 0; j < 3; j++)
               {
                  Player owner = _board.Squares[j, i].Owner;

                  if (owner == null)
                  {
                     winner = null;
                     break;
                  }
                  else if (winner == null)
                  {
                     winner = owner;
                  }
                  else if (owner != winner)
                  {
                     winner = null;
                     break;
                  }
               }

               if (winner != null)
               {
                  break;
               }
            }
         }

         // Diagonal down-right
         if (winner == null)
         {
            for (int i = 0; i < 3; i++)
            {
               Player owner = _board.Squares[i, i].Owner;

               if (owner == null)
               {
                  winner = null;
                  break;
               }
               else if (winner == null)
               {
                  winner = owner;
               }
               else if (owner != winner)
               {
                  winner = null;
                  break;
               }
            }
         }

         // Diagonal up-right
         if (winner == null)
         {
            for (int i = 0; i < 3; i++)
            {
               Player owner = _board.Squares[2 - i, i].Owner;

               if (owner == null)
               {
                  winner = null;
                  break;
               }
               else if (winner == null)
               {
                  winner = owner;
               }
               else if (owner != winner)
               {
                  winner = null;
                  break;
               }
            }
         }

         // Get total move count
         int totalMoveCount = 0;

         foreach(Square sq in _board.Squares)
         {
            if (sq.Owner != null)
            {
               totalMoveCount++;
            }
         }

         // Determine end result
         if (winner != null || totalMoveCount == 9)
         {
            isCompleted = true;
         }         

         return new GameState(isCompleted, winner, totalMoveCount);
      }

      #endregion

      #region Protected Methods

      protected void AdvanceTurn()
      {
         _activePlayerNode = _activePlayerNode.Next;
      }

      #endregion
   }
}
