using System;
using System.Collections.Generic;

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

        void SetName(CatchmentIdentity identity, string name);
        string GetName(CatchmentIdentity identity);
    }
}
