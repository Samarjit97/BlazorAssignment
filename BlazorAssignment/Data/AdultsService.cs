using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.Json;
using BlazorAssignment.Models;
 

namespace BlazorAssignment.Data
{
    public class AdultsService : IAdultsService
    {
        private string adultsFile = "adults.json";
        public IList<Adult> Adults { get; private set; }

        public void addAdult(Adult adult)
        {
            int max = Adults.Max(adult => adult.Id);


            adult.Id = (++max);
            Adults.Add(adult);


            WriteAdultsToFile();
        }

        public void removeAdult(int adultId)
        {
            Adult toRemove = Adults.First(A => A.Id == adultId);
            Adults.Remove(toRemove);
            WriteAdultsToFile();
        }

        public void updateAdult(Adult adult)
        {
            Adult toUpdate = Adults.First(A => A.Id == adult.Id);
            toUpdate.Id = adult.Id;
            toUpdate.FirstName = adult.FirstName;
            toUpdate.LastName = adult.LastName;
            toUpdate.HairColor = adult.HairColor;
            toUpdate.EyeColor = adult.EyeColor;
            toUpdate.Age = adult.Age;
            toUpdate.Weight = adult.Weight;
            toUpdate.Height = adult.Height;
            toUpdate.JobTitle = adult.JobTitle;


            WriteAdultsToFile();
        }

        public string GetEyeColor(Adult adult)
        {
            return adult.GetEyeColor();
        }


        private void WriteAdultsToFile()
        {
            string adultsAsJson = JsonSerializer.Serialize(Adults);
            File.WriteAllText(adultsFile, adultsAsJson);
        }

        public Adult Get(int id)
        {
            return Adults.FirstOrDefault(A => A.Id == id);
        }


        public AdultsService()
        {
            string content = File.ReadAllText(adultsFile);
            Adults = JsonSerializer.Deserialize<List<Adult>>(content);
        }

      
        public IList<T> ReadData<T>()
        {
            using (var jsonReader = File.OpenText(adultsFile))
            {
                return JsonSerializer.Deserialize<List<T>>(jsonReader.ReadToEnd());
            }
        }
        
    }
}