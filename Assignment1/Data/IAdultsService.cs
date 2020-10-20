using System.Collections.Generic;
using Models;

namespace Assignment1.Data
{
    public interface IAdultsService
    {
        IList<Adult> GetAdults();
        void AddAdult(Adult adult);
        void RemoveAdult(int Id);
    }
}