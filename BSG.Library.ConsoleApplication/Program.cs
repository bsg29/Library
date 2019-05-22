using System;
using System.Collections.Generic;
using BSG.Library.Models;
using BSG.Library.Models.Enums;
using BSG.Library.Models.Repository;

namespace BSG.Library.ConsoleApplication
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
                    Password = "123",
                    Login = "MytanTTeR",
                    PositionWrapper = PositionEnum.Administrator
                },
                new User()
                {
                    FirstName = "Владимир",
                    LastName = "Болдонов",
                    MiddleName = "Геннадьевич",
                    Password = "123",
                    Login = "Rimid",
                    PositionWrapper = PositionEnum.Administrator
                }
            };

            foreach (var adminUser in adminUsers)
            {
                userRepository.Save(adminUser);
            }

            var users = userRepository.GetObjects();

            foreach (var user in users)
            {
                Console.WriteLine("{0} - {1} {2}", user.Id, user.FirstName, user.LastName);
            }

            Console.ReadKey();
        }
    }
}
