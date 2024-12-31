namespace WindowsFormsApp1_241231
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
            this.buttonBattle = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonBattle
            // 
            this.buttonBattle.Location = new System.Drawing.Point(102, 67);
            this.buttonBattle.Name = "buttonBattle";
            this.buttonBattle.Size = new System.Drawing.Size(149, 49);
            this.buttonBattle.TabIndex = 0;
            this.buttonBattle.Text = "Start_Battle";
            this.buttonBattle.UseVisualStyleBackColor = true;
            this.buttonBattle.Click += new System.EventHandler(this.buttonBattle_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonBattle);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonBattle;
    }
}

