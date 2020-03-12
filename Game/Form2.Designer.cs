using System.ComponentModel;

namespace Game
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private IContainer components = null;

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
            System.ComponentModel.ComponentResourceManager resources =
                new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.bomb = new System.Windows.Forms.PictureBox();
            this.kim = new System.Windows.Forms.PictureBox();
            this.score = new System.Windows.Forms.Label();
            this.life = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize) (this.bomb)).BeginInit();
            ((System.ComponentModel.ISupportInitialize) (this.kim)).BeginInit();
            this.SuspendLayout();
            // 
            // bomb
            // 
            this.bomb.BackColor = System.Drawing.Color.Transparent;
            this.bomb.Image = ((System.Drawing.Image) (resources.GetObject("bomb.Image")));
            this.bomb.Location = new System.Drawing.Point(373, 12);
            this.bomb.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.bomb.Name = "bomb";
            this.bomb.Size = new System.Drawing.Size(45, 78);
            this.bomb.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.bomb.TabIndex = 1;
            this.bomb.TabStop = false;
            // 
            // kim
            // 
            this.kim.BackColor = System.Drawing.Color.Transparent;
            this.kim.Image = ((System.Drawing.Image) (resources.GetObject("kim.Image")));
            this.kim.Location = new System.Drawing.Point(359, 400);
            this.kim.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.kim.Name = "kim";
            this.kim.Size = new System.Drawing.Size(95, 111);
            this.kim.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.kim.TabIndex = 2;
            this.kim.TabStop = false;
            // 
            // score
            // 
            this.score.AutoSize = true;
            this.score.BackColor = System.Drawing.Color.Transparent;
            this.score.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.score.ForeColor = System.Drawing.Color.White;
            this.score.Location = new System.Drawing.Point(12, 9);
            this.score.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.score.Name = "score";
            this.score.Size = new System.Drawing.Size(92, 25);
            this.score.TabIndex = 3;
            this.score.Text = "SCORE: 0";
            this.score.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // life
            // 
            this.life.AutoSize = true;
            this.life.BackColor = System.Drawing.Color.Transparent;
            this.life.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.life.ForeColor = System.Drawing.Color.Salmon;
            this.life.Location = new System.Drawing.Point(13, 33);
            this.life.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.life.Name = "life";
            this.life.Size = new System.Drawing.Size(69, 25);
            this.life.TabIndex = 4;
            this.life.Text = "LIFE: 3";
            this.life.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image) (resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(933, 519);
            this.Controls.Add(this.life);
            this.Controls.Add(this.score);
            this.Controls.Add(this.kim);
            this.Controls.Add(this.bomb);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kim baby save";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.kim_KeyDown);
            ((System.ComponentModel.ISupportInitialize) (this.bomb)).EndInit();
            ((System.ComponentModel.ISupportInitialize) (this.kim)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.PictureBox kim;
        private System.Windows.Forms.Label score;
        private System.Windows.Forms.Label life;
        private System.Windows.Forms.PictureBox bomb;
    }
}