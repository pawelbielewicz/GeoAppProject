using GeoApp.Model;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace GeoApp.Persistence
{
    public interface IGeoStoreRepository
    {
        GeoObject GetGeoObjectById(string id);
        void SaveNewObject(GeoObject geoObject);
    }
}
