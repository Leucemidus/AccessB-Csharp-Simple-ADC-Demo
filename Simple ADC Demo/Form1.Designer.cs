namespace Simple_ADC_Demo
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
            this.btnADCconfig = new System.Windows.Forms.Button();
            this.btnADCOn = new System.Windows.Forms.Button();
            this.btnADCOff = new System.Windows.Forms.Button();
            this.btnSample = new System.Windows.Forms.Button();
            this.btnFindDev = new System.Windows.Forms.Button();
            this.lblStatus = new System.Windows.Forms.Label();
            this.txbSampleVal = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbChannel = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // btnADCconfig
            // 
            this.btnADCconfig.Enabled = false;
            this.btnADCconfig.Location = new System.Drawing.Point(12, 62);
            this.btnADCconfig.Name = "btnADCconfig";
            this.btnADCconfig.Size = new System.Drawing.Size(134, 35);
            this.btnADCconfig.TabIndex = 0;
            this.btnADCconfig.Text = "Configure ADC";
            this.btnADCconfig.UseVisualStyleBackColor = true;
            this.btnADCconfig.Click += new System.EventHandler(this.btnADCconfig_Click);
            // 
            // btnADCOn
            // 
            this.btnADCOn.Enabled = false;
            this.btnADCOn.Location = new System.Drawing.Point(162, 21);
            this.btnADCOn.Name = "btnADCOn";
            this.btnADCOn.Size = new System.Drawing.Size(134, 35);
            this.btnADCOn.TabIndex = 0;
            this.btnADCOn.Text = "ADC On";
            this.btnADCOn.UseVisualStyleBackColor = true;
            this.btnADCOn.Click += new System.EventHandler(this.btnADCOn_Click);
            // 
            // btnADCOff
            // 
            this.btnADCOff.Enabled = false;
            this.btnADCOff.Location = new System.Drawing.Point(162, 62);
            this.btnADCOff.Name = "btnADCOff";
            this.btnADCOff.Size = new System.Drawing.Size(134, 35);
            this.btnADCOff.TabIndex = 0;
            this.btnADCOff.Text = "ADC Off";
            this.btnADCOff.UseVisualStyleBackColor = true;
            this.btnADCOff.Click += new System.EventHandler(this.btnADCOff_Click);
            // 
            // btnSample
            // 
            this.btnSample.Enabled = false;
            this.btnSample.Location = new System.Drawing.Point(12, 122);
            this.btnSample.Name = "btnSample";
            this.btnSample.Size = new System.Drawing.Size(134, 35);
            this.btnSample.TabIndex = 0;
            this.btnSample.Text = "Sample";
            this.btnSample.UseVisualStyleBackColor = true;
            this.btnSample.Click += new System.EventHandler(this.btnSample_Click);
            // 
            // btnFindDev
            // 
            this.btnFindDev.Location = new System.Drawing.Point(12, 21);
            this.btnFindDev.Name = "btnFindDev";
            this.btnFindDev.Size = new System.Drawing.Size(134, 35);
            this.btnFindDev.TabIndex = 0;
            this.btnFindDev.Text = "Find Device";
            this.btnFindDev.UseVisualStyleBackColor = true;
            this.btnFindDev.Click += new System.EventHandler(this.btnFindDev_Click);
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Location = new System.Drawing.Point(27, 5);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(109, 13);
            this.lblStatus.TabIndex = 1;
            this.lblStatus.Text = "Status: Disconnected";
            // 
            // txbSampleVal
            // 
            this.txbSampleVal.Location = new System.Drawing.Point(239, 122);
            this.txbSampleVal.Name = "txbSampleVal";
            this.txbSampleVal.Size = new System.Drawing.Size(35, 20);
            this.txbSampleVal.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(159, 152);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "ADC Channel:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(171, 122);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "ADC Value:";
            // 
            // cmbChannel
            // 
            this.cmbChannel.FormattingEnabled = true;
            this.cmbChannel.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.cmbChannel.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3",
            "4",
            "8",
            "9",
            "10",
            "11",
            "12"});
            this.cmbChannel.Location = new System.Drawing.Point(239, 152);
            this.cmbChannel.Name = "cmbChannel";
            this.cmbChannel.Size = new System.Drawing.Size(50, 21);
            this.cmbChannel.TabIndex = 3;
            this.cmbChannel.KeyUp += new System.Windows.Forms.KeyEventHandler(this.cmbChannelBorrar_KeyUp);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(325, 189);
            this.Controls.Add(this.cmbChannel);
            this.Controls.Add(this.txbSampleVal);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.btnSample);
            this.Controls.Add(this.btnADCOff);
            this.Controls.Add(this.btnADCOn);
            this.Controls.Add(this.btnFindDev);
            this.Controls.Add(this.btnADCconfig);
            this.Name = "Form1";
            this.Text = "Simple ADC Demo";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnADCconfig;
        private System.Windows.Forms.Button btnADCOn;
        private System.Windows.Forms.Button btnADCOff;
        private System.Windows.Forms.Button btnSample;
        private System.Windows.Forms.Button btnFindDev;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.TextBox txbSampleVal;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbChannel;
    }
}

