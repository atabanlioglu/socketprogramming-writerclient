namespace WriterClient_Computer
{
    partial class WriterClient_Computer
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
            this.btnDurdur = new System.Windows.Forms.Button();
            this.btnBasla = new System.Windows.Forms.Button();
            this.txt_Port = new System.Windows.Forms.TextBox();
            this.performanceCpu = new System.Diagnostics.PerformanceCounter();
            this.performanceRam = new System.Diagnostics.PerformanceCounter();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtIpAdresi = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.performanceCpu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.performanceRam)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(149, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "Port Numarası";
            // 
            // btnDurdur
            // 
            this.btnDurdur.Location = new System.Drawing.Point(152, 99);
            this.btnDurdur.Name = "btnDurdur";
            this.btnDurdur.Size = new System.Drawing.Size(141, 79);
            this.btnDurdur.TabIndex = 10;
            this.btnDurdur.Text = "Durdur";
            this.btnDurdur.UseVisualStyleBackColor = true;
            this.btnDurdur.Click += new System.EventHandler(this.btnDurdur_Click);
            // 
            // btnBasla
            // 
            this.btnBasla.Location = new System.Drawing.Point(17, 99);
            this.btnBasla.Name = "btnBasla";
            this.btnBasla.Size = new System.Drawing.Size(129, 79);
            this.btnBasla.TabIndex = 9;
            this.btnBasla.Text = "Gönder";
            this.btnBasla.UseVisualStyleBackColor = true;
            this.btnBasla.Click += new System.EventHandler(this.btnBasla_Click);
            // 
            // txt_Port
            // 
            this.txt_Port.Location = new System.Drawing.Point(152, 57);
            this.txt_Port.Name = "txt_Port";
            this.txt_Port.Size = new System.Drawing.Size(129, 20);
            this.txt_Port.TabIndex = 8;
            // 
            // performanceCpu
            // 
            this.performanceCpu.CategoryName = "Processor Information";
            this.performanceCpu.CounterName = "% Processor Time";
            this.performanceCpu.InstanceName = "_Total";
            // 
            // performanceRam
            // 
            this.performanceRam.CategoryName = "Memory";
            this.performanceRam.CounterName = "Available MBytes";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.groupBox1.Controls.Add(this.txtIpAdresi);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.btnDurdur);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txt_Port);
            this.groupBox1.Controls.Add(this.btnBasla);
            this.groupBox1.Location = new System.Drawing.Point(12, 14);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(302, 184);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Writer Client";
            // 
            // txtIpAdresi
            // 
            this.txtIpAdresi.Location = new System.Drawing.Point(15, 57);
            this.txtIpAdresi.Name = "txtIpAdresi";
            this.txtIpAdresi.Size = new System.Drawing.Size(131, 20);
            this.txtIpAdresi.TabIndex = 13;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "İp Adresi";
            // 
            // WriterClient_Computer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(328, 210);
            this.Controls.Add(this.groupBox1);
            this.Name = "WriterClient_Computer";
            this.Text = "WriterClient_Computer";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.performanceCpu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.performanceRam)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnDurdur;
        private System.Windows.Forms.Button btnBasla;
        private System.Windows.Forms.TextBox txt_Port;
        private System.Diagnostics.PerformanceCounter performanceCpu;
        private System.Diagnostics.PerformanceCounter performanceRam;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtIpAdresi;
        private System.Windows.Forms.Label label2;

    }
}

