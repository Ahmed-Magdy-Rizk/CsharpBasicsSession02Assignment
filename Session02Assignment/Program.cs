namespace Session02Assignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region First Question
            ///*1- Write a program that allows the user to enter a number then print it. */

            //// prompt the user to enter a number
            //Console.WriteLine("Plase Enter a Number: ");
            //// Declare a var to store the user's answer
            //String UserNumber = Console.ReadLine();
            //// Print out the user value
            //Console.WriteLine($"Your Number is : {UserNumber}");
            #endregion

            #region Second Question
            ///*2-Write C# program that Assigning one value type variable to another
            // and modifying the value of one variable and mention what will happen*/

            //// Assigning intials value to two vars
            //int FirstVar = 10;
            //int SecondVar;

            //// Assigning the first var value to the second one
            //SecondVar = FirstVar;

            //// Print out values before modificaton
            //Console.WriteLine($"SecondVar: {FirstVar}");
            //Console.WriteLine($"SecondVar: {SecondVar}");

            ////Modify the frist var value
            //FirstVar = 50;

            ////Print out the var values after the modifycation
            //Console.WriteLine("After modifycation");
            //Console.WriteLine($"SecondVar: {FirstVar}");
            //Console.WriteLine($"SecondVar: {SecondVar}");

            ///*
            // When we assign one var to another var we just create a copy from the frist var, so changing the frist var value
            //won't affect the second one
            // */
            #endregion

            #region Third Question
            /*2-Write C# program that Assigning one value type variable to another
             and modifying the value of one variable and mention what will happen*/

            // Declaring & initialize a reference for p1 and setting p2 to null
            Point P1 = new Point();
            Point P2;
            // Assigning the values for point 1
            P1.x = 10;
            P1.y = 20;

            // Assigning the reference of point 1 to point 2
            P2 = P1;

            // Print out values before modificaton
            Console.WriteLine($"P1.X: {P1.x}");
            Console.WriteLine($"P1.y: {P1.y}");
            Console.WriteLine($"P2.X: {P2.x}");
            Console.WriteLine($"P2.y: {P2.y}");

            //Modify the frist var value
            P1.x = 50;
            P1.y = 60;

            //Print out the points values after the modifycation
            Console.WriteLine("After modifycation");
            Console.WriteLine($"P1.X: {P1.x}");
            Console.WriteLine($"P1.y: {P1.y}");
            Console.WriteLine($"P2.X: {P2.x}");
            Console.WriteLine($"P2.y: {P2.y}");

            /*
             When we assign a reference type var to another one thats means that both var pointing to the same object in memory
            , so changing the frist var value will affect the second one
             */
            #endregion
        }
    }
}
