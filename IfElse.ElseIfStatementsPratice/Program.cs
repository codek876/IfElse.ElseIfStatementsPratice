/*
 * 25 Questions
 * If Else ElseIf Statements
 * W3Shools
 */

// Q#1
//Program to accept two integers and check whether they are equal or not.

/*
int first_number;
int second_number;

Console.WriteLine("Enter two integers.");
first_number = Int32.Parse(Console.ReadLine());
second_number =Int32.Parse(Console.ReadLine());

if(first_number != second_number)
    Console.WriteLine($"{first_number} and {second_number} are not equal");
Console.WriteLine($"{first_number} and {second_number} are equal");
*/

//Q#2
//program to check whether a given number is even or odd
/*
int num;

Console.WriteLine("Enter a number to check if its even or odd");
num = Int32.Parse(Console.ReadLine());

if (num % 2 == 0)
    Console.WriteLine($"{num} is an even integer");
else if (num % 2 == 1)
    Console.WriteLine($"{num} is an odd integer");
*/

//Q#3
//Program to check whether a given number is positive or negative.
/*
int num;

Console.WriteLine("Enter an number to hek if its positive or negative");
num = Int32.Parse(Console.ReadLine());

if (num > 0)
    Console.WriteLine($"{num} is postive");
else
    Console.WriteLine($"{num} is negative");
*/

//@#4
//Program to find whether a given year is a leap year or not.
/*
int year;

Console.WriteLine("Enter a year to hek if its a leap year or not");
year = Int32.Parse(Console.ReadLine());

if (year % 4 == 0)
    Console.WriteLine($"{year} is leap year");
else if (year % 400 == 0)
    Console.WriteLine($"{year} is leap year");
else if (year % 100 == 0)
    Console.WriteLine($"{year} is not a leap year");
else
    Console.WriteLine($"{year} is not a leap year");
*/

//Q#5
//Program to read the age of a candidate and determine whether it is eligible
//for casting his/her own vote.
/*
int candidateAge;

Console.WriteLine("Enter your age.");
candidateAge = int.Parse(Console.ReadLine());

if (candidateAge >= 18)
    Console.WriteLine("Congratulation! You are eligible for casting your vote");
else
    Console.WriteLine("You are not eligible for casting your vote");
    Console.WriteLine("You would be able to caste your vote after {0} year.\n\n", 18 - candidateAge);
*/

//Q#6
//program to read the value of an integer m and display the value of n is 1
//when m is larger than 0, 0 when m is 0 and -1 when m is less than 0
/*
int m,n = 0;

Console.WriteLine("Enter a integer");
m = int.Parse(Console.ReadLine());

if (m > 0)
    n = 1;
else if (m < 0)
    n = -1;
else if(m == 0)
    n = 0;

Console.WriteLine("The value of n is {0}", n);
*/

//Q#7
//program to accept the height of a person in centimeter and
//categorize the person according to their height.
/*
decimal heightIhes, heightTentimeters;

Console.WriteLine("What is your height?");
heightIhes = decimal.Parse(Console.ReadLine());

heightTentimeters = heightIhes * 30.48m;
//30.48 to entimeters
if (heightTentimeters < 147)
    Console.WriteLine("Your height {0} in entimeters and you are a dwarf", heightTentimeters);
else
    Console.WriteLine("Your height {0} in entimeters and you are tall", heightTentimeters);
*/

//Q#8
//Program to find the largest of three numbers
/*
int first_number, seond_number, third_number;

Console.WriteLine("Enter three (3) numbers.");
first_number = int.Parse(Console.ReadLine());
seond_number = int.Parse(Console.ReadLine());
third_number = int.Parse(Console.ReadLine());

if (first_number > seond_number)
    Console.WriteLine("First_number is the greatest number of three");
else if (third_number > first_number)
    Console.WriteLine("Third_number is the greatest number of three");
else if (seond_number > third_number)
    Console.WriteLine("Seond_number is the greatest number of three");
*/

