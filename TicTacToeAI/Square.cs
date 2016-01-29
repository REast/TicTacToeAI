using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToe
{
   public class Square
   {

      #region Constructor

      /// <summary>
      /// Create a new square instance
      /// </summary>
      public Square()
      {
         _owner = null;
      }

      #endregion

      #region Properties

      private Player _owner;

      /// <summary>
      /// Player who owns this square (null if the square is unclaimed)
      /// </summary>
      public Player Owner
      {
         get { return _owner; }
         internal set { _owner = value; }
      }

      #endregion
   }
}
