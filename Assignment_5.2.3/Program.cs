/*
3. Write a program in C# Sharp to print numbers from n to 1 using recursion.
Test Data :
How many numbers to print : 10
Expected Output :
10 9 8 7 6 5 4 3 2 1s
*/



namespace Assignment_5._2._3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int naturalNum = 10;
            RecursionOfDigit(naturalNum);
        }
        static void RecursionOfDigit(int naturalNum)
        {
            if (naturalNum != 0)
            {
                Console.Write(naturalNum + " ");
                naturalNum -= 1;
                RecursionOfDigit(naturalNum);
            }

        }
    }
}
