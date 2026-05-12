namespace PayrollSystem
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            try
            {
                //Validation (data format)
                if (string.IsNullOrWhiteSpace(txtName.Text))
                {
                    MessageBox.Show("Please enter contractor's name.");
                    return;
                }

                if (!decimal.TryParse(txtHours.Text, out decimal hours))
                {
                    MessageBox.Show("Please enter valid (numeric) hours worked.");
                    return;
                }

                if (!int.TryParse(txtDependents.Text, out int dependents))
                {
                    MessageBox.Show("Please enter valid number of dependents.");
                    return;
                }

                if (hours < 0)
                {
                    MessageBox.Show("Hours worked cannot be negative.");
                    return;
                }

                if (dependents < 0)
                {
                    MessageBox.Show("Number of dependents cannot be negative.");
                    return;
                }

                if (dependents > 10)
                {
                    MessageBox.Show("Number of dependents cannot exceed 10.");
                    return;
                }

                //New calc object
                PayrollCalculator calc = new PayrollCalculator();

                //Calculations
                decimal grossPay = calc.CalculateGrossPay(hours);
                decimal uif = calc.CalculateUIF(grossPay);
                decimal membership = calc.CalculateMembership(grossPay);
                decimal paye = calc.CalculatePAYE(grossPay, dependents);
                decimal netPay = calc.CalculateNetPay(grossPay, uif, paye, membership);

                //Display results
                txtGrossPay.Text = grossPay.ToString("C");
                txtUIF.Text = uif.ToString("C");
                txtMembership.Text = membership.ToString("C");
                txtPAYE.Text = paye.ToString("C");
                txtNET.Text = netPay.ToString("C");

            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred during calculation: " + ex.Message);
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtName.Clear();
            txtHours.Clear();
            txtDependents.Clear();

            txtGrossPay.Clear();
            txtUIF.Clear();
            txtMembership.Clear();
            txtPAYE.Clear();
            txtNET.Clear();

            txtName.Focus();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
