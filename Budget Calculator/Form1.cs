namespace Budget_Calculator
{
    public partial class budgetCalculator : Form
    {
        //Various subtotals used to calculate displays
        decimal inputSubtotal = 0;
        decimal annualInputSubtotal = 0;
        decimal incomeSubtotal = 0;
        decimal expenseSubtotal = 0;
        decimal incomeReoccuringSubtotal = 0;
        decimal expenseReoccuringSubtotal = 0;
        string incomeList = ("INCOMES" + "\n");
        string expenseList = ("EXPENSES" + "\n");
        public budgetCalculator()
        {
            InitializeComponent();

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void budgetInput_CheckedChange(object sender, EventArgs e)
        {
            if (incomeButton.Checked)
            {

            }
            else if (expenseButton.Checked)
            {

            }
        }

        private void calculateBudget(object sender, EventArgs e)
        {



        }
        //method to display the montly and annual budget.
        private void calculateButton_Click(object sender, EventArgs e)
        {
            monthlyBudget.Text = "$" + (inputSubtotal + annualInputSubtotal).ToString();
            annualBudget.Text = "$" + ((annualInputSubtotal * 12) + inputSubtotal).ToString();
            incomeSubtotalBox.Text = "$" + incomeSubtotal.ToString();
            expenseSubtotalBox.Text = "$" + expenseSubtotal.ToString();

        }
        //method to reset the various values in the program
        private void clearButton_Click(object sender, EventArgs e)
        {
            inputBox.Text = "";
            inputSubtotal = 0;
            annualInputSubtotal = 0;
            monthlyBudget.Text = "";
            annualBudget.Text = "";
            lastInputBox.Text = "";
            lastInputDescBox.Text = "";
            descBox.Text = "";
            incomeSubtotal = 0;
            expenseSubtotal = 0;
            incomeSubtotalBox.Text = "";
            expenseSubtotalBox.Text = "";
            incomeList = ("INCOMES" + "\n");
            expenseList = ("EXPENSES" + "\n");
        }

        private void clearReoccuring()
        {
            occuringMonthly.Checked = false;
        }
        //code to make the exit button close the program
        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        //code to handle adding the reoccuring and non-reoccuring budget inputs
        private void addInput_Click(object sender, EventArgs e)
        {
            try
            {
                //reoccuring budget inputs
                if (occuringMonthly.Checked)
                {
                    if (incomeButton.Checked)
                    {
                        annualInputSubtotal += Decimal.Parse(inputBox.Text);
                        incomeSubtotal += Decimal.Parse(inputBox.Text);
                        lastInputBox.Text = inputBox.Text;
                        lastInputDescBox.Text = descBox.Text;
                        incomeList += ("$" + inputBox.Text + ", " + descBox.Text + "; " + "Reoccuring" + "\n");


                    }
                    else if (expenseButton.Checked)
                    {
                        annualInputSubtotal -= Decimal.Parse(inputBox.Text);
                        expenseSubtotal -= Decimal.Parse(inputBox.Text);
                        lastInputBox.Text = "-" + inputBox.Text;
                        lastInputDescBox.Text = descBox.Text;
                        expenseList += ("$" + inputBox.Text + ", " + descBox.Text + "; " + "Reoccuring" + "\n");
                    }
                }
                //non-reoccuring budget inputs
                else
                {
                    if (incomeButton.Checked)
                    {
                        inputSubtotal += Decimal.Parse(inputBox.Text);
                        incomeSubtotal += Decimal.Parse(inputBox.Text);
                        lastInputBox.Text = inputBox.Text;
                        lastInputDescBox.Text = descBox.Text;
                        incomeList += ("$" + inputBox.Text + ", " + descBox.Text + "\n");
                    }
                    else if (expenseButton.Checked)
                    {
                        inputSubtotal -= Decimal.Parse(inputBox.Text);
                        expenseSubtotal -= Decimal.Parse(inputBox.Text);
                        lastInputBox.Text = "-" + inputBox.Text;
                        lastInputDescBox.Text = descBox.Text;
                        expenseList += ("$" + inputBox.Text + ", " + descBox.Text + "; " + "\n");

                    }
                }
                inputBox.Text = "";
                descBox.Text = "";
            }
            catch (FormatException)
            {
                MessageBox.Show("Invalid input in Budget value. Please ensure budget is a number.", "Entry Error");
            }
            catch (OverflowException)
            {
                MessageBox.Show("Values are too large or too small for decimal input.", "Entry Error");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + "\n\n" + ex.GetType().ToString() + "\n" + ex.StackTrace, "Exception");
            }

        }

        private void incomeDisplay_Click(object sender, EventArgs e)
        {
            MessageBox.Show(incomeList, "LIST OF INCOME");
        }

        private void expenseDisplay_Click(object sender, EventArgs e)
        {
            MessageBox.Show(expenseList, "LIST OF EXPENSE");
        }
    }
}
