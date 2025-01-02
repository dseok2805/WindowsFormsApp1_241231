namespace WindowsFormsApp1_241231
{
    partial class buttonLevelUp
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
            this.buttonBattle = new System.Windows.Forms.Button();
            this.labelPlayer1HP = new System.Windows.Forms.Label();
            this.labelPlayer2HP = new System.Windows.Forms.Label();
            this.labelMonster1HP = new System.Windows.Forms.Label();
            this.labelMonster2HP = new System.Windows.Forms.Label();
            this.progressBarPlayer1 = new System.Windows.Forms.ProgressBar();
            this.progressBarPlayer2 = new System.Windows.Forms.ProgressBar();
            this.progressBarMonster1 = new System.Windows.Forms.ProgressBar();
            this.progressBarMonster2 = new System.Windows.Forms.ProgressBar();
            this.buttonReset = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonBattle
            // 
            this.buttonBattle.Location = new System.Drawing.Point(12, 12);
            this.buttonBattle.Name = "buttonBattle";
            this.buttonBattle.Size = new System.Drawing.Size(149, 49);
            this.buttonBattle.TabIndex = 0;
            this.buttonBattle.Text = "Start_Battle";
            this.buttonBattle.UseVisualStyleBackColor = true;
            this.buttonBattle.Click += new System.EventHandler(this.buttonBattle_Click);
            // 
            // labelPlayer1HP
            // 
            this.labelPlayer1HP.AutoSize = true;
            this.labelPlayer1HP.Location = new System.Drawing.Point(12, 75);
            this.labelPlayer1HP.Name = "labelPlayer1HP";
            this.labelPlayer1HP.Size = new System.Drawing.Size(90, 12);
            this.labelPlayer1HP.TabIndex = 1;
            this.labelPlayer1HP.Text = "labelPlayer1HP";
            // 
            // labelPlayer2HP
            // 
            this.labelPlayer2HP.AutoSize = true;
            this.labelPlayer2HP.Location = new System.Drawing.Point(212, 75);
            this.labelPlayer2HP.Name = "labelPlayer2HP";
            this.labelPlayer2HP.Size = new System.Drawing.Size(90, 12);
            this.labelPlayer2HP.TabIndex = 2;
            this.labelPlayer2HP.Text = "labelPlayer2HP";
            // 
            // labelMonster1HP
            // 
            this.labelMonster1HP.AutoSize = true;
            this.labelMonster1HP.Location = new System.Drawing.Point(405, 75);
            this.labelMonster1HP.Name = "labelMonster1HP";
            this.labelMonster1HP.Size = new System.Drawing.Size(100, 12);
            this.labelMonster1HP.TabIndex = 3;
            this.labelMonster1HP.Text = "labelMonster1HP";
            // 
            // labelMonster2HP
            // 
            this.labelMonster2HP.AutoSize = true;
            this.labelMonster2HP.Location = new System.Drawing.Point(599, 75);
            this.labelMonster2HP.Name = "labelMonster2HP";
            this.labelMonster2HP.Size = new System.Drawing.Size(100, 12);
            this.labelMonster2HP.TabIndex = 4;
            this.labelMonster2HP.Text = "labelMonster2HP";
            // 
            // progressBarPlayer1
            // 
            this.progressBarPlayer1.Location = new System.Drawing.Point(14, 109);
            this.progressBarPlayer1.MarqueeAnimationSpeed = 200;
            this.progressBarPlayer1.Name = "progressBarPlayer1";
            this.progressBarPlayer1.Size = new System.Drawing.Size(147, 23);
            this.progressBarPlayer1.TabIndex = 5;
            // 
            // progressBarPlayer2
            // 
            this.progressBarPlayer2.Location = new System.Drawing.Point(214, 108);
            this.progressBarPlayer2.Maximum = 200;
            this.progressBarPlayer2.Name = "progressBarPlayer2";
            this.progressBarPlayer2.Size = new System.Drawing.Size(147, 23);
            this.progressBarPlayer2.TabIndex = 6;
            // 
            // progressBarMonster1
            // 
            this.progressBarMonster1.Location = new System.Drawing.Point(407, 108);
            this.progressBarMonster1.Maximum = 150;
            this.progressBarMonster1.Name = "progressBarMonster1";
            this.progressBarMonster1.Size = new System.Drawing.Size(147, 23);
            this.progressBarMonster1.TabIndex = 7;
            // 
            // progressBarMonster2
            // 
            this.progressBarMonster2.Location = new System.Drawing.Point(601, 109);
            this.progressBarMonster2.Name = "progressBarMonster2";
            this.progressBarMonster2.Size = new System.Drawing.Size(147, 23);
            this.progressBarMonster2.TabIndex = 8;
            // 
            // buttonReset
            // 
            this.buttonReset.Location = new System.Drawing.Point(14, 356);
            this.buttonReset.Name = "buttonReset";
            this.buttonReset.Size = new System.Drawing.Size(147, 58);
            this.buttonReset.TabIndex = 9;
            this.buttonReset.Text = "Reset_Battle";
            this.buttonReset.UseVisualStyleBackColor = true;
            this.buttonReset.Click += new System.EventHandler(this.buttonReset_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(14, 299);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(146, 47);
            this.button1.TabIndex = 10;
            this.button1.Text = "LevelUP";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // buttonLevelUp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.buttonReset);
            this.Controls.Add(this.progressBarMonster2);
            this.Controls.Add(this.progressBarMonster1);
            this.Controls.Add(this.progressBarPlayer2);
            this.Controls.Add(this.progressBarPlayer1);
            this.Controls.Add(this.labelMonster2HP);
            this.Controls.Add(this.labelMonster1HP);
            this.Controls.Add(this.labelPlayer2HP);
            this.Controls.Add(this.labelPlayer1HP);
            this.Controls.Add(this.buttonBattle);
            this.Name = "buttonLevelUp";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonBattle;
        private System.Windows.Forms.Label labelPlayer1HP;
        private System.Windows.Forms.Label labelPlayer2HP;
        private System.Windows.Forms.Label labelMonster1HP;
        private System.Windows.Forms.Label labelMonster2HP;
        private System.Windows.Forms.ProgressBar progressBarPlayer1;
        private System.Windows.Forms.ProgressBar progressBarPlayer2;
        private System.Windows.Forms.ProgressBar progressBarMonster1;
        private System.Windows.Forms.ProgressBar progressBarMonster2;
        private System.Windows.Forms.Button buttonReset;
        private System.Windows.Forms.Button button1;
    }
}

