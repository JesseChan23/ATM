namespace ATM
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.Title = new System.Windows.Forms.RichTextBox();
            this.DisplayInstruction = new System.Windows.Forms.RichTextBox();
            this.DisplayInput = new System.Windows.Forms.RichTextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button0 = new System.Windows.Forms.Button();
            this.CancelButton = new System.Windows.Forms.Button();
            this.ClearButton = new System.Windows.Forms.Button();
            this.EnterButton = new System.Windows.Forms.Button();
            this.numberPanel = new System.Windows.Forms.Panel();
            this.accountPanel = new System.Windows.Forms.Panel();
            this.exitButton = new System.Windows.Forms.Button();
            this.withdrawButton = new System.Windows.Forms.Button();
            this.balanceButton = new System.Windows.Forms.Button();
            this.panelWithdraw = new System.Windows.Forms.Panel();
            this.BackButton = new System.Windows.Forms.Button();
            this.WithdrawCustom = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.button10 = new System.Windows.Forms.Button();
            this.Withdraw50 = new System.Windows.Forms.Button();
            this.Withdraw25 = new System.Windows.Forms.Button();
            this.Withdraw10 = new System.Windows.Forms.Button();
            this.numberPanel.SuspendLayout();
            this.accountPanel.SuspendLayout();
            this.panelWithdraw.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // Title
            // 
            this.Title.Font = new System.Drawing.Font("Courier New", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Title.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.Title.Location = new System.Drawing.Point(121, 12);
            this.Title.Name = "Title";
            this.Title.ReadOnly = true;
            this.Title.Size = new System.Drawing.Size(540, 45);
            this.Title.TabIndex = 0;
            this.Title.Text = "Welcome to ATM MACHINE";
            // 
            // DisplayInstruction
            // 
            this.DisplayInstruction.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.DisplayInstruction.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.DisplayInstruction.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DisplayInstruction.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.DisplayInstruction.Location = new System.Drawing.Point(167, 63);
            this.DisplayInstruction.Name = "DisplayInstruction";
            this.DisplayInstruction.ReadOnly = true;
            this.DisplayInstruction.Size = new System.Drawing.Size(454, 25);
            this.DisplayInstruction.TabIndex = 1;
            this.DisplayInstruction.Text = "Please enter your Account number";
            // 
            // DisplayInput
            // 
            this.DisplayInput.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.DisplayInput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.DisplayInput.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DisplayInput.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.DisplayInput.Location = new System.Drawing.Point(315, 94);
            this.DisplayInput.MaxLength = 6;
            this.DisplayInput.Name = "DisplayInput";
            this.DisplayInput.ReadOnly = true;
            this.DisplayInput.Size = new System.Drawing.Size(150, 25);
            this.DisplayInput.TabIndex = 2;
            this.DisplayInput.Text = "";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(50, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(45, 45);
            this.button1.TabIndex = 3;
            this.button1.Text = "1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(101, 3);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(45, 45);
            this.button2.TabIndex = 4;
            this.button2.Text = "2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(152, 3);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(45, 45);
            this.button3.TabIndex = 5;
            this.button3.Text = "3";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Location = new System.Drawing.Point(50, 52);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(45, 45);
            this.button4.TabIndex = 6;
            this.button4.Text = "4";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.Location = new System.Drawing.Point(101, 52);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(45, 45);
            this.button5.TabIndex = 7;
            this.button5.Text = "5";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button6
            // 
            this.button6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button6.Location = new System.Drawing.Point(152, 52);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(45, 45);
            this.button6.TabIndex = 8;
            this.button6.Text = "6";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button7
            // 
            this.button7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button7.Location = new System.Drawing.Point(50, 103);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(45, 45);
            this.button7.TabIndex = 9;
            this.button7.Text = "7";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // button8
            // 
            this.button8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button8.Location = new System.Drawing.Point(102, 103);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(45, 45);
            this.button8.TabIndex = 10;
            this.button8.Text = "8";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // button9
            // 
            this.button9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button9.Location = new System.Drawing.Point(152, 103);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(45, 45);
            this.button9.TabIndex = 11;
            this.button9.Text = "9";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.button9_Click);
            // 
            // button0
            // 
            this.button0.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button0.Location = new System.Drawing.Point(101, 154);
            this.button0.Name = "button0";
            this.button0.Size = new System.Drawing.Size(45, 45);
            this.button0.TabIndex = 12;
            this.button0.Text = "0";
            this.button0.UseVisualStyleBackColor = true;
            this.button0.Click += new System.EventHandler(this.button0_Click);
            // 
            // CancelButton
            // 
            this.CancelButton.BackColor = System.Drawing.Color.Red;
            this.CancelButton.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CancelButton.Location = new System.Drawing.Point(253, 3);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(110, 45);
            this.CancelButton.TabIndex = 13;
            this.CancelButton.Text = "Cancel";
            this.CancelButton.UseVisualStyleBackColor = false;
            this.CancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // ClearButton
            // 
            this.ClearButton.BackColor = System.Drawing.Color.Yellow;
            this.ClearButton.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ClearButton.Location = new System.Drawing.Point(253, 54);
            this.ClearButton.Name = "ClearButton";
            this.ClearButton.Size = new System.Drawing.Size(110, 45);
            this.ClearButton.TabIndex = 14;
            this.ClearButton.Text = "Clear";
            this.ClearButton.UseVisualStyleBackColor = false;
            this.ClearButton.Click += new System.EventHandler(this.ClearButton_Click);
            // 
            // EnterButton
            // 
            this.EnterButton.BackColor = System.Drawing.Color.Lime;
            this.EnterButton.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EnterButton.Location = new System.Drawing.Point(253, 103);
            this.EnterButton.Name = "EnterButton";
            this.EnterButton.Size = new System.Drawing.Size(110, 45);
            this.EnterButton.TabIndex = 15;
            this.EnterButton.Text = "Enter";
            this.EnterButton.UseVisualStyleBackColor = false;
            this.EnterButton.Click += new System.EventHandler(this.EnterButton_Click);
            // 
            // numberPanel
            // 
            this.numberPanel.BackColor = System.Drawing.Color.Transparent;
            this.numberPanel.Controls.Add(this.button1);
            this.numberPanel.Controls.Add(this.EnterButton);
            this.numberPanel.Controls.Add(this.button2);
            this.numberPanel.Controls.Add(this.ClearButton);
            this.numberPanel.Controls.Add(this.button3);
            this.numberPanel.Controls.Add(this.CancelButton);
            this.numberPanel.Controls.Add(this.button4);
            this.numberPanel.Controls.Add(this.button0);
            this.numberPanel.Controls.Add(this.button5);
            this.numberPanel.Controls.Add(this.button9);
            this.numberPanel.Controls.Add(this.button6);
            this.numberPanel.Controls.Add(this.button8);
            this.numberPanel.Controls.Add(this.button7);
            this.numberPanel.Location = new System.Drawing.Point(198, 125);
            this.numberPanel.Name = "numberPanel";
            this.numberPanel.Size = new System.Drawing.Size(366, 250);
            this.numberPanel.TabIndex = 16;
            // 
            // accountPanel
            // 
            this.accountPanel.BackColor = System.Drawing.Color.Transparent;
            this.accountPanel.Controls.Add(this.exitButton);
            this.accountPanel.Controls.Add(this.withdrawButton);
            this.accountPanel.Controls.Add(this.balanceButton);
            this.accountPanel.Location = new System.Drawing.Point(189, 124);
            this.accountPanel.Name = "accountPanel";
            this.accountPanel.Size = new System.Drawing.Size(375, 262);
            this.accountPanel.TabIndex = 18;
            this.accountPanel.Visible = false;
            // 
            // exitButton
            // 
            this.exitButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitButton.Location = new System.Drawing.Point(37, 153);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(291, 43);
            this.exitButton.TabIndex = 2;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // withdrawButton
            // 
            this.withdrawButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.withdrawButton.Location = new System.Drawing.Point(38, 100);
            this.withdrawButton.Name = "withdrawButton";
            this.withdrawButton.Size = new System.Drawing.Size(291, 43);
            this.withdrawButton.TabIndex = 1;
            this.withdrawButton.Text = "Withdraw";
            this.withdrawButton.UseVisualStyleBackColor = true;
            this.withdrawButton.Click += new System.EventHandler(this.withdrawButton_Click);
            // 
            // balanceButton
            // 
            this.balanceButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.balanceButton.Location = new System.Drawing.Point(38, 49);
            this.balanceButton.Name = "balanceButton";
            this.balanceButton.Size = new System.Drawing.Size(291, 43);
            this.balanceButton.TabIndex = 0;
            this.balanceButton.Text = "Check Balance";
            this.balanceButton.UseVisualStyleBackColor = true;
            this.balanceButton.Click += new System.EventHandler(this.button10_Click);
            // 
            // panelWithdraw
            // 
            this.panelWithdraw.BackColor = System.Drawing.Color.Transparent;
            this.panelWithdraw.Controls.Add(this.BackButton);
            this.panelWithdraw.Controls.Add(this.WithdrawCustom);
            this.panelWithdraw.Controls.Add(this.panel3);
            this.panelWithdraw.Controls.Add(this.Withdraw50);
            this.panelWithdraw.Controls.Add(this.Withdraw25);
            this.panelWithdraw.Controls.Add(this.Withdraw10);
            this.panelWithdraw.Location = new System.Drawing.Point(189, 124);
            this.panelWithdraw.Name = "panelWithdraw";
            this.panelWithdraw.Size = new System.Drawing.Size(375, 262);
            this.panelWithdraw.TabIndex = 19;
            this.panelWithdraw.Visible = false;
            // 
            // BackButton
            // 
            this.BackButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BackButton.Location = new System.Drawing.Point(102, 215);
            this.BackButton.Name = "BackButton";
            this.BackButton.Size = new System.Drawing.Size(150, 43);
            this.BackButton.TabIndex = 21;
            this.BackButton.Text = "Cancel";
            this.BackButton.UseVisualStyleBackColor = true;
            this.BackButton.Click += new System.EventHandler(this.BackButton_Click);
            // 
            // WithdrawCustom
            // 
            this.WithdrawCustom.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WithdrawCustom.Location = new System.Drawing.Point(37, 166);
            this.WithdrawCustom.Name = "WithdrawCustom";
            this.WithdrawCustom.Size = new System.Drawing.Size(291, 43);
            this.WithdrawCustom.TabIndex = 20;
            this.WithdrawCustom.Text = "Withdraw Custom Amount";
            this.WithdrawCustom.UseVisualStyleBackColor = true;
            this.WithdrawCustom.Click += new System.EventHandler(this.WithdrawCustom_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.button10);
            this.panel3.Location = new System.Drawing.Point(372, 173);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(375, 262);
            this.panel3.TabIndex = 19;
            // 
            // button10
            // 
            this.button10.Location = new System.Drawing.Point(20, 20);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(343, 56);
            this.button10.TabIndex = 0;
            this.button10.Text = "button10";
            this.button10.UseVisualStyleBackColor = true;
            // 
            // Withdraw50
            // 
            this.Withdraw50.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Withdraw50.Location = new System.Drawing.Point(38, 117);
            this.Withdraw50.Name = "Withdraw50";
            this.Withdraw50.Size = new System.Drawing.Size(291, 43);
            this.Withdraw50.TabIndex = 2;
            this.Withdraw50.Text = "Withdraw £50";
            this.Withdraw50.UseVisualStyleBackColor = true;
            this.Withdraw50.Click += new System.EventHandler(this.Withdraw50_Click);
            // 
            // Withdraw25
            // 
            this.Withdraw25.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Withdraw25.Location = new System.Drawing.Point(38, 68);
            this.Withdraw25.Name = "Withdraw25";
            this.Withdraw25.Size = new System.Drawing.Size(291, 43);
            this.Withdraw25.TabIndex = 1;
            this.Withdraw25.Text = "Withdraw £25";
            this.Withdraw25.UseVisualStyleBackColor = true;
            this.Withdraw25.Click += new System.EventHandler(this.Withdraw25_Click);
            // 
            // Withdraw10
            // 
            this.Withdraw10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Withdraw10.Location = new System.Drawing.Point(37, 19);
            this.Withdraw10.Name = "Withdraw10";
            this.Withdraw10.Size = new System.Drawing.Size(291, 43);
            this.Withdraw10.TabIndex = 0;
            this.Withdraw10.Text = "Withdraw £10";
            this.Withdraw10.UseVisualStyleBackColor = true;
            this.Withdraw10.Click += new System.EventHandler(this.Withdraw10_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ATM.Properties.Resources.tech_background_hd_1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(839, 432);
            this.Controls.Add(this.panelWithdraw);
            this.Controls.Add(this.accountPanel);
            this.Controls.Add(this.numberPanel);
            this.Controls.Add(this.DisplayInput);
            this.Controls.Add(this.DisplayInstruction);
            this.Controls.Add(this.Title);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "ATM";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.numberPanel.ResumeLayout(false);
            this.accountPanel.ResumeLayout(false);
            this.panelWithdraw.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox Title;
        private System.Windows.Forms.RichTextBox DisplayInstruction;
        private System.Windows.Forms.RichTextBox DisplayInput;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button0;
        private System.Windows.Forms.Button CancelButton;
        private System.Windows.Forms.Button ClearButton;
        private System.Windows.Forms.Button EnterButton;
        private System.Windows.Forms.Panel numberPanel;
        private System.Windows.Forms.Panel accountPanel;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Button withdrawButton;
        private System.Windows.Forms.Button balanceButton;
        private System.Windows.Forms.Panel panelWithdraw;
        private System.Windows.Forms.Button WithdrawCustom;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Button Withdraw50;
        private System.Windows.Forms.Button Withdraw25;
        private System.Windows.Forms.Button Withdraw10;
        private System.Windows.Forms.Button BackButton;
    }
}

