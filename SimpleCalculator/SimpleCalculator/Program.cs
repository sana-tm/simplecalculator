using System;

namespace SimpleCalculator
{
    class Program
    {

        static void Main()
        {
            Console.WriteLine(" ---> CALCULATOR <--- ");
            bool runProgram = true;

            while (runProgram)
            {
                Console.WriteLine("Select the Mathematical operation to do:" +
                    "\n 1 : Addition" +
                    "\n 2 : Subtraction" +
                    "\n 3 : Division" +
                    "\n 4 : Multiplication" +
                    "\n 5 : Modulus" +
                    "\n 6 : SquareRoot" +
                    "\n 7 : Power Function" +
                    "\n 9 : Exit");

                string selectNum = Console.ReadLine();
                try
                {
                    switch (selectNum)
                    {
                        case "1":
                            Console.Clear();
                            Addition();
                            break;

                        case "2":
                            Console.Clear();
                            Subtraction();
                            break;

                        case "3":
                            Console.Clear();
                            Division();
                            break;

                        case "4":
                            Console.Clear();
                            Multiplication();
                            break;

                        case "5":
                            Console.Clear();
                            Modulus();
                            break;

                        case "6":
                            Console.Clear();
                            SquareRoot();
                            break;

                        case "7":
                            Console.Clear();
                            Power();
                            break;

                        case "9":
                            Console.WriteLine("Thank you. BYE!!");
                            runProgram = false;
                            break;

                        default:
                            Console.WriteLine("Invalid Selection, please try again");
                            break;

                    }
                }
                catch
                {
                    Console.WriteLine("Please make sure you have entered numbers and not any other characters." +
                        "\n Please Try again");
                }

                Console.ReadKey();
            }

        }

        //Function for addition of multiple numbers
        public static void Addition()
        {
            int i;
            decimal sum = 0;

            Console.WriteLine(" ADDITION FUCTION ");

            Console.Write("Enter the elements you want to add : ");
            int n = Convert.ToInt32(Console.ReadLine());
            decimal[] a = new decimal[n];

            if (n <= 1)
            {
                Console.WriteLine("Addition not possible with single element.");
                return;
            }
            Console.WriteLine("Enter the {0} numbers to be added : ", n);
            for (i = 0; i < n; i++)
            {
                Console.Write("Enter {0} element  : ", i + 1);
                a[i] = Convert.ToDecimal(Console.ReadLine());
            }

            for (i = 0; i < n; i++)
                sum += a[i];

            Console.WriteLine("The sum of all the numbers is : " + sum);
        }

        //Function to find subtraction for multiple numbers
        public static void Subtraction()
        {
            int i;

            decimal difference = 0;

            Console.WriteLine(" SUBTRACTION FUCTION ");

            Console.Write("Enter the number of elements you want to subtract : ");
            int n = Convert.ToInt32(Console.ReadLine());

            decimal[] a = new decimal[n];

            if (n <= 1)
            {
                Console.WriteLine("Subtraction not possible with single element.");

            }

            else
            {
                Console.WriteLine("Enter the {0} numbers to be subtracted : ", n);
                for (i = 0; i < n; i++)
                {
                    Console.Write("Enter {0} element : ", i + 1);
                    a[i] = Convert.ToDecimal(Console.ReadLine());
                }

                difference = a[0] - a[1];

                for (i = 2; i < n; i++)
                    difference = difference - a[i];

                Console.WriteLine("The difference between the numbers is : " + difference);
            }

        }

        //Function to find Division
        public static void Division()
        {
            decimal result;

            Console.WriteLine(" DIVISION FUCTION ");
            Console.Write("Enter a number :");
            decimal a = Convert.ToDecimal(Console.ReadLine());

            Console.Write("Enter another number :");
            decimal b = Convert.ToDecimal(Console.ReadLine());


            if (b != 0)
            {
                result = a / b;
                Console.WriteLine("The division of {0} / {1} is : {2} ", a, b, result);

            }
            else
            {
                Console.WriteLine("Cannot Divide by Zero");
            }
        }

        //Function to find multiplication
        public static void Multiplication()
        {
            decimal product;

            Console.WriteLine(" MULTIPLICATION FUCTION ");

            Console.Write("Enter a number to multiply : ");
            decimal a = Convert.ToDecimal(Console.ReadLine());

            Console.Write("Enter another number to multiply it with : ");
            decimal b = Convert.ToDecimal(Console.ReadLine());

            product = a * b;

            Console.WriteLine("The product of {0} * {1} is : {2}  ", a, b, product);

        }

        //Function to find mod of two numbers
        public static void Modulus()
        {
            decimal remainder;

            Console.WriteLine(" MODULUS FUCTION ");

            Console.Write("Enter first operand: ");
            decimal a = Convert.ToDecimal(Console.ReadLine());

            Console.Write("Enter second operand: ");
            decimal b = Convert.ToDecimal(Console.ReadLine());

            if (b != 0)
            {
                remainder = a % b;

                Console.WriteLine("The Modulus {0} % {1} is: {2} ", a, b, remainder);
            }
            else
                Console.WriteLine("Modulus fucntion not possible if the second number is Zero. ");
        }

        //Function to find square root of a number
        public static void SquareRoot()
        {
            double sqrRoot;

            Console.WriteLine(" SQUARE ROOT FUCTION ");

            Console.Write("Enter the number to find square root of: ");

            double a = Convert.ToDouble(Console.ReadLine());

            sqrRoot = Math.Sqrt(a);

            Console.WriteLine("The SquareRoot of {0} is : {1}", a, sqrRoot);


        }

        //Function to find Power of Base number
        public static void Power()
        {
            double result;

            Console.WriteLine(" POWER FUCTION ");

            Console.Write("Enter the value for the base number: ");
            double a = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter the value for the power number: ");
            double b = Convert.ToDouble(Console.ReadLine());

            result = Math.Pow(a, b);

            Console.WriteLine("The answer for {0} ^ {1} is : {2}", a, b, result);


        }
    }

}