# CSharp_Unit-4-Making-Decisions
Exercises 4-1 - 4-10

SlayTeam 2023

Exercise Instructions
----------------------
4-1
--
Write a program named CheckCredit that prompts users to enter a purchase price for an item. If the value entered is greater than a credit limit of $8,000, display an error message; otherwise, display Approved.

4-2
--
Write a program named Twitter that accepts a user’s message and determines whether it is short enough for a social networking service that does not accept messages of more than 140 characters.

4-3
--
Write a program named Admission for a college’s admissions office. The user enters a numeric high school grade point average (for example, 3.2) and an admission test score. Display the message Accept if the student meets either of the following requirements:

- A grade point average of 3.0 or higher, and an admission test score of at least 60

- A grade point average of less than 3.0, and an admission test score of at least 80

- If the student does not meet either of the qualification criteria, display Reject.

4-4
--
The Saffir-Simpson Hurricane Scale classifies hurricanes into five categories numbered 1 through 5. Write an application named Hurricane that outputs a hurricane’s category based on the user’s input of the wind speed. Category 5 hurricanes have sustained winds of at least 157 miles per hour. The minimum sustained wind speeds for categories 4 through 1 are 130, 111, 96, and 74 miles per hour, respectively. Any storm with winds of less than 74 miles per hour is not a hurricane.

4-5
--
Account numbers sometimes contain a check digit that is the result of a mathematical calculation. The inclusion of the digit in an account number helps ascertain whether the number is a valid one. Write an application named CheckDigit that asks a user to enter a four-digit account number and determines whether it is a valid number. The number is valid if the fourth digit is the remainder when the number represented by the first three digits of the four-digit number is divided by 7. For example, 7770 is valid, because 0 is the remainder when 777 is divided by 7.

4-9
--
Write a program named CheckMonth that prompts a user to enter a birth month. If the value entered is greater than 12 or less than 1, display an error message; otherwise, display the valid month with a message such as 3 is a valid month.

4-10
--
Write a program named CheckMonth2 that prompts a user to enter a birth month and day. Display an error message if the month is invalid (not 1 through 12) or the day is invalid for the month (for example, not between 1 and 31 for January or between 1 and 29 for February). If the month and day are valid, display them with a message.

Case Problems 
--------------------
1
--
In Chapter 2, you created an interactive application named GreenvilleRevenue, and in Chapter 3 you created a GUI version of the application named GreenvilleRevenueGUI. The programs prompt a user for the number of contestants entered in this year’s and last year’s Greenville Idol competition, and then they display the revenue expected for this year’s competition if each contestant pays a $25 entrance fee. The programs also display a statement that compares the number of contestants each year. Now, replace that statement with one of the following messages:

- If the competition has more than twice as many contestants as last year, display The competition is more than twice as big this year!

- If the competition is bigger than last year’s but not more than twice as big, display The competition is bigger than ever!

- If the competition is smaller than last year’s, display, A tighter race this year! Come out and cast your vote!

2
--
In Chapter 2, you created an interactive application named MarshallsRevenue, and in Chapter 3 you created a GUI version of the application named MarshallsRevenueGUI. The programs prompt a user for the number of interior and exterior murals scheduled to be painted during the next month by Marshall’s Murals. Next, the programs compute the expected revenue for each type of mural when interior murals cost $500 each and exterior murals cost $750 each. The applications also display the total expected revenue and a statement that indicates whether more interior murals are scheduled than exterior ones. Now, modify one or both of the applications to accept a numeric value for the month being scheduled and to modify the pricing as follows:

- Because of uncertain weather conditions, exterior murals cannot be painted in December through February, so change the number of exterior murals to 0 for those months.

 - Marshall prefers to paint exterior murals in April, May, September, and October. To encourage business, he charges only $699 for an exterior mural during those - months. Murals in other months continue to cost $750.

- Marshall prefers to paint interior murals in July and August, so he charges only $450 for an interior mural during those months. Murals in other months continue to cost $500.
