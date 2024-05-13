# UserManagement-Using Single Responsibility Principle. 

- This program shows two classes , where one hat violates the Single Responsibility Principle (SRP) and the  other class adheres to SRP.
- The UserManager.cs class violates SRP because it is responsible for both managing the user list and handling notifications, which are logically separate concerns.
- The UserManagers.cs ensures that each class has one reason to change: UserManagers changes only for reasons related to user management, and NotificationService changes only for reasons related to user notifications. This separation makes the code cleaner, easier to maintain, and more modular.


