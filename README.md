# MonthlySalary
When supplied employee details: first name, last name, annual salary (positive integer) and super rate (0% - 50% inclusive), pay period, the program should generate pay slip information with name, pay period, gross income, income tax, net income and super.
The calculation details will be the following:
• pay period = per calendar month
• gross income = annual salary / 12 months
• income tax = based on the tax table provided below
• net income = gross income - income tax
• super = gross income x super rate
Notes: All calculation results should be rounded to 2dp

The following rates apply:
Taxable income
Tax rate
Up to $14,000 10.5%
Over $14,000 and up to $48,000 17.5%
Over $48,000 and up to $70,000 30%
Over $70,000 and up to $180,000 33%
Remaining income over $180,000 39%
For example, the payment in March for an employee with an annual salary of $60,050 and a super rate of 9% is:
• pay period = Month of March (01 March to 31 March)
• gross income = 60,050 / 12 = 5,004.17
• income tax = (14000 * 0.105 + 34000 * 0.175 + 12050 * 0.3) / 12 = 919.58
• net income = 5,004.17 – 919.58 = 4,084.59
• super = 5,004.17 x 9% = 450.38
Here is the csv input and output format we provide (but feel free to use any format you want):
Input (first name, last name, annual salary, super rate (%), pay period):
John,Smith,60050,9%,March
Alex,Wong,120000,10%,March
Output (name, pay period, gross income, income tax, net income, super):
John Smith,01 March – 31 March,5004.17,919.58,4084.59,450.38
Alex Wong,01 March – 31 March,10000.00,2543.33,7456.67,1000.00

Downlaod the repo 
  then dotnet run to root folder
