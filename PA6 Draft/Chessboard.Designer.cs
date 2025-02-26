﻿namespace PA6_Draft
{
    partial class Chessboard
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Chessboard));
            this.Board = new System.Windows.Forms.PictureBox();
            this.Player2Time = new System.Windows.Forms.TextBox();
            this.Player1Time = new System.Windows.Forms.TextBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.MainTimer = new System.Windows.Forms.Timer(this.components);
            this.Player2 = new System.Windows.Forms.TextBox();
            this.Player1 = new System.Windows.Forms.TextBox();
            this.Test4PF = new System.Windows.Forms.Label();
            this.Test3PF = new System.Windows.Forms.Label();
            this.Test2PF = new System.Windows.Forms.Label();
            this.Test1PF = new System.Windows.Forms.Label();
            this.Test4Label = new System.Windows.Forms.Label();
            this.Test3Label = new System.Windows.Forms.Label();
            this.Test2Label = new System.Windows.Forms.Label();
            this.Test1Label = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Board)).BeginInit();
            this.SuspendLayout();
            // 
            // Board
            // 
            this.Board.Location = new System.Drawing.Point(12, 37);
            this.Board.MaximumSize = new System.Drawing.Size(512, 512);
            this.Board.MinimumSize = new System.Drawing.Size(512, 512);
            this.Board.Name = "Board";
            this.Board.Size = new System.Drawing.Size(512, 512);
            this.Board.TabIndex = 0;
            this.Board.TabStop = false;
            this.Board.Paint += new System.Windows.Forms.PaintEventHandler(this.Board_Paint);
            this.Board.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Board_MouseDown);
            this.Board.MouseLeave += new System.EventHandler(this.Board_MouseLeave);
            this.Board.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Board_MouseMove);
            this.Board.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Board_MouseUp);
            // 
            // Player2Time
            // 
            this.Player2Time.BackColor = System.Drawing.SystemColors.Menu;
            this.Player2Time.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Player2Time.Enabled = false;
            this.Player2Time.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Player2Time.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.Player2Time.Location = new System.Drawing.Point(473, 11);
            this.Player2Time.Name = "Player2Time";
            this.Player2Time.Size = new System.Drawing.Size(51, 19);
            this.Player2Time.TabIndex = 1;
            this.Player2Time.TextChanged += new System.EventHandler(this.Player2Time_TextChanged);
            // 
            // Player1Time
            // 
            this.Player1Time.BackColor = System.Drawing.SystemColors.Menu;
            this.Player1Time.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Player1Time.Enabled = false;
            this.Player1Time.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Player1Time.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.Player1Time.Location = new System.Drawing.Point(473, 555);
            this.Player1Time.Name = "Player1Time";
            this.Player1Time.Size = new System.Drawing.Size(51, 19);
            this.Player1Time.TabIndex = 2;
            this.Player1Time.TextChanged += new System.EventHandler(this.Player1Time_TextChanged);
            // 
            // listBox1
            // 
            this.listBox1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.listBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBox1.ForeColor = System.Drawing.Color.AliceBlue;
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 20;
            this.listBox1.Location = new System.Drawing.Point(539, 45);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(235, 504);
            this.listBox1.TabIndex = 9;
            // 
            // MainTimer
            // 
            this.MainTimer.Enabled = true;
            this.MainTimer.Interval = 15;
            this.MainTimer.Tick += new System.EventHandler(this.MainTimer_Tick);
            // 
            // Player2
            // 
            this.Player2.BackColor = System.Drawing.SystemColors.Menu;
            this.Player2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Player2.Enabled = false;
            this.Player2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Player2.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.Player2.Location = new System.Drawing.Point(12, 11);
            this.Player2.Name = "Player2";
            this.Player2.Size = new System.Drawing.Size(161, 19);
            this.Player2.TabIndex = 10;
            // 
            // Player1
            // 
            this.Player1.BackColor = System.Drawing.SystemColors.Menu;
            this.Player1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Player1.Enabled = false;
            this.Player1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Player1.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.Player1.Location = new System.Drawing.Point(12, 555);
            this.Player1.Name = "Player1";
            this.Player1.Size = new System.Drawing.Size(161, 19);
            this.Player1.TabIndex = 11;
            // 
            // Test4PF
            // 
            this.Test4PF.AutoSize = true;
            this.Test4PF.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Test4PF.Location = new System.Drawing.Point(1005, 415);
            this.Test4PF.Name = "Test4PF";
            this.Test4PF.Size = new System.Drawing.Size(23, 25);
            this.Test4PF.TabIndex = 20;
            this.Test4PF.Text = "a";
            this.Test4PF.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Test3PF
            // 
            this.Test3PF.AutoSize = true;
            this.Test3PF.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Test3PF.Location = new System.Drawing.Point(1005, 331);
            this.Test3PF.Name = "Test3PF";
            this.Test3PF.Size = new System.Drawing.Size(23, 25);
            this.Test3PF.TabIndex = 19;
            this.Test3PF.Text = "a";
            this.Test3PF.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Test2PF
            // 
            this.Test2PF.AutoSize = true;
            this.Test2PF.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Test2PF.Location = new System.Drawing.Point(1005, 249);
            this.Test2PF.Name = "Test2PF";
            this.Test2PF.Size = new System.Drawing.Size(23, 25);
            this.Test2PF.TabIndex = 18;
            this.Test2PF.Text = "a";
            this.Test2PF.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Test1PF
            // 
            this.Test1PF.AutoSize = true;
            this.Test1PF.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Test1PF.Location = new System.Drawing.Point(1005, 166);
            this.Test1PF.Name = "Test1PF";
            this.Test1PF.Size = new System.Drawing.Size(23, 25);
            this.Test1PF.TabIndex = 17;
            this.Test1PF.Text = "a";
            this.Test1PF.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Test4Label
            // 
            this.Test4Label.AutoSize = true;
            this.Test4Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Test4Label.Location = new System.Drawing.Point(889, 415);
            this.Test4Label.Name = "Test4Label";
            this.Test4Label.Size = new System.Drawing.Size(73, 25);
            this.Test4Label.TabIndex = 16;
            this.Test4Label.Text = "Test 4:";
            // 
            // Test3Label
            // 
            this.Test3Label.AutoSize = true;
            this.Test3Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Test3Label.Location = new System.Drawing.Point(889, 331);
            this.Test3Label.Name = "Test3Label";
            this.Test3Label.Size = new System.Drawing.Size(73, 25);
            this.Test3Label.TabIndex = 15;
            this.Test3Label.Text = "Test 3:";
            // 
            // Test2Label
            // 
            this.Test2Label.AutoSize = true;
            this.Test2Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Test2Label.Location = new System.Drawing.Point(889, 249);
            this.Test2Label.Name = "Test2Label";
            this.Test2Label.Size = new System.Drawing.Size(73, 25);
            this.Test2Label.TabIndex = 14;
            this.Test2Label.Text = "Test 2:";
            // 
            // Test1Label
            // 
            this.Test1Label.AutoSize = true;
            this.Test1Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Test1Label.Location = new System.Drawing.Point(889, 166);
            this.Test1Label.Name = "Test1Label";
            this.Test1Label.Size = new System.Drawing.Size(73, 25);
            this.Test1Label.TabIndex = 13;
            this.Test1Label.Text = "Test 1:";
            // 
            // Chessboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1243, 593);
            this.Controls.Add(this.Test4PF);
            this.Controls.Add(this.Test3PF);
            this.Controls.Add(this.Test2PF);
            this.Controls.Add(this.Test1PF);
            this.Controls.Add(this.Test4Label);
            this.Controls.Add(this.Test3Label);
            this.Controls.Add(this.Test2Label);
            this.Controls.Add(this.Test1Label);
            this.Controls.Add(this.Player1);
            this.Controls.Add(this.Player2);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.Player1Time);
            this.Controls.Add(this.Player2Time);
            this.Controls.Add(this.Board);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Chessboard";
            this.Text = "Chessboard";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Chessboard_FormClosed);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.ChessBoard_MouseMove);
            ((System.ComponentModel.ISupportInitialize)(this.Board)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox Board;
        private System.Windows.Forms.TextBox Player2Time;
        private System.Windows.Forms.TextBox Player1Time;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Timer MainTimer;
        private System.Windows.Forms.TextBox Player2;
        private System.Windows.Forms.TextBox Player1;
        public System.Windows.Forms.Label Test4PF;
        public System.Windows.Forms.Label Test3PF;
        public System.Windows.Forms.Label Test2PF;
        public System.Windows.Forms.Label Test1PF;
        private System.Windows.Forms.Label Test4Label;
        private System.Windows.Forms.Label Test3Label;
        private System.Windows.Forms.Label Test2Label;
        private System.Windows.Forms.Label Test1Label;
    }
}