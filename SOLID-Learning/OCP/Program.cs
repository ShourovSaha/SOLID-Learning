namespace OCP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World! Let's calculate your income tax.");
            IncomeDetails incomeDetails = new IncomeDetails()
            {
                TotalIncome = 1000,
                TotalDeduction = 250,
                Country = "US"
            };

            ITaxCalculator taxCalculator = null;
            switch (incomeDetails.Country)
            {
                case "US":
                    taxCalculator = new TaxCalculatorForUS();
                    break;
                case "UK":
                    taxCalculator = new TaxCalculatorForUS();
                    break;
                case "BD":
                    taxCalculator = new TaxCalculatorForUS();
                    break;
            }

            taxCalculator.Income = incomeDetails.TotalIncome;
            taxCalculator.Deduction = incomeDetails.TotalDeduction;
            var a = taxCalculator.CalculateTaxAmount();
            Console.WriteLine(String.Format("Your tax is: {0}$", taxCalculator.CalculateTaxAmount()));
        }
    }

    public class IncomeDetails
    {
        public decimal TotalIncome { get; set; }
        public decimal TotalDeduction { get; set; }
        public string Country { get; set; }
    }
}