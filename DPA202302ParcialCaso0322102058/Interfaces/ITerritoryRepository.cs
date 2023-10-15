using DPA202302ParcialCaso0322102058.Data;

namespace DPA202302ParcialCaso0322102058.Interfaces
{
    public interface ITerritoryRepository
    {

        Task<bool> Insert(Territory territory);

        Task<bool> Delete(int id);

        Task<IEnumerable<Territory>> GetAll();

    }
}