//@#9
//Program to accept a coordinate point in an XY coordinate system and determine in
//which quadrant the coordinate point lies
/*
int x, y;

Console.Write("Input the value for X ordinate: ");
x = int.Parse(Console.ReadLine());

Console.Write("Input the value for Y ordinate: ");
y = int.Parse(Console.ReadLine());

if (x > 0 && y > 0)
    Console.WriteLine($"The coordinate point ({x}, {y}) lies in the First quadrant.");
else if (x < 0 && y > 0)
    Console.WriteLine($"The coordinate point ({x}, {y}) lies in the Seond quadrant.");
else if (x < 0 && y < 0)
    Console.WriteLine($"The coordinate point ({x}, {y}) lies in the Third quadrant.");
else if (x > 0 && y < 0)
    Console.WriteLine($"The coordinate point ({x}, {y}) lies in the Fourth quadrant.");
*/


//Q#10
//Program to find the eligibility of admission for a professional course based on
//the following criteria:
//Marks in Maths >= 65
//Marks in Phy >= 55
//Marks in Chem >= 50
//Total in all three subject >=180
//OR Total in Math and Subjects >=140
/*
int maths, phys, chem;

Console.Write("Input your grade for Maths: ");
maths = int.Parse(Console.ReadLine());

Console.Write("Input your grade for Physics: ");
phys = int.Parse(Console.ReadLine());

Console.Write("Input your grade for chemistry: ");
chem = int.Parse(Console.ReadLine());

int total = maths + phys + chem;
int totalMP = maths + phys;

if (maths >= 65 || phys >= 55 || chem >= 50 || total >= 180)
{
    if (total >= 180)
        Console.WriteLine("The  candidate is eligible for admission");
    else if (maths >= 65 && phys >= 55 && chem >= 50)
        Console.WriteLine("The  candidate is eligible for admission");
    else if (totalMP >= 140)
        Console.WriteLine("The  candidate is eligible for admission");
    
}
else if (maths < 65 && phys < 55 && chem < 50)
    Console.WriteLine("The candidate is not eligible for admission");
*/

//Q#11
//Program to calculate root of Quadratic Equation

/*
int a, b, c, d1, d2;
int x1, x2;


Console.Write("Input value for a: ");
a = int.Parse(Console.ReadLine());

Console.Write("Input value for b: ");
b = int.Parse(Console.ReadLine());

Console.Write("Input value for c: ");
c = int.Parse(Console.ReadLine());

d1 = (int)(b ^ 2 - 4 * a * c);
d2 = (int)(b ^ 2 - 4 * a * c);

x1 = (int)(-b + Math.Sqrt(d1) / 2 * a);
x2 = (int)(-b - Math.Sqrt(d2) / 2 * a);

if (d1 > 0 && d2 > 0)
{
    Console.WriteLine("Two real and different roots");
}
else if (d1 < 0 && d2 < 0)
{
    Console.WriteLine("Two complex(imaginary) roots");
}
else if (d1 == 0 && d2 == 0)
{
    Console.WriteLine("Only one real root");
}
*/

