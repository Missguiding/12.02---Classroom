
namespace ButtonColorChanger
{
    partial class ChangeColor
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.buttonChanger = new System.Windows.Forms.Button();
            this.messageButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonChanger
            // 
            this.buttonChanger.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.buttonChanger.Location = new System.Drawing.Point(252, 65);
            this.buttonChanger.Name = "buttonChanger";
            this.buttonChanger.Size = new System.Drawing.Size(309, 110);
            this.buttonChanger.TabIndex = 0;
            this.buttonChanger.Text = "Click to change color";
            this.buttonChanger.UseVisualStyleBackColor = false;
            this.buttonChanger.Click += new System.EventHandler(this.buttonChanger_Click);
            // 
            // messageButton
            // 
            this.messageButton.Location = new System.Drawing.Point(210, 240);
            this.messageButton.Name = "messageButton";
            this.messageButton.Size = new System.Drawing.Size(381, 51);
            this.messageButton.TabIndex = 1;
            this.messageButton.Text = "See how many times you changed";
            this.messageButton.UseVisualStyleBackColor = true;
            this.messageButton.Click += new System.EventHandler(this.messageButton_Click);
            // 
            // ChangeColor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.messageButton);
            this.Controls.Add(this.buttonChanger);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "ChangeColor";
            this.Text = "Change Color Botton";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonChanger;
        private System.Windows.Forms.Button messageButton;
    }
}

