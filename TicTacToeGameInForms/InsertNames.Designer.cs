
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txbPlayer1 = new System.Windows.Forms.TextBox();
            this.txbPlayer2 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(197, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Player One Name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(12, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(194, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Player Two Name:";
            // 
            // txbPlayer1
            // 
            this.txbPlayer1.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txbPlayer1.Location = new System.Drawing.Point(212, 6);
            this.txbPlayer1.Name = "txbPlayer1";
            this.txbPlayer1.Size = new System.Drawing.Size(273, 32);
            this.txbPlayer1.TabIndex = 2;
            this.txbPlayer1.TextChanged += new System.EventHandler(this.txbPlayer1_TextChanged);
            // 
            // txbPlayer2
            // 
            this.txbPlayer2.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txbPlayer2.Location = new System.Drawing.Point(212, 44);
            this.txbPlayer2.Name = "txbPlayer2";
            this.txbPlayer2.Size = new System.Drawing.Size(273, 32);
            this.txbPlayer2.TabIndex = 3;
            this.txbPlayer2.TextChanged += new System.EventHandler(this.txbPlayer2_TextChanged);
            this.txbPlayer2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txbPlayer2_KeyPress);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button1.Location = new System.Drawing.Point(391, 82);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(94, 38);
            this.button1.TabIndex = 4;
            this.button1.Text = "PLAY";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // InsertNames
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(505, 140);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txbPlayer2);
            this.Controls.Add(this.txbPlayer1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
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

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txbPlayer1;
        private System.Windows.Forms.TextBox txbPlayer2;
        private System.Windows.Forms.Button button1;
    }
}