//Q#12
//program to read roll no, name and marks of three subjects
//and calculate the total, percentage and division
/*
int rollNumber;
decimal phys, chem, compApp;
decimal totalMarks, percentage;

string studentName, division = "";

Console.Write("Input the Roll Number of the Student: ");
rollNumber = int.Parse(Console.ReadLine());

Console.Write("Input the name of the Student: ");
studentName = Console.ReadLine();

Console.Write("Input the marks of Physics, Chemistry and Computer Application: ");
phys = decimal.Parse(Console.ReadLine());
chem = decimal.Parse(Console.ReadLine());
compApp = decimal.Parse(Console.ReadLine());

totalMarks = phys + chem + compApp;
percentage = totalMarks / 3.0m;


if (percentage >= 60 && percentage <= 100)
{
    division = "First";
}
else if (percentage >= 48 && percentage <= 59)
{
    division = "Second";
}
else if (percentage >= 36 && percentage <= 47)
{
    division = "Pass";
}
else if (percentage <= 35)
{
    division = "Failed";
}

Console.WriteLine("---------------------------------------");
//Console.WriteLine("123456789012345678901234567890123456789");
Console.WriteLine("Roll No: \t\t\t{0}", rollNumber);
Console.WriteLine("Name of Student: \t\t{0}", studentName);
Console.WriteLine("Marks in Physics: \t\t{0}", phys);
Console.WriteLine("Marks in Chemistry: \t\t{0}", chem);
Console.WriteLine("Marks in Computer Application: \t{0}", compApp);
Console.WriteLine("Total Marks: \t\t\t{0}", totalMarks);
Console.WriteLine("Total Marks: \t\t\t{0}", totalMarks);
Console.WriteLine("Percentage: \t\t\t{0}", percentage);
Console.WriteLine("Division: \t\t\t{0}", division);
Console.WriteLine("---------------------------------------");
*/

//Q#13
//program to read temperature in centigrade and display a
//suitable message according to temperature state below
/*
 * Temp < 0 then Freezing weather
   Temp 0-10 then Very Cold weather
   Temp 10-20 then Cold weather
   Temp 20-30 then Normal in Temp
   Temp 30-40 then Its Hot
   Temp >=40 then Its Very Hot
 */
/*
decimal temperature;

Console.Write("What is the temperature today? ");
temperature = decimal.Parse(Console.ReadLine());

if (temperature < 0)
    Console.WriteLine("Freezing Weather.");
else if (temperature >= 0 && temperature < 10)
    Console.WriteLine("Very Cold Weather");
else if (temperature >= 10 && temperature < 20)
    Console.WriteLine("Cold Weather");
else if (temperature >= 20 && temperature < 30)
    Console.WriteLine("Normal in Temperature");
else if (temperature >= 30 && temperature < 40)
    Console.WriteLine("Its Hot");
else if (temperature >= 40)
    Console.WriteLine("Its Very Hot");
*/

//Q#14
//Program to check whether a triangle is Equilateral, Isosceles or Scalene
/*
int a, b, c;

Console.WriteLine("Input the length for the sides of a triangle: ");
Console.WriteLine("-----------------");

Console.Write("Input value for a: ");
a = int.Parse(Console.ReadLine());

Console.Write("Input value for b: ");
b = int.Parse(Console.ReadLine());

Console.Write("Input value for c: ");
c = int.Parse(Console.ReadLine());

Console.WriteLine("------------------");

if (a == b && b == c)
    Console.WriteLine("This is an Equalilateral Triangle.");
else if (a == b || b == c || c == a)
    Console.WriteLine("This is an Isosceles Triangle");
else if (a != b && b != c)
    Console.WriteLine("This is an Scalene Triangle");
*/

//Q#15
//program to check whether a triangle can be formed by the given value for the angles
//Sum of 3 angles in a triangle is 180
/*
int a, b, c;
int anglesTotal;

Console.WriteLine("Input 3 angles to form a triangle: ");
Console.WriteLine("-----------------");

Console.Write("Input value for a: ");
a = int.Parse(Console.ReadLine());

Console.Write("Input value for b: ");
b = int.Parse(Console.ReadLine());

Console.Write("Input value for c: ");
c = int.Parse(Console.ReadLine());

anglesTotal = a + b + c;

if (anglesTotal == 180)
    Console.WriteLine("That is a valid triangle");
else
    Console.WriteLine("That is not a valid triangle");
*/

