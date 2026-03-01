using System;

class Program
{
    static void Main(string[] args)
    { //exe1
        Console.WriteLine("Exercise 1：");

        Console.WriteLine("Enter first nnumber:");
        double firstnum = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Enter second nnumber:");
        double secondnum = Convert.ToDouble(Console.ReadLine());

        if (firstnum == secondnum)
        {
            Console.WriteLine("Numbers are equal");
        }
        else if (firstnum > secondnum)
        {
            Console.WriteLine("First number is greater");
        }
        else
        {
            Console.WriteLine("Second number is greater");
        }

        Console.WriteLine();

        // exe2
        Console.WriteLine("Exercise 2：");  

        Console.Write("Enter number:");
        double num = Convert.ToDouble(Console.ReadLine());

        if (num > 5 && num <10)
        {
            Console.WriteLine("The number is greater than 5 and less than 10");
        }
        else
        {
            Console.WriteLine("Unknown number");
        }

        Console.WriteLine();

        //exe3

        Console.WriteLine("Exercise 3：");

        Console.Write("Enter number:");
        double n = Convert.ToDouble(Console.ReadLine());

        if (n == 5 || n == 10)
        {
            Console.WriteLine("The number is either 5 or 10");
        }
        else
        {
            Console.WriteLine("Unknown number");
        }

        Console.WriteLine();

        //exe4

        Console.WriteLine("Exercise 4：");

        Console.Write("Enter deposit amount:");
        double money = Convert.ToDouble(Console.ReadLine());

        if (money < 100)
        {
            money = money + money * 0.05;   
        }
        else if (money <= 200)
        { 
            money = money + money * 0.07;
        }
        else
        {
            money = money + money* 0.10;
        }

        Console.WriteLine("Total amount: " + money);

        Console.WriteLine();


        //exe5
        Console.WriteLine("Exercise 5：");

        Console.Write("Enter deposit amount: ");
        double money2 = Convert.ToDouble(Console.ReadLine());

        if (money2 < 100)
        {
            money2 = money2 + money2 * 0.05;
        }
        else if (money2 <= 200)
        {
            money2 = money2 + money2 * 0.07;
        }
        else
        {
            money2 = money2 + money2 * 0.10;
        }

        money2 = money2 + 15;
        Console.WriteLine("Total amount with bonus: " + money2);
        Console.WriteLine();

        //exe6
        Console.WriteLine("Exercise 6：");

        Console.WriteLine("1 - Addition");
        Console.WriteLine("2 - Subtraction");
        Console.WriteLine("3 - Multiplication");

        int op = Convert.ToInt32(Console.ReadLine());

        switch (op)
        {
            case 1:
                Console.WriteLine("You selected Addition");
                break;
            case 2:
                Console.WriteLine("You selected Subtraction");
                break;
            case 3:
                Console.WriteLine("You selected Multiplication");
                break;
            default:
                Console.WriteLine("Unknown operation");
                break;
        }
        Console.WriteLine();

        //exe7
        Console.WriteLine("Exercise 7：");
        Console.WriteLine("1 - Addition");
        Console.WriteLine("2 - Subtraction");
        Console.WriteLine("3 - Multiplication");

        int op2 = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter first number: ");
        int num1 = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter second number:");
        int num2 = Convert.ToInt32(Console.ReadLine());

        switch (op2)
        {
            case 1:
                Console.WriteLine("Result: " + (num1 + num2));
                break;
            case 2:
                Console.WriteLine("Result: " + (num1 - num2));
                break;
            case 3:
                Console.WriteLine("Result: " + (num1 * num2));
                break;
            default:
                Console.WriteLine("Unknown operation");
                break;
        }
    }
}
