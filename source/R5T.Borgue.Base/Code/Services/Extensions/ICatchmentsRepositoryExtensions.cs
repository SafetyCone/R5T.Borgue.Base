using System;
using System.Collections.Generic;
using System.Threading.Tasks;

using R5T.Corcyra;


namespace R5T.Borgue
{
    public static class ICatchmentsRepositoryExtensions
    {
        public static async Task<CatchmentIdentity> Add(this ICatchmentsRepository repository, string name, IEnumerable<LngLat> vertices)
        {
            var catchmentIdentity = CatchmentIdentity.New();

            var catchment = new Catchment()
            {
                Identity = catchmentIdentity,
                Name = name,
            };

            catchment.Boundary.AddRange(vertices);

            await repository.Add(catchment);

            return catchmentIdentity;
        }

        public static async Task Delete(this ICatchmentsRepository repository, Guid catchmentIdentityValue)
        {
            var catchmentIdentity = CatchmentIdentity.From(catchmentIdentityValue);

            await repository.Delete(catchmentIdentity);
        }

        public static async Task<Catchment> Get(this ICatchmentsRepository repository, Guid catchmentIdentityValue)
        {
            var catchmentIdentity = CatchmentIdentity.From(catchmentIdentityValue);

            var catchment = await repository.Get(catchmentIdentity);
            return catchment;
        }

        public static async Task<CatchmentInfo> GetCatchmentInfoAsync(this ICatchmentsRepository repository, CatchmentIdentity catchmentIdentity)
        {
            var name = await repository.GetName(catchmentIdentity);

            var catchmentInfo = new CatchmentInfo()
            {
                CatchmentIdentity = catchmentIdentity,
                Name = name,
            };
            return catchmentInfo;
        }
    }
}
