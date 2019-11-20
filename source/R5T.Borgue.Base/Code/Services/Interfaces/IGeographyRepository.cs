using System;
using System.Collections.Generic;

using R5T.Corcyra;


namespace R5T.Borgue
{
    public interface IGeographyRepository
    {
        void Add(Geography geography);

        bool Exists(GeographyIdentity identity);

        Geography Get(GeographyIdentity identity);
        IEnumerable<Geography> GetAll();
        IEnumerable<Geography> GetGeographiesContainingPoint(LngLat lngLat);

        void Delete(GeographyIdentity identity);
    }
}
