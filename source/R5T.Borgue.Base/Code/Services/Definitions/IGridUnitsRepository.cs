using System;
using System.Collections.Generic;
using System.Threading.Tasks;

using R5T.Corcyra;

using R5T.T0064;


namespace R5T.Borgue
{
    [ServiceDefinitionMarker]
    public interface IGridUnitsRepository : IServiceDefinition
    {
        Task SetGridUnitsForCatchment(CatchmentIdentity catchmentIdentity);

        Task Add(GridUnit geography);
        Task Delete(GridUnitIdentity identity);
        Task<bool> Exists(GridUnitIdentity identity);
        Task<GridUnit> Get(GridUnitIdentity identity);
        Task<IEnumerable<GridUnit>> GetAll();

        // Getters and setters for catchment components
        Task SetName(GridUnitIdentity identity, string name);
        Task<string> GetName(GridUnitIdentity identity);
        Task SetBoundary(GridUnitIdentity identity, IEnumerable<LngLat> boundaryVertices);
        Task<LngLat[]> GetBoundary(GridUnitIdentity identity);
    }
}
