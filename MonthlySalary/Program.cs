// See https://aka.ms/new-console-template for more information

using MonthlySalary.Dto;

//process the input file
string fileName = "Data.txt";
string path = Path.Combine(Environment.CurrentDirectory, @"Input\", fileName);
Console.WriteLine(path);
string[] lines = File.ReadAllLines(path);
Console.WriteLine("Below are the inputs:");
Console.WriteLine(string.Join("\n", lines));

//process employees
var procesedDetails = Detail.GetEmployees(lines);

//print out employee details
foreach (var emp in procesedDetails)
    Console.WriteLine($"{emp.FullName}, {emp.PayPeriod}, {emp.GrossIncome}, {emp.IncomeTax}, {emp.NetIncome}, {emp.Super}");
