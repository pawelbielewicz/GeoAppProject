using GeoApp.Data;
using GeoApp.Model;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace GeoApp.Persistence
{
    public class GeoStoreRepository : IGeoStoreRepository
    {
        private GeoObjectDbContext _dbContext;
        public GeoStoreRepository(GeoObjectDbContext context)
        {
            _dbContext = context;
        }

        public GeoObject GetGeoObjectById(string id)
        {
            return _dbContext.GeoObjects.Where(g => g.Id.ToString() == id).FirstOrDefault();
        }

        public void SaveNewObject(GeoObject geoObject)
        {
            _dbContext.GeoObjects.Add(geoObject);
            _dbContext.SaveChanges();
        }
    }
}
