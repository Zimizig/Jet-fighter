namespace Jet_fighter
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.enemyOne = new System.Windows.Forms.PictureBox();
            this.enemyTwo = new System.Windows.Forms.PictureBox();
            this.enemyThree = new System.Windows.Forms.PictureBox();
            this.bullet = new System.Windows.Forms.PictureBox();
            this.player = new System.Windows.Forms.PictureBox();
            this.txtScore = new System.Windows.Forms.Label();
            this.gameTimer = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.enemyOne)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.enemyTwo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.enemyThree)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bullet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.player)).BeginInit();
            this.SuspendLayout();
            // 
            // enemyOne
            // 
            this.enemyOne.Image = global::Jet_fighter.Properties.Resources.enemy;
            this.enemyOne.Location = new System.Drawing.Point(76, 23);
            this.enemyOne.Name = "enemyOne";
            this.enemyOne.Size = new System.Drawing.Size(102, 92);
            this.enemyOne.TabIndex = 0;
            this.enemyOne.TabStop = false;
            // 
            // enemyTwo
            // 
            this.enemyTwo.Image = global::Jet_fighter.Properties.Resources.enemy;
            this.enemyTwo.Location = new System.Drawing.Point(433, 23);
            this.enemyTwo.Name = "enemyTwo";
            this.enemyTwo.Size = new System.Drawing.Size(106, 105);
            this.enemyTwo.TabIndex = 1;
            this.enemyTwo.TabStop = false;
            // 
            // enemyThree
            // 
            this.enemyThree.Image = global::Jet_fighter.Properties.Resources.enemy;
            this.enemyThree.Location = new System.Drawing.Point(754, 23);
            this.enemyThree.Name = "enemyThree";
            this.enemyThree.Size = new System.Drawing.Size(103, 92);
            this.enemyThree.TabIndex = 2;
            this.enemyThree.TabStop = false;
            // 
            // bullet
            // 
            this.bullet.Image = global::Jet_fighter.Properties.Resources.bullet;
            this.bullet.Location = new System.Drawing.Point(482, 630);
            this.bullet.Name = "bullet";
            this.bullet.Size = new System.Drawing.Size(10, 27);
            this.bullet.TabIndex = 3;
            this.bullet.TabStop = false;
            // 
            // player
            // 
            this.player.Image = global::Jet_fighter.Properties.Resources.player;
            this.player.Location = new System.Drawing.Point(433, 697);
            this.player.Name = "player";
            this.player.Size = new System.Drawing.Size(109, 97);
            this.player.TabIndex = 4;
            this.player.TabStop = false;
            // 
            // txtScore
            // 
            this.txtScore.Font = new System.Drawing.Font("Minecraft Rus", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtScore.Location = new System.Drawing.Point(1, 301);
            this.txtScore.Name = "txtScore";
            this.txtScore.Size = new System.Drawing.Size(974, 144);
            this.txtScore.TabIndex = 7;
            this.txtScore.Text = "0";
            this.txtScore.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // gameTimer
            // 
            this.gameTimer.Interval = 20;
            this.gameTimer.Tick += new System.EventHandler(this.mainGameTimerEvent);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Blue;
            this.ClientSize = new System.Drawing.Size(978, 816);
            this.Controls.Add(this.player);
            this.Controls.Add(this.bullet);
            this.Controls.Add(this.enemyThree);
            this.Controls.Add(this.enemyTwo);
            this.Controls.Add(this.enemyOne);
            this.Controls.Add(this.txtScore);
            this.Name = "Form1";
            this.Text = "Jet fighter game";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.keyisdown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.keyisup);
            ((System.ComponentModel.ISupportInitialize)(this.enemyOne)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.enemyTwo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.enemyThree)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bullet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.player)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private PictureBox enemyOne;
        private PictureBox enemyTwo;
        private PictureBox enemyThree;
        private PictureBox bullet;
        private PictureBox player;
        private Label txtScore;
        private System.Windows.Forms.Timer gameTimer;
    }
}