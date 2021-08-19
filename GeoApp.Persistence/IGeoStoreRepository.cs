using GeoApp.Model;

namespace GeoApp.Persistence
{
    public interface IGeoStoreRepository
    {
        GeoObject GetGeoObjectById(string id);
        void SaveNewObject(GeoObject geoObject);
    }
}
