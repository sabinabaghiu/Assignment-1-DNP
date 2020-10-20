using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.Json;
using Models;

namespace Assignment1.Data
{
    public class AdultService : IAdultsService
    {
        private string adultFile = "adults.json";
        private IList<Adult> adults;

        public AdultService()
        {
            if (!File.Exists(adultFile))
            {
                WriteAdultsToFile();
            }
            else
            {
                string content = File.ReadAllText(adultFile);
                adults = JsonSerializer.Deserialize<List<Adult>>(content);
            }
        }

        public IList<Adult> GetAdults()
        {
            return adults;
        }

        public void AddAdult(Adult adult)
        {
            int max = adults.Max(adult => adult.Id);
            adult.Id = (++max);
            adults.Add(adult);
            WriteAdultsToFile();
        }
        
        public void RemoveAdult(int Id)
        {
            Adult toRemove = adults.First(a => a.Id == Id);
            adults.Remove(toRemove);
            WriteAdultsToFile();
        }

        private void WriteAdultsToFile()
        {
            string productsAsJson = JsonSerializer.Serialize(adults);
            File.WriteAllText(adultFile, productsAsJson);
        }
    }
}