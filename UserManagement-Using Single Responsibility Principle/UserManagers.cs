using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserManagement_Using_Single_Responsibility_Principle
{
    public class UserManagers
    {
        public List<string> Users { get; set; }
        private NotificationService _notificationService;

        public UserManagers(NotificationService notificationService)
        {
            Users = new List<string>();
            _notificationService = notificationService;
        }

        public void AddUser(string user)
        {
            Users.Add(user);
            _notificationService.SendEmail(user, "You have been added.");
        }

        public void RemoveUser(string user)
        {
            Users.Remove(user);
            _notificationService.SendEmail(user, "You have been removed.");
        }

        public class NotificationService
        {
            public void SendEmail(string user, string message)
            {
                // Simulate sending an email
                Console.WriteLine($"Email to {user}: {message}");
            }

        }
    }
}
