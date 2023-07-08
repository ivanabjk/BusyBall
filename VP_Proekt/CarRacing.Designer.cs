namespace VP_Proekt
{
    partial class CarRacing
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.pbRedChoice = new System.Windows.Forms.PictureBox();
            this.pbBlueChoice = new System.Windows.Forms.PictureBox();
            this.lblChoose = new System.Windows.Forms.Label();
            this.pbAward = new System.Windows.Forms.PictureBox();
            this.pbExplosion = new System.Windows.Forms.PictureBox();
            this.pbPlayerCar = new System.Windows.Forms.PictureBox();
            this.pbCar2 = new System.Windows.Forms.PictureBox();
            this.pbCar1 = new System.Windows.Forms.PictureBox();
            this.pbRoad2 = new System.Windows.Forms.PictureBox();
            this.pbRoad1 = new System.Windows.Forms.PictureBox();
            this.btnStart = new System.Windows.Forms.Button();
            this.lblScore = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.btnSwitchCar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbRedChoice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbBlueChoice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbAward)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbExplosion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPlayerCar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCar2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCar1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbRoad2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbRoad1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Controls.Add(this.pbRedChoice);
            this.panel1.Controls.Add(this.pbBlueChoice);
            this.panel1.Controls.Add(this.lblChoose);
            this.panel1.Controls.Add(this.pbAward);
            this.panel1.Controls.Add(this.pbExplosion);
            this.panel1.Controls.Add(this.pbPlayerCar);
            this.panel1.Controls.Add(this.pbCar2);
            this.panel1.Controls.Add(this.pbCar1);
            this.panel1.Controls.Add(this.pbRoad2);
            this.panel1.Controls.Add(this.pbRoad1);
            this.panel1.Location = new System.Drawing.Point(0, -1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(474, 519);
            this.panel1.TabIndex = 0;
            // 
            // pbRedChoice
            // 
            this.pbRedChoice.BackColor = System.Drawing.Color.Black;
            this.pbRedChoice.Image = global::VP_Proekt.Properties.Resources.carRed;
            this.pbRedChoice.Location = new System.Drawing.Point(44, 176);
            this.pbRedChoice.Name = "pbRedChoice";
            this.pbRedChoice.Size = new System.Drawing.Size(166, 261);
            this.pbRedChoice.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbRedChoice.TabIndex = 11;
            this.pbRedChoice.TabStop = false;
            this.pbRedChoice.Click += new System.EventHandler(this.pbRedChoice_Click);
            // 
            // pbBlueChoice
            // 
            this.pbBlueChoice.BackColor = System.Drawing.Color.Black;
            this.pbBlueChoice.Image = global::VP_Proekt.Properties.Resources.carBlue;
            this.pbBlueChoice.Location = new System.Drawing.Point(249, 176);
            this.pbBlueChoice.Name = "pbBlueChoice";
            this.pbBlueChoice.Size = new System.Drawing.Size(166, 261);
            this.pbBlueChoice.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbBlueChoice.TabIndex = 10;
            this.pbBlueChoice.TabStop = false;
            this.pbBlueChoice.Click += new System.EventHandler(this.pbBlueChoice_Click);
            // 
            // lblChoose
            // 
            this.lblChoose.AutoSize = true;
            this.lblChoose.BackColor = System.Drawing.Color.Black;
            this.lblChoose.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblChoose.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblChoose.ForeColor = System.Drawing.Color.White;
            this.lblChoose.Location = new System.Drawing.Point(54, 55);
            this.lblChoose.Name = "lblChoose";
            this.lblChoose.Size = new System.Drawing.Size(338, 60);
            this.lblChoose.TabIndex = 9;
            this.lblChoose.Text = "Choose a car!";
            // 
            // pbAward
            // 
            this.pbAward.BackColor = System.Drawing.Color.OliveDrab;
            this.pbAward.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pbAward.Image = global::VP_Proekt.Properties.Resources.FirstPlace;
            this.pbAward.Location = new System.Drawing.Point(139, 118);
            this.pbAward.Name = "pbAward";
            this.pbAward.Size = new System.Drawing.Size(188, 235);
            this.pbAward.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbAward.TabIndex = 8;
            this.pbAward.TabStop = false;
            this.pbAward.Visible = false;
            // 
            // pbExplosion
            // 
            this.pbExplosion.Image = global::VP_Proekt.Properties.Resources.explosion;
            this.pbExplosion.Location = new System.Drawing.Point(66, 341);
            this.pbExplosion.Name = "pbExplosion";
            this.pbExplosion.Size = new System.Drawing.Size(93, 76);
            this.pbExplosion.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbExplosion.TabIndex = 7;
            this.pbExplosion.TabStop = false;
            this.pbExplosion.Visible = false;
            // 
            // pbPlayerCar
            // 
            this.pbPlayerCar.Image = global::VP_Proekt.Properties.Resources.carRed;
            this.pbPlayerCar.Location = new System.Drawing.Point(200, 391);
            this.pbPlayerCar.Name = "pbPlayerCar";
            this.pbPlayerCar.Size = new System.Drawing.Size(67, 114);
            this.pbPlayerCar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbPlayerCar.TabIndex = 6;
            this.pbPlayerCar.TabStop = false;
            this.pbPlayerCar.Visible = false;
            // 
            // pbCar2
            // 
            this.pbCar2.Image = global::VP_Proekt.Properties.Resources.carBlue;
            this.pbCar2.Location = new System.Drawing.Point(249, 85);
            this.pbCar2.Name = "pbCar2";
            this.pbCar2.Size = new System.Drawing.Size(73, 131);
            this.pbCar2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbCar2.TabIndex = 5;
            this.pbCar2.TabStop = false;
            this.pbCar2.Tag = "carRight";
            this.pbCar2.Visible = false;
            // 
            // pbCar1
            // 
            this.pbCar1.Image = global::VP_Proekt.Properties.Resources.carBlue;
            this.pbCar1.Location = new System.Drawing.Point(66, 19);
            this.pbCar1.Name = "pbCar1";
            this.pbCar1.Size = new System.Drawing.Size(73, 131);
            this.pbCar1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbCar1.TabIndex = 2;
            this.pbCar1.TabStop = false;
            this.pbCar1.Tag = "carLeft";
            this.pbCar1.Visible = false;
            // 
            // pbRoad2
            // 
            this.pbRoad2.BackColor = System.Drawing.Color.IndianRed;
            this.pbRoad2.Image = global::VP_Proekt.Properties.Resources.PicOfTrack;
            this.pbRoad2.Location = new System.Drawing.Point(-9, 0);
            this.pbRoad2.Name = "pbRoad2";
            this.pbRoad2.Size = new System.Drawing.Size(475, 790);
            this.pbRoad2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbRoad2.TabIndex = 4;
            this.pbRoad2.TabStop = false;
            // 
            // pbRoad1
            // 
            this.pbRoad1.BackColor = System.Drawing.Color.Khaki;
            this.pbRoad1.Image = global::VP_Proekt.Properties.Resources.PicOfTrack;
            this.pbRoad1.Location = new System.Drawing.Point(-9, -519);
            this.pbRoad1.Name = "pbRoad1";
            this.pbRoad1.Size = new System.Drawing.Size(475, 519);
            this.pbRoad1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbRoad1.TabIndex = 3;
            this.pbRoad1.TabStop = false;
            // 
            // btnStart
            // 
            this.btnStart.BackColor = System.Drawing.SystemColors.Control;
            this.btnStart.Enabled = false;
            this.btnStart.Font = new System.Drawing.Font("Arial Rounded MT Bold", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStart.Location = new System.Drawing.Point(139, 572);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(198, 65);
            this.btnStart.TabIndex = 0;
            this.btnStart.Text = "START";
            this.btnStart.UseVisualStyleBackColor = false;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // lblScore
            // 
            this.lblScore.AutoSize = true;
            this.lblScore.Font = new System.Drawing.Font("Arial Rounded MT Bold", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblScore.Location = new System.Drawing.Point(172, 537);
            this.lblScore.Name = "lblScore";
            this.lblScore.Size = new System.Drawing.Size(130, 32);
            this.lblScore.TabIndex = 1;
            this.lblScore.Text = "Score : 0";
            // 
            // timer1
            // 
            this.timer1.Interval = 20;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // btnSwitchCar
            // 
            this.btnSwitchCar.BackColor = System.Drawing.Color.OliveDrab;
            this.btnSwitchCar.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSwitchCar.ForeColor = System.Drawing.Color.White;
            this.btnSwitchCar.Location = new System.Drawing.Point(355, 572);
            this.btnSwitchCar.Name = "btnSwitchCar";
            this.btnSwitchCar.Size = new System.Drawing.Size(78, 65);
            this.btnSwitchCar.TabIndex = 12;
            this.btnSwitchCar.Text = "Switch Car";
            this.btnSwitchCar.UseVisualStyleBackColor = false;
            this.btnSwitchCar.Visible = false;
            this.btnSwitchCar.Click += new System.EventHandler(this.btnSwitchCar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.OliveDrab;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(12, 578);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 53);
            this.label1.TabIndex = 14;
            this.label1.Text = " Gold  > 1500\r\n Silver  >  700\r\n Bronse > 200\r\n";
            // 
            // CarRacing
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.YellowGreen;
            this.ClientSize = new System.Drawing.Size(462, 649);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSwitchCar);
            this.Controls.Add(this.lblScore);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "CarRacing";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.CarRacing_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.CarRacing_KeyUp);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbRedChoice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbBlueChoice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbAward)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbExplosion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPlayerCar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCar2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCar1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbRoad2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbRoad1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Label lblScore;
        private System.Windows.Forms.PictureBox pbRoad1;
        private System.Windows.Forms.PictureBox pbRoad2;
        private System.Windows.Forms.PictureBox pbAward;
        private System.Windows.Forms.PictureBox pbExplosion;
        private System.Windows.Forms.PictureBox pbPlayerCar;
        private System.Windows.Forms.PictureBox pbCar2;
        private System.Windows.Forms.PictureBox pbCar1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.PictureBox pbRedChoice;
        private System.Windows.Forms.PictureBox pbBlueChoice;
        private System.Windows.Forms.Label lblChoose;
        private System.Windows.Forms.Button btnSwitchCar;
        private System.Windows.Forms.Label label1;
    }
}