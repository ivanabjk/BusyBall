namespace VP_Proekt
{
    partial class Quiz
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
            this.tbQuestion = new System.Windows.Forms.TextBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.btnPlay = new System.Windows.Forms.Button();
            this.lblExplanation = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.pbCorrectAnswers = new System.Windows.Forms.ProgressBar();
            this.lblCorrectAnswers = new System.Windows.Forms.Label();
            this.lblNumOfQuestion = new System.Windows.Forms.Label();
            this.btnNext = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.rbAnswer3 = new System.Windows.Forms.RadioButton();
            this.rbAnswer1 = new System.Windows.Forms.RadioButton();
            this.rbAnswer2 = new System.Windows.Forms.RadioButton();
            this.rbAnswer4 = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // tbQuestion
            // 
            this.tbQuestion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(222)))), ((int)(((byte)(209)))));
            this.tbQuestion.Enabled = false;
            this.tbQuestion.Font = new System.Drawing.Font("Arial Rounded MT Bold", 17F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbQuestion.ForeColor = System.Drawing.SystemColors.Window;
            this.tbQuestion.Location = new System.Drawing.Point(122, 119);
            this.tbQuestion.Multiline = true;
            this.tbQuestion.Name = "tbQuestion";
            this.tbQuestion.Size = new System.Drawing.Size(591, 81);
            this.tbQuestion.TabIndex = 0;
            this.tbQuestion.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbQuestion.Visible = false;
            // 
            // btnPlay
            // 
            this.btnPlay.BackColor = System.Drawing.Color.IndianRed;
            this.btnPlay.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPlay.Location = new System.Drawing.Point(587, 363);
            this.btnPlay.Name = "btnPlay";
            this.btnPlay.Size = new System.Drawing.Size(174, 58);
            this.btnPlay.TabIndex = 5;
            this.btnPlay.Text = "PLAY";
            this.btnPlay.UseVisualStyleBackColor = false;
            this.btnPlay.Click += new System.EventHandler(this.btnPlay_Click);
            // 
            // lblExplanation
            // 
            this.lblExplanation.AutoSize = true;
            this.lblExplanation.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblExplanation.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblExplanation.Location = new System.Drawing.Point(89, 155);
            this.lblExplanation.Name = "lblExplanation";
            this.lblExplanation.Size = new System.Drawing.Size(147, 31);
            this.lblExplanation.TabIndex = 6;
            this.lblExplanation.Text = "Explanation";
            this.lblExplanation.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Mongolian Baiti", 40.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Location = new System.Drawing.Point(308, 19);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(189, 71);
            this.lblName.TabIndex = 7;
            this.lblName.Text = "QUIZ";
            // 
            // pbCorrectAnswers
            // 
            this.pbCorrectAnswers.BackColor = System.Drawing.Color.IndianRed;
            this.pbCorrectAnswers.ForeColor = System.Drawing.Color.Maroon;
            this.pbCorrectAnswers.Location = new System.Drawing.Point(75, 382);
            this.pbCorrectAnswers.Name = "pbCorrectAnswers";
            this.pbCorrectAnswers.Size = new System.Drawing.Size(461, 28);
            this.pbCorrectAnswers.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.pbCorrectAnswers.TabIndex = 8;
            this.pbCorrectAnswers.Visible = false;
            // 
            // lblCorrectAnswers
            // 
            this.lblCorrectAnswers.AutoSize = true;
            this.lblCorrectAnswers.Location = new System.Drawing.Point(72, 352);
            this.lblCorrectAnswers.Name = "lblCorrectAnswers";
            this.lblCorrectAnswers.Size = new System.Drawing.Size(106, 16);
            this.lblCorrectAnswers.TabIndex = 9;
            this.lblCorrectAnswers.Text = "Correct answers:";
            this.lblCorrectAnswers.Visible = false;
            // 
            // lblNumOfQuestion
            // 
            this.lblNumOfQuestion.AutoSize = true;
            this.lblNumOfQuestion.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumOfQuestion.Location = new System.Drawing.Point(34, 145);
            this.lblNumOfQuestion.Name = "lblNumOfQuestion";
            this.lblNumOfQuestion.Size = new System.Drawing.Size(62, 29);
            this.lblNumOfQuestion.TabIndex = 10;
            this.lblNumOfQuestion.Text = "1/10";
            this.lblNumOfQuestion.Visible = false;
            // 
            // btnNext
            // 
            this.btnNext.BackColor = System.Drawing.Color.IndianRed;
            this.btnNext.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNext.Location = new System.Drawing.Point(587, 363);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(174, 58);
            this.btnNext.TabIndex = 11;
            this.btnNext.Text = "NEXT";
            this.btnNext.UseVisualStyleBackColor = false;
            this.btnNext.Visible = false;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // rbAnswer3
            // 
            this.rbAnswer3.AutoSize = true;
            this.rbAnswer3.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbAnswer3.Location = new System.Drawing.Point(190, 285);
            this.rbAnswer3.Name = "rbAnswer3";
            this.rbAnswer3.Size = new System.Drawing.Size(142, 33);
            this.rbAnswer3.TabIndex = 2;
            this.rbAnswer3.TabStop = true;
            this.rbAnswer3.Text = "Answer3";
            this.rbAnswer3.UseVisualStyleBackColor = true;
            this.rbAnswer3.Visible = false;
            // 
            // rbAnswer1
            // 
            this.rbAnswer1.AutoSize = true;
            this.rbAnswer1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbAnswer1.Location = new System.Drawing.Point(190, 229);
            this.rbAnswer1.Name = "rbAnswer1";
            this.rbAnswer1.Size = new System.Drawing.Size(148, 33);
            this.rbAnswer1.TabIndex = 1;
            this.rbAnswer1.TabStop = true;
            this.rbAnswer1.Text = "Answer 1";
            this.rbAnswer1.UseVisualStyleBackColor = true;
            this.rbAnswer1.Visible = false;
            // 
            // rbAnswer2
            // 
            this.rbAnswer2.AutoSize = true;
            this.rbAnswer2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbAnswer2.Location = new System.Drawing.Point(480, 229);
            this.rbAnswer2.Name = "rbAnswer2";
            this.rbAnswer2.Size = new System.Drawing.Size(148, 33);
            this.rbAnswer2.TabIndex = 3;
            this.rbAnswer2.TabStop = true;
            this.rbAnswer2.Text = "Answer 2";
            this.rbAnswer2.UseVisualStyleBackColor = true;
            this.rbAnswer2.Visible = false;
            // 
            // rbAnswer4
            // 
            this.rbAnswer4.AutoSize = true;
            this.rbAnswer4.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbAnswer4.Location = new System.Drawing.Point(483, 285);
            this.rbAnswer4.Name = "rbAnswer4";
            this.rbAnswer4.Size = new System.Drawing.Size(142, 33);
            this.rbAnswer4.TabIndex = 4;
            this.rbAnswer4.TabStop = true;
            this.rbAnswer4.Text = "Answer4";
            this.rbAnswer4.UseVisualStyleBackColor = true;
            this.rbAnswer4.Visible = false;
            // 
            // Quiz
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(194)))), ((int)(((byte)(173)))));
            this.ClientSize = new System.Drawing.Size(840, 450);
            this.Controls.Add(this.rbAnswer4);
            this.Controls.Add(this.rbAnswer2);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.rbAnswer3);
            this.Controls.Add(this.rbAnswer1);
            this.Controls.Add(this.lblNumOfQuestion);
            this.Controls.Add(this.lblCorrectAnswers);
            this.Controls.Add(this.pbCorrectAnswers);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.lblExplanation);
            this.Controls.Add(this.btnPlay);
            this.Controls.Add(this.tbQuestion);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Quiz";
            this.Text = "Quiz";
            this.Load += new System.EventHandler(this.Quiz_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbQuestion;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Button btnPlay;
        private System.Windows.Forms.Label lblExplanation;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.ProgressBar pbCorrectAnswers;
        private System.Windows.Forms.Label lblCorrectAnswers;
        private System.Windows.Forms.Label lblNumOfQuestion;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.RadioButton rbAnswer4;
        private System.Windows.Forms.RadioButton rbAnswer2;
        private System.Windows.Forms.RadioButton rbAnswer3;
        private System.Windows.Forms.RadioButton rbAnswer1;
    }
}