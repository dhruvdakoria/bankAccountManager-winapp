namespace lab3
{
    partial class BankAccountManager
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
            this.groupBoxCurrency = new System.Windows.Forms.GroupBox();
            this.radioButtonUS = new System.Windows.Forms.RadioButton();
            this.radioButtonCAD = new System.Windows.Forms.RadioButton();
            this.labelBalance = new System.Windows.Forms.Label();
            this.labelCurrencyBal = new System.Windows.Forms.Label();
            this.groupBoxDeposit = new System.Windows.Forms.GroupBox();
            this.buttonDeposit = new System.Windows.Forms.Button();
            this.textBoxAmtD = new System.Windows.Forms.TextBox();
            this.labelAmountD = new System.Windows.Forms.Label();
            this.buttonExit = new System.Windows.Forms.Button();
            this.groupBoxWithdraw = new System.Windows.Forms.GroupBox();
            this.buttonWithdraw = new System.Windows.Forms.Button();
            this.textBoxAmtW = new System.Windows.Forms.TextBox();
            this.labelAmtW = new System.Windows.Forms.Label();
            this.labelBalanceOut = new System.Windows.Forms.Label();
            this.groupBoxCurrency.SuspendLayout();
            this.groupBoxDeposit.SuspendLayout();
            this.groupBoxWithdraw.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxCurrency
            // 
            this.groupBoxCurrency.Controls.Add(this.radioButtonUS);
            this.groupBoxCurrency.Controls.Add(this.radioButtonCAD);
            this.groupBoxCurrency.Location = new System.Drawing.Point(28, 58);
            this.groupBoxCurrency.Name = "groupBoxCurrency";
            this.groupBoxCurrency.Size = new System.Drawing.Size(123, 92);
            this.groupBoxCurrency.TabIndex = 0;
            this.groupBoxCurrency.TabStop = false;
            this.groupBoxCurrency.Text = "Currency";
            // 
            // radioButtonUS
            // 
            this.radioButtonUS.AutoSize = true;
            this.radioButtonUS.Location = new System.Drawing.Point(19, 54);
            this.radioButtonUS.Name = "radioButtonUS";
            this.radioButtonUS.Size = new System.Drawing.Size(49, 17);
            this.radioButtonUS.TabIndex = 1;
            this.radioButtonUS.TabStop = true;
            this.radioButtonUS.Text = "$ US";
            this.radioButtonUS.UseVisualStyleBackColor = true;
            // 
            // radioButtonCAD
            // 
            this.radioButtonCAD.AutoSize = true;
            this.radioButtonCAD.Location = new System.Drawing.Point(19, 31);
            this.radioButtonCAD.Name = "radioButtonCAD";
            this.radioButtonCAD.Size = new System.Drawing.Size(56, 17);
            this.radioButtonCAD.TabIndex = 0;
            this.radioButtonCAD.TabStop = true;
            this.radioButtonCAD.Text = "$ CAD";
            this.radioButtonCAD.UseVisualStyleBackColor = true;
            // 
            // labelBalance
            // 
            this.labelBalance.AutoSize = true;
            this.labelBalance.Location = new System.Drawing.Point(35, 228);
            this.labelBalance.Name = "labelBalance";
            this.labelBalance.Size = new System.Drawing.Size(49, 13);
            this.labelBalance.TabIndex = 1;
            this.labelBalance.Text = "Balance:";
            // 
            // labelCurrencyBal
            // 
            this.labelCurrencyBal.AutoSize = true;
            this.labelCurrencyBal.Location = new System.Drawing.Point(136, 256);
            this.labelCurrencyBal.Name = "labelCurrencyBal";
            this.labelCurrencyBal.Size = new System.Drawing.Size(0, 13);
            this.labelCurrencyBal.TabIndex = 3;
            // 
            // groupBoxDeposit
            // 
            this.groupBoxDeposit.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.groupBoxDeposit.Controls.Add(this.buttonDeposit);
            this.groupBoxDeposit.Controls.Add(this.textBoxAmtD);
            this.groupBoxDeposit.Controls.Add(this.labelAmountD);
            this.groupBoxDeposit.Location = new System.Drawing.Point(233, 50);
            this.groupBoxDeposit.Name = "groupBoxDeposit";
            this.groupBoxDeposit.Size = new System.Drawing.Size(203, 124);
            this.groupBoxDeposit.TabIndex = 4;
            this.groupBoxDeposit.TabStop = false;
            this.groupBoxDeposit.Text = "Make a deposit";
            // 
            // buttonDeposit
            // 
            this.buttonDeposit.Location = new System.Drawing.Point(56, 71);
            this.buttonDeposit.Name = "buttonDeposit";
            this.buttonDeposit.Size = new System.Drawing.Size(75, 23);
            this.buttonDeposit.TabIndex = 6;
            this.buttonDeposit.Text = "Deposit";
            this.buttonDeposit.UseVisualStyleBackColor = true;
            this.buttonDeposit.Click += new System.EventHandler(this.buttonDeposit_Click);
            // 
            // textBoxAmtD
            // 
            this.textBoxAmtD.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxAmtD.Location = new System.Drawing.Point(84, 36);
            this.textBoxAmtD.Name = "textBoxAmtD";
            this.textBoxAmtD.Size = new System.Drawing.Size(100, 20);
            this.textBoxAmtD.TabIndex = 3;
            // 
            // labelAmountD
            // 
            this.labelAmountD.AutoSize = true;
            this.labelAmountD.Location = new System.Drawing.Point(18, 39);
            this.labelAmountD.Name = "labelAmountD";
            this.labelAmountD.Size = new System.Drawing.Size(46, 13);
            this.labelAmountD.TabIndex = 2;
            this.labelAmountD.Text = "Amount:";
            // 
            // buttonExit
            // 
            this.buttonExit.Location = new System.Drawing.Point(76, 303);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(75, 23);
            this.buttonExit.TabIndex = 5;
            this.buttonExit.Text = "Exit";
            this.buttonExit.UseVisualStyleBackColor = true;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // groupBoxWithdraw
            // 
            this.groupBoxWithdraw.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.groupBoxWithdraw.Controls.Add(this.buttonWithdraw);
            this.groupBoxWithdraw.Controls.Add(this.textBoxAmtW);
            this.groupBoxWithdraw.Controls.Add(this.labelAmtW);
            this.groupBoxWithdraw.Location = new System.Drawing.Point(233, 200);
            this.groupBoxWithdraw.Name = "groupBoxWithdraw";
            this.groupBoxWithdraw.Size = new System.Drawing.Size(203, 126);
            this.groupBoxWithdraw.TabIndex = 6;
            this.groupBoxWithdraw.TabStop = false;
            this.groupBoxWithdraw.Text = "Make a withdrawal";
            // 
            // buttonWithdraw
            // 
            this.buttonWithdraw.Location = new System.Drawing.Point(56, 71);
            this.buttonWithdraw.Name = "buttonWithdraw";
            this.buttonWithdraw.Size = new System.Drawing.Size(75, 23);
            this.buttonWithdraw.TabIndex = 6;
            this.buttonWithdraw.Text = "Withdraw";
            this.buttonWithdraw.UseVisualStyleBackColor = true;
            this.buttonWithdraw.Click += new System.EventHandler(this.buttonWithdraw_Click);
            // 
            // textBoxAmtW
            // 
            this.textBoxAmtW.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxAmtW.Location = new System.Drawing.Point(84, 36);
            this.textBoxAmtW.Name = "textBoxAmtW";
            this.textBoxAmtW.Size = new System.Drawing.Size(100, 20);
            this.textBoxAmtW.TabIndex = 3;
            // 
            // labelAmtW
            // 
            this.labelAmtW.AutoSize = true;
            this.labelAmtW.Location = new System.Drawing.Point(18, 39);
            this.labelAmtW.Name = "labelAmtW";
            this.labelAmtW.Size = new System.Drawing.Size(46, 13);
            this.labelAmtW.TabIndex = 2;
            this.labelAmtW.Text = "Amount:";
            // 
            // labelBalanceOut
            // 
            this.labelBalanceOut.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.labelBalanceOut.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelBalanceOut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.labelBalanceOut.Location = new System.Drawing.Point(30, 255);
            this.labelBalanceOut.Name = "labelBalanceOut";
            this.labelBalanceOut.Size = new System.Drawing.Size(100, 20);
            this.labelBalanceOut.TabIndex = 7;
            // 
            // BankAccountManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(473, 355);
            this.Controls.Add(this.labelBalanceOut);
            this.Controls.Add(this.groupBoxWithdraw);
            this.Controls.Add(this.buttonExit);
            this.Controls.Add(this.groupBoxDeposit);
            this.Controls.Add(this.labelCurrencyBal);
            this.Controls.Add(this.labelBalance);
            this.Controls.Add(this.groupBoxCurrency);
            this.Name = "BankAccountManager";
            this.Text = "Bank Account Manager";
            this.Load += new System.EventHandler(this.BankAccountManager_Load);
            this.groupBoxCurrency.ResumeLayout(false);
            this.groupBoxCurrency.PerformLayout();
            this.groupBoxDeposit.ResumeLayout(false);
            this.groupBoxDeposit.PerformLayout();
            this.groupBoxWithdraw.ResumeLayout(false);
            this.groupBoxWithdraw.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxCurrency;
        private System.Windows.Forms.RadioButton radioButtonUS;
        private System.Windows.Forms.RadioButton radioButtonCAD;
        private System.Windows.Forms.Label labelBalance;
        private System.Windows.Forms.Label labelCurrencyBal;
        private System.Windows.Forms.GroupBox groupBoxDeposit;
        private System.Windows.Forms.Button buttonDeposit;
        private System.Windows.Forms.TextBox textBoxAmtD;
        private System.Windows.Forms.Label labelAmountD;
        private System.Windows.Forms.Button buttonExit;
        private System.Windows.Forms.GroupBox groupBoxWithdraw;
        private System.Windows.Forms.Button buttonWithdraw;
        private System.Windows.Forms.TextBox textBoxAmtW;
        private System.Windows.Forms.Label labelAmtW;
        private System.Windows.Forms.Label labelBalanceOut;
    }
}

