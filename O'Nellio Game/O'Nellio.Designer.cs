namespace Project_Start
{
    partial class ONellio
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
            this.ptc_BlackCounter = new System.Windows.Forms.PictureBox();
            this.ptc_WhiteCounter = new System.Windows.Forms.PictureBox();
            this.ptc_bar = new System.Windows.Forms.PictureBox();
            this.p1Turn = new System.Windows.Forms.PictureBox();
            this.p2Turn = new System.Windows.Forms.PictureBox();
            this.p1Name = new System.Windows.Forms.TextBox();
            this.p2Name = new System.Windows.Forms.TextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.gameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newGameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveGameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.settingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.InformationBox = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lbl_WhiteCount = new System.Windows.Forms.Label();
            this.lbl_BlackCount = new System.Windows.Forms.Label();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.ptc_BlackCounter)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptc_WhiteCounter)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptc_bar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.p1Turn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.p2Turn)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // ptc_BlackCounter
            // 
            this.ptc_BlackCounter.BackColor = System.Drawing.SystemColors.Desktop;
            this.ptc_BlackCounter.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.ptc_BlackCounter.Location = new System.Drawing.Point(400, 626);
            this.ptc_BlackCounter.Margin = new System.Windows.Forms.Padding(2);
            this.ptc_BlackCounter.Name = "ptc_BlackCounter";
            this.ptc_BlackCounter.Size = new System.Drawing.Size(25, 25);
            this.ptc_BlackCounter.TabIndex = 2;
            this.ptc_BlackCounter.TabStop = false;
            // 
            // ptc_WhiteCounter
            // 
            this.ptc_WhiteCounter.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ptc_WhiteCounter.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.ptc_WhiteCounter.Location = new System.Drawing.Point(94, 626);
            this.ptc_WhiteCounter.Margin = new System.Windows.Forms.Padding(2);
            this.ptc_WhiteCounter.Name = "ptc_WhiteCounter";
            this.ptc_WhiteCounter.Size = new System.Drawing.Size(25, 25);
            this.ptc_WhiteCounter.TabIndex = 3;
            this.ptc_WhiteCounter.TabStop = false;
            // 
            // ptc_bar
            // 
            this.ptc_bar.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.ptc_bar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ptc_bar.Location = new System.Drawing.Point(40, 593);
            this.ptc_bar.Margin = new System.Windows.Forms.Padding(2);
            this.ptc_bar.Name = "ptc_bar";
            this.ptc_bar.Size = new System.Drawing.Size(566, 72);
            this.ptc_bar.TabIndex = 6;
            this.ptc_bar.TabStop = false;
            // 
            // p1Turn
            // 
            this.p1Turn.BackColor = System.Drawing.Color.Red;
            this.p1Turn.Location = new System.Drawing.Point(128, 608);
            this.p1Turn.Margin = new System.Windows.Forms.Padding(2);
            this.p1Turn.Name = "p1Turn";
            this.p1Turn.Size = new System.Drawing.Size(163, 13);
            this.p1Turn.TabIndex = 11;
            this.p1Turn.TabStop = false;
            this.p1Turn.Visible = false;
            // 
            // p2Turn
            // 
            this.p2Turn.BackColor = System.Drawing.Color.Red;
            this.p2Turn.Location = new System.Drawing.Point(428, 608);
            this.p2Turn.Margin = new System.Windows.Forms.Padding(2);
            this.p2Turn.Name = "p2Turn";
            this.p2Turn.Size = new System.Drawing.Size(163, 13);
            this.p2Turn.TabIndex = 12;
            this.p2Turn.TabStop = false;
            // 
            // p1Name
            // 
            this.p1Name.Location = new System.Drawing.Point(129, 628);
            this.p1Name.Margin = new System.Windows.Forms.Padding(2);
            this.p1Name.Name = "p1Name";
            this.p1Name.Size = new System.Drawing.Size(162, 20);
            this.p1Name.TabIndex = 13;
            this.p1Name.Text = "Player 1";
            // 
            // p2Name
            // 
            this.p2Name.Location = new System.Drawing.Point(431, 629);
            this.p2Name.Margin = new System.Windows.Forms.Padding(2);
            this.p2Name.Name = "p2Name";
            this.p2Name.Size = new System.Drawing.Size(160, 20);
            this.p2Name.TabIndex = 14;
            this.p2Name.Text = "Player 2";
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gameToolStripMenuItem,
            this.settingsToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(646, 24);
            this.menuStrip1.TabIndex = 15;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // gameToolStripMenuItem
            // 
            this.gameToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newGameToolStripMenuItem,
            this.saveGameToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.gameToolStripMenuItem.Name = "gameToolStripMenuItem";
            this.gameToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.gameToolStripMenuItem.Text = "Game";
            // 
            // newGameToolStripMenuItem
            // 
            this.newGameToolStripMenuItem.Name = "newGameToolStripMenuItem";
            this.newGameToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.newGameToolStripMenuItem.Text = "New Game";
            this.newGameToolStripMenuItem.Click += new System.EventHandler(this.newGameToolStripMenuItem_Click);
            // 
            // saveGameToolStripMenuItem
            // 
            this.saveGameToolStripMenuItem.Name = "saveGameToolStripMenuItem";
            this.saveGameToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.saveGameToolStripMenuItem.Text = "Save Game";
            this.saveGameToolStripMenuItem.Click += new System.EventHandler(this.saveGameToolStripMenuItem_Click);
            // 
            // settingsToolStripMenuItem
            // 
            this.settingsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.InformationBox});
            this.settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            this.settingsToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.settingsToolStripMenuItem.Text = "Settings";
            // 
            // InformationBox
            // 
            this.InformationBox.Checked = true;
            this.InformationBox.CheckOnClick = true;
            this.InformationBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.InformationBox.Name = "InformationBox";
            this.InformationBox.Size = new System.Drawing.Size(169, 22);
            this.InformationBox.Text = "Information Panel";
            this.InformationBox.Click += new System.EventHandler(this.InformationBox_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click_1);
            // 
            // lbl_WhiteCount
            // 
            this.lbl_WhiteCount.AutoSize = true;
            this.lbl_WhiteCount.Location = new System.Drawing.Point(54, 631);
            this.lbl_WhiteCount.Name = "lbl_WhiteCount";
            this.lbl_WhiteCount.Size = new System.Drawing.Size(0, 13);
            this.lbl_WhiteCount.TabIndex = 18;
            // 
            // lbl_BlackCount
            // 
            this.lbl_BlackCount.AutoSize = true;
            this.lbl_BlackCount.Location = new System.Drawing.Point(360, 631);
            this.lbl_BlackCount.Name = "lbl_BlackCount";
            this.lbl_BlackCount.Size = new System.Drawing.Size(13, 13);
            this.lbl_BlackCount.TabIndex = 19;
            this.lbl_BlackCount.Text = "0";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // ONellio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(646, 676);
            this.Controls.Add(this.lbl_BlackCount);
            this.Controls.Add(this.lbl_WhiteCount);
            this.Controls.Add(this.p2Name);
            this.Controls.Add(this.p1Name);
            this.Controls.Add(this.p2Turn);
            this.Controls.Add(this.p1Turn);
            this.Controls.Add(this.ptc_WhiteCounter);
            this.Controls.Add(this.ptc_BlackCounter);
            this.Controls.Add(this.ptc_bar);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "ONellio";
            this.Text = "O\'Nellio";
            ((System.ComponentModel.ISupportInitialize)(this.ptc_BlackCounter)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptc_WhiteCounter)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptc_bar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.p1Turn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.p2Turn)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

         }

         #endregion
         private System.Windows.Forms.PictureBox ptc_BlackCounter;
         private System.Windows.Forms.PictureBox ptc_WhiteCounter;
         private System.Windows.Forms.PictureBox ptc_bar;
         private System.Windows.Forms.PictureBox p1Turn;
         private System.Windows.Forms.PictureBox p2Turn;
         private System.Windows.Forms.TextBox p1Name;
         private System.Windows.Forms.TextBox p2Name;
         private System.Windows.Forms.MenuStrip menuStrip1;
         private System.Windows.Forms.ToolStripMenuItem gameToolStripMenuItem;
         private System.Windows.Forms.ToolStripMenuItem settingsToolStripMenuItem;
         private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
         private System.Windows.Forms.ToolStripMenuItem newGameToolStripMenuItem;
         private System.Windows.Forms.ToolStripMenuItem InformationBox;
        private System.Windows.Forms.ToolStripMenuItem saveGameToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.Label lbl_WhiteCount;
        private System.Windows.Forms.Label lbl_BlackCount;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
    }
    }


