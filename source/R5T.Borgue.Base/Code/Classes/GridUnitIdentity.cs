using System;

using R5T.Guide;


namespace R5T.Borgue
{
    public class GridUnitIdentity : MutableTypedGuid
    {
        #region Static

        public static GridUnitIdentity New()
        {
            var geographyIdentity = new GridUnitIdentity(Guid.NewGuid());
            return geographyIdentity;
        }

        public static GridUnitIdentity From(Guid value)
        {
            var geographyIdentity = new GridUnitIdentity(value);
            return geographyIdentity;
        }

        #endregion



        public GridUnitIdentity(Guid value)
            : base(value)
        {
        }

        public GridUnitIdentity()
            : base()
        {
        }
    }
}
