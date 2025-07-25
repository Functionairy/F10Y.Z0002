using System;


namespace F10Y.Z0002
{
    public class TargetFrameworkMonikerSets : ITargetFrameworkMonikerSets
    {
        #region Infrastructure

        public static ITargetFrameworkMonikerSets Instance { get; } = new TargetFrameworkMonikerSets();


        private TargetFrameworkMonikerSets()
        {
        }

        #endregion
    }
}


namespace F10Y.Z0002.Raw
{
    public class TargetFrameworkMonikerSets : ITargetFrameworkMonikerSets
    {
        #region Infrastructure

        public static ITargetFrameworkMonikerSets Instance { get; } = new TargetFrameworkMonikerSets();


        private TargetFrameworkMonikerSets()
        {
        }

        #endregion
    }
}
