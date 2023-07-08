namespace VP_Proekt
{
    partial class MathOperations
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
            this.btnPlay = new System.Windows.Forms.Button();
            this.lblText = new System.Windows.Forms.Label();
            this.tbAnswer = new System.Windows.Forms.TextBox();
            this.btnOK = new System.Windows.Forms.Button();
            this.tbOperation = new System.Windows.Forms.TextBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.lblTimer = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.lblNumOfOperations = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnPlay
            // 
            this.btnPlay.BackColor = System.Drawing.Color.Sienna;
            this.btnPlay.Font = new System.Drawing.Font("Microsoft Sans Serif", 17F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPlay.ForeColor = System.Drawing.Color.FloralWhite;
            this.btnPlay.Location = new System.Drawing.Point(166, 330);
            this.btnPlay.Name = "btnPlay";
            this.btnPlay.Size = new System.Drawing.Size(158, 61);
            this.btnPlay.TabIndex = 0;
            this.btnPlay.Text = "PLAY";
            this.btnPlay.UseVisualStyleBackColor = false;
            this.btnPlay.Click += new System.EventHandler(this.btnPlay_Click);
            // 
            // lblText
            // 
            this.lblText.AutoSize = true;
            this.lblText.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblText.Location = new System.Drawing.Point(80, 267);
            this.lblText.Name = "lblText";
            this.lblText.Size = new System.Drawing.Size(398, 24);
            this.lblText.TabIndex = 1;
            this.lblText.Text = "You have 2 minutes for 3 operations. Be quick!";
            this.lblText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tbAnswer
            // 
            this.tbAnswer.BackColor = System.Drawing.Color.Wheat;
            this.tbAnswer.Enabled = false;
            this.tbAnswer.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbAnswer.Location = new System.Drawing.Point(144, 212);
            this.tbAnswer.Name = "tbAnswer";
            this.tbAnswer.Size = new System.Drawing.Size(100, 26);
            this.tbAnswer.TabIndex = 2;
            this.tbAnswer.Validating += new System.ComponentModel.CancelEventHandler(this.tbAnswer_Validating);
            // 
            // btnOK
            // 
            this.btnOK.BackColor = System.Drawing.Color.Sienna;
            this.btnOK.Enabled = false;
            this.btnOK.ForeColor = System.Drawing.Color.FloralWhite;
            this.btnOK.Location = new System.Drawing.Point(275, 208);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(60, 36);
            this.btnOK.TabIndex = 3;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = false;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // tbOperation
            // 
            this.tbOperation.BackColor = System.Drawing.Color.Wheat;
            this.tbOperation.Enabled = false;
            this.tbOperation.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbOperation.Location = new System.Drawing.Point(92, 132);
            this.tbOperation.Name = "tbOperation";
            this.tbOperation.ReadOnly = true;
            this.tbOperation.Size = new System.Drawing.Size(319, 26);
            this.tbOperation.TabIndex = 4;
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // lblTimer
            // 
            this.lblTimer.AutoSize = true;
            this.lblTimer.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTimer.Location = new System.Drawing.Point(173, 31);
            this.lblTimer.Name = "lblTimer";
            this.lblTimer.Size = new System.Drawing.Size(151, 58);
            this.lblTimer.TabIndex = 5;
            this.lblTimer.Text = "00:40";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // lblNumOfOperations
            // 
            this.lblNumOfOperations.AutoSize = true;
            this.lblNumOfOperations.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumOfOperations.Location = new System.Drawing.Point(434, 9);
            this.lblNumOfOperations.Name = "lblNumOfOperations";
            this.lblNumOfOperations.Size = new System.Drawing.Size(0, 20);
            this.lblNumOfOperations.TabIndex = 6;
            // 
            // MathOperations
            // 
            this.AcceptButton = this.btnOK;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.BurlyWood;
            this.ClientSize = new System.Drawing.Size(496, 403);
            this.Controls.Add(this.lblNumOfOperations);
            this.Controls.Add(this.lblTimer);
            this.Controls.Add(this.tbOperation);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.tbAnswer);
            this.Controls.Add(this.lblText);
            this.Controls.Add(this.btnPlay);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MathOperations";
            this.Text = "MathOperations";
            this.Load += new System.EventHandler(this.MathOperations_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnPlay;
        private System.Windows.Forms.Label lblText;
        private System.Windows.Forms.TextBox tbAnswer;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.TextBox tbOperation;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label lblTimer;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Label lblNumOfOperations;
    }
}