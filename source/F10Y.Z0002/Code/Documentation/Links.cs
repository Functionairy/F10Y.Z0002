using System;

using F10Y.T0001;


namespace F10Y.Z0002
{
    public partial class Documentation
    {
        [DocumentationsMarker]
        public partial class Links
        {
            /// <summary>
            /// <value><see href="https://learn.microsoft.com/en-us/dotnet/standard/frameworks"/></value>
            /// </summary>
            public readonly object DotnetTargetFrameworks;

            /// <summary>
            /// <value><see href="https://learn.microsoft.com/en-us/dotnet/standard/net-standard?tabs=net-standard-2-0#select-net-standard-version"/></value>
            /// </summary>
            public static readonly object DotnetStandardVersions;

            /// <summary>
            /// <see href="https://spdx.org/licenses/"/>
            /// </summary>
            public static readonly object SPDXLicenseExpressions;
        }
    }
}
