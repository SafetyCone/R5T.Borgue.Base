using System;
using System.Collections.Generic;

using R5T.Corcyra;


namespace R5T.Borgue
{
    public class GridUnit
    {
        public GridUnitIdentity Identity { get; set; }
        public string Name { get; set; }
        public List<LngLat> Boundary { get; } = new List<LngLat>();
    }
}
