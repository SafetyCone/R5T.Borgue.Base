using System;
using System.Collections.Generic;

using R5T.Corcyra;


namespace R5T.Borgue
{
    public static class IGeographyRepositoryExtensions
    {
        public static GeographyIdentity Add(this IGeographyRepository repository, IEnumerable<LngLat> vertices)
        {
            var geography = new Geography()
            {
                Identity = GeographyIdentity.New(),
            };

            geography.Vertices.AddRange(vertices);

            repository.Add(geography);

            return geography.Identity;
        }
    }
}
