using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToe
{
   [Serializable]
   public class InvalidMoveException : Exception
   {
      public InvalidMoveException() : base() { }

      public InvalidMoveException(string message) : base(message) { }

      public InvalidMoveException(string message, Exception innerException) : base(message, innerException) { }

      protected InvalidMoveException(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context) : base(info, context) { }
   }

   [Serializable]
   public class StartGameException : Exception
   {
      public StartGameException() : base() { }

      public StartGameException(string message) : base(message) { }

      public StartGameException(string message, Exception innerException) : base(message, innerException) { }

      protected StartGameException(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context) : base(info, context) { }
   }
}
