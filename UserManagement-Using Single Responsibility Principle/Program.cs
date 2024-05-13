using System;
using UserManagement_Using_Single_Responsibility_Principle;
using static UserManagement_Using_Single_Responsibility_Principle.UserManagers;

namespace UserManagement_Using_Single_Responsibility_Principle
{
    class Program
    {
        static void Main(string[] args)
        {
            //UserManager userManager = new UserManager();
            //// Add users
            //userManager.AddUser("Alice");
            //userManager.AddUser("Bob");

            //// Keep the console window open
            //Console.WriteLine("Press any key to exit.");
            //Console.ReadKey();


            // Create an instance of NotificationService
            NotificationService notificationService = new NotificationService();

            // Pass the NotificationService instance to UserManager
            UserManagers userManager = new UserManagers(notificationService);

            // Add users
            userManager.AddUser("Alice");
            userManager.AddUser("Bob");

            // Remove a user
            userManager.RemoveUser("Alice");

            // Keep the console window open
            Console.WriteLine("Press any key to exit.");
            Console.ReadKey();

        }
    }
}