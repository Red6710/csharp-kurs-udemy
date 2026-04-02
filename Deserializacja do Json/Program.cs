using Deserializacja_do_Json;
using System;
using System.Runtime.InteropServices;
using Newtonsoft.Json;


namespace Json
{
    class Program
    {
        static void Main(string[] args)
        {
            var player = new Player()
            {
                Name = "Mario",
                Level = 1,
                HealtPoints = 100,
                Statistics = new List<Statistic>()
                {
                    new Statistic()
                    {
                        Name = "Strength",
                        Points = 10,
                    },
                    new Statistic()
                    {
                        Name = "Intelligence",
                        Points = 10
                    }
                }
            };

            player.Level++;

           string playerJson = JsonConvert.SerializeObject(player);
            File.WriteAllText($"D:\\Program Files\\TextFiles\\Write\\PLayerData-{player.Name}.json",playerJson);
            String playerSerialized = File.ReadAllText($"D:\\Program Files\\TextFiles\\Write\\PLayerData-Mario.json");
            player = JsonConvert.DeserializeObject<Player>(playerSerialized);
            Console.WriteLine(player.Name);
        } 
    }
}