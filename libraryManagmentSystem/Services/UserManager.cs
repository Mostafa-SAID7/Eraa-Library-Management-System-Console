using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.Json;
using AdvancedLibraryManagementSystem.Models;

namespace AdvancedLibraryManagementSystem.Services
{
    public static class UserManager
    {
        private static List<User> users = new();

        public static void AddUser(User user)
        {
            users.Add(user);
        }

        public static bool UserExists(string username)
        {
            return users.Any(u => u.Username == username);
        }

        public static User Authenticate(string username, string password)
        {
            return users.FirstOrDefault(u => u.Username == username && u.Password == password);
        }

        public static void ViewUsers()
        {
            Console.WriteLine("Registered Users:");
            foreach (var u in users)
            {
                Console.WriteLine($"- {u.Username} {(u.IsAdmin ? "(Admin)" : "")}");
            }
        }

        public static void Save(string filename)
        {
            var json = JsonSerializer.Serialize(users, new JsonSerializerOptions { WriteIndented = true });
            File.WriteAllText(filename, json);
        }

        public static void Load(string filename)
        {
            if (!File.Exists(filename))
            {
                // Create default admin user
                users = new List<User> { new User { Username = "admin", Password = "admin", IsAdmin = true } };
                Save(filename);
                return;
            }

            var json = File.ReadAllText(filename);
            users = JsonSerializer.Deserialize<List<User>>(json) ?? new List<User>();
        }
    }
}
