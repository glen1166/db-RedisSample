using ServiceStack.Redis;
using System;

namespace RedisSample
{
    class Program
    {
        static RedisClient redisClient = new RedisClient("127.0.0.1", 6379);
        static void Main(string[] args)
        {
            Console.WriteLine(redisClient.Get<string>("city"));
            Console.ReadKey();
        }
    }
}
