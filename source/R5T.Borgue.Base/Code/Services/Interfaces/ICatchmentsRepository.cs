using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

using R5T.Corcyra;


namespace R5T.Borgue
{
    public interface ICatchmentsRepository
    {
        Task Add(Catchment catchment);
        Task Add(GeoJsonMultiPolygonJsonString geoJsonMultiPolygonJsonString, Catchment otherCatchmentInfo);

        Task<bool> Exists(CatchmentIdentity identity);
        Task<bool> Exists(string catchmentName);

        Task<List<CatchmentIdentity>> GetAllCatchmentIdentitiesContainingPoint(LngLat lngLat);
        Task<(CatchmentIdentity Identity, string Name)[]> FindIdentityNamePairsByRegexOnName(Regex regexOnName);
        Task<List<Catchment>> GetAllWithinRadiusOfPoint(double radiusInDegrees, LngLat lngLat);
        Task<List<CatchmentGeoJson>> GetAllWithinRadiusOfPointGeoJson(double radiusInDegrees, LngLat lngLat);
        Task<List<Catchment>> GetFilteredByName(string nameContains);
        Task<List<Catchment>> GetFilteredByNameAndRadius(string nameContains, double radiusDegrees, LngLat lngLat);
        Task<List<Catchment>> GetAllContainingPoint(LngLat lngLat);
        Task<List<CatchmentGeoJson>> GetAllContainingPointGeoJson(LngLat lngLat);

        Task<Catchment> Get(CatchmentIdentity identity);
        Task<CatchmentGeoJson> GetByIdentity(CatchmentIdentity catchmentIdentity);
        Task<IEnumerable<Catchment>> GetAll();

        Task Delete(CatchmentIdentity identity);

        Task SetName(CatchmentIdentity identity, string name);
        Task<string> GetName(CatchmentIdentity identity);

        Task SetBoundary(CatchmentIdentity identity, GeoJsonMultiPolygonJsonString newGeoJsonMultiPolygonJsonString);
        Task SetBoundary(CatchmentIdentity identity, IEnumerable<LngLat> boundaryVertices);
        Task<LngLat[]> GetBoundary(CatchmentIdentity identity);
    }
}
