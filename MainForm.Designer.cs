namespace AlarmClock
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.timerClock = new System.Windows.Forms.Timer(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.lblClockHours = new System.Windows.Forms.Label();
            this.lblClockMinutes = new System.Windows.Forms.Label();
            this.lblClockSeconds = new System.Windows.Forms.Label();
            this.txbHour = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.txbMinutes = new System.Windows.Forms.TextBox();
            this.btnA = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 120F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label1.Location = new System.Drawing.Point(273, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 238);
            this.label1.TabIndex = 2;
            this.label1.Text = ":";
            // 
            // timerClock
            // 
            this.timerClock.Enabled = true;
            this.timerClock.Interval = 1000;
            this.timerClock.Tick += new System.EventHandler(this.timerClock_Tick);
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Segoe UI", 120F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label2.Location = new System.Drawing.Point(640, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(111, 238);
            this.label2.TabIndex = 7;
            this.label2.Text = ":";
            // 
            // lblClockHours
            // 
            this.lblClockHours.AutoSize = true;
            this.lblClockHours.BackColor = System.Drawing.Color.Transparent;
            this.lblClockHours.Font = new System.Drawing.Font("Segoe UI", 130F, System.Drawing.FontStyle.Bold);
            this.lblClockHours.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.lblClockHours.Location = new System.Drawing.Point(10, 26);
            this.lblClockHours.Name = "lblClockHours";
            this.lblClockHours.Size = new System.Drawing.Size(297, 230);
            this.lblClockHours.TabIndex = 9;
            this.lblClockHours.Text = "00";
            // 
            // lblClockMinutes
            // 
            this.lblClockMinutes.AutoSize = true;
            this.lblClockMinutes.Font = new System.Drawing.Font("Segoe UI", 129.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClockMinutes.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.lblClockMinutes.Location = new System.Drawing.Point(353, 26);
            this.lblClockMinutes.Name = "lblClockMinutes";
            this.lblClockMinutes.Size = new System.Drawing.Size(297, 229);
            this.lblClockMinutes.TabIndex = 10;
            this.lblClockMinutes.Text = "00";
            this.lblClockMinutes.Click += new System.EventHandler(this.lblClockMinutes_Click);
            // 
            // lblClockSeconds
            // 
            this.lblClockSeconds.AutoSize = true;
            this.lblClockSeconds.Font = new System.Drawing.Font("Segoe UI", 129.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClockSeconds.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.lblClockSeconds.Location = new System.Drawing.Point(713, 27);
            this.lblClockSeconds.Name = "lblClockSeconds";
            this.lblClockSeconds.Size = new System.Drawing.Size(297, 229);
            this.lblClockSeconds.TabIndex = 11;
            this.lblClockSeconds.Text = "00";
            // 
            // txbHour
            // 
            this.txbHour.Font = new System.Drawing.Font("Segoe UI", 21.75F, System.Drawing.FontStyle.Bold);
            this.txbHour.Location = new System.Drawing.Point(353, 281);
            this.txbHour.Name = "txbHour";
            this.txbHour.Size = new System.Drawing.Size(100, 46);
            this.txbHour.TabIndex = 12;
            this.txbHour.Text = "00";
            this.txbHour.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txbHour.Leave += new System.EventHandler(this.isValidHour);
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Segoe UI", 21.75F, System.Drawing.FontStyle.Bold);
            this.textBox1.Location = new System.Drawing.Point(459, 280);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 46);
            this.textBox1.TabIndex = 13;
            this.textBox1.Text = ":";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txbMinutes
            // 
            this.txbMinutes.Font = new System.Drawing.Font("Segoe UI", 21.75F, System.Drawing.FontStyle.Bold);
            this.txbMinutes.Location = new System.Drawing.Point(565, 281);
            this.txbMinutes.Name = "txbMinutes";
            this.txbMinutes.Size = new System.Drawing.Size(100, 46);
            this.txbMinutes.TabIndex = 14;
            this.txbMinutes.Text = "00";
            this.txbMinutes.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txbMinutes.Leave += new System.EventHandler(this.isValidMinutes);
            // 
            // btnA
            // 
            this.btnA.BackColor = System.Drawing.Color.Red;
            this.btnA.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnA.Location = new System.Drawing.Point(249, 281);
            this.btnA.Name = "btnA";
            this.btnA.Size = new System.Drawing.Size(75, 45);
            this.btnA.TabIndex = 15;
            this.btnA.Text = "off";
            this.btnA.UseVisualStyleBackColor = false;
            this.btnA.Click += new System.EventHandler(this.btnA_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(961, 343);
            this.Controls.Add(this.btnA);
            this.Controls.Add(this.txbMinutes);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.txbHour);
            this.Controls.Add(this.lblClockSeconds);
            this.Controls.Add(this.lblClockMinutes);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblClockHours);
            this.Name = "MainForm";
            this.Text = "Alarm Clock";
            this.Load += new System.EventHandler(this.MainForm_Load_1);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Label label1;
        private System.Windows.Forms.Timer timerClock;
        private Label label2;
        private Label lblClockHours;
        private Label lblClockMinutes;
        private Label lblClockSeconds;
        private TextBox txbHour;
        private TextBox textBox1;
        private TextBox txbMinutes;
        private Button btnA;
    }
}