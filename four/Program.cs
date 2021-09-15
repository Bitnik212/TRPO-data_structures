using System;

// Двухстороняя очередь. Более удобная очередь, где можно убрать или добавить человека в начало или конец
namespace four
{
    internal class Program
    {
        struct People
        {
            public string FirstName;
            public string LastName;
            public int Age;

            private static string[] names = new[] { "Иван", "Георгий", "Олег" };
            private static string[] lastNames = new[] { "Иванов", "Баксиров", "Скаратов" };

            public void print()
            {
                Console.WriteLine($"name {FirstName}, lastname {LastName}, age {Age}");
            }

            public string toString()
            {
                return $"name: {FirstName}, lastname: {LastName}, age: {Age}";
            }
            
            public People genRandomPeople()
            {
                Random random = new Random();
                People people = new People();
                people.Age = random.Next(100);
                people.FirstName = names[random.Next(names.Length)];
                people.LastName = lastNames[random.Next(lastNames.Length)];
                return people;
            }
        }
        
        public static void Main(string[] args)
        {
            People people = new People();
            People nonRandomPeople = new People();
            nonRandomPeople.Age = 10;
            nonRandomPeople.FirstName = "Абобус";
            nonRandomPeople.LastName = "Автобус";
            Deque<People> queue = new DequeImpl<People>();
            queue.Enqueue(people.genRandomPeople());
            queue.Enqueue(people.genRandomPeople());
            queue.Enqueue(people.genRandomPeople());
            queue.AddFirst(nonRandomPeople);
            // queue.DeleteLast();
            
            foreach (var p in queue)
            {
                p.print();
            }
        }
    }
}