namespace PayrollSystem
{
    public class PayrollCalculator
    {
        private const decimal HourlyRate = 950m;

        public decimal CalculateGrossPay(decimal hoursWorked)
        {
            return hoursWorked * HourlyRate;
        }

        public decimal CalculateUIF (decimal grossPay)
        {
            return grossPay * 0.01m; // 1% UIF contribution
        }

        public decimal CalculateMembership(decimal grossPay)
        {
            return grossPay * 0.13m; 
        }

        public decimal CalculatePAYE(decimal grossPay, int dependents)
        {
            return (grossPay - (grossPay * 0.0575m * dependents)) * 0.25m;
        }

        public decimal CalculateNetPay(decimal grossPay, decimal uif, decimal paye, decimal membership)
        {
            return grossPay - uif - paye - membership;
        }
    }
}