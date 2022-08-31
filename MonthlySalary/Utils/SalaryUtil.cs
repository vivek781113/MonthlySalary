namespace MonthlySalary.Utils
{
    internal class SalaryUtil
    {
        private static double lastRate = 39;
        private static (double sal, double rate)[] GetSlabs()
        {
            //this can be made dynamic
            var slabs = new (double sal, double rate)[4];
            slabs[0] = (14000, 10.5);
            slabs[1] = (34000, 17.5);
            slabs[2] = (22000, 30);
            slabs[3] = (110000, 33);

            return slabs;
        }

        internal static (double netTax, double annual, double monthly) ComputeSalary(double salary) 
        {
            double sal = salary;
            double netTax = 0;
            int i = 0;

            var slabs = GetSlabs();
            int n = slabs.Length;
            while (sal > 0 && i < n)
            {
                var slab = slabs[i++];
                var rate = slab.rate;
                var s = slab.sal;
                var tax = rate * (s >= sal ? sal : s) / 100;
                netTax += tax;
                sal -= s;
                //Console.WriteLine($"s: {s} | r: {rate} | tax:{tax} | netTax: {netTax} | sal: {sal}");
            }
            if (sal > 0) 
            {
                var tax = (lastRate * sal / 100) ;
                netTax += tax;
                //Console.WriteLine($"s: {sal} | r: {lastRate} | tax:{tax} | netTax: {netTax} | sal: {sal}");
            }

            var netSalary = salary - netTax;
            var monthlySalary = netSalary / 12;
            //Console.WriteLine($"netSalary: {netSalary} | monthlySalary: {monthlySalary}");
            return (Math.Round(netTax, 2), Math.Round(netSalary, 2), Math.Round(monthlySalary, 2));
        }

        internal static string ComputePayPeriod(string month)
        {
            string payperiod = "";
            switch (month.ToLower()[..3])
            {
                case "jan":
                    payperiod = $"01 January - 31 March";
                    break;
                case "feb":
                    var lastDate = DateTime.IsLeapYear(DateTime.Now.Year) ? "29" : "28";
                    payperiod = $"01 February - {lastDate} February";
                    break;
                case "mar":
                    payperiod = $"01 March - 31 March";
                    break;
                case "apr":
                    payperiod = $"01 April - 30 April";
                    break;
                case "may":
                    payperiod = $"01 May - 31 May";
                    break;
                case "jun":
                    payperiod = $"01 June - 30 June";
                    break;
                case "jul":
                    payperiod = $"01 July - 31 July";
                    break;
                case "aug":
                    payperiod = $"01 August  - 31 August";
                    break;
                case "sep":
                    payperiod = $"01 September - 30 September";
                    break;
                case "oct":
                    payperiod = $"01 October - 31 October";
                    break;
                case "nov":
                    payperiod = $"01 November - 30 November";
                    break;
                case "dec":
                    payperiod = $"01 December  - 31 December ";
                    break;
                default:
                    break;
            }

            return payperiod;
        }
    }
}
