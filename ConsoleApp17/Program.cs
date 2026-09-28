using System;

class Program
{
    static void Main()
    {
        while (true)
        {
            Console.Clear();

            Console.WriteLine("======================================");
            Console.WriteLine("          C# ASSIGNMENT 3");
            Console.WriteLine("======================================");
            Console.WriteLine();

            for (int i = 1; i <= 28; i++)
            {
                Console.WriteLine(i + ". Question " + i);
            }

            Console.WriteLine();
            Console.WriteLine("0. Exit");
            Console.WriteLine();

            Console.Write("Choose question: ");

            if (!int.TryParse(Console.ReadLine(), out int choice))
            {
                Console.WriteLine("Invalid choice.");
                Console.ReadKey();
                continue;
            }

            Console.Clear();

            switch (choice)
            {
                case 1: Question1(); break;
                case 2: Question2(); break;
                case 3: Question3(); break;
                case 4: Question4(); break;
                case 5: Question5(); break;
                case 6: Question6(); break;
                case 7: Question7(); break;
                case 8: Question8(); break;
                case 9: Question9(); break;
                case 10: Question10(); break;
                case 11: Question11(); break;
                case 12: Question12(); break;
                case 13: Question13(); break;
                case 14: Question14(); break;
                case 15: Question15(); break;
                case 16: Question16(); break;
                case 17: Question17(); break;
                case 18: Question18(); break;
                case 19: Question19(); break;
                case 20: Question20(); break;
                case 21: Question21(); break;
                case 22: Question22(); break;
                case 23: Question23(); break;
                case 24: Question24(); break;
                case 25: Question25(); break;
                case 26: Question26(); break;
                case 27: Question27(); break;
                case 28: Question28(); break;

                case 0:
                    return;

                default:
                    Console.WriteLine("Invalid choice.");
                    break;
            }

            Console.WriteLine();
            Console.WriteLine("Press any key to return to the menu...");
            Console.ReadKey();
        }
    }

    // =========================================================
    // QUESTION 1
    // =========================================================

    static void Question1()
    {
        Console.Write("Enter a number: ");
        int number = int.Parse(Console.ReadLine());

        if (number % 3 == 0 && number % 4 == 0)
            Console.WriteLine("Yes");
        else
            Console.WriteLine("No");
    }


    // =========================================================
    // QUESTION 2
    // =========================================================

    static void Question2()
    {
        Console.Write("Enter an integer: ");
        int number = int.Parse(Console.ReadLine());

        if (number < 0)
            Console.WriteLine("negative");
        else
            Console.WriteLine("positive");
    }


    // =========================================================
    // QUESTION 3
    // =========================================================

    static void Question3()
    {
        Console.Write("Enter first number: ");
        int a = int.Parse(Console.ReadLine());

        Console.Write("Enter second number: ");
        int b = int.Parse(Console.ReadLine());

        Console.Write("Enter third number: ");
        int c = int.Parse(Console.ReadLine());

        int max = Math.Max(a, Math.Max(b, c));
        int min = Math.Min(a, Math.Min(b, c));

        Console.WriteLine("Max element = " + max);
        Console.WriteLine("Min element = " + min);
    }


    // =========================================================
    // QUESTION 4
    // =========================================================

    static void Question4()
    {
        Console.Write("Enter an integer: ");
        int number = int.Parse(Console.ReadLine());

        if (number % 2 == 0)
            Console.WriteLine("Even");
        else
            Console.WriteLine("Odd");
    }


    // =========================================================
    // QUESTION 5
    // =========================================================

    static void Question5()
    {
        Console.Write("Enter a character: ");
        char character = char.Parse(Console.ReadLine());

        character = char.ToLower(character);

        if (character == 'a' ||
            character == 'e' ||
            character == 'i' ||
            character == 'o' ||
            character == 'u')
        {
            Console.WriteLine("vowel");
        }
        else
        {
            Console.WriteLine("Consonant");
        }
    }