//Q#16
//Program to check whether an alphabet is a vowel or consonant
/*
string letter;

Console.WriteLine("Enter a alphabet to test for vowel or consonant");
letter = Console.ReadLine();

letter.ToLower();

if (letter == "a" || letter == "e" || letter == "i" || letter == "o" || letter == "u")
    Console.WriteLine("Its an vowel");
else
    Console.WriteLine("Its an consonant");
*/

//Q#17
//Program to calculate profit and loss on a transaction
/*
double income, expenditure;
double total;

Console.WriteLine("Testing for profit or loss");

Console.Write("What is your inome? ");
income = double.Parse(Console.ReadLine());

Console.Write("What is your expenditure? ");
expenditure = double.Parse(Console.ReadLine());

total = income - expenditure;
Console.WriteLine(total);

if (total > 0)
    Console.WriteLine("You can book your profit amount: {0}", total);
else
    Console.WriteLine("You are making loss: {0}", total);
*/

//Q#18
//calculate and print the Electricity bill of a given customer. The customer id.,
//name and unit consumed by the user should be taken from the keyboard and
//display the total amount to pay to the customer
/*
int unit, customerId;
double perUnit = 0.00, charge = .15;
double chargeAmt = 0.00;
double sum, billNet = 0.00;
double totalCharges = 0.00;

string customerName;

Console.WriteLine("--------------------------------------------");
Console.WriteLine("Calculating Eletriity Bil of a Given ustomer");

Console.Write("Input the ustomer ID: ");
customerId = int.Parse(Console.ReadLine());

Console.Write("Input the ustomer name: ");
customerName = Console.ReadLine();

Console.Write("Input the ustomer unit onsumed: ");
unit = int.Parse(Console.ReadLine());

if (unit >= 100 && unit < 200)
{
    perUnit = 1.20;
    totalCharges = perUnit * unit;
}
else if (unit >= 200 && unit < 400)
{
    perUnit = 1.50;
    totalCharges = perUnit * unit;
}
else if (unit >= 400 && unit < 600)
{
    perUnit = 1.80;
    totalCharges = perUnit * unit;
    chargeAmt = totalCharges * charge;
    billNet = totalCharges + chargeAmt;
}
else if (unit >= 600)
{
    perUnit = 2.00;
    totalCharges = perUnit * unit;
    chargeAmt = totalCharges * charge;
    billNet = totalCharges + chargeAmt;
}

Console.WriteLine();
Console.WriteLine();
Console.WriteLine("--------------------------------------------");
Console.WriteLine("Customer IDNO: {0}", customerId);
Console.WriteLine("Customer Name: {0}", customerName);
Console.WriteLine("Unit Consumed: {0}", unit);
Console.WriteLine(@"Amount Charges @Rs. {0:N2} per unit: {1}", perUnit, totalCharges);

if (chargeAmt == 0)
    Console.WriteLine("No Surcharge Applied");
else
    Console.WriteLine("Surcharge Amount: {0}", chargeAmt);


Console.WriteLine("Net Amount Paid By the Customer: {0}", billNet);
Console.WriteLine("--------------------------------------------");
*/

//Q#19
//Accept a grade and declare the equivalent description
/*
string input;

Console.Write("Enter a grade letter: ");
input = Console.ReadLine();

if (input.ToUpper() == "E")
    input = "Excellent";
else if (input.ToUpper() == "V")
    input = "Very Good";
else if (input.ToUpper() == "G")
    input = "Good";
else if (input.ToUpper() == "A")
    input = "Average";
else if (input.ToUpper() == "F")
    input = "Fail";
else
    input = "Invalid Grade found";

Console.WriteLine("You have hosen {0}", input);
*/

