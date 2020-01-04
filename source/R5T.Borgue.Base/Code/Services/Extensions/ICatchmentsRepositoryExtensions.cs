using System;
using System.Collections.Generic;

using R5T.Corcyra;


namespace R5T.Borgue
{
    public static class ICatchmentsRepositoryExtensions
    {
        public static CatchmentIdentity Add(this ICatchmentsRepository repository, string name, IEnumerable<LngLat> vertices)
        {
            var catchment = new Catchment()
            {
                Identity = CatchmentIdentity.New(),
                Name = name,
            };

            catchment.Boundary.AddRange(vertices);

            repository.Add(catchment);

            return catchment.Identity;
        }

        public static void Delete(this ICatchmentsRepository repository, Guid catchmentIdentityValue)
        {
            repository.Delete(CatchmentIdentity.From(catchmentIdentityValue));
        }

        public static Catchment Get(this ICatchmentsRepository repository, Guid catchmentIdentityValue)
        {
            var output = repository.Get(CatchmentIdentity.From(catchmentIdentityValue));
            return output;
        }
    }
}
