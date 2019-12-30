using System;
using System.Collections.Generic;

using R5T.Corcyra;


namespace R5T.Borgue
{
    public static class ICatchmentsRepositoryExtensions
    {
        public static CatchmentIdentity Add(this ICatchmentsRepository repository, IEnumerable<LngLat> vertices)
        {
            var geography = new Catchment()
            {
                Identity = CatchmentIdentity.New(),
            };

            geography.Boundary.AddRange(vertices);

            repository.Add(geography);

            return geography.Identity;
        }

        public static Catchment Get(this ICatchmentsRepository repository, Guid catchmentIdentity)
        {
            var output = repository.Get(new CatchmentIdentity(catchmentIdentity));
            return output;
        }
    }
}
