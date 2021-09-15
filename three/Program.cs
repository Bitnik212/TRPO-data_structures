using System;
using System.Collections.Generic;

//очередь играков. Можно продвинуть очередь, а модно посмотреть кто первый в очереди
namespace three
{
    internal class Program
    {
        struct Player
        {
            public int id;
            public string name;
            
            private static string[] names = new[] { "Amir", "Avgustus", "Nikolay", "SerGAY" };
            
            public Player getRandomUser()
            {
                Random random = new Random();
                Player user = new Player();
                user.id = random.Next(100);
                user.name = names[random.Next(0, names.Length)];
                Console.Write("добавлен пользователь ");
                user.print();
                return user;
            }

            public void print()
            {
                Console.WriteLine($"id: {id}, name: {name}");
            }
        }
        private static void printQueueCount(Queue<Player> queue)
        {
            Console.WriteLine($"Количество людей в очереде: {queue.Count}");
        }
        private static void printNowPlayersInQueue(Queue<Player> queue)
        {
            Console.WriteLine("\nСейчас в очереди:");
            foreach (var p in queue.ToArray())
            {
                p.print();
            }
            printQueueCount(queue);
        }
        private static Player pushQueue(Queue<Player> queue)
        {
            Player player = queue.Dequeue();
            Console.Write("\nУдалил ");
            player.print();
            printNowPlayersInQueue(queue);
            return player;
        }
        private static Player nowFirstPlayerInQueue(Queue<Player> queue)
        {
            Player player = queue.Peek();
            Console.Write("\nТекущий первый игрок ");
            player.print();
            return player;
        }
        public static void Main(string[] args)
        {
            Queue<Player> queue = new Queue<Player>();
            Player player = new Player();
            printNowPlayersInQueue(queue);
            queue.Enqueue(player.getRandomUser());
            queue.Enqueue(player.getRandomUser());
            queue.Enqueue(player.getRandomUser());
            queue.Enqueue(player.getRandomUser());
            printNowPlayersInQueue(queue);
            pushQueue(queue);
            nowFirstPlayerInQueue(queue);
        }
    }
}