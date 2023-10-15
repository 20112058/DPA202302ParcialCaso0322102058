using DPA202302ParcialCaso0322102058.Data;
using DPA202302ParcialCaso0322102058.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace DPA202302ParcialCaso0322102058.Repositorio
{
    public class TerritoryRepository : ITerritoryRepository
    {
        private readonly Dpa202302parcialCaso0322102058Context _dbContext;

        public TerritoryRepository(Dpa202302parcialCaso0322102058Context dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<bool> Insert(Territory territory)
        {
            await _dbContext.Territory.AddAsync(territory);
            var rows = await _dbContext.SaveChangesAsync();
            return rows > 0;
        }

        public async Task<bool> Delete(int id)
        {
            var category = await _dbContext.Territory.Where(x => x.Id == id).FirstOrDefaultAsync();
            if (category == null)
                return false;

            _dbContext.Territory.Remove(category);
            var rows = await _dbContext.SaveChangesAsync();
            return rows > 0;
        }

        public async Task<IEnumerable<Territory>> GetAll()
        {
            return await _dbContext.Territory.ToListAsync();
        }
    }
}
