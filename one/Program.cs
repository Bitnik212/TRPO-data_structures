using System;

namespace one
{
    internal class Program
    {
        
        struct User
        {
            public string firstName;
            public string gender;
            public int age;
            
            private static string[] genders = new[] {"Man", "Woman", "One other gender"};
            private static string[] names = new[] { "Amir", "Avgustus", "Aboba", "Nikolay", "SerGAY" };
            
            public void print()
            {
                Console.WriteLine($"name: {firstName}, age: {age}, gender: {gender}");
            }

            public User getRandomUser()
            {
                Random random = new Random();
                User user = new User();
                user.age = random.Next(1, 100);
                user.gender = genders[random.Next(0, genders.Length)];
                user.firstName = names[random.Next(0, names.Length)];
                return user;
            }
        }
        public static void Main(string[] args)
        {

            User[] users = new[]
            {
                new User().getRandomUser(),
                new User().getRandomUser(),
                new User().getRandomUser(),
                new User().getRandomUser(),
                new User().getRandomUser(),
                new User().getRandomUser(),
            };
            foreach (var user in users)
            {
                user.print();
            }
        }
    }
}