using System;

namespace one
{
    internal class Program
    {
        
        struct Abobys
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

            public Abobys getRandomUser()
            {
                Random random = new Random();
                Abobys user = new Abobys();
                user.age = random.Next(1, 100);
                user.gender = genders[random.Next(0, genders.Length)];
                user.firstName = names[random.Next(0, names.Length)];
                return user;
            }
        }
        public static void Main(string[] args)
        {

            Abobys[] users = new[]
            {
                new Abobys().getRandomUser(),
                new Abobys().getRandomUser(),
                new Abobys().getRandomUser(),
                new Abobys().getRandomUser(),
                new Abobys().getRandomUser(),
                new Abobys().getRandomUser(),
            };
            foreach (var abobys in users)
            {
                abobys.print();
            }
        }
    }
}