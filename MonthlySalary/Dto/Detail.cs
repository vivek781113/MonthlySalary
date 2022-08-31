using MonthlySalary.Utils;

namespace MonthlySalary.Dto
{
    internal class Detail
    {

        public string FullName { get; set; }
        public double GrossIncome{ get; set; }
        public double NetIncome{ get; set; }
        public double IncomeTax{ get; set; }
        public double Super{ get; set; }
        public string PayPeriod{ get; set; }

        public static Detail[] GetEmployees(string[] inputLines) 
        {
            var employees = new List<Detail>(inputLines.Length);
            foreach(string line in inputLines)
            {
                var details = line.Split(",");
                double salary = double.Parse(details[2].Trim());
                var (netTax, _, monthly) = SalaryUtil.ComputeSalary(salary);
                var super = details[3].Trim().TrimEnd(new char[] { '%' });
                var superDouble = double.Parse(super);
                double grossMonthly = Math.Round(salary / 12, 2);
                var emp = new Detail
                {
                    FullName = $"{details[0].Trim()} {details[1].Trim()}",
                    PayPeriod = SalaryUtil.ComputePayPeriod(details[4].Trim()),
                    Super = Math.Round(grossMonthly * superDouble / 100, 2),
                    GrossIncome = grossMonthly,
                    NetIncome = monthly,
                    IncomeTax = Math.Round(netTax / 12, 2)
                };
                employees.Add(emp);
            }
            return employees.ToArray();
        }
    }
}
