using System;
using System.Collections.Generic;
using System.Threading.Tasks;

using R5T.Corcyra;


namespace R5T.Borgue
{
    public interface ICatchmentsRepository
    {
        void Add(Catchment geography);

        bool Exists(CatchmentIdentity identity);

        Catchment Get(CatchmentIdentity identity);
        IEnumerable<Catchment> GetAll();
        IEnumerable<Catchment> GetAllContainingPoint(LngLat lngLat);

        void Delete(CatchmentIdentity identity);

        Task SetName(CatchmentIdentity identity, string name);
        Task<string> GetName(CatchmentIdentity identity);

        Task SetBoundary(CatchmentIdentity identity, IEnumerable<LngLat> boundaryVertices);
        Task<IEnumerable<LngLat>> GetBoundary(CatchmentIdentity identity);
    }
}