//Q#20
//Read any day number in integer and display day name in word
/*
int number;
string dayInWord;

Console.Write("Input a day number and display the day name: ");
number = int.Parse(Console.ReadLine());

switch(number)
{
    case 1:
        dayInWord = "Sunday";
        break;
    case 2:
        dayInWord = "Monday";
        break;
    case 3:
        dayInWord = "Tuesday";
        break;
    case 4:
        dayInWord = "Wednesday";
        break;
    case 5:
        dayInWord = "Thursday";
        break;
    case 6:
        dayInWord = "Friday";
        break;
    case 7:
        dayInWord = "Saturday";
        break;
    default:
        dayInWord = "Invalid number to math a day";
        break;
}

Console.WriteLine(dayInWord);
*/

//Q#21
//Read any digit, display in the word
/*
int digit;
string digitInWord;

Console.Write("Input a digit and display it in words: ");
digit = int.Parse(Console.ReadLine());

switch(digit)
{
    case 0:
        digitInWord = "Zero";
        break;
    case 1:
        digitInWord = "One";
        break;
    case 2:
        digitInWord = "Two";
        break;
    case 3:
        digitInWord = "Three";
        break;
    case 4:
        digitInWord = "Four";
        break;
    case 5:
        digitInWord = "Five";
        break;
    case 6:
        digitInWord = "Six";
        break;
    case 7:
        digitInWord = "Seven";
        break;
    case 8:
        digitInWord = "Eight";
        break;
    case 9:
        digitInWord = "Nine";
        break;
    default:
        digitInWord = "Not a valid digit to display its word equivalent";
        break;
}

Console.WriteLine(digitInWord);
*/

//Q#22
//Read any Month Number in integer and display Month name in the word
/*
int monthNumber;
string monthNumberInWord;

Console.Write("Input a digit and display it in words: ");
monthNumber = int.Parse(Console.ReadLine());

switch (monthNumber)
{
    case 1:
        monthNumberInWord = "January";
        break;
    case 2:
        monthNumberInWord = "February";
        break;
    case 3:
        monthNumberInWord = "March";
        break;
    case 4:
        monthNumberInWord = "April";
        break;
    case 5:
        monthNumberInWord = "May";
        break;
    case 6:
        monthNumberInWord = "June";
        break;
    case 7:
        monthNumberInWord = "July";
        break;
    case 8:
        monthNumberInWord = "August";
        break;
    case 9:
        monthNumberInWord = "September";
        break;
    case 10:
        monthNumberInWord = "October";
        break;
    case 11:
        monthNumberInWord = "November";
        break;
    case 12:
        monthNumberInWord = "December";
        break;
    default:
        monthNumberInWord = "Not a valid number to display a month equivalent";
        break;
}

Console.WriteLine(monthNumberInWord);
*/

//Q#23
//read any Month Number in integer and display the number of days for this month
/*
int monthNumber, daysInMonth = 0;
string monthNumberInWord;

Console.Write("Input a digit and display it in words: ");
monthNumber = int.Parse(Console.ReadLine());

switch (monthNumber)
{
    case 1:
        monthNumberInWord = "January";
        daysInMonth = 31;
        break;
    case 2:
        monthNumberInWord = "February";
        daysInMonth = 28;
        break;
    case 3:
        monthNumberInWord = "March";
        daysInMonth = 31;
        break;
    case 4:
        monthNumberInWord = "April";
        daysInMonth = 30;
        break;
    case 5:
        monthNumberInWord = "May";
        daysInMonth = 31;
        break;
    case 6:
        monthNumberInWord = "June";
        daysInMonth = 30;
        break;
    case 7:
        monthNumberInWord = "July";
        daysInMonth = 31;
        break;
    case 8:
        monthNumberInWord = "August";
        daysInMonth = 31;
        break;
    case 9:
        monthNumberInWord = "September";
        daysInMonth = 30;
        break;
    case 10:
        monthNumberInWord = "October";
        daysInMonth = 31;
        break;
    case 11:
        monthNumberInWord = "November";
        daysInMonth = 30;
        break;
    case 12:
        monthNumberInWord = "December";
        daysInMonth = 31;
        break;
    default:
        monthNumberInWord = "Not a valid number to display a month equivalent";
        break;
}

Console.WriteLine($"Month have {daysInMonth} days");
*/

