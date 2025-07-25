using System;

using F10Y.T0001;


namespace F10Y.Z0002
{
    public partial class Documentation
    {
        [DocumentationsMarker]
        public partial class Examples
        {
            /// <summary>
            /// <value>C:\Program Files\dotnet\sdk\8.0.300\</value>
            /// </summary>
            public static readonly object DotnetSdkDirectoryPath;

            /// <summary>
            /// A directory inside the <see cref="DotnetSdkDirectoryPath"/>.
            /// <para><value>8.0.300</value></para>
            /// </summary>
            public static readonly object DotnetSdkName_Directory;

            /// <summary>
            /// <value>C:\Program Files\dotnet\sdk\8.0.300\Sdks\Microsoft.NET.Sdk\</value>
            /// </summary>
            public static readonly object DotnetProjectSdkDirectoryPath;

            /// <summary>
            /// <value>Microsoft.NET.Sdk</value>
            /// </summary>
            public static readonly object DotnetProjectSdkName;

            /// <summary>
            /// <value>net8.0</value>
            /// </summary>
            public static readonly object DotnetTargetFramework;

            /// <summary>
            /// <value>8.0.0</value>
            /// </summary>
            public static readonly object VersionName;
        }
    }
}
