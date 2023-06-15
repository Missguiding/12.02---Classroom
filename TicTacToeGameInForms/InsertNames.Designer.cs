
namespace TicTacToeGameForms
{
    partial class InsertNames
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
            this.lblPlayer1 = new System.Windows.Forms.Label();
            this.lblPlayer2 = new System.Windows.Forms.Label();
            this.txbPlayer1 = new System.Windows.Forms.TextBox();
            this.txbPlayer2 = new System.Windows.Forms.TextBox();
            this.btnPlayGame = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblPlayer1
            // 
            this.lblPlayer1.AutoSize = true;
            this.lblPlayer1.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblPlayer1.Location = new System.Drawing.Point(12, 9);
            this.lblPlayer1.Name = "lblPlayer1";
            this.lblPlayer1.Size = new System.Drawing.Size(197, 25);
            this.lblPlayer1.TabIndex = 0;
            this.lblPlayer1.Text = "Player One Name:";            
            // 
            // lblPlayer2
            // 
            this.lblPlayer2.AutoSize = true;
            this.lblPlayer2.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblPlayer2.Location = new System.Drawing.Point(12, 47);
            this.lblPlayer2.Name = "lblPlayer2";
            this.lblPlayer2.Size = new System.Drawing.Size(194, 25);
            this.lblPlayer2.TabIndex = 1;
            this.lblPlayer2.Text = "Player Two Name:";
            // 
            // txbPlayer1
            // 
            this.txbPlayer1.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txbPlayer1.Location = new System.Drawing.Point(212, 6);
            this.txbPlayer1.Name = "txbPlayer1";
            this.txbPlayer1.Size = new System.Drawing.Size(273, 32);
            this.txbPlayer1.TabIndex = 2;
            this.txbPlayer1.TextChanged += new System.EventHandler(this.TxbPlayer1_TextChanged);
            // 
            // txbPlayer2
            // 
            this.txbPlayer2.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txbPlayer2.Location = new System.Drawing.Point(212, 44);
            this.txbPlayer2.Name = "txbPlayer2";
            this.txbPlayer2.Size = new System.Drawing.Size(273, 32);
            this.txbPlayer2.TabIndex = 3;
            this.txbPlayer2.TextChanged += new System.EventHandler(this.TxbPlayer2_TextChanged);
            this.txbPlayer2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxbPlayer2_KeyPress);
            // 
            // btnPlayGame
            // 
            this.btnPlayGame.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnPlayGame.Location = new System.Drawing.Point(391, 82);
            this.btnPlayGame.Name = "btnPlayGame";
            this.btnPlayGame.Size = new System.Drawing.Size(94, 38);
            this.btnPlayGame.TabIndex = 4;
            this.btnPlayGame.Text = "PLAY";
            this.btnPlayGame.UseVisualStyleBackColor = true;
            this.btnPlayGame.Click += new System.EventHandler(this.BtnPlayGame_Click);
            // 
            // InsertNames
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(505, 140);
            this.Controls.Add(this.btnPlayGame);
            this.Controls.Add(this.txbPlayer2);
            this.Controls.Add(this.txbPlayer1);
            this.Controls.Add(this.lblPlayer2);
            this.Controls.Add(this.lblPlayer1);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(523, 187);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(523, 187);
            this.Name = "InsertNames";
            this.ShowIcon = false;
            this.Text = "TicTacToe";
            this.Load += new System.EventHandler(this.InsertNames_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblPlayer1;
        private System.Windows.Forms.Label lblPlayer2;
        private System.Windows.Forms.TextBox txbPlayer1;
        private System.Windows.Forms.TextBox txbPlayer2;
        private System.Windows.Forms.Button btnPlayGame;
    }
}