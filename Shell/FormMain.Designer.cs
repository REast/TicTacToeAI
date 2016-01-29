namespace Shell
{
   partial class FormMain
   {
      /// <summary>
      /// Required designer variable.
      /// </summary>
      private System.ComponentModel.IContainer components = null;

      /// <summary>
      /// Clean up any resources being used.
      /// </summary>
      /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
      protected override void Dispose(bool disposing)
      {
         if (disposing && (components != null))
         {
            components.Dispose();
         }
         base.Dispose(disposing);
      }

      #region Windows Form Designer generated code

      /// <summary>
      /// Required method for Designer support - do not modify
      /// the contents of this method with the code editor.
      /// </summary>
      private void InitializeComponent()
      {
         this.comboBoxPlayer1 = new System.Windows.Forms.ComboBox();
         this.comboBoxPlayer2 = new System.Windows.Forms.ComboBox();
         this.labelPlayer1 = new System.Windows.Forms.Label();
         this.labelPlayer2 = new System.Windows.Forms.Label();
         this.btnStart = new System.Windows.Forms.Button();
         this.panelGameBoard = new System.Windows.Forms.Panel();
         this.square3_3 = new System.Windows.Forms.Button();
         this.square3_2 = new System.Windows.Forms.Button();
         this.square3_1 = new System.Windows.Forms.Button();
         this.square2_3 = new System.Windows.Forms.Button();
         this.square2_2 = new System.Windows.Forms.Button();
         this.square2_1 = new System.Windows.Forms.Button();
         this.square1_3 = new System.Windows.Forms.Button();
         this.square1_2 = new System.Windows.Forms.Button();
         this.square1_1 = new System.Windows.Forms.Button();
         this.panelGameBoard.SuspendLayout();
         this.SuspendLayout();
         // 
         // comboBoxPlayer1
         // 
         this.comboBoxPlayer1.FormattingEnabled = true;
         this.comboBoxPlayer1.Items.AddRange(new object[] {
            "Human",
            "AI"});
         this.comboBoxPlayer1.Location = new System.Drawing.Point(12, 29);
         this.comboBoxPlayer1.Name = "comboBoxPlayer1";
         this.comboBoxPlayer1.Size = new System.Drawing.Size(121, 21);
         this.comboBoxPlayer1.TabIndex = 0;
         // 
         // comboBoxPlayer2
         // 
         this.comboBoxPlayer2.FormattingEnabled = true;
         this.comboBoxPlayer2.Items.AddRange(new object[] {
            "Human",
            "AI"});
         this.comboBoxPlayer2.Location = new System.Drawing.Point(261, 29);
         this.comboBoxPlayer2.Name = "comboBoxPlayer2";
         this.comboBoxPlayer2.Size = new System.Drawing.Size(121, 21);
         this.comboBoxPlayer2.TabIndex = 1;
         // 
         // labelPlayer1
         // 
         this.labelPlayer1.AutoSize = true;
         this.labelPlayer1.Location = new System.Drawing.Point(37, 14);
         this.labelPlayer1.Name = "labelPlayer1";
         this.labelPlayer1.Size = new System.Drawing.Size(74, 13);
         this.labelPlayer1.TabIndex = 2;
         this.labelPlayer1.Text = "Player 1 ( X\'s )";
         // 
         // labelPlayer2
         // 
         this.labelPlayer2.AutoSize = true;
         this.labelPlayer2.Location = new System.Drawing.Point(285, 14);
         this.labelPlayer2.Name = "labelPlayer2";
         this.labelPlayer2.Size = new System.Drawing.Size(75, 13);
         this.labelPlayer2.TabIndex = 3;
         this.labelPlayer2.Text = "Player 2 ( O\'s )";
         // 
         // btnStart
         // 
         this.btnStart.Location = new System.Drawing.Point(139, 27);
         this.btnStart.Name = "btnStart";
         this.btnStart.Size = new System.Drawing.Size(116, 23);
         this.btnStart.TabIndex = 4;
         this.btnStart.Text = "Start";
         this.btnStart.UseVisualStyleBackColor = true;
         this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
         // 
         // panelGameBoard
         // 
         this.panelGameBoard.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
         this.panelGameBoard.BackColor = System.Drawing.SystemColors.ControlLight;
         this.panelGameBoard.Controls.Add(this.square3_3);
         this.panelGameBoard.Controls.Add(this.square3_2);
         this.panelGameBoard.Controls.Add(this.square3_1);
         this.panelGameBoard.Controls.Add(this.square2_3);
         this.panelGameBoard.Controls.Add(this.square2_2);
         this.panelGameBoard.Controls.Add(this.square2_1);
         this.panelGameBoard.Controls.Add(this.square1_3);
         this.panelGameBoard.Controls.Add(this.square1_2);
         this.panelGameBoard.Controls.Add(this.square1_1);
         this.panelGameBoard.Location = new System.Drawing.Point(13, 56);
         this.panelGameBoard.Name = "panelGameBoard";
         this.panelGameBoard.Size = new System.Drawing.Size(369, 369);
         this.panelGameBoard.TabIndex = 5;
         // 
         // square3_3
         // 
         this.square3_3.Enabled = false;
         this.square3_3.Font = new System.Drawing.Font("Microsoft Sans Serif", 63.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.square3_3.Location = new System.Drawing.Point(248, 247);
         this.square3_3.Name = "square3_3";
         this.square3_3.Size = new System.Drawing.Size(116, 116);
         this.square3_3.TabIndex = 17;
         this.square3_3.UseVisualStyleBackColor = true;
         this.square3_3.Click += new System.EventHandler(this.square_clicked);
         // 
         // square3_2
         // 
         this.square3_2.Enabled = false;
         this.square3_2.Font = new System.Drawing.Font("Microsoft Sans Serif", 63.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.square3_2.Location = new System.Drawing.Point(126, 247);
         this.square3_2.Name = "square3_2";
         this.square3_2.Size = new System.Drawing.Size(116, 116);
         this.square3_2.TabIndex = 16;
         this.square3_2.UseVisualStyleBackColor = true;
         this.square3_2.Click += new System.EventHandler(this.square_clicked);
         // 
         // square3_1
         // 
         this.square3_1.Enabled = false;
         this.square3_1.Font = new System.Drawing.Font("Microsoft Sans Serif", 63.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.square3_1.Location = new System.Drawing.Point(4, 247);
         this.square3_1.Name = "square3_1";
         this.square3_1.Size = new System.Drawing.Size(116, 116);
         this.square3_1.TabIndex = 15;
         this.square3_1.UseVisualStyleBackColor = true;
         this.square3_1.Click += new System.EventHandler(this.square_clicked);
         // 
         // square2_3
         // 
         this.square2_3.Enabled = false;
         this.square2_3.Font = new System.Drawing.Font("Microsoft Sans Serif", 63.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.square2_3.Location = new System.Drawing.Point(248, 125);
         this.square2_3.Name = "square2_3";
         this.square2_3.Size = new System.Drawing.Size(116, 116);
         this.square2_3.TabIndex = 14;
         this.square2_3.UseVisualStyleBackColor = true;
         this.square2_3.Click += new System.EventHandler(this.square_clicked);
         // 
         // square2_2
         // 
         this.square2_2.Enabled = false;
         this.square2_2.Font = new System.Drawing.Font("Microsoft Sans Serif", 63.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.square2_2.Location = new System.Drawing.Point(126, 125);
         this.square2_2.Name = "square2_2";
         this.square2_2.Size = new System.Drawing.Size(116, 116);
         this.square2_2.TabIndex = 13;
         this.square2_2.UseVisualStyleBackColor = true;
         this.square2_2.Click += new System.EventHandler(this.square_clicked);
         // 
         // square2_1
         // 
         this.square2_1.Enabled = false;
         this.square2_1.Font = new System.Drawing.Font("Microsoft Sans Serif", 63.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.square2_1.Location = new System.Drawing.Point(4, 125);
         this.square2_1.Name = "square2_1";
         this.square2_1.Size = new System.Drawing.Size(116, 116);
         this.square2_1.TabIndex = 12;
         this.square2_1.UseVisualStyleBackColor = true;
         this.square2_1.Click += new System.EventHandler(this.square_clicked);
         // 
         // square1_3
         // 
         this.square1_3.Enabled = false;
         this.square1_3.Font = new System.Drawing.Font("Microsoft Sans Serif", 63.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.square1_3.Location = new System.Drawing.Point(248, 3);
         this.square1_3.Name = "square1_3";
         this.square1_3.Size = new System.Drawing.Size(116, 116);
         this.square1_3.TabIndex = 11;
         this.square1_3.UseVisualStyleBackColor = true;
         this.square1_3.Click += new System.EventHandler(this.square_clicked);
         // 
         // square1_2
         // 
         this.square1_2.Enabled = false;
         this.square1_2.Font = new System.Drawing.Font("Microsoft Sans Serif", 63.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.square1_2.Location = new System.Drawing.Point(126, 3);
         this.square1_2.Name = "square1_2";
         this.square1_2.Size = new System.Drawing.Size(116, 116);
         this.square1_2.TabIndex = 10;
         this.square1_2.UseVisualStyleBackColor = true;
         this.square1_2.Click += new System.EventHandler(this.square_clicked);
         // 
         // square1_1
         // 
         this.square1_1.Enabled = false;
         this.square1_1.Font = new System.Drawing.Font("Microsoft Sans Serif", 63.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.square1_1.Location = new System.Drawing.Point(4, 3);
         this.square1_1.Name = "square1_1";
         this.square1_1.Size = new System.Drawing.Size(116, 116);
         this.square1_1.TabIndex = 9;
         this.square1_1.UseVisualStyleBackColor = true;
         this.square1_1.Click += new System.EventHandler(this.square_clicked);
         // 
         // FormMain
         // 
         this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.ClientSize = new System.Drawing.Size(395, 437);
         this.Controls.Add(this.panelGameBoard);
         this.Controls.Add(this.btnStart);
         this.Controls.Add(this.labelPlayer2);
         this.Controls.Add(this.labelPlayer1);
         this.Controls.Add(this.comboBoxPlayer2);
         this.Controls.Add(this.comboBoxPlayer1);
         this.MaximumSize = new System.Drawing.Size(411, 476);
         this.MinimumSize = new System.Drawing.Size(411, 476);
         this.Name = "FormMain";
         this.Text = "TicTacToe";
         this.panelGameBoard.ResumeLayout(false);
         this.ResumeLayout(false);
         this.PerformLayout();

      }

      #endregion

      private System.Windows.Forms.ComboBox comboBoxPlayer1;
      private System.Windows.Forms.ComboBox comboBoxPlayer2;
      private System.Windows.Forms.Label labelPlayer1;
      private System.Windows.Forms.Label labelPlayer2;
      private System.Windows.Forms.Button btnStart;
      private System.Windows.Forms.Panel panelGameBoard;
      private System.Windows.Forms.Button square3_3;
      private System.Windows.Forms.Button square3_2;
      private System.Windows.Forms.Button square3_1;
      private System.Windows.Forms.Button square2_3;
      private System.Windows.Forms.Button square2_2;
      private System.Windows.Forms.Button square2_1;
      private System.Windows.Forms.Button square1_3;
      private System.Windows.Forms.Button square1_2;
      private System.Windows.Forms.Button square1_1;
   }
}

