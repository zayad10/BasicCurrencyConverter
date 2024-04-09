namespace Simple_Currency_Converter
{
    partial class Form1
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
            convertButton = new Button();
            titleLabel = new Label();
            fromCurrencyBox = new ComboBox();
            toCurrencyBox = new ComboBox();
            fromLabel = new Label();
            toLabel = new Label();
            amountLabel = new Label();
            amountInput = new TextBox();
            conversionRateLabel = new Label();
            convertedAmountLabel = new Label();
            SuspendLayout();
            // 
            // convertButton
            // 
            convertButton.BackColor = SystemColors.ScrollBar;
            convertButton.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            convertButton.ForeColor = SystemColors.WindowText;
            convertButton.Location = new Point(261, 350);
            convertButton.Name = "convertButton";
            convertButton.Size = new Size(268, 48);
            convertButton.TabIndex = 0;
            convertButton.Text = "Convert";
            convertButton.UseVisualStyleBackColor = false;
            convertButton.Click += convertButton_Click;
            // 
            // titleLabel
            // 
            titleLabel.AutoSize = true;
            titleLabel.Font = new Font("Segoe UI", 24.75F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, 0);
            titleLabel.Location = new Point(198, 9);
            titleLabel.Name = "titleLabel";
            titleLabel.Size = new Size(437, 45);
            titleLabel.TabIndex = 1;
            titleLabel.Text = "Simple Currency Converter";
            titleLabel.TextAlign = ContentAlignment.TopCenter;
            // 
            // fromCurrencyBox
            // 
            fromCurrencyBox.FormattingEnabled = true;
            fromCurrencyBox.Items.AddRange(new object[] { "GBP", "EUR", "USD", "BTC", "ETH", "LTC" });
            fromCurrencyBox.Location = new Point(179, 205);
            fromCurrencyBox.Name = "fromCurrencyBox";
            fromCurrencyBox.Size = new Size(181, 23);
            fromCurrencyBox.TabIndex = 2;
            fromCurrencyBox.SelectedIndexChanged += fromCurrencyBox_SelectedIndexChanged;
            // 
            // toCurrencyBox
            // 
            toCurrencyBox.FormattingEnabled = true;
            toCurrencyBox.Items.AddRange(new object[] { "GBP", "EUR", "USD", "BTC", "ETH", "LTC" });
            toCurrencyBox.Location = new Point(446, 205);
            toCurrencyBox.Name = "toCurrencyBox";
            toCurrencyBox.Size = new Size(181, 23);
            toCurrencyBox.TabIndex = 3;
            // 
            // fromLabel
            // 
            fromLabel.AutoSize = true;
            fromLabel.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            fromLabel.Location = new Point(198, 177);
            fromLabel.Name = "fromLabel";
            fromLabel.Size = new Size(139, 25);
            fromLabel.TabIndex = 4;
            fromLabel.Text = "From Currency";
            // 
            // toLabel
            // 
            toLabel.AutoSize = true;
            toLabel.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            toLabel.Location = new Point(481, 177);
            toLabel.Name = "toLabel";
            toLabel.Size = new Size(113, 25);
            toLabel.TabIndex = 5;
            toLabel.Text = "To Currency";
            // 
            // amountLabel
            // 
            amountLabel.AutoSize = true;
            amountLabel.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            amountLabel.Location = new Point(198, 283);
            amountLabel.Name = "amountLabel";
            amountLabel.Size = new Size(185, 25);
            amountLabel.TabIndex = 6;
            amountLabel.Text = "Amount To Convert:";
            // 
            // amountInput
            // 
            amountInput.Location = new Point(382, 285);
            amountInput.Name = "amountInput";
            amountInput.Size = new Size(147, 23);
            amountInput.TabIndex = 7;
            amountInput.WordWrap = false;
            // 
            // conversionRateLabel
            // 
            conversionRateLabel.AutoSize = true;
            conversionRateLabel.Font = new Font("Segoe UI Semibold", 15F, FontStyle.Bold, GraphicsUnit.Point, 0);
            conversionRateLabel.Location = new Point(261, 86);
            conversionRateLabel.Name = "conversionRateLabel";
            conversionRateLabel.Size = new Size(243, 28);
            conversionRateLabel.TabIndex = 8;
            conversionRateLabel.Text = "Conversion Rate: £1 = ???";
            // 
            // convertedAmountLabel
            // 
            convertedAmountLabel.AutoSize = true;
            convertedAmountLabel.Font = new Font("Segoe UI Semibold", 15F, FontStyle.Bold, GraphicsUnit.Point, 0);
            convertedAmountLabel.Location = new Point(261, 129);
            convertedAmountLabel.Name = "convertedAmountLabel";
            convertedAmountLabel.Size = new Size(225, 28);
            convertedAmountLabel.TabIndex = 9;
            convertedAmountLabel.Text = "Converted Amount: ???";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(convertedAmountLabel);
            Controls.Add(conversionRateLabel);
            Controls.Add(amountInput);
            Controls.Add(amountLabel);
            Controls.Add(toLabel);
            Controls.Add(fromLabel);
            Controls.Add(toCurrencyBox);
            Controls.Add(fromCurrencyBox);
            Controls.Add(titleLabel);
            Controls.Add(convertButton);
            Name = "Form1";
            Text = "Simple Currency Converter";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button convertButton;
        private Label titleLabel;
        private ComboBox fromCurrencyBox;
        private ComboBox toCurrencyBox;
        private Label fromLabel;
        private Label toLabel;
        private Label amountLabel;
        private TextBox amountInput;
        private Label conversionRateLabel;
        private Label convertedAmountLabel;
    }
}
