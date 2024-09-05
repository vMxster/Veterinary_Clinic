using Veterinary_Clinic.Models;

namespace Veterinary_Clinic._Repositories
{
    public interface IPetRepository
    {
        void Add(PetModel petModel);
        void Edit(PetModel petModel);
        void Delete(int id);
        IEnumerable<PetModel> GetAll();
        IEnumerable<PetModel> GetByValue(string value);
    }
}
