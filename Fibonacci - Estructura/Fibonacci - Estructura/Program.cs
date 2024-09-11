
using System;


class Program
{
    private static bool isRunning = true;

    static void Main()
    {


        do
        {

            Console.WriteLine("Choose an option: \n 0 = End program, 1 = Fibonacci , 2 = Factorial,  3 = Sum, \n 4 = Pyramid, 5 = Palyndrome");
            string response = Console.ReadLine();


            switch (response)
            {
                case "0":
                    isRunning = false;

                    break;

                case "1":

                    // Fibonacci
                    Console.Write("Write amount of Fibonacci Steps: ");
                    int fibonacciCuantity = int.Parse(Console.ReadLine());
                    Console.WriteLine("Fibonacci Sequence:");
                    for (int i = 0; i < fibonacciCuantity; i++)
                    {
                        Console.Write(Fibonacci(i) + " ");
                    }
                    Console.WriteLine();

                    break;

                case "2":

                    //Factorial
                    Console.Write("Write number: ");
                    int numberToFactorial = int.Parse(Console.ReadLine());
                    Console.WriteLine("Result of " + numberToFactorial + " is: " + Factorial(numberToFactorial));






                    break;

                case "3":


                    // Sum
                    Console.Write("Write number: ");

                    int numeroSuma = int.Parse(Console.ReadLine());

                    Console.WriteLine("Sum to " + numeroSuma + " is: " + Sum(numeroSuma));




                    break;

                case "4":


                    //Pyramid
                    Console.Write("Write pyramid height: ");

                    int pyramidHeight = int.Parse(Console.ReadLine());

                    Console.WriteLine("Pyramid height " + pyramidHeight + ":");

                    PrintPyramid(pyramidHeight, 0);


                    break;

                case "5":


                    //Palyndrome
                    Console.Write("Write a phrase to check palyndrome status: ");
                    string phrase = Console.ReadLine();
                    bool isPalyndrome = PalyndromeCheck(phrase.Replace(" ", "").ToLower());
                    Console.WriteLine("Check: " + isPalyndrome);




                    break;
            }



        }
        while (isRunning);
        


        

        

        

        

        
    }





   
    static int Fibonacci(int n)
    {
        if (n <= 1)
            return n;
        return Fibonacci(n - 1) + Fibonacci(n - 2);
    }

  
    static int Factorial(int n)
    {
        if (n <= 1)
            return 1;
        return n * Factorial(n - 1);
    }

    
    static int Sum(int n)
    {
        if (n <= 1)
            return n;
        return n + Sum(n - 1);
    }


    static void PrintPyramid(int height, int queue)
    {
        if (queue >= height)
            return;

        PrintSpaces(height - queue - 1);
        PrintChara(queue * 2 + 1, 'x');
        Console.WriteLine();
        PrintPyramid(height, queue + 1);
    }

    static void PrintSpaces(int cuantity)
    {
        if (cuantity <= 0)
            return;
        Console.Write(" ");
        PrintSpaces(cuantity - 1);
    }

    static void PrintChara(int cuantity, char character)
    {
        if (cuantity <= 0)
            return;
        Console.Write(character);
        PrintChara(cuantity - 1, character);
    }

    
    static bool PalyndromeCheck(string s)
    {
        if (s.Length <= 1)
            return true;
        if (s[0] != s[s.Length - 1])
            return false;
        return PalyndromeCheck(s.Substring(1, s.Length - 2));
    }
}