namespace WindowsFormsAppXO
{
    partial class FormXO
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
            this.btn00 = new System.Windows.Forms.Button();
            this.btn01 = new System.Windows.Forms.Button();
            this.btn02 = new System.Windows.Forms.Button();
            this.btn10 = new System.Windows.Forms.Button();
            this.btn11 = new System.Windows.Forms.Button();
            this.btn12 = new System.Windows.Forms.Button();
            this.btn20 = new System.Windows.Forms.Button();
            this.btn21 = new System.Windows.Forms.Button();
            this.btn22 = new System.Windows.Forms.Button();
            this.lblTurn = new System.Windows.Forms.Label();
            this.lblPlayer = new System.Windows.Forms.Label();
            this.btnNewgame = new System.Windows.Forms.Button();
            this.lblTag = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn00
            // 
            this.btn00.Location = new System.Drawing.Point(12, 12);
            this.btn00.Name = "btn00";
            this.btn00.Size = new System.Drawing.Size(65, 80);
            this.btn00.TabIndex = 0;
            this.btn00.UseVisualStyleBackColor = true;
            this.btn00.Click += new System.EventHandler(this.Btn00_Click);
            // 
            // btn01
            // 
            this.btn01.Location = new System.Drawing.Point(83, 12);
            this.btn01.Name = "btn01";
            this.btn01.Size = new System.Drawing.Size(65, 80);
            this.btn01.TabIndex = 1;
            this.btn01.UseVisualStyleBackColor = true;
            this.btn01.Click += new System.EventHandler(this.Btn01_Click);
            // 
            // btn02
            // 
            this.btn02.Location = new System.Drawing.Point(154, 12);
            this.btn02.Name = "btn02";
            this.btn02.Size = new System.Drawing.Size(65, 80);
            this.btn02.TabIndex = 2;
            this.btn02.UseVisualStyleBackColor = true;
            this.btn02.Click += new System.EventHandler(this.Btn02_Click);
            // 
            // btn10
            // 
            this.btn10.Location = new System.Drawing.Point(12, 98);
            this.btn10.Name = "btn10";
            this.btn10.Size = new System.Drawing.Size(65, 80);
            this.btn10.TabIndex = 3;
            this.btn10.UseVisualStyleBackColor = true;
            this.btn10.Click += new System.EventHandler(this.Btn10_Click);
            // 
            // btn11
            // 
            this.btn11.Location = new System.Drawing.Point(83, 98);
            this.btn11.Name = "btn11";
            this.btn11.Size = new System.Drawing.Size(65, 80);
            this.btn11.TabIndex = 4;
            this.btn11.UseVisualStyleBackColor = true;
            this.btn11.Click += new System.EventHandler(this.Btn11_Click);
            // 
            // btn12
            // 
            this.btn12.Location = new System.Drawing.Point(155, 98);
            this.btn12.Name = "btn12";
            this.btn12.Size = new System.Drawing.Size(65, 80);
            this.btn12.TabIndex = 5;
            this.btn12.UseVisualStyleBackColor = true;
            this.btn12.Click += new System.EventHandler(this.Btn12_Click);
            // 
            // btn20
            // 
            this.btn20.Location = new System.Drawing.Point(12, 184);
            this.btn20.Name = "btn20";
            this.btn20.Size = new System.Drawing.Size(65, 80);
            this.btn20.TabIndex = 6;
            this.btn20.UseVisualStyleBackColor = true;
            this.btn20.Click += new System.EventHandler(this.Btn20_Click);
            // 
            // btn21
            // 
            this.btn21.Location = new System.Drawing.Point(83, 184);
            this.btn21.Name = "btn21";
            this.btn21.Size = new System.Drawing.Size(65, 80);
            this.btn21.TabIndex = 7;
            this.btn21.UseVisualStyleBackColor = true;
            this.btn21.Click += new System.EventHandler(this.Btn21_Click);
            // 
            // btn22
            // 
            this.btn22.Location = new System.Drawing.Point(154, 184);
            this.btn22.Name = "btn22";
            this.btn22.Size = new System.Drawing.Size(65, 80);
            this.btn22.TabIndex = 8;
            this.btn22.UseVisualStyleBackColor = true;
            this.btn22.Click += new System.EventHandler(this.Btn22_Click);
            // 
            // lblTurn
            // 
            this.lblTurn.AutoSize = true;
            this.lblTurn.Location = new System.Drawing.Point(77, 285);
            this.lblTurn.Name = "lblTurn";
            this.lblTurn.Size = new System.Drawing.Size(38, 13);
            this.lblTurn.TabIndex = 9;
            this.lblTurn.Text = "Turn : ";
            // 
            // lblPlayer
            // 
            this.lblPlayer.AutoSize = true;
            this.lblPlayer.Location = new System.Drawing.Point(109, 285);
            this.lblPlayer.Name = "lblPlayer";
            this.lblPlayer.Size = new System.Drawing.Size(46, 13);
            this.lblPlayer.TabIndex = 10;
            this.lblPlayer.Text = "Player X";
            // 
            // btnNewgame
            // 
            this.btnNewgame.Location = new System.Drawing.Point(63, 305);
            this.btnNewgame.Name = "btnNewgame";
            this.btnNewgame.Size = new System.Drawing.Size(103, 23);
            this.btnNewgame.TabIndex = 11;
            this.btnNewgame.Text = "New game";
            this.btnNewgame.UseVisualStyleBackColor = true;
            this.btnNewgame.Click += new System.EventHandler(this.BtnNewgame_Click);
            // 
            // lblTag
            // 
            this.lblTag.AutoSize = true;
            this.lblTag.Location = new System.Drawing.Point(30, 335);
            this.lblTag.Name = "lblTag";
            this.lblTag.Size = new System.Drawing.Size(174, 13);
            this.lblTag.TabIndex = 12;
            this.lblTag.Text = "Developed by hoseyn mohamadpor";
            // 
            // FormXO
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(231, 372);
            this.Controls.Add(this.lblTag);
            this.Controls.Add(this.btnNewgame);
            this.Controls.Add(this.lblPlayer);
            this.Controls.Add(this.lblTurn);
            this.Controls.Add(this.btn22);
            this.Controls.Add(this.btn21);
            this.Controls.Add(this.btn20);
            this.Controls.Add(this.btn12);
            this.Controls.Add(this.btn11);
            this.Controls.Add(this.btn10);
            this.Controls.Add(this.btn02);
            this.Controls.Add(this.btn01);
            this.Controls.Add(this.btn00);
            this.Name = "FormXO";
            this.Text = "XO Game";
            this.Load += new System.EventHandler(this.FormXO_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn00;
        private System.Windows.Forms.Button btn01;
        private System.Windows.Forms.Button btn02;
        private System.Windows.Forms.Button btn10;
        private System.Windows.Forms.Button btn11;
        private System.Windows.Forms.Button btn12;
        private System.Windows.Forms.Button btn20;
        private System.Windows.Forms.Button btn21;
        private System.Windows.Forms.Button btn22;
        private System.Windows.Forms.Label lblTurn;
        private System.Windows.Forms.Label lblPlayer;
        private System.Windows.Forms.Button btnNewgame;
        private System.Windows.Forms.Label lblTag;
    }
}

