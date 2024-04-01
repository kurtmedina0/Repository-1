using System;

class Myfirstproj
{
    static void Main(string[] args)
    {
        string correctusername = "Admin";
        string correctpassword = "Admin1234!";
        int attempts = 3;
       

        while (attempts > 0)
        {
            Console.Write("Enter your username:");
            string username = Console.ReadLine();
            Console.Write("Enter your password:");
            string password = Console.ReadLine();

            if (username == correctusername && password == correctpassword)
            {
                Console.WriteLine("Login successful!");
                break;
            }
            else
            {
                Console.WriteLine("Incorrect. Please try again.");
                attempts--;
                if (attempts > 0)
                {
                    Console.WriteLine($"You have {attempts} attempts left");
                    Console.WriteLine();
                }
               
            }

        }
        if (attempts == 0)
        {
            Console.WriteLine("You have fully consumed your attempts.");
        }

        Console.ReadLine(); 

    }
}