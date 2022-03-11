namespace DMX2022
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
            this.cbxPorts = new System.Windows.Forms.ComboBox();
            this.cbxInterval = new System.Windows.Forms.ComboBox();
            this.tcb2 = new System.Windows.Forms.TrackBar();
            this.tcb1 = new System.Windows.Forms.TrackBar();
            this.tcb3 = new System.Windows.Forms.TrackBar();
            this.pnlColor = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblRed = new System.Windows.Forms.Label();
            this.lblBlue = new System.Windows.Forms.Label();
            this.lblGreen = new System.Windows.Forms.Label();
            this.btnReset = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.tcb2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tcb1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tcb3)).BeginInit();
            this.SuspendLayout();
            // 
            // cbxPorts
            // 
            this.cbxPorts.FormattingEnabled = true;
            this.cbxPorts.Location = new System.Drawing.Point(70, 388);
            this.cbxPorts.Name = "cbxPorts";
            this.cbxPorts.Size = new System.Drawing.Size(121, 21);
            this.cbxPorts.TabIndex = 0;
            // 
            // cbxInterval
            // 
            this.cbxInterval.FormattingEnabled = true;
            this.cbxInterval.Location = new System.Drawing.Point(294, 388);
            this.cbxInterval.Name = "cbxInterval";
            this.cbxInterval.Size = new System.Drawing.Size(121, 21);
            this.cbxInterval.TabIndex = 1;
            // 
            // tcb2
            // 
            this.tcb2.Location = new System.Drawing.Point(13, 225);
            this.tcb2.Maximum = 255;
            this.tcb2.Name = "tcb2";
            this.tcb2.Size = new System.Drawing.Size(474, 45);
            this.tcb2.TabIndex = 2;
            // 
            // tcb1
            // 
            this.tcb1.Location = new System.Drawing.Point(13, 165);
            this.tcb1.Maximum = 255;
            this.tcb1.Name = "tcb1";
            this.tcb1.Size = new System.Drawing.Size(474, 45);
            this.tcb1.TabIndex = 3;
            // 
            // tcb3
            // 
            this.tcb3.Location = new System.Drawing.Point(13, 276);
            this.tcb3.Maximum = 255;
            this.tcb3.Name = "tcb3";
            this.tcb3.Size = new System.Drawing.Size(474, 45);
            this.tcb3.TabIndex = 4;
            // 
            // pnlColor
            // 
            this.pnlColor.Location = new System.Drawing.Point(588, 12);
            this.pnlColor.Name = "pnlColor";
            this.pnlColor.Size = new System.Drawing.Size(200, 137);
            this.pnlColor.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 391);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Ports";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(544, 165);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(27, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Red";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(235, 391);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Interval";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(544, 267);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(28, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Blue";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(544, 219);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(36, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Green";
            // 
            // lblRed
            // 
            this.lblRed.AutoSize = true;
            this.lblRed.Location = new System.Drawing.Point(661, 165);
            this.lblRed.Name = "lblRed";
            this.lblRed.Size = new System.Drawing.Size(13, 13);
            this.lblRed.TabIndex = 11;
            this.lblRed.Text = "0";
            // 
            // lblBlue
            // 
            this.lblBlue.AutoSize = true;
            this.lblBlue.Location = new System.Drawing.Point(661, 267);
            this.lblBlue.Name = "lblBlue";
            this.lblBlue.Size = new System.Drawing.Size(13, 13);
            this.lblBlue.TabIndex = 12;
            this.lblBlue.Text = "0";
            // 
            // lblGreen
            // 
            this.lblGreen.AutoSize = true;
            this.lblGreen.Location = new System.Drawing.Point(661, 219);
            this.lblGreen.Name = "lblGreen";
            this.lblGreen.Size = new System.Drawing.Size(13, 13);
            this.lblGreen.TabIndex = 13;
            this.lblGreen.Text = "0";
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(713, 391);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(75, 50);
            this.btnReset.TabIndex = 14;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.lblGreen);
            this.Controls.Add(this.lblBlue);
            this.Controls.Add(this.lblRed);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pnlColor);
            this.Controls.Add(this.tcb3);
            this.Controls.Add(this.tcb1);
            this.Controls.Add(this.tcb2);
            this.Controls.Add(this.cbxInterval);
            this.Controls.Add(this.cbxPorts);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.tcb2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tcb1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tcb3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbxPorts;
        private System.Windows.Forms.ComboBox cbxInterval;
        private System.Windows.Forms.TrackBar tcb2;
        private System.Windows.Forms.TrackBar tcb1;
        private System.Windows.Forms.TrackBar tcb3;
        private System.Windows.Forms.Panel pnlColor;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblRed;
        private System.Windows.Forms.Label lblBlue;
        private System.Windows.Forms.Label lblGreen;
        private System.Windows.Forms.Button btnReset;
    }
}

