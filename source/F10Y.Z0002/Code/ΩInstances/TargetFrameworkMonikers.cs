using System;


namespace F10Y.Z0002
{
    public class TargetFrameworkMonikers : ITargetFrameworkMonikers
    {
        #region Infrastructure

        public static ITargetFrameworkMonikers Instance { get; } = new TargetFrameworkMonikers();


        private TargetFrameworkMonikers()
        {
        }

        #endregion
    }
}


namespace F10Y.Z0002.Conceptual
{
    public class TargetFrameworkMonikers : ITargetFrameworkMonikers
    {
        #region Infrastructure

        public static ITargetFrameworkMonikers Instance { get; } = new TargetFrameworkMonikers();


        private TargetFrameworkMonikers()
        {
        }

        #endregion
    }
}