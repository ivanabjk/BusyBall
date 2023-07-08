namespace VP_Proekt
{
    partial class MainForm
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
            this.timerStart = new System.Windows.Forms.Timer(this.components);
            this.timerAlarm = new System.Windows.Forms.Timer(this.components);
            this.lblListName = new System.Windows.Forms.Label();
            this.btnGame4 = new System.Windows.Forms.Button();
            this.btnGame1 = new System.Windows.Forms.Button();
            this.btnGame2 = new System.Windows.Forms.Button();
            this.btnGame3 = new System.Windows.Forms.Button();
            this.lblTurnAlarmOff = new System.Windows.Forms.Label();
            this.btnGuide = new System.Windows.Forms.Button();
            this.lblGuide = new System.Windows.Forms.Label();
            this.lblEnd = new System.Windows.Forms.Label();
            this.pbBall = new System.Windows.Forms.PictureBox();
            this.pbZZZ = new System.Windows.Forms.PictureBox();
            this.pbToDoList = new System.Windows.Forms.PictureBox();
            this.pbAlarmClock = new System.Windows.Forms.PictureBox();
            this.lblText = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbBall)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbZZZ)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbToDoList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbAlarmClock)).BeginInit();
            this.SuspendLayout();
            // 
            // timerStart
            // 
            this.timerStart.Interval = 1000;
            this.timerStart.Tick += new System.EventHandler(this.timerStart_Tick);
            // 
            // timerAlarm
            // 
            this.timerAlarm.Tick += new System.EventHandler(this.timerAlarm_Tick);
            // 
            // lblListName
            // 
            this.lblListName.AutoSize = true;
            this.lblListName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.lblListName.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblListName.ForeColor = System.Drawing.Color.Maroon;
            this.lblListName.Location = new System.Drawing.Point(847, 112);
            this.lblListName.Name = "lblListName";
            this.lblListName.Size = new System.Drawing.Size(124, 39);
            this.lblListName.TabIndex = 3;
            this.lblListName.Text = "TO DO";
            this.lblListName.Click += new System.EventHandler(this.label2_Click);
            // 
            // btnGame4
            // 
            this.btnGame4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnGame4.Enabled = false;
            this.btnGame4.Font = new System.Drawing.Font("MV Boli", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGame4.Location = new System.Drawing.Point(783, 450);
            this.btnGame4.Name = "btnGame4";
            this.btnGame4.Size = new System.Drawing.Size(253, 50);
            this.btnGame4.TabIndex = 7;
            this.btnGame4.Text = "Gaming";
            this.btnGame4.UseVisualStyleBackColor = false;
            this.btnGame4.Click += new System.EventHandler(this.btnGame4_Click);
            // 
            // btnGame1
            // 
            this.btnGame1.BackColor = System.Drawing.Color.IndianRed;
            this.btnGame1.Enabled = false;
            this.btnGame1.Font = new System.Drawing.Font("MV Boli", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGame1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnGame1.Location = new System.Drawing.Point(783, 208);
            this.btnGame1.Name = "btnGame1";
            this.btnGame1.Size = new System.Drawing.Size(253, 53);
            this.btnGame1.TabIndex = 13;
            this.btnGame1.Text = "Studying";
            this.btnGame1.UseVisualStyleBackColor = false;
            this.btnGame1.Click += new System.EventHandler(this.btnGame1_Click);
            // 
            // btnGame2
            // 
            this.btnGame2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnGame2.Enabled = false;
            this.btnGame2.Font = new System.Drawing.Font("MV Boli", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGame2.Location = new System.Drawing.Point(783, 292);
            this.btnGame2.Name = "btnGame2";
            this.btnGame2.Size = new System.Drawing.Size(253, 50);
            this.btnGame2.TabIndex = 14;
            this.btnGame2.Text = "Painting";
            this.btnGame2.UseVisualStyleBackColor = false;
            this.btnGame2.Click += new System.EventHandler(this.btnGame2_Click);
            // 
            // btnGame3
            // 
            this.btnGame3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnGame3.Enabled = false;
            this.btnGame3.Font = new System.Drawing.Font("MV Boli", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGame3.Location = new System.Drawing.Point(783, 373);
            this.btnGame3.Name = "btnGame3";
            this.btnGame3.Size = new System.Drawing.Size(253, 50);
            this.btnGame3.TabIndex = 15;
            this.btnGame3.Text = "Cleaning";
            this.btnGame3.UseVisualStyleBackColor = false;
            this.btnGame3.Click += new System.EventHandler(this.btnGame3_Click);
            // 
            // lblTurnAlarmOff
            // 
            this.lblTurnAlarmOff.AutoSize = true;
            this.lblTurnAlarmOff.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.lblTurnAlarmOff.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblTurnAlarmOff.Font = new System.Drawing.Font("Arial Rounded MT Bold", 8F);
            this.lblTurnAlarmOff.Location = new System.Drawing.Point(360, 472);
            this.lblTurnAlarmOff.Name = "lblTurnAlarmOff";
            this.lblTurnAlarmOff.Size = new System.Drawing.Size(103, 18);
            this.lblTurnAlarmOff.TabIndex = 17;
            this.lblTurnAlarmOff.Text = "TURN IT OFF!";
            // 
            // btnGuide
            // 
            this.btnGuide.BackColor = System.Drawing.Color.DarkRed;
            this.btnGuide.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuide.ForeColor = System.Drawing.Color.White;
            this.btnGuide.Location = new System.Drawing.Point(12, 525);
            this.btnGuide.Name = "btnGuide";
            this.btnGuide.Size = new System.Drawing.Size(73, 55);
            this.btnGuide.TabIndex = 18;
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
            this.lblGuide.Location = new System.Drawing.Point(134, 29);
            this.lblGuide.Name = "lblGuide";
            this.lblGuide.Size = new System.Drawing.Size(53, 21);
            this.lblGuide.TabIndex = 19;
            this.lblGuide.Text = "label1";
            this.lblGuide.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblGuide.Visible = false;
            // 
            // lblEnd
            // 
            this.lblEnd.AutoSize = true;
            this.lblEnd.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.lblEnd.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblEnd.Font = new System.Drawing.Font("Arial Rounded MT Bold", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEnd.Location = new System.Drawing.Point(292, 139);
            this.lblEnd.Name = "lblEnd";
            this.lblEnd.Size = new System.Drawing.Size(172, 41);
            this.lblEnd.TabIndex = 21;
            this.lblEnd.Text = "THE END";
            this.lblEnd.Visible = false;
            // 
            // pbBall
            // 
            this.pbBall.BackColor = System.Drawing.Color.Transparent;
            this.pbBall.Image = global::VP_Proekt.Properties.Resources.RedBall;
            this.pbBall.Location = new System.Drawing.Point(220, 339);
            this.pbBall.Name = "pbBall";
            this.pbBall.Size = new System.Drawing.Size(118, 110);
            this.pbBall.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbBall.TabIndex = 23;
            this.pbBall.TabStop = false;
            // 
            // pbZZZ
            // 
            this.pbZZZ.BackColor = System.Drawing.Color.Transparent;
            this.pbZZZ.Image = global::VP_Proekt.Properties.Resources.ZZZ;
            this.pbZZZ.Location = new System.Drawing.Point(304, 276);
            this.pbZZZ.Name = "pbZZZ";
            this.pbZZZ.Size = new System.Drawing.Size(77, 66);
            this.pbZZZ.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbZZZ.TabIndex = 22;
            this.pbZZZ.TabStop = false;
            // 
            // pbToDoList
            // 
            this.pbToDoList.BackColor = System.Drawing.Color.Transparent;
            this.pbToDoList.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbToDoList.Image = global::VP_Proekt.Properties.Resources.imgbin_list_icon_files_and_folders_icon_clipboard_icon_png;
            this.pbToDoList.Location = new System.Drawing.Point(700, 12);
            this.pbToDoList.Name = "pbToDoList";
            this.pbToDoList.Size = new System.Drawing.Size(414, 579);
            this.pbToDoList.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbToDoList.TabIndex = 2;
            this.pbToDoList.TabStop = false;
            // 
            // pbAlarmClock
            // 
            this.pbAlarmClock.BackColor = System.Drawing.Color.Transparent;
            this.pbAlarmClock.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbAlarmClock.Enabled = false;
            this.pbAlarmClock.Image = global::VP_Proekt.Properties.Resources.imgbin_alarm_clock_png__1_;
            this.pbAlarmClock.Location = new System.Drawing.Point(378, 395);
            this.pbAlarmClock.Name = "pbAlarmClock";
            this.pbAlarmClock.Size = new System.Drawing.Size(64, 61);
            this.pbAlarmClock.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbAlarmClock.TabIndex = 0;
            this.pbAlarmClock.TabStop = false;
            this.pbAlarmClock.Click += new System.EventHandler(this.pbAlarmClock_Click);
            // 
            // lblText
            // 
            this.lblText.AutoSize = true;
            this.lblText.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.lblText.Font = new System.Drawing.Font("Arial Rounded MT Bold", 8F);
            this.lblText.Location = new System.Drawing.Point(735, 564);
            this.lblText.Name = "lblText";
            this.lblText.Size = new System.Drawing.Size(340, 16);
            this.lblText.TabIndex = 24;
            this.lblText.Text = "YOU CAN CONTINUE TO PLAY THE MINI GAMES";
            this.lblText.Visible = false;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1143, 593);
            this.Controls.Add(this.lblText);
            this.Controls.Add(this.lblGuide);
            this.Controls.Add(this.pbBall);
            this.Controls.Add(this.pbZZZ);
            this.Controls.Add(this.lblEnd);
            this.Controls.Add(this.btnGuide);
            this.Controls.Add(this.lblTurnAlarmOff);
            this.Controls.Add(this.btnGame3);
            this.Controls.Add(this.btnGame2);
            this.Controls.Add(this.btnGame1);
            this.Controls.Add(this.btnGame4);
            this.Controls.Add(this.lblListName);
            this.Controls.Add(this.pbToDoList);
            this.Controls.Add(this.pbAlarmClock);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainForm";
            this.Text = " ";
            ((System.ComponentModel.ISupportInitialize)(this.pbBall)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbZZZ)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbToDoList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbAlarmClock)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbAlarmClock;
        private System.Windows.Forms.Timer timerStart;
        private System.Windows.Forms.Timer timerAlarm;
        private System.Windows.Forms.PictureBox pbToDoList;
        private System.Windows.Forms.Label lblListName;
        private System.Windows.Forms.Button btnGame4;
        private System.Windows.Forms.Button btnGame1;
        private System.Windows.Forms.Button btnGame2;
        private System.Windows.Forms.Button btnGame3;
        private System.Windows.Forms.Label lblTurnAlarmOff;
        private System.Windows.Forms.Button btnGuide;
        private System.Windows.Forms.Label lblGuide;
        private System.Windows.Forms.Label lblEnd;
        private System.Windows.Forms.PictureBox pbZZZ;
        private System.Windows.Forms.PictureBox pbBall;
        private System.Windows.Forms.Label lblText;
    }
}