using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using TicTacToe;

namespace Shell
{
   public partial class FormMain : Form
   {

      #region Constructor

      public FormMain()
      {
         InitializeComponent();

         squareButtons = new Button[3, 3]
         {
            {  square1_1, square1_2, square1_3 },
            {  square2_1, square2_2, square2_3 },
            {  square3_1, square3_2, square3_3 }
         };
      }

      #endregion

      #region Delegates
      
      delegate void SetControlTextCallback(Control control, string text);

      delegate void EnableConfigurationOptionsCallback(bool setEnabled);

      delegate void SafeEnableControlCallback(Control control, bool setEnabled); 

      #endregion

      #region Fields

      protected Button[,] squareButtons;
      protected Game gameActive;

      #endregion

      #region EventHandlers

      /// <summary>
      /// Called when the user clicks the 'Start' button
      /// </summary>
      /// <param name="sender"></param>
      /// <param name="e"></param>
      private void btnStart_Click(object sender, EventArgs e)
      {
         try
         {
            EnableConfigurationOptions(false);
            InitializeGame();
         }
         catch(Exception ex)
         {
            MessageBox.Show(this, ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            EnableConfigurationOptions(true);
         }
      }

      /// <summary>
      /// Called when the user clicks a square button in the game board visual area
      /// </summary>
      /// <param name="sender"></param>
      /// <param name="e"></param>
      private void square_clicked(object sender, EventArgs e)
      {
         Button squareClicked = (Button)sender;

         if (squareClicked.Enabled && gameActive != null)
         {
            Square squareObject = null;

            for (int iX = 0; iX < 3; iX++)
            {
               for (int iY = 0; iY < 3; iY++)
               {
                  if (squareButtons[iX,iY] == squareClicked)
                  {
                     squareObject = gameActive.Board.Squares[iX, iY];
                     break;
                  }
               }
            }

            if (squareObject != null)
            {
               Move move = new Move(gameActive.ActivePlayer, squareObject);
               gameActive.PlayMove(move);
            }
         }
      }

      /// <summary>
      /// Called when the game raises a gameUpdate event
      /// </summary>
      /// <param name="sender">Game instance raising the update</param>
      /// <param name="e"></param>
      private void game_gameUpdate(object sender, EventArgs e)
      {
         Game game = (Game)sender;

         for(int iX = 0; iX < 3;  iX++)
         {
            for (int iY = 0; iY < 3; iY++)
            {
               string symbolStr = string.Empty;
               Player squareOwner = game.Board.Squares[iX, iY].Owner;

               Control control = squareButtons[iX, iY];

               SafeEnableControl(control, false);

               if (squareOwner != null)
               {
                  symbolStr = squareOwner.Symbol.ToString();
               }               

               SetControlText(control, symbolStr);
            }
         }

         GameState state = game.GetGameState();

         if (state.IsCompleted)
         {
            string gameOverText;

            if (state.Winner == null)
            {
               gameOverText = "Game ended in a tie!";
            }
            else
            {
               gameOverText = string.Format("{0}'s won!", state.Winner.Symbol);
            }

            MessageBox.Show(gameOverText, "Game Over", MessageBoxButtons.OK);

            EnableConfigurationOptions(true);
         }
      }

      /// <summary>
      /// Called when a player object is given control, prompting the user for a move
      /// </summary>
      /// <param name="sender">Game instance requesting a human player's move</param>
      /// <param name="e"></param>
      private void player_promptForMove(object sender, EventArgs e)
      {
         gameActive = (Game)sender;

         for (int iX = 0; iX < 3; iX++)
         {
            for (int iY = 0; iY < 3; iY++)
            {
               string symbolStr = string.Empty;
               Player squareOwner = gameActive.Board.Squares[iX, iY].Owner;

               Control control = squareButtons[iX, iY];
               bool setEnabled = squareOwner == null;

               SafeEnableControl(control, setEnabled);
            }
         }
      }

      #endregion

      #region Protected Methods

      protected void InitializeGame()
      {
         string playerOneStr = comboBoxPlayer1.Text;
         string playerTwoStr = comboBoxPlayer2.Text;
                  
         Player playerOne = CreatePlayerInstance(playerOneStr, 'X');
         Player playerTwo = CreatePlayerInstance(playerTwoStr, 'O');

         if (playerOne == null || playerTwo == null)
         {
            throw new ConfigurationException("Both players must be set to either Human or AI in order to start a game.");
         }

         Game game = new Game(playerOne, playerTwo);
         Thread thread = new Thread(game.Start);                           
         game.GameUpdate += game_gameUpdate;
         thread.Start();
      }

      protected Player CreatePlayerInstance(string playerType, char playerSymbol)
      {
         Player player;

         switch (playerType.ToLower())
         {
            case "human":
               player = new PlayerHuman(playerSymbol, player_promptForMove);
               break;

            case "ai":
               player = new PlayerAI(playerSymbol, 1000);
               break;

            default:
               player = null;
               break;
         }

         return player;
      }

      protected void SafeEnableControl(Control control, bool setEnabled)
      {
         if (control.InvokeRequired)
         {
            SafeEnableControlCallback d = new SafeEnableControlCallback(SafeEnableControl);
            Invoke(d, new object[] { control, setEnabled });
         }
         else
         {
            control.Enabled = setEnabled;
         }
      }

      /// <summary>
      /// Thread safe method of setting text box text
      /// </summary>
      /// <param name="control">Control to set text for</param>
      /// <param name="text">Text to put into the control</param>
      protected void SetControlText(Control control, string text)
      {
         if (control.InvokeRequired)
         {
            SetControlTextCallback d = new SetControlTextCallback(SetControlText);
            Invoke(d, new object[] { control, text });
         }
         else
         {
            control.Text = text;
         }
      }            

      protected void EnableConfigurationOptions(bool setEnabled)
      {
         if (InvokeRequired)
         {
            EnableConfigurationOptionsCallback d = new EnableConfigurationOptionsCallback(EnableConfigurationOptions);
            Invoke(d, new object[] { setEnabled });
         }
         else
         {
            btnStart.Enabled = setEnabled;
            comboBoxPlayer1.Enabled = setEnabled;
            comboBoxPlayer2.Enabled = setEnabled;
         }         
      }

      #endregion
   }
}