    // =========================================================
    // QUESTION 6
    // =========================================================

    static void Question6()
    {
        Console.Write("Enter an integer: ");
        int number = int.Parse(Console.ReadLine());

        for (int i = 1; i <= number; i++)
        {
            Console.Write(i);

            if (i < number)
                Console.Write(", ");
        }

        Console.WriteLine();
    }


    // =========================================================
    // QUESTION 7
    // =========================================================

    static void Question7()
    {
        Console.Write("Enter a number: ");
        int number = int.Parse(Console.ReadLine());

        for (int i = 1; i <= 12; i++)
        {
            Console.Write(number * i);

            if (i < 12)
                Console.Write(" ");
        }

        Console.WriteLine();
    }


    // =========================================================
    // QUESTION 8
    // =========================================================

    static void Question8()
    {
        Console.Write("Enter a number: ");
        int number = int.Parse(Console.ReadLine());

        for (int i = 2; i <= number; i += 2)
        {
            Console.Write(i);

            if (i + 2 <= number)
                Console.Write(" ");
        }

        Console.WriteLine();
    }


    // =========================================================
    // QUESTION 9
    // =========================================================

    static void Question9()
    {
        Console.Write("Enter first number: ");
        int number1 = int.Parse(Console.ReadLine());

        Console.Write("Enter second number: ");
        int number2 = int.Parse(Console.ReadLine());

        int result = 1;

        for (int i = 1; i <= number2; i++)
        {
            result *= number1;
        }

        Console.WriteLine("Power = " + result);
    }


    // =========================================================
    // QUESTION 10
    // =========================================================

    static void Question10()
    {
        int total = 0;

        Console.WriteLine("Enter marks of five subjects:");

        for (int i = 1; i <= 5; i++)
        {
            Console.Write("Subject " + i + ": ");
            int mark = int.Parse(Console.ReadLine());

            total += mark;
        }

        double average = total / 5.0;
        double percentage = total / 5.0;

        Console.WriteLine("Total marks = " + total);
        Console.WriteLine("Average Marks = " + average);
        Console.WriteLine("Percentage = " + percentage);
    }


    // =========================================================
    // QUESTION 11
    // =========================================================

    static void Question11()
    {
        Console.Write("Enter month number: ");
        int month = int.Parse(Console.ReadLine());

        int days;

        switch (month)
        {
            case 1:
                days = 31;
                break;

            case 2:
                days = 28;
                break;

            case 3:
                days = 31;
                break;

            case 4:
                days = 30;
                break;

            case 5:
                days = 31;
                break;

            case 6:
                days = 30;
                break;

            case 7:
                days = 31;
                break;

            case 8:
                days = 31;
                break;

            case 9:
                days = 30;
                break;

            case 10:
                days = 31;
                break;

            case 11:
                days = 30;
                break;

            case 12:
                days = 31;
                break;

            default:
                Console.WriteLine("Invalid month.");
                return;
        }

        Console.WriteLine("Days in Month: " + days);
    }


    // =========================================================
    // QUESTION 12
    // =========================================================

    static void Question12()
    {
        Console.Write("Enter first number: ");
        double number1 = double.Parse(Console.ReadLine());

        Console.Write("Enter operator (+, -, *, /): ");
        char operation = char.Parse(Console.ReadLine());

        Console.Write("Enter second number: ");
        double number2 = double.Parse(Console.ReadLine());

        double result;

        switch (operation)
        {
            case '+':
                result = number1 + number2;
                Console.WriteLine("Result = " + result);
                break;

            case '-':
                result = number1 - number2;
                Console.WriteLine("Result = " + result);
                break;

            case '*':
                result = number1 * number2;
                Console.WriteLine("Result = " + result);
                break;

            case '/':
                if (number2 == 0)
                {
                    Console.WriteLine("Cannot divide by zero.");
                }
                else
                {
                    result = number1 / number2;
                    Console.WriteLine("Result = " + result);
                }

                break;

            default:
                Console.WriteLine("Invalid operator.");
                break;
        }
    }


