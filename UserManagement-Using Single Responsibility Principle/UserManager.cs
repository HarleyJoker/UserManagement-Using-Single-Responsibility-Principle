using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserManagement_Using_Single_Responsibility_Principle
{
    public class UserManager
    { 
        public List<string> Users { get; set; }

        public UserManager() {

         Users = new List<string>();
        }

        public void AddUser(string user)
        {
            Users.Add(user);
            SendEmail(user, " You have been added.");
        }

        private void SendEmail(string user, string message)
        {
            // Simulate sending an email
            Console.WriteLine($"Email to {user}: {message}");
        }



    }
}
