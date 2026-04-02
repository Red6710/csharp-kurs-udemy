using System.Data;

namespace Using
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var filePath = ($"D:\\Program Files\\TextFiles\\TextFile2.txt");
            var fileContent = File.ReadAllText(filePath);

            using (var readFileStream = new FileStream(filePath, FileMode.Open))
            {
                
            }
           
            
            

            var writeFileStream = new FileStream(filePath, FileMode.Open);
            writeFileStream.Close();
        }
    }
}