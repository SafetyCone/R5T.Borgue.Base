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

        void Delete(GeographyIdentity identity);
    }
}
