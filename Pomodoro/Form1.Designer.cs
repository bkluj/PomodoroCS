namespace Pomodoro
{
    partial class formPomodorro
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.lblPomodorro = new System.Windows.Forms.Label();
            this.btnStartStop = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.lblTime = new System.Windows.Forms.Label();
            this.lblWork = new System.Windows.Forms.Label();
            this.lblBreak = new System.Windows.Forms.Label();
            this.lblWorkLabel = new System.Windows.Forms.Label();
            this.lblBreaLabel = new System.Windows.Forms.Label();
            this.btnBTDown = new System.Windows.Forms.Button();
            this.btnBTUp = new System.Windows.Forms.Button();
            this.btnWTDown = new System.Windows.Forms.Button();
            this.btnWTUp = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblPomodorro
            // 
            this.lblPomodorro.AutoSize = true;
            this.lblPomodorro.Font = new System.Drawing.Font("FL Pismo Techniczne", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblPomodorro.Location = new System.Drawing.Point(13, 9);
            this.lblPomodorro.Name = "lblPomodorro";
            this.lblPomodorro.Size = new System.Drawing.Size(411, 79);
            this.lblPomodorro.TabIndex = 0;
            this.lblPomodorro.Text = "Pomodorro app";
            // 
            // btnStartStop
            // 
            this.btnStartStop.Location = new System.Drawing.Point(6, 84);
            this.btnStartStop.Name = "btnStartStop";
            this.btnStartStop.Size = new System.Drawing.Size(93, 41);
            this.btnStartStop.TabIndex = 1;
            this.btnStartStop.Text = "Start / stop";
            this.btnStartStop.UseVisualStyleBackColor = true;
            this.btnStartStop.Click += new System.EventHandler(this.btnStartStop_Click);
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(117, 84);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(93, 41);
            this.btnReset.TabIndex = 1;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.Font = new System.Drawing.Font("FL Pismo Techniczne", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblTime.Location = new System.Drawing.Point(30, 9);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(162, 79);
            this.lblTime.TabIndex = 0;
            this.lblTime.Text = "00:00";
            // 
            // lblWork
            // 
            this.lblWork.AutoSize = true;
            this.lblWork.Font = new System.Drawing.Font("FL Pismo Techniczne", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblWork.Location = new System.Drawing.Point(32, 43);
            this.lblWork.Name = "lblWork";
            this.lblWork.Size = new System.Drawing.Size(92, 79);
            this.lblWork.TabIndex = 0;
            this.lblWork.Text = "00";
            // 
            // lblBreak
            // 
            this.lblBreak.AutoSize = true;
            this.lblBreak.Font = new System.Drawing.Font("FL Pismo Techniczne", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblBreak.Location = new System.Drawing.Point(32, 44);
            this.lblBreak.Name = "lblBreak";
            this.lblBreak.Size = new System.Drawing.Size(92, 79);
            this.lblBreak.TabIndex = 0;
            this.lblBreak.Text = "00";
            // 
            // lblWorkLabel
            // 
            this.lblWorkLabel.AutoSize = true;
            this.lblWorkLabel.Font = new System.Drawing.Font("FL Pismo Techniczne", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblWorkLabel.Location = new System.Drawing.Point(6, 16);
            this.lblWorkLabel.Name = "lblWorkLabel";
            this.lblWorkLabel.Size = new System.Drawing.Size(195, 39);
            this.lblWorkLabel.TabIndex = 0;
            this.lblWorkLabel.Text = "Work time set";
            // 
            // lblBreaLabel
            // 
            this.lblBreaLabel.AutoSize = true;
            this.lblBreaLabel.Font = new System.Drawing.Font("FL Pismo Techniczne", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblBreaLabel.Location = new System.Drawing.Point(6, 16);
            this.lblBreaLabel.Name = "lblBreaLabel";
            this.lblBreaLabel.Size = new System.Drawing.Size(203, 39);
            this.lblBreaLabel.TabIndex = 0;
            this.lblBreaLabel.Text = "Break time set";
            // 
            // btnBTDown
            // 
            this.btnBTDown.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnBTDown.Location = new System.Drawing.Point(130, 93);
            this.btnBTDown.Name = "btnBTDown";
            this.btnBTDown.Size = new System.Drawing.Size(37, 29);
            this.btnBTDown.TabIndex = 1;
            this.btnBTDown.Text = "-";
            this.btnBTDown.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnBTDown.UseVisualStyleBackColor = true;
            this.btnBTDown.Click += new System.EventHandler(this.btnBTDown_Click);
            // 
            // btnBTUp
            // 
            this.btnBTUp.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnBTUp.Location = new System.Drawing.Point(130, 58);
            this.btnBTUp.Name = "btnBTUp";
            this.btnBTUp.Size = new System.Drawing.Size(37, 29);
            this.btnBTUp.TabIndex = 1;
            this.btnBTUp.Text = "+";
            this.btnBTUp.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnBTUp.UseVisualStyleBackColor = true;
            this.btnBTUp.Click += new System.EventHandler(this.btnBTUp_Click);
            // 
            // btnWTDown
            // 
            this.btnWTDown.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnWTDown.Location = new System.Drawing.Point(130, 93);
            this.btnWTDown.Name = "btnWTDown";
            this.btnWTDown.Size = new System.Drawing.Size(37, 29);
            this.btnWTDown.TabIndex = 1;
            this.btnWTDown.Text = "-";
            this.btnWTDown.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnWTDown.UseVisualStyleBackColor = true;
            this.btnWTDown.Click += new System.EventHandler(this.btnWTDown_Click);
            // 
            // btnWTUp
            // 
            this.btnWTUp.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnWTUp.Location = new System.Drawing.Point(130, 58);
            this.btnWTUp.Name = "btnWTUp";
            this.btnWTUp.Size = new System.Drawing.Size(37, 29);
            this.btnWTUp.TabIndex = 1;
            this.btnWTUp.Text = "+";
            this.btnWTUp.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnWTUp.UseVisualStyleBackColor = true;
            this.btnWTUp.Click += new System.EventHandler(this.button4_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnBTUp);
            this.groupBox1.Controls.Add(this.btnBTDown);
            this.groupBox1.Controls.Add(this.lblBreaLabel);
            this.groupBox1.Controls.Add(this.lblBreak);
            this.groupBox1.Location = new System.Drawing.Point(16, 161);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(212, 136);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lblWorkLabel);
            this.groupBox2.Controls.Add(this.btnWTUp);
            this.groupBox2.Controls.Add(this.lblWork);
            this.groupBox2.Controls.Add(this.btnWTDown);
            this.groupBox2.Location = new System.Drawing.Point(16, 19);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(212, 136);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.groupBox2);
            this.groupBox3.Controls.Add(this.groupBox1);
            this.groupBox3.Location = new System.Drawing.Point(498, 54);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(244, 313);
            this.groupBox3.TabIndex = 4;
            this.groupBox3.TabStop = false;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.btnReset);
            this.groupBox4.Controls.Add(this.btnStartStop);
            this.groupBox4.Controls.Add(this.lblTime);
            this.groupBox4.Location = new System.Drawing.Point(117, 157);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(220, 131);
            this.groupBox4.TabIndex = 5;
            this.groupBox4.TabStop = false;
            // 
            // formPomodorro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblPomodorro);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox4);
            this.Name = "formPomodorro";
            this.Text = "Pomodorro";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblPomodorro;
        private System.Windows.Forms.Button btnStartStop;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.Label lblWork;
        private System.Windows.Forms.Label lblBreak;
        private System.Windows.Forms.Label lblWorkLabel;
        private System.Windows.Forms.Label lblBreaLabel;
        private System.Windows.Forms.Button btnBTDown;
        private System.Windows.Forms.Button btnBTUp;
        private System.Windows.Forms.Button btnWTDown;
        private System.Windows.Forms.Button btnWTUp;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
    }
}