    // =========================================================
    // QUESTION 13
    // =========================================================

    static void Question13()
    {
        Console.Write("Enter a string: ");
        string text = Console.ReadLine();

        char[] characters = text.ToCharArray();

        Array.Reverse(characters);

        string reversed = new string(characters);

        Console.WriteLine("Reverse = " + reversed);
    }


    // =========================================================
    // QUESTION 14
    // =========================================================

    static void Question14()
    {
        Console.Write("Enter an integer: ");
        int number = int.Parse(Console.ReadLine());

        int original = number;
        int reversed = 0;

        number = Math.Abs(number);

        while (number > 0)
        {
            int digit = number % 10;

            reversed = reversed * 10 + digit;

            number /= 10;
        }

        if (original < 0)
            reversed = -reversed;

        Console.WriteLine("Reversed = " + reversed);
    }


    // =========================================================
    // QUESTION 15
    // =========================================================

    static void Question15()
    {
        Console.Write("Input starting number of range: ");
        int start = int.Parse(Console.ReadLine());

        Console.Write("Input ending number of range: ");
        int end = int.Parse(Console.ReadLine());

        Console.WriteLine();
        Console.WriteLine(
            "The prime number between " +
            start +
            " and " +
            end +
            " are:"
        );

        for (int number = start; number <= end; number++)
        {
            if (IsPrime(number))
            {
                Console.Write(number + " ");
            }
        }

        Console.WriteLine();
    }

    static bool IsPrime(int number)
    {
        if (number < 2)
            return false;

        for (int i = 2; i <= Math.Sqrt(number); i++)
        {
            if (number % i == 0)
                return false;
        }

        return true;
    }


    // =========================================================
    // QUESTION 16
    // =========================================================

    static void Question16()
    {
        Console.Write("Enter a number to convert: ");
        int number = int.Parse(Console.ReadLine());

        if (number == 0)
        {
            Console.WriteLine("The Binary of 0 is 0.");
            return;
        }

        int original = number;
        string binary = "";

        while (number > 0)
        {
            int remainder = number % 2;

            binary = remainder + binary;

            number /= 2;
        }

        Console.WriteLine(
            "The Binary of " +
            original +
            " is " +
            binary +
            "."
        );
    }


    // =========================================================
    // QUESTION 17
    // =========================================================

    static void Question17()
    {
        Console.WriteLine("Enter Point 1:");

        Console.Write("x1 = ");
        double x1 = double.Parse(Console.ReadLine());

        Console.Write("y1 = ");
        double y1 = double.Parse(Console.ReadLine());

        Console.WriteLine();

        Console.WriteLine("Enter Point 2:");

        Console.Write("x2 = ");
        double x2 = double.Parse(Console.ReadLine());

        Console.Write("y2 = ");
        double y2 = double.Parse(Console.ReadLine());

        Console.WriteLine();

        Console.WriteLine("Enter Point 3:");

        Console.Write("x3 = ");
        double x3 = double.Parse(Console.ReadLine());

        Console.Write("y3 = ");
        double y3 = double.Parse(Console.ReadLine());

        double result =
            x1 * (y2 - y3) +
            x2 * (y3 - y1) +
            x3 * (y1 - y2);

        if (result == 0)
            Console.WriteLine("The points lie on a single straight line.");
        else
            Console.WriteLine("The points do not lie on a single straight line.");
    }


    // =========================================================
    // QUESTION 18
    // =========================================================

    static void Question18()
    {
        Console.Write("Enter the time taken in hours: ");
        double hours = double.Parse(Console.ReadLine());

        if (hours >= 2 && hours < 3)
        {
            Console.WriteLine("Highly efficient");
        }
        else if (hours >= 3 && hours < 4)
        {
            Console.WriteLine("You are instructed to increase your speed.");
        }
        else if (hours >= 4 && hours <= 5)
        {
            Console.WriteLine("You are provided with training to enhance your speed.");
        }
        else if (hours > 5)
        {
            Console.WriteLine("You are required to leave the company.");
        }
        else
        {
            Console.WriteLine("Invalid time.");
        }
    }


