using System;
using System.Collections.Generic;
using System.Threading.Tasks;

using R5T.Corcyra;


namespace R5T.Borgue
{
    public interface IGridUnitsRepository
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
