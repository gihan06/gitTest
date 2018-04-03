namespace BreakoutGame
{
    partial class FrmBreakout
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmBreakout));
            this.pnlGame = new System.Windows.Forms.Panel();
            this.lblWin = new System.Windows.Forms.Label();
            this.lblLose = new System.Windows.Forms.Label();
            this.lblScore = new System.Windows.Forms.Label();
            this.tmrOne = new System.Windows.Forms.Timer(this.components);
            this.btnPause = new System.Windows.Forms.Button();
            this.btnEnd = new System.Windows.Forms.Button();
            this.btnStart = new System.Windows.Forms.Button();
            this.picThumbsup = new System.Windows.Forms.PictureBox();
            this.picThumbsdwn = new System.Windows.Forms.PictureBox();
            this.pnlGame.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picThumbsup)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picThumbsdwn)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlGame
            // 
            this.pnlGame.BackColor = System.Drawing.Color.Indigo;
            this.pnlGame.Controls.Add(this.picThumbsdwn);
            this.pnlGame.Controls.Add(this.picThumbsup);
            this.pnlGame.Controls.Add(this.lblWin);
            this.pnlGame.Controls.Add(this.lblLose);
            this.pnlGame.Location = new System.Drawing.Point(-4, 3);
            this.pnlGame.Name = "pnlGame";
            this.pnlGame.Size = new System.Drawing.Size(938, 502);
            this.pnlGame.TabIndex = 0;
            this.pnlGame.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            this.pnlGame.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pnlGame_MouseMove);
            // 
            // lblWin
            // 
            this.lblWin.AutoSize = true;
            this.lblWin.Font = new System.Drawing.Font("Arial Rounded MT Bold", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWin.ForeColor = System.Drawing.Color.Blue;
            this.lblWin.Location = new System.Drawing.Point(284, 205);
            this.lblWin.Name = "lblWin";
            this.lblWin.Size = new System.Drawing.Size(318, 172);
            this.lblWin.TabIndex = 1;
            this.lblWin.Text = "YOU ARE THE \r\nWINNER !!\r\n\r\nPress Esc to Exit";
            this.lblWin.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblLose
            // 
            this.lblLose.AutoSize = true;
            this.lblLose.Font = new System.Drawing.Font("Arial Rounded MT Bold", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLose.ForeColor = System.Drawing.Color.Crimson;
            this.lblLose.Location = new System.Drawing.Point(305, 223);
            this.lblLose.Name = "lblLose";
            this.lblLose.Size = new System.Drawing.Size(318, 129);
            this.lblLose.TabIndex = 0;
            this.lblLose.Text = "YOU LOSE !!\r\n\r\nPress Esc to Exit";
            this.lblLose.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblScore
            // 
            this.lblScore.AutoSize = true;
            this.lblScore.BackColor = System.Drawing.Color.Lime;
            this.lblScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblScore.Location = new System.Drawing.Point(102, 522);
            this.lblScore.Name = "lblScore";
            this.lblScore.Size = new System.Drawing.Size(0, 37);
            this.lblScore.TabIndex = 17;
            this.lblScore.Click += new System.EventHandler(this.lblScore_Click);
            // 
            // tmrOne
            // 
            this.tmrOne.Tick += new System.EventHandler(this.tmrOne_Tick);
            // 
            // btnPause
            // 
            this.btnPause.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPause.Location = new System.Drawing.Point(390, 524);
            this.btnPause.Name = "btnPause";
            this.btnPause.Size = new System.Drawing.Size(79, 35);
            this.btnPause.TabIndex = 21;
            this.btnPause.Text = "PAUSE";
            this.btnPause.UseVisualStyleBackColor = true;
            this.btnPause.Click += new System.EventHandler(this.btnPause_Click_1);
            // 
            // btnEnd
            // 
            this.btnEnd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEnd.Location = new System.Drawing.Point(636, 524);
            this.btnEnd.Name = "btnEnd";
            this.btnEnd.Size = new System.Drawing.Size(82, 35);
            this.btnEnd.TabIndex = 20;
            this.btnEnd.Text = "END";
            this.btnEnd.UseVisualStyleBackColor = true;
            this.btnEnd.Click += new System.EventHandler(this.btnEnd_Click_1);
            // 
            // btnStart
            // 
            this.btnStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStart.Location = new System.Drawing.Point(511, 524);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(81, 35);
            this.btnStart.TabIndex = 19;
            this.btnStart.Text = "START";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click_1);
            // 
            // picThumbsup
            // 
            this.picThumbsup.Image = ((System.Drawing.Image)(resources.GetObject("picThumbsup.Image")));
            this.picThumbsup.Location = new System.Drawing.Point(608, 210);
            this.picThumbsup.Name = "picThumbsup";
            this.picThumbsup.Size = new System.Drawing.Size(200, 142);
            this.picThumbsup.TabIndex = 2;
            this.picThumbsup.TabStop = false;
            // 
            // picThumbsdwn
            // 
            this.picThumbsdwn.Image = ((System.Drawing.Image)(resources.GetObject("picThumbsdwn.Image")));
            this.picThumbsdwn.Location = new System.Drawing.Point(629, 170);
            this.picThumbsdwn.Name = "picThumbsdwn";
            this.picThumbsdwn.Size = new System.Drawing.Size(264, 243);
            this.picThumbsdwn.TabIndex = 3;
            this.picThumbsdwn.TabStop = false;
            // 
            // FrmBreakout
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(931, 571);
            this.Controls.Add(this.lblScore);
            this.Controls.Add(this.btnPause);
            this.Controls.Add(this.btnEnd);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.pnlGame);
            this.KeyPreview = true;
            this.Name = "FrmBreakout";
            this.Text = "PJ\'s Breakout Game";
            this.Load += new System.EventHandler(this.FrmBreakout_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.FrmBreakout_Paint);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FrmBreakout_KeyDown);
            this.pnlGame.ResumeLayout(false);
            this.pnlGame.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picThumbsup)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picThumbsdwn)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlGame;
        private System.Windows.Forms.Label lblScore;
        private System.Windows.Forms.Timer tmrOne;
        private System.Windows.Forms.Button btnPause;
        private System.Windows.Forms.Button btnEnd;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Label lblLose;
        private System.Windows.Forms.Label lblWin;
        private System.Windows.Forms.PictureBox picThumbsup;
        private System.Windows.Forms.PictureBox picThumbsdwn;
    }
}

