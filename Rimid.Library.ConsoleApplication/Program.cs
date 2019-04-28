using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using Rimid.Library.Models;
using Rimid.Library.Models.Enums;
using Rimid.Library.Models.Repository;

namespace Rimid.Library.ConsoleApplication
{
    public class Program
    {
        private static void Main(string[] args)
        {
            var context = new LibraryEntities();
            var userRepository = new UserRepository(context);

            var adminUsers = new List<User>()
            {
                new User()
                {
                    FirstName = "Дмитрий",
                    LastName = "Тепляков",
                    MiddleName = "Николаевич",
                    Phone = "+79600126139",
                    Password = ComputeSha256Hash("123"),
                    Login = "MytanTTeR",
                    PositionWrapper = PositionEnum.Administrator
                },
                new User()
                {
                    FirstName = "Владимир",
                    LastName = "Болдонов",
                    MiddleName = "Геннадьевич",
                    Password = ComputeSha256Hash("123"),
                    Login = "Rimid",
                    PositionWrapper = PositionEnum.Administrator
                }
            };

            foreach (var adminUser in adminUsers)
            {
                var isAdminUserExisted = context.Users.Any(x => x.Login == adminUser.Login);

                if (isAdminUserExisted) continue;

                context.Users.Add(adminUser);
                context.SaveChanges();
            }

            var users = context.Users.ToList();

            foreach (var user in users)
            {
                Console.WriteLine("{0} - {1} {2}", user.Id, user.FirstName, user.LastName);
            }

            Console.ReadKey();
        }

        private static string ComputeSha256Hash(string rawData)
        {
            // Create a SHA256   
            using (var sha256Hash = SHA256.Create())
            {
                // ComputeHash - returns byte array  
                var hashBytes = sha256Hash.ComputeHash(Encoding.UTF8.GetBytes(rawData));

                // Convert byte array to a string   
                var builder = new StringBuilder();
                foreach (var hashByte in hashBytes)
                {
                    builder.Append(hashByte.ToString("x2"));
                }
                return builder.ToString();
            }
        }
    }
}
