// See https://aka.ms/new-console-template for more information

using MonthlySalary.Dto;

string fileName = "Data.txt";
string path = Path.Combine(Environment.CurrentDirectory, @"Input\", fileName);
Console.WriteLine(path);
string[] lines = File.ReadAllLines(path);
Console.WriteLine("Below are the inputs:");
Console.WriteLine(string.Join("\n", lines));
var empDetail = new Detail();
var procesedDetails = empDetail.GetEmployees(lines);
foreach (var emp in procesedDetails)
{
    Console.WriteLine($"{emp.FullName}, {emp.PayPeriod}, {emp.GrossIncome}, {emp.IncomeTax}, {emp.NetIncome}, {emp.Super}");
}

/*

For example, the payment in March for an employee with an annual salary of $60,050 and a super rate of 9% is:
• pay period = Month of March (01 March to 31 March)
• gross income = 60,050 / 12 = 5,004.17
• income tax = (14000 * 0.105 + 34000 * 0.175 + 12050 * 0.3) / 12 = 919.58
• net income = 5,004.17 – 919.58 = 4,084.59
• super = 5,004.17 x 9% = 450.38
 */