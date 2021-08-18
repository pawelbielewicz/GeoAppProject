using System;
using System.Threading.Tasks;
using GeoApp.Model;
using GeoApp.Persistence;

namespace GeoApp.Infrastructure
{
    public class GeoService
    {
        private IGeoStoreRepository _repository;

        public GeoService(IGeoStoreRepository repository)
        {
            _repository = repository;
        }

        public GeoObject GetObjectById(string id)
        {
            if (string.IsNullOrWhiteSpace(id))
                return null;

            bool isValid = Guid.TryParse(id, out _);

            return isValid ? _repository.GetGeoObjectById(id) : null;
        }

        public void SaveNewObject(GeoObject newGeoObject)
        {
            if (newGeoObject == null)
                throw new ArgumentNullException(nameof(newGeoObject));

            
            newGeoObject.Id = Guid.NewGuid();
            newGeoObject.MeasurementDateTime = DateTime.UtcNow;
            newGeoObject.Accuracy = Math.Abs(newGeoObject.Accuracy);

            _repository.SaveNewObject(newGeoObject);
        }
    }
}
