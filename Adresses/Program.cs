using System.Net.Http.Json;
using System.Text.Json.Serialization;
using Newtonsoft.Json;

namespace Adresses
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var people = LoadePeople();
            var addresses = LoadeAddresses();


            var joinedData = people.GroupJoin(addresses,
                p => p.Id,
                a => a.PersonId,
                (person, addresses) => new { person.Name, Addresses = addresses });

            foreach (var element in joinedData)
            {
                Console.WriteLine($"Name: {element.Name}");
                foreach (var address in element.Addresses)
                
                    {
                    Console.WriteLine($"\t City : {address.City} street: {address.Street}");
                     }
            }
                

            //foreach (var person in people)
            //{
            //    var address = addresses.FirstOrDefault(a => a.PersonId == person.Id);
            //    if (address != null)
            //    {
            //        Console.WriteLine($"Name: {person.Name}, address: {address.City}, {address.Street}");
            //    }
            //}


            Console.WriteLine();
        }

        private static List<Person> LoadePeople()
        {
            var currentDir = Directory.GetCurrentDirectory();
            var jsonFullPath = Path.GetRelativePath(currentDir, "Person/People.json");



            var json = File.ReadAllText(jsonFullPath);
            return JsonConvert.DeserializeObject<List<Person>>(json);
        }
        private static List<Address> LoadeAddresses()
        {
            var currentDir = Directory.GetCurrentDirectory();
            var jsonFullPath = Path.GetRelativePath(currentDir, "Person/Addresses.json");
            var json = File.ReadAllText(jsonFullPath);
            return JsonConvert.DeserializeObject<List<Address>>(json);

        }
    }
}
