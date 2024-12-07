namespace Budget_Calculator
{
    partial class budgetCalculator
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
            inputBox = new TextBox();
            monthlyBudget = new TextBox();
            annualBudget = new TextBox();
            calculateButton = new Button();
            incomeButton = new RadioButton();
            expenseButton = new RadioButton();
            occuringMonthly = new CheckBox();
            budgetSettings = new GroupBox();
            groupBox1 = new GroupBox();
            label9 = new Label();
            label8 = new Label();
            expenseSubtotalBox = new TextBox();
            incomeSubtotalBox = new TextBox();
            expenseDisplay = new Button();
            incomeDisplay = new Button();
            label7 = new Label();
            label6 = new Label();
            exitButton = new Button();
            clearButton = new Button();
            label3 = new Label();
            label2 = new Label();
            label4 = new Label();
            lastInputBox = new TextBox();
            label1 = new Label();
            addInput = new Button();
            label5 = new Label();
            descBox = new TextBox();
            lastInputDescBox = new TextBox();
            budgetSettings.SuspendLayout();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // inputBox
            // 
            inputBox.Location = new Point(29, 33);
            inputBox.Name = "inputBox";
            inputBox.Size = new Size(170, 23);
            inputBox.TabIndex = 0;
            // 
            // monthlyBudget
            // 
            monthlyBudget.Location = new Point(285, 53);
            monthlyBudget.Name = "monthlyBudget";
            monthlyBudget.ReadOnly = true;
            monthlyBudget.Size = new Size(100, 23);
            monthlyBudget.TabIndex = 1;
            // 
            // annualBudget
            // 
            annualBudget.Location = new Point(285, 97);
            annualBudget.Name = "annualBudget";
            annualBudget.ReadOnly = true;
            annualBudget.Size = new Size(100, 23);
            annualBudget.TabIndex = 2;
            // 
            // calculateButton
            // 
            calculateButton.Location = new Point(11, 153);
            calculateButton.Name = "calculateButton";
            calculateButton.Size = new Size(89, 32);
            calculateButton.TabIndex = 3;
            calculateButton.Text = "Calculate";
            calculateButton.UseVisualStyleBackColor = true;
            calculateButton.Click += calculateButton_Click;
            // 
            // incomeButton
            // 
            incomeButton.AutoSize = true;
            incomeButton.Checked = true;
            incomeButton.Location = new Point(6, 22);
            incomeButton.Name = "incomeButton";
            incomeButton.Size = new Size(65, 19);
            incomeButton.TabIndex = 4;
            incomeButton.TabStop = true;
            incomeButton.Text = "Income";
            incomeButton.UseVisualStyleBackColor = true;
            incomeButton.CheckedChanged += budgetInput_CheckedChange;
            // 
            // expenseButton
            // 
            expenseButton.AutoSize = true;
            expenseButton.Location = new Point(6, 47);
            expenseButton.Name = "expenseButton";
            expenseButton.Size = new Size(68, 19);
            expenseButton.TabIndex = 5;
            expenseButton.TabStop = true;
            expenseButton.Text = "Expense";
            expenseButton.UseVisualStyleBackColor = true;
            expenseButton.CheckedChanged += budgetInput_CheckedChange;
            // 
            // occuringMonthly
            // 
            occuringMonthly.AutoSize = true;
            occuringMonthly.Location = new Point(97, 23);
            occuringMonthly.Name = "occuringMonthly";
            occuringMonthly.Size = new Size(86, 19);
            occuringMonthly.TabIndex = 6;
            occuringMonthly.Text = "Reoccuring";
            occuringMonthly.UseVisualStyleBackColor = true;
            // 
            // budgetSettings
            // 
            budgetSettings.Controls.Add(incomeButton);
            budgetSettings.Controls.Add(occuringMonthly);
            budgetSettings.Controls.Add(expenseButton);
            budgetSettings.Location = new Point(217, 12);
            budgetSettings.Name = "budgetSettings";
            budgetSettings.Size = new Size(197, 100);
            budgetSettings.TabIndex = 7;
            budgetSettings.TabStop = false;
            budgetSettings.Text = "Budget Settings";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label9);
            groupBox1.Controls.Add(label8);
            groupBox1.Controls.Add(expenseSubtotalBox);
            groupBox1.Controls.Add(incomeSubtotalBox);
            groupBox1.Controls.Add(expenseDisplay);
            groupBox1.Controls.Add(incomeDisplay);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(exitButton);
            groupBox1.Controls.Add(clearButton);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(monthlyBudget);
            groupBox1.Controls.Add(annualBudget);
            groupBox1.Controls.Add(calculateButton);
            groupBox1.Location = new Point(217, 139);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(399, 202);
            groupBox1.TabIndex = 8;
            groupBox1.TabStop = false;
            groupBox1.Text = "Budget Calculation";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(142, 78);
            label9.Name = "label9";
            label9.Size = new Size(97, 15);
            label9.TabIndex = 15;
            label9.Text = "Expense Subtotal";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(13, 78);
            label8.Name = "label8";
            label8.Size = new Size(94, 15);
            label8.TabIndex = 14;
            label8.Text = "Income Subtotal";
            // 
            // expenseSubtotalBox
            // 
            expenseSubtotalBox.Location = new Point(144, 96);
            expenseSubtotalBox.Name = "expenseSubtotalBox";
            expenseSubtotalBox.ReadOnly = true;
            expenseSubtotalBox.Size = new Size(89, 23);
            expenseSubtotalBox.TabIndex = 13;
            // 
            // incomeSubtotalBox
            // 
            incomeSubtotalBox.Location = new Point(13, 96);
            incomeSubtotalBox.Name = "incomeSubtotalBox";
            incomeSubtotalBox.ReadOnly = true;
            incomeSubtotalBox.Size = new Size(89, 23);
            incomeSubtotalBox.TabIndex = 12;
            // 
            // expenseDisplay
            // 
            expenseDisplay.Location = new Point(142, 52);
            expenseDisplay.Name = "expenseDisplay";
            expenseDisplay.Size = new Size(91, 23);
            expenseDisplay.TabIndex = 11;
            expenseDisplay.Text = "List Expenses";
            expenseDisplay.UseVisualStyleBackColor = true;
            expenseDisplay.Click += expenseDisplay_Click;
            // 
            // incomeDisplay
            // 
            incomeDisplay.Location = new Point(11, 53);
            incomeDisplay.Name = "incomeDisplay";
            incomeDisplay.Size = new Size(89, 23);
            incomeDisplay.TabIndex = 10;
            incomeDisplay.Text = "List Incomes";
            incomeDisplay.UseVisualStyleBackColor = true;
            incomeDisplay.Click += incomeDisplay_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 9F, FontStyle.Bold | FontStyle.Underline);
            label7.Location = new Point(144, 34);
            label7.Name = "label7";
            label7.Size = new Size(56, 15);
            label7.TabIndex = 9;
            label7.Text = "EXPENSE";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 9F, FontStyle.Bold | FontStyle.Underline);
            label6.Location = new Point(11, 34);
            label6.Name = "label6";
            label6.Size = new Size(53, 15);
            label6.TabIndex = 8;
            label6.Text = "INCOME";
            // 
            // exitButton
            // 
            exitButton.Location = new Point(285, 153);
            exitButton.Name = "exitButton";
            exitButton.Size = new Size(103, 32);
            exitButton.TabIndex = 7;
            exitButton.Text = "Exit";
            exitButton.UseVisualStyleBackColor = true;
            exitButton.Click += exitButton_Click;
            // 
            // clearButton
            // 
            clearButton.Location = new Point(144, 153);
            clearButton.Name = "clearButton";
            clearButton.Size = new Size(97, 32);
            clearButton.TabIndex = 6;
            clearButton.Text = "Clear";
            clearButton.UseVisualStyleBackColor = true;
            clearButton.Click += clearButton_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(285, 35);
            label3.Name = "label3";
            label3.Size = new Size(93, 15);
            label3.TabIndex = 5;
            label3.Text = "Monthly Budget";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(285, 79);
            label2.Name = "label2";
            label2.Size = new Size(86, 15);
            label2.TabIndex = 4;
            label2.Text = "Annual Budget";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(29, 155);
            label4.Name = "label4";
            label4.Size = new Size(59, 15);
            label4.TabIndex = 9;
            label4.Text = "Last Input";
            // 
            // lastInputBox
            // 
            lastInputBox.Location = new Point(29, 173);
            lastInputBox.Name = "lastInputBox";
            lastInputBox.ReadOnly = true;
            lastInputBox.Size = new Size(170, 23);
            lastInputBox.TabIndex = 8;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(29, 12);
            label1.Name = "label1";
            label1.Size = new Size(76, 15);
            label1.TabIndex = 9;
            label1.Text = "Budget Input";
            // 
            // addInput
            // 
            addInput.Location = new Point(29, 109);
            addInput.Name = "addInput";
            addInput.Size = new Size(100, 23);
            addInput.TabIndex = 10;
            addInput.Text = "Add Input";
            addInput.UseVisualStyleBackColor = true;
            addInput.Click += addInput_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(29, 59);
            label5.Name = "label5";
            label5.Size = new Size(67, 15);
            label5.TabIndex = 11;
            label5.Text = "Description";
            // 
            // descBox
            // 
            descBox.Location = new Point(29, 77);
            descBox.Name = "descBox";
            descBox.Size = new Size(170, 23);
            descBox.TabIndex = 12;
            // 
            // lastInputDescBox
            // 
            lastInputDescBox.Location = new Point(29, 202);
            lastInputDescBox.Name = "lastInputDescBox";
            lastInputDescBox.ReadOnly = true;
            lastInputDescBox.Size = new Size(170, 23);
            lastInputDescBox.TabIndex = 13;
            // 
            // budgetCalculator
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(628, 358);
            Controls.Add(lastInputDescBox);
            Controls.Add(label4);
            Controls.Add(lastInputBox);
            Controls.Add(descBox);
            Controls.Add(label5);
            Controls.Add(addInput);
            Controls.Add(label1);
            Controls.Add(groupBox1);
            Controls.Add(budgetSettings);
            Controls.Add(inputBox);
            Name = "budgetCalculator";
            Text = "Budget Calculator";
            Load += Form1_Load;
            budgetSettings.ResumeLayout(false);
            budgetSettings.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox inputBox;
        private TextBox monthlyBudget;
        private TextBox annualBudget;
        private Button calculateButton;
        private RadioButton incomeButton;
        private RadioButton expenseButton;
        private CheckBox occuringMonthly;
        private GroupBox budgetSettings;
        private GroupBox groupBox1;
        private Label label1;
        private Label label2;
        private Label label3;
        private Button clearButton;
        private Button exitButton;
        private Button addInput;
        private TextBox lastInputBox;
        private Label label4;
        private Label label5;
        private TextBox descBox;
        private TextBox lastInputDescBox;
        private Label label6;
        private Button expenseDisplay;
        private Button incomeDisplay;
        private Label label7;
        private TextBox expenseSubtotalBox;
        private TextBox incomeSubtotalBox;
        private Label label9;
        private Label label8;
    }
}
