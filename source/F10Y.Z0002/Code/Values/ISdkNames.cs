using System;

using F10Y.T0003;
using F10Y.T0011;


namespace F10Y.Z0002
{
    [ValuesMarker]
    public partial interface ISdkNames
    {
#pragma warning disable IDE1006 // Naming Styles

        [Ignore]
        public Raw.ISdkNames _Raw => Raw.SdkNames.Instance;

#pragma warning restore IDE1006 // Naming Styles


        /// <summary>
        /// <para><value>Microsoft.NET.Sdk</value></para>
        /// </summary>
        public string Microsoft_NET_Sdk => "Microsoft.NET.Sdk";
    }
}
