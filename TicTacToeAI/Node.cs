using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToe
{
   public class Node<T>
   {

      #region Constructors

      /// <summary>
      /// Create a node of the given type with the given member data
      /// </summary>
      /// <param name="member">Member data to be stored in this node</param>
      public Node(T member)
      {
         _member = member;
      }

      /// <summary>
      /// Create a node of the given type with the given member data and linked to the given next node
      /// </summary>
      /// <param name="member">Member data to be stored in this node</param>
      /// <param name="next">Next node linked to this node</param>
      public Node(T member, Node<T> next)
      {
         _member = member;
         _next = next;
      }

      #endregion

      #region Properties

      private T _member;

      /// <summary>
      /// Member data of this node
      /// </summary>
      public T Member
      {
         get { return _member; }
         set { _member = value; }
      }

      private Node<T> _next;

      /// <summary>
      /// Next node
      /// </summary>
      public Node<T> Next
      {
         get { return _next; }
         set { _next = value; }
      }

      #endregion
   }
}
