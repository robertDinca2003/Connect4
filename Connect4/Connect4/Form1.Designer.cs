namespace Connect4
{
    partial class Form1
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
            this.lblGameName = new System.Windows.Forms.Label();
            this.btn_play = new System.Windows.Forms.Button();
            this.btn_exit = new System.Windows.Forms.Button();
            this.panelGame = new System.Windows.Forms.Panel();
            this.lblCurrentTurn = new System.Windows.Forms.Label();
            this.btn_back = new System.Windows.Forms.Button();
            this.panelGame.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblGameName
            // 
            this.lblGameName.AutoSize = true;
            this.lblGameName.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGameName.ForeColor = System.Drawing.Color.DarkGreen;
            this.lblGameName.Location = new System.Drawing.Point(282, 5);
            this.lblGameName.Name = "lblGameName";
            this.lblGameName.Size = new System.Drawing.Size(462, 108);
            this.lblGameName.TabIndex = 0;
            this.lblGameName.Text = "Connect4";
            // 
            // btn_play
            // 
            this.btn_play.BackColor = System.Drawing.Color.DarkGreen;
            this.btn_play.Font = new System.Drawing.Font("Microsoft Sans Serif", 26F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_play.ForeColor = System.Drawing.Color.PapayaWhip;
            this.btn_play.Location = new System.Drawing.Point(312, 325);
            this.btn_play.Name = "btn_play";
            this.btn_play.Size = new System.Drawing.Size(397, 90);
            this.btn_play.TabIndex = 1;
            this.btn_play.Text = "PLAY";
            this.btn_play.UseVisualStyleBackColor = false;
            this.btn_play.Click += new System.EventHandler(this.btn_play_Click);
            // 
            // btn_exit
            // 
            this.btn_exit.BackColor = System.Drawing.Color.DarkGreen;
            this.btn_exit.Font = new System.Drawing.Font("Microsoft Sans Serif", 26F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_exit.ForeColor = System.Drawing.Color.PapayaWhip;
            this.btn_exit.Location = new System.Drawing.Point(312, 461);
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.Size = new System.Drawing.Size(397, 90);
            this.btn_exit.TabIndex = 2;
            this.btn_exit.Text = "EXIT";
            this.btn_exit.UseVisualStyleBackColor = false;
            this.btn_exit.Click += new System.EventHandler(this.btn_exit_Click);
            // 
            // panelGame
            // 
            this.panelGame.Controls.Add(this.btn_back);
            this.panelGame.Controls.Add(this.lblCurrentTurn);
            this.panelGame.Controls.Add(this.btn_exit);
            this.panelGame.Controls.Add(this.btn_play);
            this.panelGame.Controls.Add(this.lblGameName);
            this.panelGame.Location = new System.Drawing.Point(1, 4);
            this.panelGame.Name = "panelGame";
            this.panelGame.Size = new System.Drawing.Size(1060, 1026);
            this.panelGame.TabIndex = 3;
            this.panelGame.MouseClick += new System.Windows.Forms.MouseEventHandler(this.panelGame_MouseClick);
            // 
            // lblCurrentTurn
            // 
            this.lblCurrentTurn.AutoSize = true;
            this.lblCurrentTurn.Enabled = false;
            this.lblCurrentTurn.Font = new System.Drawing.Font("Microsoft Sans Serif", 26F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCurrentTurn.ForeColor = System.Drawing.Color.DarkGreen;
            this.lblCurrentTurn.Location = new System.Drawing.Point(50, 159);
            this.lblCurrentTurn.Name = "lblCurrentTurn";
            this.lblCurrentTurn.Size = new System.Drawing.Size(333, 59);
            this.lblCurrentTurn.TabIndex = 3;
            this.lblCurrentTurn.Text = "Current Turn:";
            this.lblCurrentTurn.Visible = false;
            // 
            // btn_back
            // 
            this.btn_back.BackColor = System.Drawing.Color.DarkGreen;
            this.btn_back.Enabled = false;
            this.btn_back.Font = new System.Drawing.Font("Microsoft Sans Serif", 26F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_back.ForeColor = System.Drawing.Color.PapayaWhip;
            this.btn_back.Location = new System.Drawing.Point(786, 23);
            this.btn_back.Name = "btn_back";
            this.btn_back.Size = new System.Drawing.Size(259, 90);
            this.btn_back.TabIndex = 4;
            this.btn_back.Text = "Back";
            this.btn_back.UseVisualStyleBackColor = false;
            this.btn_back.Visible = false;
            this.btn_back.Click += new System.EventHandler(this.btn_back_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PapayaWhip;
            this.ClientSize = new System.Drawing.Size(1058, 1024);
            this.Controls.Add(this.panelGame);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Name = "Form1";
            this.Text = "Connect4";
            this.panelGame.ResumeLayout(false);
            this.panelGame.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblGameName;
        private System.Windows.Forms.Button btn_play;
        private System.Windows.Forms.Button btn_exit;
        private System.Windows.Forms.Panel panelGame;
        private System.Windows.Forms.Label lblCurrentTurn;
        private System.Windows.Forms.Button btn_back;
    }
}

