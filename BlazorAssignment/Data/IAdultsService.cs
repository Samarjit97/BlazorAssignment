using System.Collections.Generic;
using BlazorAssignment.Models;


namespace BlazorAssignment.Data
{
    public interface IAdultsService
    {
        public IList<Adult> Adults { get; }
        void addAdult(Adult adult);
        void removeAdult(int adultId);
        void updateAdult(Adult adult);
       
        Adult Get(int id);
    }
}