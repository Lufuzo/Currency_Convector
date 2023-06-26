namespace Currency_Convector
{
    partial class frmCurrency
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
            this.btnConvect = new System.Windows.Forms.Button();
            this.lstvCurrrency = new System.Windows.Forms.ListView();
            this.txtCurrencyAmount = new System.Windows.Forms.TextBox();
            this.txtCurrency = new System.Windows.Forms.TextBox();
            this.txtConvectedAmount = new System.Windows.Forms.TextBox();
            this.lblCurrencyAmount = new System.Windows.Forms.Label();
            this.lblCurrency = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.gbxLatestCurrencies = new System.Windows.Forms.GroupBox();
            this.gbxCalculations = new System.Windows.Forms.GroupBox();
            this.txtAmountToConvect = new System.Windows.Forms.TextBox();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.Currency_Symbol = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Currency_Value = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lblError = new System.Windows.Forms.Label();
            this.gbxLatestCurrencies.SuspendLayout();
            this.gbxCalculations.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnConvect
            // 
            this.btnConvect.Location = new System.Drawing.Point(22, 87);
            this.btnConvect.Name = "btnConvect";
            this.btnConvect.Size = new System.Drawing.Size(75, 23);
            this.btnConvect.TabIndex = 1;
            this.btnConvect.Text = "Convert";
            this.btnConvect.UseVisualStyleBackColor = true;
            this.btnConvect.Click += new System.EventHandler(this.btnConvect_Click);
            // 
            // lstvCurrrency
            // 
            this.lstvCurrrency.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Currency_Symbol,
            this.Currency_Value});
            this.lstvCurrrency.HideSelection = false;
            this.lstvCurrrency.Location = new System.Drawing.Point(540, 12);
            this.lstvCurrrency.Name = "lstvCurrrency";
            this.lstvCurrrency.Size = new System.Drawing.Size(248, 386);
            this.lstvCurrrency.TabIndex = 2;
            this.lstvCurrrency.UseCompatibleStateImageBehavior = false;
            this.lstvCurrrency.SelectedIndexChanged += new System.EventHandler(this.lstvCurrrency_SelectedIndexChanged);
            // 
            // txtCurrencyAmount
            // 
            this.txtCurrencyAmount.Location = new System.Drawing.Point(140, 43);
            this.txtCurrencyAmount.Name = "txtCurrencyAmount";
            this.txtCurrencyAmount.ReadOnly = true;
            this.txtCurrencyAmount.Size = new System.Drawing.Size(196, 20);
            this.txtCurrencyAmount.TabIndex = 3;
            // 
            // txtCurrency
            // 
            this.txtCurrency.Location = new System.Drawing.Point(140, 105);
            this.txtCurrency.Name = "txtCurrency";
            this.txtCurrency.ReadOnly = true;
            this.txtCurrency.Size = new System.Drawing.Size(196, 20);
            this.txtCurrency.TabIndex = 4;
            // 
            // txtConvectedAmount
            // 
            this.txtConvectedAmount.Location = new System.Drawing.Point(133, 90);
            this.txtConvectedAmount.Name = "txtConvectedAmount";
            this.txtConvectedAmount.ReadOnly = true;
            this.txtConvectedAmount.Size = new System.Drawing.Size(196, 20);
            this.txtConvectedAmount.TabIndex = 5;
            // 
            // lblCurrencyAmount
            // 
            this.lblCurrencyAmount.AutoSize = true;
            this.lblCurrencyAmount.Location = new System.Drawing.Point(16, 46);
            this.lblCurrencyAmount.Name = "lblCurrencyAmount";
            this.lblCurrencyAmount.Size = new System.Drawing.Size(88, 13);
            this.lblCurrencyAmount.TabIndex = 6;
            this.lblCurrencyAmount.Text = "Currency Amount";
            // 
            // lblCurrency
            // 
            this.lblCurrency.AutoSize = true;
            this.lblCurrency.Location = new System.Drawing.Point(16, 112);
            this.lblCurrency.Name = "lblCurrency";
            this.lblCurrency.Size = new System.Drawing.Size(49, 13);
            this.lblCurrency.TabIndex = 7;
            this.lblCurrency.Text = "Currency";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Amount to Convect";
            // 
            // gbxLatestCurrencies
            // 
            this.gbxLatestCurrencies.Controls.Add(this.lblCurrencyAmount);
            this.gbxLatestCurrencies.Controls.Add(this.txtCurrencyAmount);
            this.gbxLatestCurrencies.Controls.Add(this.lblCurrency);
            this.gbxLatestCurrencies.Controls.Add(this.txtCurrency);
            this.gbxLatestCurrencies.Location = new System.Drawing.Point(48, 12);
            this.gbxLatestCurrencies.Name = "gbxLatestCurrencies";
            this.gbxLatestCurrencies.Size = new System.Drawing.Size(380, 203);
            this.gbxLatestCurrencies.TabIndex = 9;
            this.gbxLatestCurrencies.TabStop = false;
            this.gbxLatestCurrencies.Text = "Latest Currencies";
            // 
            // gbxCalculations
            // 
            this.gbxCalculations.Controls.Add(this.txtAmountToConvect);
            this.gbxCalculations.Controls.Add(this.label1);
            this.gbxCalculations.Controls.Add(this.txtConvectedAmount);
            this.gbxCalculations.Controls.Add(this.btnConvect);
            this.gbxCalculations.Location = new System.Drawing.Point(55, 221);
            this.gbxCalculations.Name = "gbxCalculations";
            this.gbxCalculations.Size = new System.Drawing.Size(373, 165);
            this.gbxCalculations.TabIndex = 10;
            this.gbxCalculations.TabStop = false;
            this.gbxCalculations.Text = "Calculation";
            // 
            // txtAmountToConvect
            // 
            this.txtAmountToConvect.Location = new System.Drawing.Point(133, 32);
            this.txtAmountToConvect.Name = "txtAmountToConvect";
            this.txtAmountToConvect.Size = new System.Drawing.Size(196, 20);
            this.txtAmountToConvect.TabIndex = 9;
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(112, 402);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 36);
            this.btnExit.TabIndex = 11;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(309, 402);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 36);
            this.btnClear.TabIndex = 12;
            this.btnClear.Text = "&Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // Currency_Symbol
            // 
            this.Currency_Symbol.Text = "Currency Symbol";
            this.Currency_Symbol.Width = 100;
            // 
            // Currency_Value
            // 
            this.Currency_Value.Text = "Currency Value";
            this.Currency_Value.Width = 100;
            // 
            // lblError
            // 
            this.lblError.AutoSize = true;
            this.lblError.Location = new System.Drawing.Point(511, 425);
            this.lblError.Name = "lblError";
            this.lblError.Size = new System.Drawing.Size(0, 13);
            this.lblError.TabIndex = 13;
            this.lblError.Visible = false;
            // 
            // frmCurrency
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblError);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.gbxCalculations);
            this.Controls.Add(this.gbxLatestCurrencies);
            this.Controls.Add(this.lstvCurrrency);
            this.Name = "frmCurrency";
            this.Text = "Currency Form";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.gbxLatestCurrencies.ResumeLayout(false);
            this.gbxLatestCurrencies.PerformLayout();
            this.gbxCalculations.ResumeLayout(false);
            this.gbxCalculations.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnConvect;
        private System.Windows.Forms.ListView lstvCurrrency;
        private System.Windows.Forms.TextBox txtCurrencyAmount;
        private System.Windows.Forms.TextBox txtCurrency;
        private System.Windows.Forms.TextBox txtConvectedAmount;
        private System.Windows.Forms.Label lblCurrencyAmount;
        private System.Windows.Forms.Label lblCurrency;
        private System.Windows.Forms.ColumnHeader Currency_Symbol;
        private System.Windows.Forms.ColumnHeader Currency_Value;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox gbxLatestCurrencies;
        private System.Windows.Forms.GroupBox gbxCalculations;
        private System.Windows.Forms.TextBox txtAmountToConvect;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Label lblError;
    }
}

