using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToe
{
   public class Board
   {

      #region Constructor

      /// <summary>
      /// Create an empty Board
      /// </summary>
      public Board()
      {
         _squares = new Square[3, 3];
         ClearBoard();         
      }

      /// <summary>
      /// Create a board by copying the squares from an existing board
      /// </summary>
      /// <param name="sourceBoard">Board to copy</param>
      public Board(Board sourceBoard)
      {
         _squares = new Square[3, 3];

         if (sourceBoard != null)
         {
            Array.Copy(sourceBoard.Squares, Squares, sourceBoard.Squares.Length);
         }
      }

      #endregion

      #region Properties

      private Square[,] _squares;

      /// <summary>
      /// Squares of this Board
      /// </summary>
      public Square[,] Squares
      {
         get { return _squares; }
      }

      #endregion

      #region Public Methods

      /// <summary>
      /// Clear the board of all moves
      /// </summary>
      public void ClearBoard()
      {
         for (int iX = 0; iX < 3; iX++)
         {
            for (int iY = 0; iY < 3; iY++)
            {
               _squares[iX, iY] = new Square();
            }
         }
      }

      #endregion

   }
}
