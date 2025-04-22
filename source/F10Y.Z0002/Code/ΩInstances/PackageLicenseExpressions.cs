using System;


namespace F10Y.Z0002
{
    public class PackageLicenseExpressions : IPackageLicenseExpressions
    {
        #region Infrastructure

        public static IPackageLicenseExpressions Instance { get; } = new PackageLicenseExpressions();


        private PackageLicenseExpressions()
        {
        }

        #endregion
    }
}