    // =========================================================
    // QUESTION 19
    // =========================================================

    static void Question19()
    {
        Console.Write("Enter n: ");
        int n = int.Parse(Console.ReadLine());

        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n; j++)
            {
                if (i == j)
                    Console.Write("1 ");
                else
                    Console.Write("0 ");
            }

            Console.WriteLine();
        }
    }


    // =========================================================
    // QUESTION 20
    // =========================================================

    static void Question20()
    {
        Console.Write("Enter array size: ");
        int size = int.Parse(Console.ReadLine());

        int[] numbers = new int[size];

        int sum = 0;

        for (int i = 0; i < size; i++)
        {
            Console.Write("Enter element " + i + ": ");

            numbers[i] = int.Parse(Console.ReadLine());

            sum += numbers[i];
        }

        Console.WriteLine("Sum = " + sum);
    }


    // =========================================================
    // QUESTION 21
    // =========================================================

    static void Question21()
    {
        Console.Write("Enter size of arrays: ");
        int size = int.Parse(Console.ReadLine());

        int[] array1 = new int[size];
        int[] array2 = new int[size];

        Console.WriteLine("Enter first array:");

        for (int i = 0; i < size; i++)
        {
            array1[i] = int.Parse(Console.ReadLine());
        }

        Console.WriteLine("Enter second array:");

        for (int i = 0; i < size; i++)
        {
            array2[i] = int.Parse(Console.ReadLine());
        }

        Array.Sort(array1);
        Array.Sort(array2);

        int[] merged = new int[size * 2];

        int x = 0;
        int y = 0;
        int z = 0;

        while (x < array1.Length && y < array2.Length)
        {
            if (array1[x] <= array2[y])
            {
                merged[z] = array1[x];
                x++;
            }
            else
            {
                merged[z] = array2[y];
                y++;
            }

            z++;
        }

        while (x < array1.Length)
        {
            merged[z] = array1[x];

            x++;
            z++;
        }

        while (y < array2.Length)
        {
            merged[z] = array2[y];

            y++;
            z++;
        }

        Console.WriteLine("Merged array:");

        for (int i = 0; i < merged.Length; i++)
        {
            Console.Write(merged[i] + " ");
        }

        Console.WriteLine();
    }


    // =========================================================
    // QUESTION 22
    // =========================================================

    static void Question22()
    {
        Console.Write("Enter array size: ");
        int size = int.Parse(Console.ReadLine());

        int[] numbers = new int[size];

        for (int i = 0; i < size; i++)
        {
            Console.Write("Enter element " + i + ": ");
            numbers[i] = int.Parse(Console.ReadLine());
        }

        Console.WriteLine();
        Console.WriteLine("Frequency:");

        bool[] counted = new bool[size];

        for (int i = 0; i < size; i++)
        {
            if (counted[i])
                continue;

            int count = 1;

            for (int j = i + 1; j < size; j++)
            {
                if (numbers[i] == numbers[j])
                {
                    count++;
                    counted[j] = true;
                }
            }

            Console.WriteLine(
                numbers[i] +
                " occurs " +
                count +
                " time(s)"
            );
        }
    }


    // =========================================================
    // QUESTION 23
    // =========================================================

    static void Question23()
    {
        Console.Write("Enter array size: ");
        int size = int.Parse(Console.ReadLine());

        int[] numbers = new int[size];

        for (int i = 0; i < size; i++)
        {
            Console.Write("Enter element " + i + ": ");
            numbers[i] = int.Parse(Console.ReadLine());
        }

        int max = numbers[0];
        int min = numbers[0];

        for (int i = 1; i < size; i++)
        {
            if (numbers[i] > max)
                max = numbers[i];

            if (numbers[i] < min)
                min = numbers[i];
        }

        Console.WriteLine("Maximum = " + max);
        Console.WriteLine("Minimum = " + min);
    }


    // =========================================================
    // QUESTION 24
    // =========================================================

    static void Question24()
    {
        Console.Write("Enter array size: ");
        int size = int.Parse(Console.ReadLine());

        int[] numbers = new int[size];

        for (int i = 0; i < size; i++)
        {
            Console.Write("Enter element " + i + ": ");
            numbers[i] = int.Parse(Console.ReadLine());
        }

        Array.Sort(numbers);

        int largest = numbers[size - 1];

        int secondLargest = 0;
        bool found = false;

        for (int i = size - 2; i >= 0; i--)
        {
            if (numbers[i] != largest)
            {
                secondLargest = numbers[i];
                found = true;
                break;
            }
        }

        if (found)
        {
            Console.WriteLine(
                "Second largest element = " +
                secondLargest
            );
        }
        else
        {
            Console.WriteLine(
                "There is no second largest distinct element."
            );
        }
    }


    // =========================================================
    // QUESTION 25
    // =========================================================

    static void Question25()
    {
        Console.Write("Enter array size: ");
        int size = int.Parse(Console.ReadLine());

        int[] numbers = new int[size];

        for (int i = 0; i < size; i++)
        {
            Console.Write(
                "Enter element " +
                i +
                ": "
            );

            numbers[i] = int.Parse(Console.ReadLine());
        }

        int longestDistance = 0;

        for (int i = 0; i < size; i++)
        {
            for (int j = i + 1; j < size; j++)
            {
                if (numbers[i] == numbers[j])
                {
                    int distance = j - i - 1;

                    if (distance > longestDistance)
                        longestDistance = distance;
                }
            }
        }

        Console.WriteLine(
            "Longest distance = " +
            longestDistance
        );
    }


    // =========================================================
    // QUESTION 26
    // =========================================================

    static void Question26()
    {
        Console.Write("Enter words: ");

        string input = Console.ReadLine();

        string[] words = input.Split(' ');

        Array.Reverse(words);

        Console.WriteLine(
            string.Join(" ", words)
        );
    }


    // =========================================================
    // QUESTION 27
    // =========================================================

    static void Question27()
    {
        Console.Write("Enter number of rows: ");
        int rows = int.Parse(Console.ReadLine());

        Console.Write("Enter number of columns: ");
        int columns = int.Parse(Console.ReadLine());

        int[,] firstArray = new int[rows, columns];
        int[,] secondArray = new int[rows, columns];

        Console.WriteLine();
        Console.WriteLine("Enter values for first array:");

        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < columns; j++)
            {
                Console.Write(
                    "Element [" +
                    i +
                    "," +
                    j +
                    "]: "
                );

                firstArray[i, j] =
                    int.Parse(Console.ReadLine());
            }
        }

        // Copy first array into second array
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < columns; j++)
            {
                secondArray[i, j] =
                    firstArray[i, j];
            }
        }

        Console.WriteLine();
        Console.WriteLine("Second Array:");

        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < columns; j++)
            {
                Console.Write(
                    secondArray[i, j] +
                    " "
                );
            }

            Console.WriteLine();
        }
    }


    // =========================================================
    // QUESTION 28
    // =========================================================

    static void Question28()
    {
        Console.Write("Enter array size: ");
        int size = int.Parse(Console.ReadLine());

        int[] numbers = new int[size];

        for (int i = 0; i < size; i++)
        {
            Console.Write(
                "Enter element " +
                i +
                ": "
            );

            numbers[i] = int.Parse(Console.ReadLine());
        }

        Console.WriteLine();
        Console.WriteLine("Array in reverse order:");

        for (int i = size - 1; i >= 0; i--)
        {
            Console.Write(numbers[i] + " ");
        }

        Console.WriteLine();
    }
}