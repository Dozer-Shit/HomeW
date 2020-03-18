namespace HomeWork8
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripDropDownButton2 = new System.Windows.Forms.ToolStripDropDownButton();
            this.miNew = new System.Windows.Forms.ToolStripMenuItem();
            this.miOpen = new System.Windows.Forms.ToolStripMenuItem();
            this.miSave = new System.Windows.Forms.ToolStripMenuItem();
            this.btnSaveAs = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.miExit = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutProgramm = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.btnAdd = new System.Windows.Forms.Button();
            this.ButDelete = new System.Windows.Forms.Button();
            this.btnSaveQues = new System.Windows.Forms.Button();
            this.cboxTrue = new System.Windows.Forms.CheckBox();
            this.counter = new System.Windows.Forms.NumericUpDown();
            this.tboxQuestion = new System.Windows.Forms.TextBox();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize) (this.counter)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.BackColor = System.Drawing.Color.Tomato;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[]
                {this.toolStripDropDownButton2, this.toolStripSeparator});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(692, 25);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripDropDownButton2
            // 
            this.toolStripDropDownButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripDropDownButton2.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[]
            {
                this.miNew, this.miOpen, this.miSave, this.btnSaveAs, this.toolStripSeparator2, this.miExit,
                this.aboutProgramm
            });
            this.toolStripDropDownButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripDropDownButton2.Name = "toolStripDropDownButton2";
            this.toolStripDropDownButton2.ShowDropDownArrow = false;
            this.toolStripDropDownButton2.Size = new System.Drawing.Size(29, 22);
            this.toolStripDropDownButton2.Text = "File";
            this.toolStripDropDownButton2.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            // 
            // miNew
            // 
            this.miNew.BackColor = System.Drawing.Color.Cornsilk;
            this.miNew.Name = "miNew";
            this.miNew.Size = new System.Drawing.Size(149, 22);
            this.miNew.Text = "New";
            this.miNew.Click += new System.EventHandler(this.New_Click);
            // 
            // miOpen
            // 
            this.miOpen.BackColor = System.Drawing.Color.Cornsilk;
            this.miOpen.Name = "miOpen";
            this.miOpen.Size = new System.Drawing.Size(149, 22);
            this.miOpen.Text = "Open";
            this.miOpen.Click += new System.EventHandler(this.Open_Click);
            // 
            // miSave
            // 
            this.miSave.BackColor = System.Drawing.Color.Cornsilk;
            this.miSave.Name = "miSave";
            this.miSave.Size = new System.Drawing.Size(149, 22);
            this.miSave.Text = "Save";
            this.miSave.Click += new System.EventHandler(this.Save_Click);
            // 
            // btnSaveAs
            // 
            this.btnSaveAs.BackColor = System.Drawing.Color.Cornsilk;
            this.btnSaveAs.Name = "btnSaveAs";
            this.btnSaveAs.Size = new System.Drawing.Size(149, 22);
            this.btnSaveAs.Text = "Save As";
            this.btnSaveAs.Click += new System.EventHandler(this.butSaveAs_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.BackColor = System.Drawing.Color.Cornsilk;
            this.toolStripSeparator2.ForeColor = System.Drawing.Color.Cornsilk;
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(146, 6);
            // 
            // miExit
            // 
            this.miExit.BackColor = System.Drawing.Color.Cornsilk;
            this.miExit.Name = "miExit";
            this.miExit.Size = new System.Drawing.Size(149, 22);
            this.miExit.Text = "Exit";
            this.miExit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // aboutProgramm
            // 
            this.aboutProgramm.BackColor = System.Drawing.Color.Cornsilk;
            this.aboutProgramm.Name = "aboutProgramm";
            this.aboutProgramm.Size = new System.Drawing.Size(149, 22);
            this.aboutProgramm.Text = "О программе";
            this.aboutProgramm.Click += new System.EventHandler(this.ProgAbout_Click);
            // 
            // toolStripSeparator
            // 
            this.toolStripSeparator.Name = "toolStripSeparator";
            this.toolStripSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.Turquoise;
            this.btnAdd.Location = new System.Drawing.Point(14, 224);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(88, 27);
            this.btnAdd.TabIndex = 1;
            this.btnAdd.Text = "Добавить";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.butAdd_Click);
            // 
            // ButDelete
            // 
            this.ButDelete.BackColor = System.Drawing.Color.Crimson;
            this.ButDelete.Location = new System.Drawing.Point(182, 224);
            this.ButDelete.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.ButDelete.Name = "ButDelete";
            this.ButDelete.Size = new System.Drawing.Size(88, 27);
            this.ButDelete.TabIndex = 2;
            this.ButDelete.Text = "Удалить";
            this.ButDelete.UseVisualStyleBackColor = false;
            this.ButDelete.Click += new System.EventHandler(this.butDelete_Click);
            // 
            // btnSaveQues
            // 
            this.btnSaveQues.BackColor = System.Drawing.Color.Turquoise;
            this.btnSaveQues.Location = new System.Drawing.Point(276, 224);
            this.btnSaveQues.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnSaveQues.Name = "btnSaveQues";
            this.btnSaveQues.Size = new System.Drawing.Size(88, 27);
            this.btnSaveQues.TabIndex = 3;
            this.btnSaveQues.Text = "Сохранить";
            this.btnSaveQues.UseVisualStyleBackColor = false;
            this.btnSaveQues.Click += new System.EventHandler(this.butSaveQuest_Click);
            // 
            // cboxTrue
            // 
            this.cboxTrue.AutoSize = true;
            this.cboxTrue.BackColor = System.Drawing.Color.Transparent;
            this.cboxTrue.Location = new System.Drawing.Point(510, 225);
            this.cboxTrue.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.cboxTrue.Name = "cboxTrue";
            this.cboxTrue.Size = new System.Drawing.Size(66, 19);
            this.cboxTrue.TabIndex = 5;
            this.cboxTrue.Text = "Правда";
            this.cboxTrue.UseVisualStyleBackColor = false;
            // 
            // counter
            // 
            this.counter.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.counter.Location = new System.Drawing.Point(441, 224);
            this.counter.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.counter.Name = "counter";
            this.counter.Size = new System.Drawing.Size(62, 23);
            this.counter.TabIndex = 6;
            this.counter.ValueChanged += new System.EventHandler(this.counter_ValueChanged);
            // 
            // tboxQuestion
            // 
            this.tboxQuestion.BackColor = System.Drawing.Color.LightSlateGray;
            this.tboxQuestion.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F,
                System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.tboxQuestion.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.tboxQuestion.Location = new System.Drawing.Point(14, 32);
            this.tboxQuestion.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tboxQuestion.Multiline = true;
            this.tboxQuestion.Name = "tboxQuestion";
            this.tboxQuestion.Size = new System.Drawing.Size(663, 184);
            this.tboxQuestion.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CornflowerBlue;
            this.ClientSize = new System.Drawing.Size(692, 264);
            this.Controls.Add(this.tboxQuestion);
            this.Controls.Add(this.counter);
            this.Controls.Add(this.cboxTrue);
            this.Controls.Add(this.btnSaveQues);
            this.Controls.Add(this.ButDelete);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.toolStrip1);
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "Form1";
            this.Text = "Верю - Не верю";
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize) (this.counter)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownButton2;
        private System.Windows.Forms.ToolStripMenuItem miNew;
        private System.Windows.Forms.ToolStripMenuItem miOpen;
        private System.Windows.Forms.ToolStripMenuItem miSave;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem miExit;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button ButDelete;
        private System.Windows.Forms.Button btnSaveQues;
        private System.Windows.Forms.CheckBox cboxTrue;
        private System.Windows.Forms.NumericUpDown counter;
        private System.Windows.Forms.TextBox tboxQuestion;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator;
        private System.Windows.Forms.ToolStripMenuItem aboutProgramm;
        private System.Windows.Forms.ToolStripMenuItem btnSaveAs;
    }
}

