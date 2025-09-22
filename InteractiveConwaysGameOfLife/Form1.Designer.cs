namespace InteractiveConwaysGameOfLife
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
            this.components = new System.ComponentModel.Container();
            this.gamePanel = new System.Windows.Forms.Panel();
            this.btnStartGame = new System.Windows.Forms.Button();
            this.btnStepByOne = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.btnStop = new System.Windows.Forms.Button();
            this.btnResetGrid = new System.Windows.Forms.Button();
            this.btnSaveGrid = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // gamePanel
            // 
            this.gamePanel.BackColor = System.Drawing.Color.White;
            this.gamePanel.Location = new System.Drawing.Point(35, 21);
            this.gamePanel.Name = "gamePanel";
            this.gamePanel.Size = new System.Drawing.Size(401, 401);
            this.gamePanel.TabIndex = 0;
            this.gamePanel.Paint += new System.Windows.Forms.PaintEventHandler(this.gamePanel_Paint);
            this.gamePanel.MouseClick += new System.Windows.Forms.MouseEventHandler(this.gamePanel_MouseClick);
            // 
            // btnStartGame
            // 
            this.btnStartGame.Location = new System.Drawing.Point(497, 138);
            this.btnStartGame.Name = "btnStartGame";
            this.btnStartGame.Size = new System.Drawing.Size(250, 50);
            this.btnStartGame.TabIndex = 1;
            this.btnStartGame.Text = "start";
            this.btnStartGame.UseVisualStyleBackColor = true;
            this.btnStartGame.Click += new System.EventHandler(this.btnStartGame_Click);
            // 
            // btnStepByOne
            // 
            this.btnStepByOne.Location = new System.Drawing.Point(497, 82);
            this.btnStepByOne.Name = "btnStepByOne";
            this.btnStepByOne.Size = new System.Drawing.Size(250, 50);
            this.btnStepByOne.TabIndex = 0;
            this.btnStepByOne.Text = "step";
            this.btnStepByOne.UseVisualStyleBackColor = true;
            this.btnStepByOne.Click += new System.EventHandler(this.btnStepByOne_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // btnStop
            // 
            this.btnStop.Location = new System.Drawing.Point(497, 194);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(250, 50);
            this.btnStop.TabIndex = 2;
            this.btnStop.Text = "stop";
            this.btnStop.UseVisualStyleBackColor = true;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // btnResetGrid
            // 
            this.btnResetGrid.Location = new System.Drawing.Point(497, 250);
            this.btnResetGrid.Name = "btnResetGrid";
            this.btnResetGrid.Size = new System.Drawing.Size(250, 50);
            this.btnResetGrid.TabIndex = 3;
            this.btnResetGrid.Text = "reset";
            this.btnResetGrid.UseVisualStyleBackColor = true;
            this.btnResetGrid.Click += new System.EventHandler(this.btnResetGrid_Click);
            // 
            // btnSaveGrid
            // 
            this.btnSaveGrid.Location = new System.Drawing.Point(497, 306);
            this.btnSaveGrid.Name = "btnSaveGrid";
            this.btnSaveGrid.Size = new System.Drawing.Size(250, 50);
            this.btnSaveGrid.TabIndex = 4;
            this.btnSaveGrid.Text = "save";
            this.btnSaveGrid.UseVisualStyleBackColor = true;
            this.btnSaveGrid.Click += new System.EventHandler(this.btnSaveGrid_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnSaveGrid);
            this.Controls.Add(this.btnResetGrid);
            this.Controls.Add(this.btnStop);
            this.Controls.Add(this.btnStepByOne);
            this.Controls.Add(this.btnStartGame);
            this.Controls.Add(this.gamePanel);
            this.Name = "Form1";
            this.Text = "Conways Game of LIfe";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel gamePanel;
        private System.Windows.Forms.Button btnStartGame;
        private System.Windows.Forms.Button btnStepByOne;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.Button btnResetGrid;
        private System.Windows.Forms.Button btnSaveGrid;
    }
}

