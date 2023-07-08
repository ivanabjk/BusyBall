namespace VP_Proekt
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
            this.label1 = new System.Windows.Forms.Label();
            this.btnStart = new System.Windows.Forms.Button();
            this.lblNameOfGame = new System.Windows.Forms.Label();
            this.lblGameExplanation = new System.Windows.Forms.Label();
            this.btnGuide = new System.Windows.Forms.Button();
            this.lblGuide = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 16);
            this.label1.TabIndex = 0;
            // 
            // btnStart
            // 
            this.btnStart.BackColor = System.Drawing.Color.Firebrick;
            this.btnStart.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnStart.Font = new System.Drawing.Font("Mongolian Baiti", 25.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStart.ForeColor = System.Drawing.Color.Cornsilk;
            this.btnStart.Location = new System.Drawing.Point(788, 453);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(237, 83);
            this.btnStart.TabIndex = 1;
            this.btnStart.Text = "START";
            this.btnStart.UseVisualStyleBackColor = false;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // lblNameOfGame
            // 
            this.lblNameOfGame.AutoSize = true;
            this.lblNameOfGame.BackColor = System.Drawing.Color.Firebrick;
            this.lblNameOfGame.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblNameOfGame.Font = new System.Drawing.Font("Mongolian Baiti", 40.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNameOfGame.ForeColor = System.Drawing.Color.Cornsilk;
            this.lblNameOfGame.Location = new System.Drawing.Point(352, 61);
            this.lblNameOfGame.Name = "lblNameOfGame";
            this.lblNameOfGame.Size = new System.Drawing.Size(407, 73);
            this.lblNameOfGame.TabIndex = 2;
            this.lblNameOfGame.Text = "BUSY BALL";
            // 
            // lblGameExplanation
            // 
            this.lblGameExplanation.AutoSize = true;
            this.lblGameExplanation.BackColor = System.Drawing.Color.Cornsilk;
            this.lblGameExplanation.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblGameExplanation.Font = new System.Drawing.Font("Mongolian Baiti", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGameExplanation.ForeColor = System.Drawing.Color.Maroon;
            this.lblGameExplanation.Location = new System.Drawing.Point(185, 182);
            this.lblGameExplanation.Name = "lblGameExplanation";
            this.lblGameExplanation.Size = new System.Drawing.Size(324, 28);
            this.lblGameExplanation.TabIndex = 3;
            this.lblGameExplanation.Text = "This is how you play the game";
            this.lblGameExplanation.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnGuide
            // 
            this.btnGuide.BackColor = System.Drawing.Color.DarkRed;
            this.btnGuide.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuide.ForeColor = System.Drawing.Color.White;
            this.btnGuide.Location = new System.Drawing.Point(28, 514);
            this.btnGuide.Name = "btnGuide";
            this.btnGuide.Size = new System.Drawing.Size(73, 56);
            this.btnGuide.TabIndex = 19;
            this.btnGuide.Text = "Guide";
            this.btnGuide.UseVisualStyleBackColor = false;
            this.btnGuide.Click += new System.EventHandler(this.btnGuide_Click);
            // 
            // lblGuide
            // 
            this.lblGuide.AutoSize = true;
            this.lblGuide.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.lblGuide.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblGuide.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGuide.Location = new System.Drawing.Point(185, 39);
            this.lblGuide.Name = "lblGuide";
            this.lblGuide.Size = new System.Drawing.Size(53, 21);
            this.lblGuide.TabIndex = 20;
            this.lblGuide.Text = "label1";
            this.lblGuide.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblGuide.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1143, 593);
            this.Controls.Add(this.lblGuide);
            this.Controls.Add(this.btnGuide);
            this.Controls.Add(this.lblGameExplanation);
            this.Controls.Add(this.lblNameOfGame);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Label lblNameOfGame;
        private System.Windows.Forms.Label lblGameExplanation;
        private System.Windows.Forms.Button btnGuide;
        private System.Windows.Forms.Label lblGuide;
    }
}

