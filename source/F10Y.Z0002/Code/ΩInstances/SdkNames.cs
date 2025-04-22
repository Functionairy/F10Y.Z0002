using System;


namespace F10Y.Z0002
{
    public class SdkNames : ISdkNames
    {
        #region Infrastructure

        public static ISdkNames Instance { get; } = new SdkNames();


        private SdkNames()
        {
        }

        #endregion
    }
}


namespace F10Y.Z0002.Raw
{
    public class SdkNames : ISdkNames
    {
        #region Infrastructure

        public static ISdkNames Instance { get; } = new SdkNames();


        private SdkNames()
        {
        }

        #endregion
    }
}