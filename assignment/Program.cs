namespace assignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Q1:Write a program that allows the user to enter a number then print it.
            Console.WriteLine("Enter a Number :");
            int num;
            num=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(num);
            #endregion
            #region Q2:Write C# program that Assigning one value type variable to another and modifying the value of one variable and mention what will happen
            int x = 5;
            int y = 10;
            x = y;
            x++;
            Console.WriteLine(x);
            Console.WriteLine(y);

            #endregion

        }
    }
}
