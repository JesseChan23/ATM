namespace ATM
{
    partial class BankManager
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BankManager));
            this.btnThread = new System.Windows.Forms.Button();
            this.dataRace = new System.Windows.Forms.CheckBox();
            this.lblLog = new System.Windows.Forms.Label();
            this.txtLog = new System.Windows.Forms.RichTextBox();
            this.DataFix = new System.Windows.Forms.FlowLayoutPanel();
            this.SemaRadio = new System.Windows.Forms.RadioButton();
            this.MutexRadio = new System.Windows.Forms.RadioButton();
            this.DataFix.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnThread
            // 
            this.btnThread.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThread.Location = new System.Drawing.Point(57, 100);
            this.btnThread.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnThread.Name = "btnThread";
            this.btnThread.Size = new System.Drawing.Size(308, 69);
            this.btnThread.TabIndex = 1;
            this.btnThread.Text = "New ATM";
            this.btnThread.UseVisualStyleBackColor = true;
            this.btnThread.Click += new System.EventHandler(this.btnThread_Click);
            // 
            // dataRace
            // 
            this.dataRace.BackColor = System.Drawing.Color.Transparent;
            this.dataRace.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataRace.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.dataRace.Location = new System.Drawing.Point(57, 202);
            this.dataRace.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dataRace.Name = "dataRace";
            this.dataRace.Size = new System.Drawing.Size(261, 66);
            this.dataRace.TabIndex = 0;
            this.dataRace.Text = "Data Race";
            this.dataRace.UseVisualStyleBackColor = false;
            this.dataRace.CheckedChanged += new System.EventHandler(this.dataRace_CheckedChanged);
            // 
            // lblLog
            // 
            this.lblLog.AutoSize = true;
            this.lblLog.BackColor = System.Drawing.Color.Transparent;
            this.lblLog.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F);
            this.lblLog.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblLog.Location = new System.Drawing.Point(390, 100);
            this.lblLog.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblLog.Name = "lblLog";
            this.lblLog.Size = new System.Drawing.Size(100, 47);
            this.lblLog.TabIndex = 2;
            this.lblLog.Text = "Log:";
            // 
            // txtLog
            // 
            this.txtLog.Location = new System.Drawing.Point(482, 100);
            this.txtLog.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtLog.Name = "txtLog";
            this.txtLog.Size = new System.Drawing.Size(734, 166);
            this.txtLog.TabIndex = 3;
            this.txtLog.Text = "";
            this.txtLog.TextChanged += new System.EventHandler(this.txtLog_TextChanged);
            // 
            // DataFix
            // 
            this.DataFix.BackColor = System.Drawing.Color.Transparent;
            this.DataFix.Controls.Add(this.SemaRadio);
            this.DataFix.Controls.Add(this.MutexRadio);
            this.DataFix.Location = new System.Drawing.Point(64, 355);
            this.DataFix.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.DataFix.Name = "DataFix";
            this.DataFix.Size = new System.Drawing.Size(334, 157);
            this.DataFix.TabIndex = 4;
            // 
            // SemaRadio
            // 
            this.SemaRadio.AutoSize = true;
            this.SemaRadio.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SemaRadio.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.SemaRadio.Location = new System.Drawing.Point(4, 5);
            this.SemaRadio.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.SemaRadio.Name = "SemaRadio";
            this.SemaRadio.Size = new System.Drawing.Size(207, 41);
            this.SemaRadio.TabIndex = 0;
            this.SemaRadio.TabStop = true;
            this.SemaRadio.Text = "Semaphore";
            this.SemaRadio.UseVisualStyleBackColor = true;
            this.SemaRadio.CheckedChanged += new System.EventHandler(this.SemaRadio_CheckedChanged);
            // 
            // MutexRadio
            // 
            this.MutexRadio.AutoSize = true;
            this.MutexRadio.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MutexRadio.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.MutexRadio.Location = new System.Drawing.Point(4, 56);
            this.MutexRadio.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MutexRadio.Name = "MutexRadio";
            this.MutexRadio.Size = new System.Drawing.Size(127, 41);
            this.MutexRadio.TabIndex = 1;
            this.MutexRadio.TabStop = true;
            this.MutexRadio.Text = "Mutex";
            this.MutexRadio.UseVisualStyleBackColor = true;
            this.MutexRadio.CheckedChanged += new System.EventHandler(this.MutexRadio_CheckedChanged);
            // 
            // BankManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ATM.Properties.Resources.tech_background_hd_1;
            this.ClientSize = new System.Drawing.Size(1258, 682);
            this.Controls.Add(this.DataFix);
            this.Controls.Add(this.txtLog);
            this.Controls.Add(this.lblLog);
            this.Controls.Add(this.dataRace);
            this.Controls.Add(this.btnThread);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "BankManager";
            this.Text = "Bank Manager";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.DataFix.ResumeLayout(false);
            this.DataFix.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnThread;
        private System.Windows.Forms.CheckBox dataRace;
        private System.Windows.Forms.Label lblLog;
        private System.Windows.Forms.RichTextBox txtLog;
        private System.Windows.Forms.FlowLayoutPanel DataFix;
        private System.Windows.Forms.RadioButton SemaRadio;
        private System.Windows.Forms.RadioButton MutexRadio;
    }
}