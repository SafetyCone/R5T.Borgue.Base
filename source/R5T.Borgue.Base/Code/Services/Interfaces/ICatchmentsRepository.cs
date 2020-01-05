using System;
using System.Collections.Generic;
using System.Threading.Tasks;

using R5T.Corcyra;


namespace R5T.Borgue
{
    public interface ICatchmentsRepository
    {
        Task Add(Catchment geography);

        Task<bool> Exists(CatchmentIdentity identity);

        Task<Catchment> Get(CatchmentIdentity identity);
        Task<IEnumerable<Catchment>> GetAll();
        Task<IEnumerable<Catchment>> GetAllContainingPoint(LngLat lngLat);

        Task Delete(CatchmentIdentity identity);

        Task SetName(CatchmentIdentity identity, string name);
        Task<string> GetName(CatchmentIdentity identity);

        Task SetBoundary(CatchmentIdentity identity, IEnumerable<LngLat> boundaryVertices);
        Task<IEnumerable<LngLat>> GetBoundary(CatchmentIdentity identity);
    }
}