//@#24
//Which is a Menu-Driven Program to compute the area of the various geometrical shape
/*
int menuNumber;
double area = 0.00;
int length = 0, width = 0; 
int height = 0, baseSide = 0;
double radius;
string shape = "", formula = "";

Console.WriteLine("--------------------------");
Console.WriteLine("Menu-Driven Geometry Shape");
Console.WriteLine("1 - Area of Retangle");
Console.WriteLine("2 - Area of Square");
Console.WriteLine("3 - Area of Triangle");
Console.WriteLine("4 - Area of Cirle");
Console.WriteLine("--------------------------");

Console.Write("Selet the number you would like to find the area: ");
menuNumber = int.Parse(Console.ReadLine());

switch(menuNumber)
{
    case 1:
        shape = "This a Retangle";
        formula = "Formula: l * w";
        
        Console.Write("Input length: ");
        length = int.Parse(Console.ReadLine());
        
        Console.Write("Input width: ");
        width = int.Parse(Console.ReadLine());
        
        area = length * width;
        break;
    case 2:
        shape = "This a Square";
        formula = "Formula: l * w";

        Console.Write("Input length: ");
        length = int.Parse(Console.ReadLine());

        Console.Write("Input width: ");
        width = int.Parse(Console.ReadLine());
        
        area = length * width;
        break;
    case 3:
        shape = "This is a Triangle";
        formula = "Formula: h*b*.5";

        Console.Write("Input height: ");
        height = int.Parse(Console.ReadLine());

        Console.Write("Input base: ");
        baseSide = int.Parse(Console.ReadLine());

        area = (double)(height * baseSide * .5);
        break;
    case 4:
        shape = "This is a Triangle";
        formula = "Formula: 3.14 * radius * radius";

        Console.Write("Input radius: ");
        radius = int.Parse(Console.ReadLine());

        area = (double)(radius * radius * 3.14);
        break;
}

Console.Write("{0} and {1}, the area is: {2}", shape, formula, area);
*/

//@#25
//Which is a Menu-Driven Program to perform a simple calculation.
/*
int result = 0;
int a = 0, b = 0, input;

string operatorName = "";

Console.WriteLine("--------------------------");
Console.WriteLine("Menu-Driven Math Operation");
Console.WriteLine("1 - Addition");
Console.WriteLine("2 - Substraction");
Console.WriteLine("3 - Multiplication");
Console.WriteLine("4 - Division");
Console.WriteLine("5 - Exit");
Console.WriteLine("--------------------------");

Console.Write("Select the number you would like to do a specific operation: ");
input = int.Parse(Console.ReadLine());

switch(input)
{
    case 1:
        operatorName = "Addition";

        Console.Write("Input a value for a: ");
        a = int.Parse(Console.ReadLine());

        Console.Write("Input a value for b: ");
        b = int.Parse(Console.ReadLine());

        result = a + b;
        break;
    case 2:
        operatorName = "Substraction";

        Console.Write("Input a value for a: ");
        a = int.Parse(Console.ReadLine());

        Console.Write("Input a value for b: ");
        b = int.Parse(Console.ReadLine());

        result = a - b;
        break;
    case 3:
        operatorName = "Multiplication";

        Console.Write("Input a value for a: ");
        a = int.Parse(Console.ReadLine());

        Console.Write("Input a value for b: ");
        b = int.Parse(Console.ReadLine());

        result = a * b;
        break;
    case 4:
        operatorName = "Division";

        Console.Write("Input a value for a: ");
        a = int.Parse(Console.ReadLine());

        Console.Write("Input a value for b: ");
        b = int.Parse(Console.ReadLine());

        result = a / b;
        break;
    case 5:
        break;
}

Console.WriteLine($"{operatorName} for {a} and {b} is {result}\n\n");
*/